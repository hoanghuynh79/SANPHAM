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

    internal class themSanPham
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-DSR3HD30;Initial Catalog=CUAHANGBACHHOA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        public bool bt_Insert(int MaSP, string TenSP, int MaLoaiSP, float DonGia, int MaNCC, int SoLuong, string TenLoaiSP, string TenNCC, string DiaChi, string TrangThai)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                using (SqlCommand command = new SqlCommand("themSanPham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaSP", SqlDbType.Int).Value = MaSP;
                    command.Parameters.Add("@TenSP", SqlDbType.NVarChar, 255).Value = TenSP;
                    command.Parameters.Add("@MaLoaiSP", SqlDbType.Int).Value = MaLoaiSP;
                    command.Parameters.Add("@DonGia", SqlDbType.Real).Value = DonGia;
                    command.Parameters.Add("@MaNCC", SqlDbType.Int).Value = MaNCC;
                    command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                    command.Parameters.Add("@TenLoaiSP", SqlDbType.NVarChar, 255).Value = TenLoaiSP;
                    command.Parameters.Add("@TenNCC", SqlDbType.NVarChar, 255).Value = TenNCC;
                    command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = DiaChi;
                    command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = TrangThai;

                    SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);
                    resultParam.Direction = ParameterDirection.Output; // Đặt kiểu là OUTPUT
                    command.Parameters.Add(resultParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        int result = Convert.ToInt32(command.Parameters["@Result"].Value); // Lấy giá trị trả về từ OUTPUT

                        if (result == 1)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm không thành công!");
                            connection.Close();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.ToString());
                        return false;
                    }
                }
            }
        }
    }
}





