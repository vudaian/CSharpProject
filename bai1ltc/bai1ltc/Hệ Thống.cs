using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1ltc
{
    public partial class he_thong : Form
    {
        public he_thong()
        {
            InitializeComponent();
        }

        private void giáoTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoTrinh giao_trinh = new GiaoTrinh();
            giao_trinh.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đăng_Nhập dn = new Đăng_Nhập();
            dn.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaXuatBan nha_xuat_ban = new NhaXuatBan();
            nha_xuat_ban.ShowDialog();
        }
    }
}
