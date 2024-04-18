CREATE TRIGGER kiemTraSanPham
ON SANPHAM
INSTEAD OF UPDATE
AS
BEGIN
    -- Kiểm tra tên sản phẩm mới
    IF EXISTS (
        SELECT *
        FROM inserted i
        WHERE EXISTS (
            SELECT *
            FROM SANPHAM sp
            WHERE sp.tenSanPham = i.tenSanPham AND sp.maSanPham <> i.maSanPham
        )
    )
    BEGIN
        RAISERROR('Tên sản phẩm bị trùng', 16, 1);
        RETURN;
    END

    -- Nếu không có trùng lặp, thực hiện cập nhật
    UPDATE sp
    SET 
        maSanPham = i.maSanPham,
        tenSanPham = i.tenSanPham,
        maLoaiSanPham = i.maLoaiSanPham,
        donGia = i.donGia,
        maNCC = i.maNCC,
        soLuong = i.soLuong
    FROM SANPHAM sp
    INNER JOIN inserted i ON sp.maSanPham = i.maSanPham;
END
