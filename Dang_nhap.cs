using KTPMUD;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DANG_NHAP
{
    public partial class Dang_nhap : Form
    {
        //Check 1
        public Dang_nhap()
        {
            InitializeComponent();
        }
        Tai_khoan taikhoan = new Tai_khoan();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK = txtTK.Text;
            string matkhau = txtMK.Text;
            if(tenTK.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoàn");}
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu");}
            else
            {
                string query = "SELECT * FROM [dbo].[Users] WHERE UserName = '"+tenTK+"' AND Passwords = '"+matkhau+"'";
                if (taikhoan.TaiKhoans(query).Count != 0)
                {
                    Chuong_trinh f = new Chuong_trinh();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text;
            string password = txtMK.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=DTuanDZ;Initial Catalog=Dang_nhap;Integrated Security=True;"))
            {
                conn.Open();
                string query = "INSERT INTO Users (txtTK, txtMK) VALUES (@username, @password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}
