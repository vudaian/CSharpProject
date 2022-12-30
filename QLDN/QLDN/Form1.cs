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
using System.Text.RegularExpressions;
namespace QLDN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_taikhoan_TextChanged(object sender, EventArgs e)
        {
            tb_matkhau.Enabled = true;
            bt_dangnhap.Enabled = true;
            cb_quyen_admin.Enabled=true;
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
           

            string user = tb_taikhoan.Text;
            string password = tb_matkhau.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=dethiview;Integrated Security=True");
            //  string connectionstring = "";
            string sql = "SELECT * FROM nguoidung WHERE Taikhoan='" + user + "'AND MatKhau='" + password + "'";
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
           // SqlCommand sqlCmd = new SqlCommand("SELECT * FROM nguoidung WHERE Taikhoan=@taiKhoan AND MatKhau=@matKhau", conn);
           // sqlCmd.Parameters.AddWithValue("@taiKhoan", tb_taikhoan.Text);
           // sqlCmd.Parameters.AddWithValue("@matKhau", tb_matkhau.Text);

            
            conn.Open();

          //  SqlDataReader dr = sqlCmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Regex pattern = new Regex("[a-z0-9]");
           
            if (dt.Rows.Count > 0)
            {
             /*   if (pattern.IsMatch(user))
                {

                    MessageBox.Show("ok - User có các ký tự thỏa mãn");
                }
                else
                {
                    

                    //this.Close();
                }*/
                var admin_role = dt.Rows[0].Field<string>("Quyen_admin");
                int l = 0;
                foreach (char chr in password)
                {
                    l += 1;

                }
               if(l < 5 || pattern.IsMatch(user) == false )
                {
                    MessageBox.Show("mật khẩu bé hơn 5 kí tự hãy nhập lại or user chứa ký tự đặc biệt nhập lại user");
                
                }
                else
                {

               
                    if (admin_role == "y")
                    {
                        if (cb_quyen_admin.Checked == true)
                        {
                            MessageBox.Show("Chào mừng bạn đăng nhập bằng quyền admin!!!");
                            this.Hide();
                            menu form_tk_mk = new menu();
                            //  form_tk_mk.connect_text = connectionstring;
                            form_tk_mk.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Bạn là admin nhưng không check vào ô nên bạn đăng nhập với quyền user");
                            this.Hide();
                            menu form_tk_mk = new menu();
                            //  form_tk_mk.connect_text = connectionstring;
                            form_tk_mk.ShowDialog();
                        }
                    }
                    else
                    {
                   
                        if (cb_quyen_admin.Checked == true)
                        {
                            MessageBox.Show("Bạn không phải làm admin bỏ check vào đăng nhập lại!");
                        }
                        else 
                        {
                            MessageBox.Show("Chào mừng USER!!!");
                            this.Hide();
                            menu form_tk_mk = new menu();
                            //form_tk_mk.connect_text = connectionstring;
                            form_tk_mk.ShowDialog();
                        }
                    }
                }

                /* else
                 {
                     MessageBox.Show("Đăng nhập vào hệ thống!!!!");
                 } */


            }
            else
            {
                MessageBox.Show("Đăng nhập THẤT BẠI!");
            }

            conn.Close();
        }

        private void cb_quyen_admin_CheckedChanged(object sender, EventArgs e)
        {
             if(cb_quyen_admin.Checked==true) //&& admin_role = "y"/)
            {

            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ( dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tb_matkhau_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
