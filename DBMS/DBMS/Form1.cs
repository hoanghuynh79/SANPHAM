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
using System.IO;

namespace DBMS
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-DSR3HD30;Initial Catalog=CUAHANGBACHHOA;Integrated Security=True";
        SqlDataAdapter adapter=new SqlDataAdapter();
        DataTable table = new DataTable();

        void Loadata()
        {
            command= connection.CreateCommand();
            command.CommandText = "select * from ViewSanPham ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loadata();
            dgv.SelectionChanged += dgv_SelectionChanged;

        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                int MaSP = int.Parse(tb_maSanPham.Text);
                string TenSP = tb_tenSanPham.Text;
                float DonGia = float.Parse(tb_donGia.Text);
                int MaLoaiSP = int.Parse(tb_maLoaiSanPham.Text);
                int MaNCC = int.Parse(tb_maNCC.Text);
                int SoLuong = int.Parse(tb_soLuong.Text);
                string TenLoaiSP = tb_tenLoaiSanPham.Text;
                string TenNCC = tb_tenNCC.Text;
                string DiaChi = tb_diaChi.Text;
                string TrangThai = tb_trangThai.Text;

                themSanPham handler = new themSanPham();
                handler.bt_Insert(MaSP, TenSP, MaLoaiSP, DonGia, MaNCC, SoLuong, TenLoaiSP, TenNCC, DiaChi, TrangThai);
                Loadata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.ToString()); // Hiển thị lỗi nếu có
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chọn đúng 1 hàng
            if (dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                int MaSP = Convert.ToInt32(row.Cells["maSanPham"].Value);
                string TenSP = row.Cells["tenSanPham"].Value.ToString();
                int MaLoaiSP = Convert.ToInt32(row.Cells["maLoaiSanPham"].Value);
                float DonGia = Convert.ToSingle(row.Cells["donGia"].Value);
                int MaNCC = Convert.ToInt32(row.Cells["maNCC"].Value);
                int SoLuong = Convert.ToInt32(row.Cells["soLuong"].Value);

                tb_maSanPham.Text = MaSP.ToString();
                tb_tenSanPham.Text = TenSP;
                tb_maLoaiSanPham.Text = MaLoaiSP.ToString();
                tb_donGia.Text = DonGia.ToString();
                tb_maNCC.Text = MaNCC.ToString();
                tb_soLuong.Text = SoLuong.ToString();
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ các controls trên form
            string MaSP = tb_maSanPham.Text;
            string TenSP = tb_tenSanPham.Text;
            float DonGia = float.Parse(tb_donGia.Text);
            int MaNCC = int.Parse(tb_maNCC.Text);
            int SoLuong = int.Parse(tb_soLuong.Text);
            int MaLoaiSP = int.Parse(tb_maLoaiSanPham.Text);

            // Khởi tạo một biến để lưu kết quả cập nhật
            bool updateResult = false;

            // Gọi hàm cập nhật sản phẩm
            suaSanPham handler = new suaSanPham();
            updateResult = handler.bt_Update(MaSP, TenSP, DonGia, MaNCC, SoLuong,MaLoaiSP);

            // Kiểm tra kết quả cập nhật và hiển thị thông báo
            if (updateResult)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                // Cập nhật lại dữ liệu trong DataGridView nếu cần
                // Ví dụ: RefreshDataGridView();
                Loadata();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công!");
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            string MaSP = tb_maSanPham.Text;

            // Gọi phương thức xóa sản phẩm
            xoaSanPham handler = new xoaSanPham();
            handler.bt_Delete(MaSP);
            Loadata();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
           
                string keyword = tb_Search.Text; // Lấy từ khóa tìm kiếm từ TextBox

            // Kiểm tra xem từ khóa có rỗng không
            if (!string.IsNullOrEmpty(keyword))
            {
                timKiem search = new timKiem(); // Tạo một đối tượng của lớp timKiem
                DataTable result = search.SearchSanPham(keyword); // Thực hiện tìm kiếm sản phẩm

                // Hiển thị kết quả tìm kiếm, ví dụ: nạp kết quả vào DataGridView
                dgv.DataSource = result;

            }
            else
            {
                // Hiển thị thông báo nếu từ khóa tìm kiếm là rỗng
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
            }
        }

    }
}
