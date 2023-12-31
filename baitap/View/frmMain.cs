﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitap.Model;
using baitap.Object;
using baitap.View;
using baitap.View.Nha_Hang___Cafe;
using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;

namespace QL_QuanCafe_Trung_Hai.View
{
    public partial class frmMain : KryptonForm
    {
        public Form frmConHientai;
        private ConnectToSQL conn = new ConnectToSQL();

        public frmMain()
        {
            InitializeComponent();
            MofrmCon(new frmTrangChu());
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            int minSize = 50;
            panelSidebar.Width = (panelSidebar.Width == minSize) ? 200 : minSize;

            NutBam(btnTrangChu, "Trang Chủ");
            NutBam(btnBooking, "Thuê Resort");
            NutBam(btnNhaHang, "Nhà Hàng");
            NutBam(btnQuanCafe, "Quán Cafe");
            NutBam(btnDanhGia, "Đánh Giá");
            NutBam(btnCaiDat, "Cài Đặt");
            NutBam(btnDangXuat, "Đăng Xuất");
        }

        private void NutBam(Button button, string originalText)
        {
            button.ImageAlign = (button.ImageAlign == ContentAlignment.MiddleLeft) ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            button.Text = (button.Text == originalText) ? "" : originalText;
        }

        public void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.Close();
            }

            frmConHientai = frmCon;

            frmCon.TopLevel = false;
            frmCon.FormBorderStyle = FormBorderStyle.None;
            frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void TrangChuOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu());
        }

        private void ThueResortOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmDatPhong());
        }

        private void NhaHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmNhaHang());
        }

        private void NhaHang2Open(object sender, EventArgs e)
        {
            MofrmCon(new frmCafe());
        }

        private void DanhGiaOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmDanhGia());
        }

        private void NhanVienOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmNhanVien());
        }

        private void KhachHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmKhachHang());
        }

        private void SettingOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettings());
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng vừa đăng nhập không?", "Đăng xuất khỏi ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login frm1 = new Login();
                frm1.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
        }

        private void LoadThongTinKhachHang()
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                    using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                    {
                        DataTable khachHangDataTable = new DataTable();
                        khachHangDataAdapter.Fill(khachHangDataTable);

                        if (khachHangDataTable.Rows.Count > 0)
                        {
                            label2.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                            object avatarObject = khachHangDataTable.Rows[0]["Avatar"];

                            if (avatarObject != DBNull.Value && avatarObject != null)
                            {
                                byte[] hinhAnh = (byte[])avatarObject;
                                HienThiAnhDaiDien(hinhAnh);
                            }
                            else
                            {
                                pictureBox1.Image = null;
                            }
                        }
                    }
                }
            }
        }

        public void HienThiAnhDaiDien(byte[] hinhAnh)
        {
            if (hinhAnh != null && hinhAnh.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(hinhAnh))
                {
                    pictureBox3.Image = Image.FromStream(ms);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBox3.Image = null;
            }
        }
    }
}
