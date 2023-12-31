﻿using System;

namespace baitap.Object
{
    public class KhachHangObj
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MaKhachHang { get; set; }
        public string MaGiamGia { get; set; }
        public byte[] Avatar { get; set; }

        public KhachHangObj() { }

        public KhachHangObj(string hoTen, string gioiTinh, string namSinh, string diaChi, string dienThoai, string tenTaiKhoan, string email, string password, string maKhachHang, string maGiamGia, byte[] avatar)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            TenTaiKhoan = tenTaiKhoan;
            Email = email;
            Password = password;
            MaKhachHang = maKhachHang;
            MaGiamGia = maGiamGia;
            Avatar = avatar;
        }
    }
    public static class Session
    {
        public static string TenTaiKhoan { get; set; }
    }
}
