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
    public partial class form_thongke : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LINH-PC;Initial Catalog=QLGiaoTrinh;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public form_thongke()
        {
            InitializeComponent();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            if (tb_tennguoimuon.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand(" SELECT GiaoTrinh.TenGiaoTrinh, SUM(SoLuong)  AS SoLuongGiaoTrinhMuon FROM CTPhieuMuon, PhieuMuon, GiaoTrinh WHERE CTPhieuMuon.MaPhieuMuon = PhieuMuon.MaPhieuMuon AND CTPhieuMuoN.MaGiaoTrinh = GiaoTrinh.MaGiaoTrinh AND NguoiMuon  = N'" + tb_tennguoimuon.Text.ToString() + "' GROUP BY CTPhieuMuon.MaGiaoTrinh,GiaoTrinh.TenGiaoTrinh", con);
                    adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dgv_thonke.DataSource = dt;
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

        private void dgv_thonke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void form_thongke_Load(object sender, EventArgs e)
        {
               try
            {
                con.Open();
                cmd = new SqlCommand(" SELECT NguoiMuon,GiaoTrinh.TenGiaoTrinh, SoLuong FROM CTPhieuMuon, PhieuMuon, GiaoTrinh WHERE CTPhieuMuon.MaPhieuMuon = PhieuMuon.MaPhieuMuon AND CTPhieuMuoN.MaGiaoTrinh = GiaoTrinh.MaGiaoTrinh", con);
                adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dgv_thonke.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
            {
                this.Hide();
                form_hethong h_t = new form_hethong();
                h_t.ShowDialog();
            }
        }
    }
}
