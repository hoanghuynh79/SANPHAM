CREATE PROCEDURE XoaSanPham
    @MaSP INT
AS
BEGIN
    DELETE FROM SANPHAM
    WHERE maSanPham = @MaSP;

    IF @@ROWCOUNT = 0
        PRINT N'Không tìm thấy sản phẩm có ID ' + CAST(@MaSP AS VARCHAR(10));
    ELSE
        PRINT N'Đã xóa sản phẩm có ID ' + CAST(@MaSP AS VARCHAR(10));
END;
