using System.Data;
using System.Data.SqlClient;
namespace QL_NhaThuoc
{
    internal class nguyen
    {
        public SqlConnection ketnoi()
        {
            string chuoiketnoi = "Server=MSI;Database=QuanLyThuoc;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            return conn;
        }

        public DataTable LayDuLieuNV()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = ketnoi())
            {
                string query = "SELECT MANV, TENNV FROM NHAN_VIEN"; // Truy vấn dữ liệu

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                    }
                }
            }
            return dataTable; // Trả về DataTable chứa dữ liệu
        }

    }
}
