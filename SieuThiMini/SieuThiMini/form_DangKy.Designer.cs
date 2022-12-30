namespace SieuThiMini
{
    partial class form_DangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Close = new System.Windows.Forms.Label();
            this.label_DangKy = new System.Windows.Forms.Label();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DangKy = new System.Windows.Forms.Button();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.textBox_taiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Close);
            this.panel1.Controls.Add(this.label_DangKy);
            this.panel1.Controls.Add(this.label_DangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 100);
            this.panel1.TabIndex = 6;
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Close.Location = new System.Drawing.Point(336, 9);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(21, 20);
            this.label_Close.TabIndex = 2;
            this.label_Close.Text = "X";
            // 
            // label_DangKy
            // 
            this.label_DangKy.AutoSize = true;
            this.label_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DangKy.ForeColor = System.Drawing.Color.White;
            this.label_DangKy.Location = new System.Drawing.Point(231, 45);
            this.label_DangKy.Name = "label_DangKy";
            this.label_DangKy.Size = new System.Drawing.Size(88, 20);
            this.label_DangKy.TabIndex = 1;
            this.label_DangKy.Text = "ĐĂNG KÝ";
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.label_DangNhap.Location = new System.Drawing.Point(50, 45);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(113, 20);
            this.label_DangNhap.TabIndex = 0;
            this.label_DangNhap.Text = "ĐĂNG NHẬP";
            this.label_DangNhap.Click += new System.EventHandler(this.label_DangNhap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DangKy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 95);
            this.panel2.TabIndex = 7;
            // 
            // DangKy
            // 
            this.DangKy.BackColor = System.Drawing.Color.Goldenrod;
            this.DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangKy.FlatAppearance.BorderSize = 0;
            this.DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKy.ForeColor = System.Drawing.Color.White;
            this.DangKy.Location = new System.Drawing.Point(103, 32);
            this.DangKy.Name = "DangKy";
            this.DangKy.Size = new System.Drawing.Size(170, 33);
            this.DangKy.TabIndex = 0;
            this.DangKy.Text = "Đăng ký";
            this.DangKy.UseVisualStyleBackColor = false;
            this.DangKy.Click += new System.EventHandler(this.DangKy_Click);
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Location = new System.Drawing.Point(132, 178);
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.Size = new System.Drawing.Size(187, 20);
            this.textBox_matKhau.TabIndex = 11;
            // 
            // textBox_taiKhoan
            // 
            this.textBox_taiKhoan.Location = new System.Drawing.Point(132, 129);
            this.textBox_taiKhoan.Name = "textBox_taiKhoan";
            this.textBox_taiKhoan.Size = new System.Drawing.Size(187, 20);
            this.textBox_taiKhoan.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên nhân viên";
            // 
            // textBox_tenNhanVien
            // 
            this.textBox_tenNhanVien.Location = new System.Drawing.Point(132, 225);
            this.textBox_tenNhanVien.Name = "textBox_tenNhanVien";
            this.textBox_tenNhanVien.Size = new System.Drawing.Size(187, 20);
            this.textBox_tenNhanVien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Địa chỉ";
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(132, 273);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(187, 20);
            this.textBox_DiaChi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số điện thoại";
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Location = new System.Drawing.Point(132, 324);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(187, 20);
            this.textBox_SDT.TabIndex = 17;
            // 
            // form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(366, 474);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tenNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.textBox_taiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_DangKy";
            this.Text = "form_DangKy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label_DangKy;
        private System.Windows.Forms.Label label_DangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DangKy;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.TextBox textBox_taiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SDT;
    }
}