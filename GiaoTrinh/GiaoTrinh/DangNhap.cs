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
namespace GiaoTrinh
{
    public partial class form_dangnhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=QLGiaoTrinh;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public form_dangnhap()
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM NguoiDung", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void form_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dg == DialogResult.OK)
            {
                this.Hide();
                form_hethong h_t = new form_hethong();
                h_t.ShowDialog();
            }
        }
    }
}
