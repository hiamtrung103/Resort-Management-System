﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Object;

namespace baitap.Model
{
    class KhachHangMod
    {
        private readonly ConnectToSQL conn = new ConnectToSQL();

        public DataTable LayDuLieuKhachHang()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn.KetNoi))
            {
                try
                {
                    conn.MoKetNoi();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc đọc dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return dt;
        }

        public bool KiemTraTonTai(string tenTaiKhoan, string email)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE TenTaiKhoan = @TenTaiKhoan OR Email = @Email", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.MoKetNoi();
                    return (int)cmd.ExecuteScalar() > 0;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc kiểm tra tài khoản/email", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        public bool ThemDuLieuKhachHang(KhachHangObj khObj)
        {
            if (KiemTraTonTai(khObj.TenTaiKhoan, khObj.Email))
            {
                MessageBox.Show("Tài khoản hoặc email đã tồn tại. Vui lòng chọn tài khoản hoặc email khác.");
                return false;
            }

            using (SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password, MaGiamGia) " +
                                                  "VALUES (@HoTen, @GioiTinh, @NamSinh, @DiaChi, @DienThoai, @TenTaiKhoan, @Email, @Password, @MaGiamGia)", conn.KetNoi))
            {
                SetKhachHangParameters(cmd, khObj);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc thêm dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        public void CapNhatDuLieuKhachHang(KhachHangObj khObj)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET HoTen = @HoTen, GioiTinh = @GioiTinh, NamSinh = @NamSinh, " +
                                                  "DiaChi = @DiaChi, DienThoai = @DienThoai, TenTaiKhoan = @TenTaiKhoan, " +
                                                  "Email = @Email, Password = @Password, MaGiamGia = @MaGiamGia " +
                                                  "WHERE ID = @ID", conn.KetNoi))
            {
                SetKhachHangParameters(cmd, khObj);
                cmd.Parameters.AddWithValue("@ID", khObj.MaKhachHang);

                try
                {
                    conn.MoKetNoi();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();

                    MessageBox.Show(soDongAnhHuong > 0 ? "Cập nhật dữ liệu thành công." : "Cập nhật dữ liệu thất bại.");
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        public bool XoaDuLieuKhachHang(string id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE ID = @ID", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc xóa dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        internal void CapNhatDuLieuCaNhan(string tenTaiKhoan, string hoTen, string gioiTinh, string namSinh, string diaChi)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET HoTen = @HoTen, GioiTinh = @GioiTinh, NamSinh = @NamSinh, " +
                                                  "DiaChi = @DiaChi WHERE TenTaiKhoan = @TenTaiKhoan", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NamSinh", namSinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu cá nhân thành công.", "Thông báo");
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu cá nhân", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }
        
        internal void CapNhatAvatar(string tenTaiKhoan, byte[] avatar)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET Avatar = @Avatar WHERE TenTaiKhoan = @TenTaiKhoan", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@Avatar", avatar);
                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu cá nhân thành công.", "Thông báo");
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu cá nhân", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        private void SetKhachHangParameters(SqlCommand cmd, KhachHangObj khObj)
        {
            cmd.Parameters.AddWithValue("@HoTen", khObj.HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", khObj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", khObj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", khObj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", khObj.DienThoai);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", khObj.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@Email", khObj.Email);
            cmd.Parameters.AddWithValue("@Password", khObj.Password);
            cmd.Parameters.AddWithValue("@MaGiamGia", khObj.MaGiamGia ?? (object)DBNull.Value);
        }

        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
