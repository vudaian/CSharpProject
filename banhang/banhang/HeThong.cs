using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace banhang
{
    public partial class form_hethong : Form
    {
        public form_hethong()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dangnhap d_n = new form_dangnhap();
            d_n.ShowDialog();
        }

        private void giáoTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_giaotrinh g_t = new form_giaotrinh();
            g_t.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_thongke t_ke = new form_thongke();
            t_ke.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_nhaxuatban nxb = new form_nhaxuatban();
            nxb.ShowDialog();
        }

        private void form_hethong_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
