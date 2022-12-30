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
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_DangKy_Click(object sender, EventArgs e)
        {
            form_DangKy form = new form_DangKy();
            form.Show();
            this.Hide();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = "admin";
            string matKhau = "admin";
            //string phanQuyen = "1";
            form_MuaHang form = new form_MuaHang();
            if (textBox_taiKhoan.Text == taiKhoan && textBox_matKhau.Text == matKhau)
            {
                MessageBox.Show("Đăng nhập thành công.");
                form.Show();
                this.Hide();
            } else if (textBox_taiKhoan.Text != taiKhoan || textBox_matKhau.Text != matKhau)
            {
                MessageBox.Show("Nhập sai thông tin.");
            } else if (textBox_taiKhoan.Text == "" || textBox_matKhau.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin.");
            }
        }
    }
}
