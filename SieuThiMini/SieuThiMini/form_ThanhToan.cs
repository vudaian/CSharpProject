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
    public partial class form_ThanhToan : Form
    {
        public form_ThanhToan()
        {
            InitializeComponent();
        }

        private void form_ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_MuaHang form = new form_MuaHang();
            form.Show();
            this.Hide();
        }
    }
}
