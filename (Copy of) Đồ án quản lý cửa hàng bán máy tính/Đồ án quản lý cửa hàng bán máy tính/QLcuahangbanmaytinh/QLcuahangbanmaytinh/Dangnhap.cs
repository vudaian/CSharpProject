﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLcuahangbanmaytinh
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if ((this.txttendangnhap.Text == "tuyenthuy") && (this.txtmatkhau.Text == "1234"))
            {
                this.Hide();
                frmMenu frm = new frmMenu();
                frm.Show();



            }
            else
            {
                MessageBox.Show("không đúng tên người dùng / mật khẩu!!!", "Thông báo");
                this.txttendangnhap.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   