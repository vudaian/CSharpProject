namespace banhang
{
    partial class form_nhaxuatban
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
            this.lb_cungcap = new System.Windows.Forms.Label();
            this.dgv_cungcap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_cungcap
            // 
            this.lb_cungcap.AutoSize = true;
            this.lb_cungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_cungcap.Location = new System.Drawing.Point(37, 30);
            this.lb_cungcap.Name = "lb_cungcap";
            this.lb_cungcap.Size = new System.Drawing.Size(396, 16);
            this.lb_cungcap.TabIndex = 1;
            this.lb_cungcap.Text = "Danh mục các nhà xuất bản đang cung cấp giáo trình cho thư viên:";
            // 
            // dgv_cungcap
            // 
            this.dgv_cungcap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cungcap.Location = new System.Drawing.Point(40, 78);
            this.dgv_cungcap.Name = "dgv_cungcap";
            this.dgv_cungcap.Size = new System.Drawing.Size(482, 164);
            this.dgv_cungcap.TabIndex = 2;
            // 
            // form_nhaxuatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Controls.Add(this.dgv_cungcap);
            this.Controls.Add(this.lb_cungcap);
            this.Name = "form_nhaxuatban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.form_nhaxuatban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cungcap;
        private System.Windows.Forms.DataGridView dgv_cungcap;
    }
}