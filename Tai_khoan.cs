using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD
{
    internal class Tai_khoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public Tai_khoan()
        {
        }

        public Tai_khoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
        SqlCommand sqlCommand; //truy vấn các câu lệnh insert, delete, update,...
        SqlDataReader dataReader; // Dùng để đọc dữ liệu trong bảng.
        
        public string TenTaiKoan { get => this.tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value;  }
        public List<Tai_khoan> TaiKhoans(string query)
        {
            List<Tai_khoan> TaiKhoans = new List<Tai_khoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    TaiKhoans.Add(new Tai_khoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
                return TaiKhoans;
        }
    }
}
