using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class form_DangKy : Form
    {
        public form_DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if(textBox_taiKhoan.Text == "" || textBox_matKhau.Text == "" || textBox_tenNhanVien.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin.");
            }
        }

        private void label_DangNhap_Click(object sender, EventArgs e)
        {
            form_DangNhap form = new form_DangNhap();
            form.Show();
            this.Hide();
        }
    }
}
