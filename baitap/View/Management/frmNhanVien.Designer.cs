﻿namespace baitap.View
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            lbemail = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            txtXacNhanPass = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            dataGridView1 = new DataGridView();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            txtTenNV = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            groupBox2 = new GroupBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            groupBox1 = new GroupBox();
            txtNamSinh = new ComboBox();
            txtGioiTinh = new ComboBox();
            txtQuyenHan = new ComboBox();
            txtDienThoai = new Krypton.Toolkit.KryptonTextBox();
            txtTenTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            txtDiaChi = new Krypton.Toolkit.KryptonTextBox();
            lb = new Krypton.Toolkit.KryptonLabel();
            txtMatkhau = new Krypton.Toolkit.KryptonTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 27;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 29);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.Rounding = 5F;
            txtEmail.StateCommon.Border.Width = 2;
            txtEmail.TabIndex = 2;
            // 
            // lbemail
            // 
            lbemail.Location = new Point(6, 139);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(40, 20);
            lbemail.TabIndex = 1;
            lbemail.Values.Text = "Email";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(442, 135);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.PasswordChar = '●';
            kryptonTextBox2.Size = new Size(183, 29);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.Rounding = 5F;
            kryptonTextBox2.StateCommon.Border.Width = 2;
            kryptonTextBox2.TabIndex = 2;
            kryptonTextBox2.UseSystemPasswordChar = true;
            // 
            // txtXacNhanPass
            // 
            txtXacNhanPass.Location = new Point(352, 139);
            txtXacNhanPass.Name = "txtXacNhanPass";
            txtXacNhanPass.Size = new Size(85, 20);
            txtXacNhanPass.TabIndex = 1;
            txtXacNhanPass.Values.Text = "Xác Mật khẩu";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(352, 37);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(57, 20);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Giới tính";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(352, 86);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Mật khẩu";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(6, 37);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(87, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Tên nhân viên";
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(255, 224, 102);
            rjButton4.BackgroundColor = Color.FromArgb(255, 224, 102);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 5;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(309, 263);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(91, 30);
            rjButton4.TabIndex = 23;
            rjButton4.Text = "Huỷ";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += btnHuy_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(13, 135, 242);
            rjButton3.BackgroundColor = Color.FromArgb(13, 135, 242);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(212, 263);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(91, 30);
            rjButton3.TabIndex = 24;
            rjButton3.Text = "Sửa";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnSua_Click;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(96, 33);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(226, 29);
            txtTenNV.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTenNV.StateCommon.Border.Rounding = 5F;
            txtTenNV.StateCommon.Border.Width = 2;
            txtTenNV.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(654, 139);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(48, 20);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Địa chỉ";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(244, 91, 105);
            rjButton2.BackgroundColor = Color.FromArgb(244, 91, 105);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(115, 263);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(91, 30);
            rjButton2.TabIndex = 25;
            rjButton2.Text = "Xoá";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnXoa_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(63, 194, 138);
            rjButton1.BackgroundColor = Color.FromArgb(63, 194, 138);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(18, 263);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(91, 30);
            rjButton1.TabIndex = 26;
            rjButton1.Text = "Thêm";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnThem_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(654, 37);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(83, 20);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Số điện thoại";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(6, 86);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(63, 20);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Tài khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(960, 217);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(654, 86);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(62, 20);
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "Năm sinh";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(txtQuyenHan);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTenTaiKhoan);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(kryptonLabel5);
            groupBox1.Controls.Add(lb);
            groupBox1.Controls.Add(lbemail);
            groupBox1.Controls.Add(kryptonLabel4);
            groupBox1.Controls.Add(kryptonLabel7);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(kryptonLabel3);
            groupBox1.Controls.Add(kryptonTextBox2);
            groupBox1.Controls.Add(txtXacNhanPass);
            groupBox1.Controls.Add(txtMatkhau);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(kryptonLabel2);
            groupBox1.Controls.Add(kryptonLabel6);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 219);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chỉnh sửa";
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.FormattingEnabled = true;
            txtNamSinh.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980" });
            txtNamSinh.Location = new Point(744, 82);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(183, 29);
            txtNamSinh.TabIndex = 6;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.FormattingEnabled = true;
            txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            txtGioiTinh.Location = new Point(442, 33);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(183, 29);
            txtGioiTinh.TabIndex = 5;
            // 
            // txtQuyenHan
            // 
            txtQuyenHan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuyenHan.FormattingEnabled = true;
            txtQuyenHan.Items.AddRange(new object[] { "Administrator", "Developer", "Manager", "Staff", "User" });
            txtQuyenHan.Location = new Point(96, 180);
            txtQuyenHan.Name = "txtQuyenHan";
            txtQuyenHan.Size = new Size(226, 29);
            txtQuyenHan.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(744, 33);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(183, 29);
            txtDienThoai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDienThoai.StateCommon.Border.Rounding = 5F;
            txtDienThoai.StateCommon.Border.Width = 2;
            txtDienThoai.TabIndex = 2;
            txtDienThoai.KeyPress += nhapSo_KeyPress;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(96, 82);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(226, 29);
            txtTenTaiKhoan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTenTaiKhoan.StateCommon.Border.Rounding = 5F;
            txtTenTaiKhoan.StateCommon.Border.Width = 2;
            txtTenTaiKhoan.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(744, 135);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(183, 29);
            txtDiaChi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDiaChi.StateCommon.Border.Rounding = 5F;
            txtDiaChi.StateCommon.Border.Width = 2;
            txtDiaChi.TabIndex = 2;
            // 
            // lb
            // 
            lb.Location = new Point(6, 184);
            lb.Name = "lb";
            lb.Size = new Size(70, 20);
            lb.TabIndex = 1;
            lb.Values.Text = "Quyền hạn";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(442, 82);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '●';
            txtMatkhau.Size = new Size(183, 29);
            txtMatkhau.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMatkhau.StateCommon.Border.Rounding = 5F;
            txtMatkhau.StateCommon.Border.Width = 2;
            txtMatkhau.TabIndex = 2;
            txtMatkhau.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.management;
            pictureBox1.Location = new Point(978, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 645);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNhanVien";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel lbemail;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel txtXacNhanPass;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton3;
        private Krypton.Toolkit.KryptonTextBox txtTenNV;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonTextBox txtDienThoai;
        private Krypton.Toolkit.KryptonTextBox txtTenTaiKhoan;
        private Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private Krypton.Toolkit.KryptonTextBox txtMatkhau;
        private ComboBox txtQuyenHan;
        private Krypton.Toolkit.KryptonLabel lb;
        private ComboBox txtGioiTinh;
        private ComboBox txtNamSinh;
        private PictureBox pictureBox1;
    }
}