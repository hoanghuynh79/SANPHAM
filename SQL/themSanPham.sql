CREATE PROCEDURE themSanPham
    @MaSP INT,
    @TenSP NVARCHAR(255),
    @MaLoaiSP INT,
    @DonGia REAL,
    @MaNCC INT,
    @SoLuong INT,
    @TenLoaiSP NVARCHAR(255),
    @TenNCC NVARCHAR(255),
    @DiaChi NVARCHAR(255),
    @TrangThai NVARCHAR(50),
    @Result INT OUTPUT -- Thêm tham số OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Thêm hoặc cập nhật thông tin trong bảng LOAISANPHAM
    IF NOT EXISTS (SELECT 1 FROM LOAISANPHAM WHERE maLoaiSanPham = @MaLoaiSP)
    BEGIN
        INSERT INTO LOAISANPHAM(maLoaiSanPham, tenLoaiSanPham)
        VALUES(@MaLoaiSP, @TenLoaiSP);
    END
    ELSE
    BEGIN
        UPDATE LOAISANPHAM
        SET tenLoaiSanPham = @TenLoaiSP
        WHERE maLoaiSanPham = @MaLoaiSP;
    END

    -- Thêm hoặc cập nhật thông tin trong bảng NHACUNGCAP
    IF NOT EXISTS (SELECT 1 FROM NHACUNGCAP WHERE maNCC = @MaNCC)
    BEGIN
        INSERT INTO NHACUNGCAP(maNCC, tenNCC, diaChi, trangThai)
        VALUES(@MaNCC, @TenNCC, @DiaChi, @TrangThai);
    END
    ELSE
    BEGIN
        UPDATE NHACUNGCAP
        SET tenNCC = @TenNCC,
            diaChi = @DiaChi,
            trangThai = @TrangThai
        WHERE maNCC = @MaNCC;
    END

    -- Thêm sản phẩm vào bảng SANPHAM
    INSERT INTO SANPHAM(maSanPham, tenSanPham, maLoaiSanPham, donGia, maNCC, soLuong)
    VALUES(@MaSP, @TenSP, @MaLoaiSP, @DonGia, @MaNCC, @SoLuong);

    -- Trả về kết quả
    IF @@ERROR = 0
    BEGIN
        SET @Result = 1; -- Thành công
    END
    ELSE
    BEGIN
        SET @Result = 0; -- Thất bại
    END
END

