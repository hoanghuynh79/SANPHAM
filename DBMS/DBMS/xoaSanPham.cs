using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    internal class xoaSanPham
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-DSR3HD30;Initial Catalog=CUAHANGBACHHOA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public bool bt_Delete(string MaSP)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand("xoaSanPham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm không tồn tại hoặc có lỗi xảy ra khi xóa!");
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
        }

    }
}
