namespace banhang
{
    partial class form_dangnhap
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
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(66, 38);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(71, 16);
            this.lb_taikhoan.TabIndex = 0;
            this.lb_taikhoan.Text = "Tài Khoản:";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_taikhoan.Location = new System.Drawing.Point(153, 38);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(165, 22);
            this.tb_taikhoan.TabIndex = 1;
            this.tb_taikhoan.TextChanged += new System.EventHandler(this.tb_taikhoan_TextChanged);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_matkhau.Location = new System.Drawing.Point(153, 90);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(165, 22);
            this.tb_matkhau.TabIndex = 3;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matkhau.Location = new System.Drawing.Point(66, 90);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(65, 16);
            this.lb_matkhau.TabIndex = 2;
            this.lb_matkhau.Text = "Mật Khẩu:";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dangnhap.Location = new System.Drawing.Point(56, 156);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(90, 29);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.Location = new System.Drawing.Point(258, 156);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 29);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 221);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.lb_taikhoan);
            this.Name = "form_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_thoat;
    }
}