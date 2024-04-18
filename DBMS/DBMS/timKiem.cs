using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    internal class timKiem
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-DSR3HD30;Initial Catalog=CUAHANGBACHHOA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable SearchSanPham(string keyword)
        {
            using (connection = new SqlConnection(str))
            {
                connection.Open();
                command = new SqlCommand("timSanPham", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@string", keyword);

                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
