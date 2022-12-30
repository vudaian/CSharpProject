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
    public partial class form_giaotrinh : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=BanHang;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        public form_giaotrinh()
        {
            InitializeComponent();
        }
        private void Display_menu()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM GiaoTrinh", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dgv_giaotrinh.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Clean_menu()
        {
            tb_magiaotrinh.Text = "";
            tb_tengiaotrinh.Text = "";
            tb_maloai.Text = "";
            tb_matacgia.Text = "";
            tb_manhaxuatban.Text = "";
            tb_namxuatban.Text = "";
        }
   

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_menu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_magiaotrinh.Text != ""&& tb_tengiaotrinh.Text != ""&& tb_maloai.Text != ""&&tb_matacgia.Text != ""&&tb_manhaxuatban.Text != ""&& tb_namxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO GiaoTrinh(MaGiaoTrinh,TenGiaoTrinh,MaLoai,MaTacGia,MaNXB,NamXB) VALUES(@mgt,@tgt,@ml,@mtgia,@manxb,@namnxb)", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@mtgia", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namnxb", tb_namxuatban.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    con.Close();
                    Display_menu();
                    Clean_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_matacgia.Text != "" && tb_manhaxuatban.Text != "" && tb_namxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE GiaoTrinh SET TenGiaoTrinh=@tgt,MaLoai=@ml,MaTacGia=@mtgia,MaNXB=@manxb,NamXB=@namnxb WHERE MaGiaoTrinh=@mgt", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@mtgia", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namnxb", tb_namxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if(rowaffected == 1)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    con.Close();
                    Display_menu();
                    Clean_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_matacgia.Text != "" && tb_manhaxuatban.Text != "" && tb_namxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM GiaoTrinh WHERE MaGiaoTrinh=@mgt AND TenGiaoTrinh=@tgt AND MaLoai=@ml AND MaTacGia=@mtgia AND MaNXB=@manxb AND NamXB=@namnxb ", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@mtgia", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namnxb", tb_namxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected == 1)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    con.Close();
                    Display_menu();
                    Clean_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tb_maloai.Text != "" )
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM GiaoTrinh WHERE MaLoai = '" + tb_maloai.Text.ToString() + "'", con);
                    adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dgv_giaotrinh.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập loại giáo trình!");
            }
        }

        private void dgv_giaotrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_id = 0;
            row_id = e.RowIndex;
            tb_magiaotrinh.Text = dgv_giaotrinh.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tengiaotrinh.Text = dgv_giaotrinh.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_maloai.Text = dgv_giaotrinh.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_matacgia.Text = dgv_giaotrinh.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_manhaxuatban.Text = dgv_giaotrinh.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_namxuatban.Text = dgv_giaotrinh.Rows[row_id].Cells[5].Value.ToString().Trim();
        }
    }
}
