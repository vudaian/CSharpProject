namespace banhang
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
            this.lb_thongke = new System.Windows.Forms.Label();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_thongke
            // 
            this.lb_thongke.AutoSize = true;
            this.lb_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongke.Location = new System.Drawing.Point(78, 44);
            this.lb_thongke.Name = "lb_thongke";
            this.lb_thongke.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_thongke.Size = new System.Drawing.Size(179, 16);
            this.lb_thongke.TabIndex = 1;
            this.lb_thongke.Text = "Thống kê só lượng giáo trình:";
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(81, 82);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.Size = new System.Drawing.Size(646, 208);
            this.dgv_thongke.TabIndex = 19;
            // 
            // form_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.lb_thongke);
            this.Name = "form_thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.form_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongke;
        private System.Windows.Forms.DataGridView dgv_thongke;
    }
}