using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QL_NhaThuoc
{
    internal class Phong
    {
        public void connection(SqlConnection conn)
        {
            conn.ConnectionString = "Server = MSI; Database = QuanLyThuoc;Integrated Security=True";
            conn.Open();
        }
        public void LoadDataLNV(SqlConnection conn,DataGridView dataGridView1)
        {
        
            string sql = " select MaNV,TenNV,FORMAT(NgaySinh, 'yyyy-MM-dd') AS FormattedDate,GioiTinh,SDT,DIACHI,URL from NHAN_VIEN; ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            dataGridView1.Rows.Clear();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int rowindex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowindex];
                    row.Cells["Column_ID"].Value = reader["MaNV"];
                    row.Cells["Column_Name"].Value = reader["TenNV"];
                    row.Cells["Column_BDate"].Value = reader["FormattedDate"];
                    row.Cells["Column_Sex"].Value = reader["GioiTinh"];
                    row.Cells["Column_Phone"].Value = reader["SDT"];
                    row.Cells["Column_Loc"].Value = reader["DIACHI"];
                    row.Cells["Column_URL"].Value = reader["URL"];
                 

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string GetMaxIDNV(SqlConnection conn)
        {
            this.connection(conn);
            string ketQua = "";
            string sql = "select Max(MANV) as MAX_MaNV from NHAN_VIEN;";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {   
                string MaxID = reader["MAX_MaNV"].ToString();
                string MaxID1 = new string(MaxID.Where(char.IsDigit).ToArray());

                // Chuyển thành kiểu int và cộng 1
                int so = int.Parse(MaxID1) + 1;
                ketQua = $"NV{so:000}";
                
            }
            conn.Close();
            return ketQua;
        }
    }
}
