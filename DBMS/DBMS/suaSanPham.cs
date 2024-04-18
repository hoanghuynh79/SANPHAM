using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    internal class suaSanPham
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-DSR3HD30;Initial Catalog=CUAHANGBACHHOA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public bool bt_Update(string MaSP, string TenSP, float DonGia, int MaNCC, int SoLuong,int MaLoaiSP)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand("suaSanPham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;
                    command.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = TenSP;
                    command.Parameters.Add("@DonGia", SqlDbType.Float).Value = DonGia;
                    command.Parameters.Add("@MaNCC", SqlDbType.Int).Value = MaNCC;
                    command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                    command.Parameters.Add("@MaLoaiSP", SqlDbType.Int).Value = MaLoaiSP;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm không thành công!");
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 50000 && ex.Message.Contains("Tên sản phẩm bị trùng"))
                        {
                            MessageBox.Show("Tên sản phẩm đã tồn tại!");
                        }
                        MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                
            }   } 
        }
    }
}
