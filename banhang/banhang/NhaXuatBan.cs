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
namespace banhang
{
    public partial class form_nhaxuatban : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=BanHang;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public form_nhaxuatban()
        {
            InitializeComponent();
        }

        private void form_nhaxuatban_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT DISTINCT TenNXB FROM GiaoTrinh, NhaXuatBan WHERE GiaoTrinh.MaNXB = NhaXuatBan.MaNXB ", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dgv_cungcap.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
