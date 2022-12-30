namespace GiaoTrinh
{
    partial class form_thongke
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
            this.tb_tennguoimuon = new System.Windows.Forms.TextBox();
            this.lb_tnm = new System.Windows.Forms.Label();
            this.dgv_thonke = new System.Windows.Forms.DataGridView();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thonke)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tennguoimuon
            // 
            this.tb_tennguoimuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tennguoimuon.Location = new System.Drawing.Point(239, 34);
            this.tb_tennguoimuon.Name = "tb_tennguoimuon";
            this.tb_tennguoimuon.Size = new System.Drawing.Size(152, 22);
            this.tb_tennguoimuon.TabIndex = 7;
            // 
            // lb_tnm
            // 
            this.lb_tnm.AutoSize = true;
            this.lb_tnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tnm.Location = new System.Drawing.Point(122, 34);
            this.lb_tnm.Name = "lb_tnm";
            this.lb_tnm.Size = new System.Drawing.Size(107, 16);
            this.lb_tnm.TabIndex = 6;
            this.lb_tnm.Text = "Tên người mượn:";
            // 
            // dgv_thonke
            // 
            this.dgv_thonke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thonke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thonke.Location = new System.Drawing.Point(77, 87);
            this.dgv_thonke.Name = "dgv_thonke";
            this.dgv_thonke.Size = new System.Drawing.Size(400, 163);
            this.dgv_thonke.TabIndex = 20;
            this.dgv_thonke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thonke_CellContentClick);
            // 
            // bt_thongke
            // 
            this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thongke.Location = new System.Drawing.Point(77, 273);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(86, 28);
            this.bt_thongke.TabIndex = 21;
            this.bt_thongke.Text = "Thống Kê";
            this.bt_thongke.UseVisualStyleBackColor = true;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.Location = new System.Drawing.Point(391, 273);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(86, 28);
            this.bt_thoat.TabIndex = 22;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // form_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.dgv_thonke);
            this.Controls.Add(this.tb_tennguoimuon);
            this.Controls.Add(this.lb_tnm);
            this.Name = "form_thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.form_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thonke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tennguoimuon;
        private System.Windows.Forms.Label lb_tnm;
        private System.Windows.Forms.DataGridView dgv_thonke;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_thoat;
    }
}