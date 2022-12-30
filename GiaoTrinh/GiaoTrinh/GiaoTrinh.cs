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
    public partial class form_giaotrinh : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=QLGiaoTrinh;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
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
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dgv_giaotrinh.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Clear_menu()
        {
            tb_magiaotrinh.Text = "";
            tb_tengiaotrinh.Text = "";
            tb_maloai.Text = "";
            tb_tentacgia.Text = "";
            tb_nhaxuatban.Text = "";
        }
        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_menu();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_magiaotrinh.Text != ""&& tb_tengiaotrinh.Text != ""&&tb_maloai.Text != "" && tb_tentacgia.Text != "" && tb_nhaxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO GiaoTRinh(MaGiaoTrinh,TenGiaoTrinh,MaLoai,TenTacGia,NhaXuatBan) VALUES(@mgt,@tgt,@ml,@tgtt,@nxb)", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@tgtt", tb_tentacgia.Text);
                    cmd.Parameters.AddWithValue("@nxb", tb_nhaxuatban.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    con.Close();
                    Display_menu();
                    Clear_menu();
                }
                catch(Exception ex)
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
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_tentacgia.Text != "" && tb_nhaxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE GiaoTRinh SET TenGiaoTrinh=@tgt,MaLoai=@ml,TenTacGia=@tgtt,NhaXuatBan=@nxb WHERE  MaGiaoTrinh=@mgt ", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@tgtt", tb_tentacgia.Text);
                    cmd.Parameters.AddWithValue("@nxb", tb_nhaxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if(rowaffected == 1)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    con.Close();
                    Display_menu();
                    Clear_menu();
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
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_tentacgia.Text != "" && tb_nhaxuatban.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM GiaoTRinh  WHERE  MaGiaoTrinh=@mgt AND TenGiaoTrinh=@tgt AND MaLoai=@ml AND TenTacGia=@tgtt AND NhaXuatBan=@nxb ", con);
                    cmd.Parameters.AddWithValue("@mgt", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tgt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@ml", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@tgtt", tb_tentacgia.Text);
                    cmd.Parameters.AddWithValue("@nxb", tb_nhaxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected == 1)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    con.Close();
                    Display_menu();
                    Clear_menu();
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

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tb_tengiaotrinh.Text !="")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM GiaoTrinh WHERE TenGiaoTrinh = N'" + tb_tengiaotrinh.Text.ToString() + "'", con);
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
                MessageBox.Show("Vui lòng nhập tên giáo trinh!");
            }
         
        }

        private void dgv_giaotrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_id = 0;
            row_id = e.RowIndex;
            tb_magiaotrinh.Text = dgv_giaotrinh.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tengiaotrinh.Text = dgv_giaotrinh.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_maloai.Text = dgv_giaotrinh.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_tentacgia.Text = dgv_giaotrinh.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_nhaxuatban.Text = dgv_giaotrinh.Rows[row_id].Cells[4].Value.ToString().Trim();
        }
    }
}
