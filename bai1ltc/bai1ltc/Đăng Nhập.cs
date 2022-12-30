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
    public partial class Đăng_Nhập : Form
    {
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dg == DialogResult.OK)
            {
                this.Hide();
                he_thong ht = new he_thong();
                ht.ShowDialog();
            }
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=bai1;Integrated Security=True");
                con.Open();
                string tk = tb_taikhoan.Text;
                string mk = tb_matkhau.Text;
                string sql = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!!!");
                }
                else
                {
                    MessageBox.Show("Đằng nhập thất bại!!!");
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
