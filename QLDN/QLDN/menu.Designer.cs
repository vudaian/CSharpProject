namespace QLDN
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_menu
            // 
            this.dgv_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(38, 47);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.Size = new System.Drawing.Size(519, 150);
            this.dgv_menu.TabIndex = 0;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(164, 238);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(197, 20);
            this.tb_taikhoan.TabIndex = 3;
            this.tb_taikhoan.TextChanged += new System.EventHandler(this.tb_taikhoan_TextChanged);
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(42, 237);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(75, 18);
            this.lb_taikhoan.TabIndex = 2;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(164, 289);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(125, 20);
            this.tb_matkhau.TabIndex = 5;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matkhau.Location = new System.Drawing.Point(46, 288);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(71, 18);
            this.lb_matkhau.TabIndex = 4;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_sua.Location = new System.Drawing.Point(250, 363);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(59, 30);
            this.bt_sua.TabIndex = 7;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_them.Location = new System.Drawing.Point(38, 363);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(59, 30);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.dgv_menu);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ImageList imageList1;
    }
}