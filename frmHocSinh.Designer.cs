namespace QuanLyTruongHoc
{
    partial class frmHocSinh
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
            this.t1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.txtTendem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtPhuHuynh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.MSHS = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayNhapHoc = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(35, 16);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(36, 20);
            this.t1.TabIndex = 0;
            this.t1.Text = "Họ :";
            this.t1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niên khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCyan;
            this.btnLuu.Location = new System.Drawing.Point(235, 406);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(380, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(174, 9);
            this.txtHo.Multiline = true;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(281, 27);
            this.txtHo.TabIndex = 1;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(174, 147);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(281, 27);
            this.txtQueQuan.TabIndex = 4;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(174, 193);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(281, 27);
            this.txtNienKhoa.TabIndex = 5;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(35, 64);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(73, 20);
            this.t2.TabIndex = 0;
            this.t2.Text = "Tên đệm :";
            this.t2.Click += new System.EventHandler(this.label1_Click);
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Location = new System.Drawing.Point(35, 107);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(39, 20);
            this.t3.TabIndex = 0;
            this.t3.Text = "Tên :";
            this.t3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTendem
            // 
            this.txtTendem.Location = new System.Drawing.Point(174, 57);
            this.txtTendem.Name = "txtTendem";
            this.txtTendem.Size = new System.Drawing.Size(281, 27);
            this.txtTendem.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(174, 100);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(281, 27);
            this.txtTen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại PH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ và Tên PH";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(174, 327);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(281, 27);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtPhuHuynh
            // 
            this.txtPhuHuynh.Location = new System.Drawing.Point(174, 368);
            this.txtPhuHuynh.Name = "txtPhuHuynh";
            this.txtPhuHuynh.Size = new System.Drawing.Size(281, 27);
            this.txtPhuHuynh.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.txtNgaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNgaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(174, 286);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(119, 27);
            this.txtNgaySinh.TabIndex = 7;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(174, 238);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(65, 28);
            this.txtGioiTinh.TabIndex = 6;
            // 
            // MSHS
            // 
            this.MSHS.AutoSize = true;
            this.MSHS.Location = new System.Drawing.Point(492, 154);
            this.MSHS.Name = "MSHS";
            this.MSHS.Size = new System.Drawing.Size(93, 20);
            this.MSHS.TabIndex = 8;
            this.MSHS.Text = "Mã Học Sinh";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(612, 151);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(141, 27);
            this.txtMaHocSinh.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCyan;
            this.btnXoa.Location = new System.Drawing.Point(539, 406);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày nhập học";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNgayNhapHoc
            // 
            this.txtNgayNhapHoc.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.txtNgayNhapHoc.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNgayNhapHoc.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNgayNhapHoc.CustomFormat = "dd/MM/yyyy";
            this.txtNgayNhapHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayNhapHoc.Location = new System.Drawing.Point(429, 284);
            this.txtNgayNhapHoc.Name = "txtNgayNhapHoc";
            this.txtNgayNhapHoc.Size = new System.Drawing.Size(119, 27);
            this.txtNgayNhapHoc.TabIndex = 7;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaHocSinh);
            this.Controls.Add(this.MSHS);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtNgayNhapHoc);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtPhuHuynh);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTendem);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t1);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label t1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLuu;
        private Button button2;
        private Label label5;
        private TextBox txtHo;
        private TextBox txtQueQuan;
        private TextBox txtNienKhoa;
        private Label t2;
        private Label t3;
        private TextBox txtTendem;
        private TextBox txtTen;
        private Label label1;
        private Label label6;
        private TextBox txtDienThoai;
        private TextBox txtPhuHuynh;
        private DateTimePicker txtNgaySinh;
        private ComboBox txtGioiTinh;
        private Label MSHS;
        private TextBox txtMaHocSinh;
        private Button btnXoa;
        private Label label7;
        private DateTimePicker txtNgayNhapHoc;
    }
}