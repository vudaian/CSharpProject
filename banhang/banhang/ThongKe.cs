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
    public partial class form_thongke : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=BanHang;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public form_thongke()
        {
            InitializeComponent();
        }

        private void form_thongke_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT TenLoai,COUNT(GiaoTrinh.MaLoai) AS SoLuong FROM GiaoTrinh, LoaiGiaoTrinh WHERE GiaoTrinh.MaLoai = LoaiGiaoTrinh.MaLoai GROUP BY TenLoai", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dgv_thongke.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
