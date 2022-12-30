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
    public partial class form_dangnhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=BanHang;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public form_dangnhap()
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE TaiKhoan = '"+tb_taikhoan.Text.ToString()+"' AND MatKhau = '"+tb_matkhau.Text.ToString()+"'", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dg == DialogResult.OK)
            {
                this.Hide();
                form_hethong h_t = new form_hethong();
                h_t.ShowDialog();
            }
        }

        private void tb_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
