namespace SieuThiMini
{
    partial class form_DangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.label_DangKy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DangNhap = new System.Windows.Forms.Button();
            this.textBox_taiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.label_Close = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(369, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DangNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 119);
            this.panel2.TabIndex = 1;
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DangNhap.ForeColor = System.Drawing.Color.White;
            this.label_DangNhap.Location = new System.Drawing.Point(50, 45);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(113, 20);
            this.label_DangNhap.TabIndex = 0;
            this.label_DangNhap.Text = "ĐĂNG NHẬP";
            // 
            // label_DangKy
            // 
            this.label_DangKy.AutoSize = true;
            this.label_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DangKy.Location = new System.Drawing.Point(231, 45);
            this.label_DangKy.Name = "label_DangKy";
            this.label_DangKy.Size = new System.Drawing.Size(88, 20);
            this.label_DangKy.TabIndex = 1;
            this.label_DangKy.Text = "ĐĂNG KÝ";
            this.label_DangKy.Click += new System.EventHandler(this.label_DangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.Color.Goldenrod;
            this.DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangNhap.FlatAppearance.BorderSize = 0;
            this.DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.ForeColor = System.Drawing.Color.White;
            this.DangNhap.Location = new System.Drawing.Point(99, 42);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(170, 33);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = false;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // textBox_taiKhoan
            // 
            this.textBox_taiKhoan.Location = new System.Drawing.Point(132, 145);
            this.textBox_taiKhoan.Name = "textBox_taiKhoan";
            this.textBox_taiKhoan.Size = new System.Drawing.Size(187, 20);
            this.textBox_taiKhoan.TabIndex = 4;
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Location = new System.Drawing.Point(132, 220);
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.Size = new System.Drawing.Size(187, 20);
            this.textBox_matKhau.TabIndex = 5;
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
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(369, 399);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.textBox_taiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_DangNhap";
            this.Text = "form_DangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_DangKy;
        private System.Windows.Forms.Label label_DangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_taiKhoan;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.Label label_Close;
    }
}