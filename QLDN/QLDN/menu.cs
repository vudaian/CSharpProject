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
namespace QLDN
{
    public partial class menu : Form
    {
        public string connect_text = "";
        public menu()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=dethiview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM nguoidung ", con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgv_menu.DataSource = ds.Tables[0];
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=dethiview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO nguoidung(Taikhoan,MatKhau) VALUES(@taikhoan, @matkhau)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@taikhoan", tb_taikhoan.Text);
            cmd.Parameters.AddWithValue("@matkhau", tb_matkhau.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm tài khoản thành công!!!");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=dethiview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM nguoidung WHERE Taikhoan=@taikhoan AND MatKhau=@matkhau", con);
            con.Open();
            cmd.Parameters.AddWithValue("@taikhoan", tb_taikhoan.Text);
            cmd.Parameters.AddWithValue("@matkhau", tb_matkhau.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa tài khoản thành công!!!");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=dethiview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE nguoidung SET Taikhoan=@taikhoan, MatKhau=@matkhau where Taikhoan=@taikhoan", con);
            con.Open();
            cmd.Parameters.AddWithValue("@taikhoan", tb_taikhoan.Text);
            cmd.Parameters.AddWithValue("@matkhau", tb_matkhau.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa tài khoản thành công!!!");
        }

        private void tb_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
