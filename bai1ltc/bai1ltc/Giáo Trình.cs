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
    public partial class GiaoTrinh : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=bai1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int row_id = 0;
        public GiaoTrinh()
        {
            InitializeComponent();
        //    Display_menu();
        }
             private void Display_menu()
             {
                 try
                 {
                     con.Open();
                     cmd = new SqlCommand ("SELECT * FROM GiaoTrinh",con);
                     adapt = new SqlDataAdapter(cmd);
                     DataSet ds = new DataSet();
                     adapt.Fill(ds);
                     dgv_menu.DataSource = ds.Tables[0];
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
            tb_matacgia.Text = "";
            tb_manhaxuatban.Text = "";
            tb_namxuatban.Text = "";
        }

        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            tb_magiaotrinh.Text = dgv_menu.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tengiaotrinh.Text = dgv_menu.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_maloai.Text = dgv_menu.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_matacgia.Text = dgv_menu.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_manhaxuatban.Text = dgv_menu.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_namxuatban.Text = dgv_menu.Rows[row_id].Cells[5].Value.ToString().Trim();

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            tb_magiaotrinh.Enabled = true;
            tb_tengiaotrinh.Enabled = true;
            tb_matacgia.Enabled = true;
            tb_manhaxuatban.Enabled = true;
            tb_namxuatban.Enabled = true;
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_matacgia.Text != "" && tb_manhaxuatban.Text != "" && tb_namxuatban.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO GiaoTrinh(MaGiaoTrinh,TenGiaoTrinh ,MaLoai ,MaTacGia ,MaNXB,NamXB) VALUES(@magiaotrinh, @tengt, @mal, @matg, @manxb, @namxb)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@magiaotrinh", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tengt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@mal", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@matg", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namxb", tb_namxuatban.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!!!");
                    con.Close();
                    Display_menu();
                    Clear_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }


        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            tb_magiaotrinh.Enabled = false;
            tb_tengiaotrinh.Enabled = false;
            tb_matacgia.Enabled = false;
            tb_manhaxuatban.Enabled = false;
            tb_namxuatban.Enabled = false;
            
            try
            {
                
                string mal = tb_maloai.Text;
                con.Open();
                string sql = "SELECT * FROM GiaoTrinh WHERE MaLoai= '" + mal + "'";
                cmd = new SqlCommand(sql,con);
                adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dgv_menu.DataSource = ds.Tables[0];
                con.Close();

               /*  string tenSP = tb_tenSP.Text;
                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM SanPham WHERE TenSP = '" + tenSP + "'", con);
                adapter.Fill(dt);
                gv_sanpham.DataSource = dt;

                con.Close();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            tb_magiaotrinh.Enabled = true;
            tb_tengiaotrinh.Enabled = true;
            tb_matacgia.Enabled = true;
            tb_manhaxuatban.Enabled = true;
            tb_namxuatban.Enabled = true;
            Display_menu();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            tb_magiaotrinh.Enabled = true;
            tb_tengiaotrinh.Enabled = true;
            tb_matacgia.Enabled = true;
            tb_manhaxuatban.Enabled = true;
            tb_namxuatban.Enabled = true;
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_matacgia.Text != "" && tb_manhaxuatban.Text != "" && tb_namxuatban.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE GiaoTrinh SET TenGiaoTrinh=@tengt ,MaLoai=@mal ,MaTacGia=@matg ,MaNXB= @manxb,NamXB=@namxb WHERE MaGiaoTrinh=@magiaotrinh", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@magiaotrinh", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tengt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@mal", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@matg", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namxb", tb_namxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if(rowaffected == 1)
                    {

                        MessageBox.Show("Sửa thành công!!!");
                    }
                
                    con.Close();
                    Display_menu();
                    Clear_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            
        
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
}

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            tb_magiaotrinh.Enabled = true;
            tb_tengiaotrinh.Enabled = true;
            tb_matacgia.Enabled = true;
            tb_manhaxuatban.Enabled = true;
            tb_namxuatban.Enabled = true;
            if (tb_magiaotrinh.Text != "" && tb_tengiaotrinh.Text != "" && tb_maloai.Text != "" && tb_matacgia.Text != "" && tb_manhaxuatban.Text != "" && tb_namxuatban.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM GiaoTrinh  WHERE MaGiaoTrinh=@magiaotrinh AND TenGiaoTrinh=@tengt AND MaLoai=@mal AND MaTacGia=@matg AND MaNXB= @manxb AND NamXB=@namxb", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@magiaotrinh", tb_magiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@tengt", tb_tengiaotrinh.Text);
                    cmd.Parameters.AddWithValue("@mal", tb_maloai.Text);
                    cmd.Parameters.AddWithValue("@matg", tb_matacgia.Text);
                    cmd.Parameters.AddWithValue("@manxb", tb_manhaxuatban.Text);
                    cmd.Parameters.AddWithValue("@namxb", tb_namxuatban.Text);
                    int rowaffected = cmd.ExecuteNonQuery();
                    if(rowaffected == 1)
                    {
                        MessageBox.Show("Xóa thành công!!!");
                        con.Close();
                    }
                    con.Close();
                    Display_menu();
                    Clear_menu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }


            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
        }
    }
}
 