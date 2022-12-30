namespace QLDN
{
    partial class Form1
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
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.cb_quyen_admin = new System.Windows.Forms.CheckBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(54, 52);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(75, 18);
            this.lb_taikhoan.TabIndex = 0;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(176, 53);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(197, 20);
            this.tb_taikhoan.TabIndex = 1;
            this.tb_taikhoan.TextChanged += new System.EventHandler(this.tb_taikhoan_TextChanged);
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matkhau.Location = new System.Drawing.Point(54, 107);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(71, 18);
            this.lb_matkhau.TabIndex = 2;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Enabled = false;
            this.tb_matkhau.Location = new System.Drawing.Point(176, 108);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(125, 20);
            this.tb_matkhau.TabIndex = 3;
            this.tb_matkhau.TextChanged += new System.EventHandler(this.tb_matkhau_TextChanged);
            // 
            // cb_quyen_admin
            // 
            this.cb_quyen_admin.AutoSize = true;
            this.cb_quyen_admin.Enabled = false;
            this.cb_quyen_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_quyen_admin.Location = new System.Drawing.Point(176, 167);
            this.cb_quyen_admin.Name = "cb_quyen_admin";
            this.cb_quyen_admin.Size = new System.Drawing.Size(107, 20);
            this.cb_quyen_admin.TabIndex = 4;
            this.cb_quyen_admin.Text = "Quyền Admin";
            this.cb_quyen_admin.UseVisualStyleBackColor = true;
            this.cb_quyen_admin.CheckedChanged += new System.EventHandler(this.cb_quyen_admin_CheckedChanged);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Enabled = false;
            this.bt_dangnhap.Location = new System.Drawing.Point(57, 222);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.bt_dangnhap.TabIndex = 5;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_huy.Location = new System.Drawing.Point(298, 222);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 23);
            this.bt_huy.TabIndex = 6;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 292);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.cb_quyen_admin);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.lb_taikhoan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Dùng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.CheckBox cb_quyen_admin;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_huy;
    }
}

