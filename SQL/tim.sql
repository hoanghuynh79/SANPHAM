CREATE PROCEDURE timSanPham 
    @string NVARCHAR(50)
AS
BEGIN
    SELECT maSanPham, tenSanPham, maLoaiSanPham, donGia, maNCC, soLuong
    FROM dbo.SANPHAM
    WHERE CONCAT(maSanPham, tenSanPham, maLoaiSanPham, donGia, maNCC, soLuong) LIKE '%' + @string + '%'
END
