CREATE PROCEDURE suaSanPham
    @MaSP INT,
    @TenSP nvarchar(255),
    @MaLoaiSP int,
    @DonGia real,
    @MaNCC int,
    @SoLuong int
AS
BEGIN
    BEGIN TRY
        -- Sửa thông tin sản phẩm
        UPDATE dbo.SANPHAM 
        SET 
            maSanPham = @MaSP,
            tenSanPham = @TenSP,
            maLoaiSanPham = @MaLoaiSP,
            donGia = @DonGia,
            maNCC = @MaNCC,
            soLuong = @SoLuong
        WHERE 
            maSanPham = @MaSP;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
    END CATCH
END
