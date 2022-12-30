using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bai1ltc
{
    public partial class NhaXuatBan : Form
    {
        public NhaXuatBan()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=bai1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT GiaoTrinh.MaNXB,NhaXuatBan.TenNXB,NhaXuatBan.DiaChi FROM GiaoTrinh,NhaXuatBan WHERE GiaoTrinh.MaNXB=NhaXuatBan.MaNXB", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_nxb.DataSource = ds.Tables[0];
        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {

        }
    }
}
