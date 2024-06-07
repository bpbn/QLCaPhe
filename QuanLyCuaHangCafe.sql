CREATE DATABASE QuanLyCuaHangCafe
GO
USE QuanLyCuaHangCafe
GO

use master
drop database QuanLyCuaHangCafe
go
-- TABLE --
CREATE TABLE TaiKhoan
(
	TenDangNhap varchar(50) not null,
	MatKhau varchar(50),
	MaChucVu varchar(10)
)

CREATE TABLE NhaCungCap
(
	MaNhaCungCap varchar(10) not null default 'NCC000',
	TenNhaCungCap nvarchar(200),
	SoDienThoai varchar(12),
	Email varchar(100),
	DiaChi nvarchar(200)
)

CREATE TABLE PhieuNhap
(
	MaPhieuNhap varchar(10) not null default 'PN000',
	NgayNhap Date,
	TongTien int default 0,
	MaNhaCungCap varchar(10),
	MaNhanVien varchar(10)
)

CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap varchar(10) not null,
	MaNguyenLieu varchar(10) not null,
	SoLuong int default 1,
	DonGia int,
	ThanhTien int default 0,
	GhiChu text
)

CREATE TABLE NguyenLieu
(
	MaNguyenLieu varchar(10) not null default 'NL000',
	TenNguyenLieu nvarchar(100),
	XuatXu nvarchar(30),
	SoLuongTon int
)

CREATE TABLE LoaiSanPham
(
	MaLoai varchar(10) not null,
	TenLoai nvarchar(100)
)	

CREATE TABLE SanPham
(
	MaSanPham varchar(10) not null default 'SP000',
	TenSanPham nvarchar(200),
	GiaBan int,
	MaLoai varchar(10),
	TrangThai nvarchar(10)
)

CREATE TABLE NhanVien
(
	MaNhanVien varchar(10) not null default 'SP000',
	TenNhanVien nvarchar(200),
	NgaySinh Date,
	GioiTinh bit,
	DiaChi nvarchar(200),
	NgayVaoLam Date,
	NgayNghi Date,
	MaChucVu varchar(10)
)

CREATE TABLE HoaDon
(
	MaHoaDon varchar(10) not null default 'HD000',
	TongTien int default 0,
	ThoiGianLap DateTime,
	MaNhanVien varchar(10), 
	GhiChu varchar(100)
)

CREATE TABLE ChiTietHoaDon
(
	MaHoaDon varchar(10) not null,
	MaSanPham varchar(10) not null,
	SoLuong int default 1,
	ThanhTien int default 0,
	GhiChu text
)

CREATE TABLE ChucVu
(
	MaChucVu varchar(10) not null,
	TenChucVu nvarchar(20),
	LuongCoBan int
)


CREATE TABLE BangLuong
(
	MaBangLuong varchar(10) not null default 'BL000',
	MaNhanVien varchar(10) not null,
	ThoiGianTraLuong Date,
	PhuCap int,
	Luong int
)

CREATE TABLE CaLam
(
	MaCaLam varchar(10) not null default 'CL000',
	GioBatDau time,
	GioKetThuc time,
	TongGio int,
)


CREATE TABLE ChiTietCaLam
(
	MaCaLam varchar(10) not null,
	MaNhanVien varchar(10) not null,
	NgayLam date not null,
)

GO
-- PRIMARY KEY --
ALTER TABLE NhaCungCap 
	ADD CONSTRAINT PK_NhaCungCap 
	PRIMARY KEY(MaNhaCungCap)

ALTER TABLE ChucVu 
	ADD CONSTRAINT PK_ChucVu 
	PRIMARY KEY (MaChucVu)

ALTER TABLE LoaiSanPham 
	ADD CONSTRAINT PK_LoaiSanPham 
	PRIMARY KEY (MaLoai)

ALTER TABLE NhanVien 
	ADD CONSTRAINT PK_NhanVien 
	PRIMARY KEY (MaNhanVien)

ALTER TABLE HoaDon 
	ADD CONSTRAINT PK_HoaDon 
	PRIMARY KEY (MaHoaDon)

ALTER TABLE SanPham 
	ADD CONSTRAINT PK_SanPham 
	PRIMARY KEY (MaSanPham)

ALTER TABLE ChiTietHoaDon 
	ADD CONSTRAINT PK_ChiTietHoaDon 
	PRIMARY KEY (MaSanPham, MaHoaDon)

ALTER TABLE PhieuNhap 
	ADD CONSTRAINT PK_PhieuNhap 
	PRIMARY KEY (MaPhieuNhap)

ALTER TABLE ChiTietPhieuNhap 
	ADD CONSTRAINT PK_ChiTietPhieuNhap 
	PRIMARY KEY (MaPhieuNhap, MaNguyenLieu)

ALTER TABLE ChiTietCaLam
	ADD CONSTRAINT PK_ChiTietCaLam 
	PRIMARY KEY (MaCaLam, MaNhanVien, NgayLam)

ALTER TABLE TaiKhoan
	ADD CONSTRAINT PK_TaiKhoan 
	PRIMARY KEY (TenDangNhap)

ALTER TABLE NguyenLieu 
	ADD CONSTRAINT PK_NguyenLieu 
	PRIMARY KEY(MaNguyenLieu)

ALTER TABLE CaLam 
	ADD CONSTRAINT PK_CaLam 
	PRIMARY KEY(MaCaLam)

ALTER TABLE BangLuong 
	ADD CONSTRAINT PK_BangLuong 
	PRIMARY KEY(MaBangLuong) 

GO

-- FOREIGN KEY --
ALTER TABLE PhieuNhap
ADD CONSTRAINT FK_PhieuNhap_NhaCungCap FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap),
	CONSTRAINT FK_PhieuNhap_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT FK_ChiTietPhieuNhap_PhieuNhap FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
	CONSTRAINT FK_ChiTietPhieuNhap_NguyenLieu FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_LoaiSanPham FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai)

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
	CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

ALTER TABLE ChiTietCaLam
ADD CONSTRAINT FK_ChiTietCaLam_CaLam FOREIGN KEY (MaCaLam) REFERENCES CaLam(MaCaLam),
	CONSTRAINT FK_ChiTietCaLam_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)

ALTER TABLE BangLuong
ADD CONSTRAINT FK_BangLuong_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO

-----------------------------
CREATE PROC pc_TimMaTiepTheo
    @table VARCHAR(20),
    @id VARCHAR(10) OUT
 AS
 BEGIN
     DECLARE @index INT
     SET @index = 1
     IF @table = 'SanPham'
         BEGIN 
         SET @id = 'SP001'
         
         WHILE EXISTS(SELECT MaSanPham FROM SanPham WHERE MaSanPham = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'SP' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	ELSE IF @table = 'NhaCungCap'
    BEGIN
        SET @id = 'NCC001'
        
        WHILE EXISTS(SELECT MaNhaCungCap FROM NhaCungCap WHERE MaNhaCungCap = @id)
        BEGIN
            SET @index = @index + 1
            SET @id = 'NCC' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
        END
    END
 
 	ELSE IF @table = 'NhanVien'
         BEGIN 
         SET @id = 'NV001'
         
         WHILE EXISTS(SELECT MaNhanVien  FROM NhanVien WHERE MaNhanVien = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'NV' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	 ELSE IF @table = 'PhieuNhap'
         BEGIN 
         SET @id = 'PN001'
         
         WHILE EXISTS(SELECT MaPhieuNhap  FROM PhieuNhap WHERE MaPhieuNhap = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'PN' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	 ELSE IF @table = 'HoaDon'
         BEGIN 
         SET @id = 'HD001'
         
         WHILE EXISTS(SELECT MaHoaDon  FROM HoaDon WHERE MaHoaDon = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'HD' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	 ELSE IF @table = 'NguyenLieu'
         BEGIN 
         SET @id = 'NL001'
         
         WHILE EXISTS(SELECT MaNguyenLieu  FROM NguyenLieu WHERE MaNguyenLieu = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'NL' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	 ELSE IF @table = 'CaLam'
         BEGIN 
         SET @id = 'CL001'
         
         WHILE EXISTS(SELECT MaCaLam  FROM CaLam WHERE MaCaLam = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'CL' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END

	 ELSE IF @table = 'BangLuong'
         BEGIN 
         SET @id = 'BL001'
         
         WHILE EXISTS(SELECT MaBangLuong  FROM BangLuong WHERE MaBangLuong = @id)
         BEGIN
             SET @index = @index + 1
             SET @id = 'BL' + REPLICATE('0',3 - LEN(CAST(@index AS VARCHAR))) + CAST(@index AS VARCHAR)
         END
     END
 
 END
 GO

 -------------------------------------------------
 CREATE TRIGGER TRG_INSERT_SANPHAM
      ON SanPham
      FOR INSERT
 AS
 BEGIN
     --set mã đơn hàng tự động
     PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'
 
     DECLARE @result VARCHAR(10) 
     EXEC pc_TimMaTiepTheo 'SanPham', @result OUT
 
     UPDATE SanPham
     SET MaSanPham = @result
     FROM SanPham JOIN inserted
     ON SanPham.MaSanPham = inserted.MaSanPham
 END
 GO

 CREATE TRIGGER TRG_INSERT_NHACUNGCAP
    ON NhaCungCap
    FOR INSERT
AS
BEGIN
    --set mã đơn hàng tự động
    PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'

    DECLARE @result VARCHAR(10) 
    EXEC pc_TimMaTiepTheo 'NhaCungCap', @result OUT

    UPDATE NhaCungCap
    SET MaNhaCungCap = @result
    FROM NhaCungCap JOIN inserted
    ON NhaCungCap.MaNhaCungCap = inserted.MaNhaCungCap
END
GO

 CREATE TRIGGER TRG_INSERT_NHANVIEN
      ON NhanVien
      FOR INSERT
 AS
 BEGIN
     --set mã đơn hàng tự động
     PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'
 
     DECLARE @result VARCHAR(10) 
     EXEC pc_TimMaTiepTheo 'NhanVien', @result OUT
 
     UPDATE NhanVien
     SET MaNhanVien = @result
     FROM NhanVien JOIN inserted
     ON NhanVien.MaNhanVien = inserted.MaNhanVien
 END
 GO


CREATE TRIGGER TRG_INSERT_PHIEUNHAP
      ON PhieuNhap
      FOR INSERT
 AS
 BEGIN
     --set mã đơn hàng tự động
     PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'
 
     DECLARE @result VARCHAR(10) 
     EXEC pc_TimMaTiepTheo 'PhieuNhap', @result OUT
 
     UPDATE PhieuNhap
     SET MaPhieuNhap = @result
     FROM PhieuNhap JOIN inserted
     ON PhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
 END
 GO

 CREATE TRIGGER TRG_INSERT_HOADON
    ON HoaDon
    FOR INSERT
AS
BEGIN
    --set mã đơn hàng tự động
    PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'

    DECLARE @result VARCHAR(10) 
    EXEC pc_TimMaTiepTheo 'HoaDon', @result OUT

    UPDATE HoaDon
    SET MaHoaDon = @result
    FROM HoaDon JOIN inserted
    ON HoaDon.MaHoaDon = inserted.MaHoaDon
END
GO

 CREATE TRIGGER TRG_INSERT_NGUYENLIEU
      ON NguyenLieu
      FOR INSERT
 AS
 BEGIN
     --set mã đơn hàng tự động
     PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'
 
     DECLARE @result VARCHAR(10) 
     EXEC pc_TimMaTiepTheo 'NguyenLieu', @result OUT
 
     UPDATE NguyenLieu
     SET MaNguyenLieu = @result
     FROM NguyenLieu JOIN inserted
     ON NguyenLieu.MaNguyenLieu = inserted.MaNguyenLieu
 END
 GO

 CREATE TRIGGER TRG_INSERT_CALAM
    ON CaLam
    FOR INSERT
AS
BEGIN
    --set mã đơn hàng tự động
    PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'

    DECLARE @result VARCHAR(10) 
    EXEC pc_TimMaTiepTheo 'CaLam', @result OUT

    UPDATE CaLam
    SET MaCaLam = @result
    FROM CaLam JOIN inserted
    ON CaLam.MaCaLam = inserted.MaCaLam
END
GO

 CREATE TRIGGER TRG_INSERT_BANGLUONG
    ON BangLuong
    FOR INSERT
AS
BEGIN
    --set mã đơn hàng tự động
    PRINT N'MÃ SẼ ĐƯỢC SET TỰ ĐỘNG'

    DECLARE @result VARCHAR(10) 
    EXEC pc_TimMaTiepTheo 'BangLuong', @result OUT

    UPDATE BangLuong
    SET MaBangLuong = @result
    FROM BangLuong JOIN inserted
    ON BangLuong.MaBangLuong = inserted.MaBangLuong
END
GO

CREATE TRIGGER TRG_INSERT_CTDN
      ON ChiTietPhieuNhap
      FOR INSERT
AS
BEGIN

      --cập nhật dữ liệu cho thuộc tính thành tiền của bảng nhập thuốc
      IF(SELECT ThanhTien FROM inserted)!= NULL
      BEGIN
            PRINT N'THÀNH TIỀN SẼ ĐƯỢC HỆ THỐNG TỰ ĐỘNG CẬP NHẬT THEO ĐƠN HÀNG'
      END

      UPDATE ChiTietPhieuNhap
      SET ThanhTien = inserted.SoLuong * ChiTietPhieuNhap.DonGia
      FROM ChiTietPhieuNhap, NguyenLieu nl, inserted
      WHERE ChiTietPhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
      AND ChiTietPhieuNhap.MaNguyenLieu = inserted.MaNguyenLieu
      AND ChiTietPhieuNhap.MaNguyenLieu = nl.MaNguyenLieu

      --cập nhật tổng tiền cho bảng đơn hàng nhập
      UPDATE PhieuNhap
      SET TongTien = TongTien + N.ThanhTien
      FROM PhieuNhap, inserted, ChiTietPhieuNhap N
      WHERE PhieuNhap.MaPhieuNhap = inserted.MaPhieuNhap
      AND N.MaNguyenLieu = inserted.MaNguyenLieu
      AND N.MaPhieuNhap = inserted.MaPhieuNhap

	  --cập nhật số lượng tồn cho bảng nguyên liệu
		UPDATE NguyenLieu
		SET SoLuongTon = SoLuongTon + (select inserted.SoLuong from inserted)
		WHERE (select MaNguyenLieu from inserted) = NguyenLieu.MaNguyenLieu
END
GO

CREATE TRIGGER TRG_INSERT_CTHD
      ON ChiTietHoaDon
      FOR INSERT
AS
BEGIN

      --cập nhật dữ liệu cho thuộc tính thành tiền của bảng nhập thuốc
      IF(SELECT ThanhTien FROM inserted)!= NULL
      BEGIN
            PRINT N'THÀNH TIỀN SẼ ĐƯỢC HỆ THỐNG TỰ ĐỘNG CẬP NHẬT THEO ĐƠN HÀNG'
      END

      UPDATE ChiTietHoaDon
      SET ThanhTien = inserted.SoLuong * sp.GiaBan
      FROM ChiTietHoaDon, SanPham sp, inserted
      WHERE ChiTietHoaDon.MaHoaDon = inserted.MaHoaDon
      AND ChiTietHoaDon.MaSanPham = inserted.MaSanPham
      AND ChiTietHoaDon.MaSanPham = sp.MaSanPham

      --cập nhật tổng tiền cho bảng đơn hàng nhập
      UPDATE HoaDon
      SET TongTien = TongTien + N.ThanhTien
      FROM HoaDon, inserted, ChiTietHoaDon N
      WHERE HoaDon.MaHoaDon = inserted.MaHoaDon
      AND N.MaSanPham = inserted.MaSanPham
      AND N.MaHoaDon = inserted.MaHoaDon
END
GO



---- Trigger nhap kho (so luong ton tang)
--Create Trigger TRG_NhapNguyenLieu ON chiTietPhieuNhap
--for insert, update, delete
--as begin
--	if exists(select * from inserted)
--	begin
--		update NguyenLieu
--		set SoLuongTon = SoLuongTon + (select inserted.SoLuong from inserted)
--		where (select MaNguyenLieu from inserted) = NguyenLieu.MaNguyenLieu
--		update PhieuNhap
--		set ThanhTien = ThanhTien + (select (SoLuong * DonGia) from inserted)
--		where PhieuNhap.MaPhieuNhap = (select MaPhieuNhap from inserted)
--	end
--	if exists(select * from deleted)
--	begin
--		update NguyenLieu
--		set SoLuongTon = SoLuongTon - (select deleted.SoLuong from deleted)
--		where (select MaNguyenLieu from deleted)= NguyenLieu.MaNguyenLieu
--		update PhieuNhap
--		set ThanhTien = ThanhTien - (select (SoLuong * DonGia) from inserted)
--		where PhieuNhap.MaPhieuNhap = (select MaPhieuNhap from inserted)
--	end
--end

-- INSERT --
SET DATEFORMAT DMY

INSERT INTO ChucVu
VALUES
('QL', N'Quản lý', 40),
('BH', N'Nhân viên bán hàng', 25),
('K', N'Nhân viên kho', 20)

INSERT INTO NhanVien (TenNhanVien, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, NgayNghi, MaChucVu) VALUES (N'Nguyễn Quốc Thái', '28/8/2002', 1, N'Thành phố Hồ Chí Minh', '29/04/2024', null, 'QL');
INSERT INTO NhanVien (TenNhanVien, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, NgayNghi, MaChucVu) VALUES (N'Nguyễn Phương Bảo Ngân', '04/02/2003', 0, N'Bình Thuận', '03/05/2024', null, 'BH');
INSERT INTO NhanVien (TenNhanVien, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, NgayNghi, MaChucVu) VALUES (N'Nguyễn Phan Như Quỳnh', '20/2/2002', 1, N'Tây Ninh', '03/05/2024', null, 'BH');
INSERT INTO NhanVien (TenNhanVien, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, NgayNghi, MaChucVu) VALUES (N'Bùi Phan Bảo Ngọc', '11/2/2003', 0, N'Bình Phước', '29/04/2024', null, 'K');

INSERT INTO TaiKhoan
VALUES
('ouoctiiai', '123', 'QL'),
('npbn', '123', 'BH'),
('win', '123', 'K')
GO


INSERT INTO NhaCungCap(TenNhaCungCap, SoDienThoai, Email, DiaChi) VALUES(N'90S Coffee', '1800888906', 'info@90scoffee.vn', N'20 Đường số 3, Phường Trường Thọ, Thủ Đức, TPHCM');
INSERT INTO NhaCungCap(TenNhaCungCap, SoDienThoai, Email, DiaChi) VALUES(N'YOTAFOOD', '0931766351', 'hongtuan104@gmail.com', N'347/40 Lê Văn Thọ Phường 9 Thành phố Hồ Chí Minh');
INSERT INTO NhaCungCap(TenNhaCungCap, SoDienThoai, Email, DiaChi) VALUES(N'Buôn Mê Coffee', '0909555301', 'buonmecoffee@gmail.com', N'35/4A Ao Đôi, Bình Trị Đông A, Quận Bình Tân, Tp.HCM');
INSERT INTO NhaCungCap(TenNhaCungCap, SoDienThoai, Email, DiaChi) VALUES(N'Pinocchio', '0908528233', 'cungcapnguyenlieu@gmail.com', N'30 Bế Văn Đàn Phường 14 Q.Tân Bình,TP.HCM');


INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Cà Phê Arabica (500gr)', N'Việt Nam', 20);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Cà Phê Robusta (500gr)', N'Việt Nam', 10);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Khô gà lá chanh (1kg)', N'Việt Nam', 5);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Bim Bim que đậu hà lan (500gr)', N'Việt Nam', 25);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Robusta Mộc Espresso (1kg)', N'', 2);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'RT1', N'Việt Nam', 30);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Trà đen đặc biệt (1kg)', N'Việt Nam', 15);
INSERT INTO NguyenLieu (TenNguyenLieu, XuatXu, SoLuongTon) VALUES(N'Sữa Đặc LaRossé (1kg)', N'Việt Nam', 1);


INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('29/04/2024', 'NCC002','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('29/04/2024', 'NCC003','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('29/04/2024', 'NCC004','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('29/04/2024', 'NCC001','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('05/05/2024', 'NCC002','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('05/05/2024', 'NCC003','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('05/05/2024', 'NCC004','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('12/05/2024', 'NCC004','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('12/05/2024', 'NCC003','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('12/05/2024', 'NCC001','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('12/05/2024', 'NCC002','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('20/05/2024', 'NCC003','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('20/05/2024', 'NCC004','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('27/05/2024', 'NCC001','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('27/05/2024', 'NCC002','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('27/05/2024', 'NCC003','NV004');
INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES('27/05/2024', 'NCC004','NV004');

INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaNguyenLieu, SoLuong, DonGia, GhiChu)
VALUES
('PN001', 'NL001', 15, 120000, null),
('PN001', 'NL002', 10, 96000, null),
('PN002', 'NL003', 3, 119000, null),
('PN002', 'NL004', 3, 29000, null),
('PN003', 'NL005', 10, 100000, null),
('PN003', 'NL006', 5, 100000, null),
('PN004', 'NL007', 4, 110000, null),
('PN004', 'NL008', 4, 44000, null),
('PN005', 'NL001', 15, 120000, null),
('PN005', 'NL002', 10, 96000, null),
('PN006', 'NL003', 3, 119000, null),
('PN006', 'NL004', 3, 29000, null),
('PN007', 'NL005', 10, 100000, null),
('PN007', 'NL006', 5, 100000, null),
('PN008', 'NL007', 4, 110000, null),
('PN008', 'NL008', 4, 44000, null),
('PN009', 'NL001', 15, 120000, null),
('PN009', 'NL002', 10, 96000, null),
('PN010', 'NL003', 3, 119000, null),
('PN010', 'NL004', 3, 29000, null),
('PN011', 'NL005', 10, 100000, null),
('PN011', 'NL006', 5, 100000, null),
('PN012', 'NL007', 4, 110000, null),
('PN012', 'NL008', 4, 44000, null),
('PN013', 'NL001', 15, 120000, null),
('PN013', 'NL002', 10, 96000, null),
('PN014', 'NL003', 3, 119000, null),
('PN014', 'NL004', 3, 29000, null),
('PN015', 'NL005', 10, 100000, null),
('PN015', 'NL006', 5, 100000, null),
('PN016', 'NL007', 4, 110000, null),
('PN016', 'NL008', 4, 44000, null),
('PN017', 'NL001', 15, 120000, null),
('PN017', 'NL002', 10, 96000, null);

INSERT INTO LoaiSanPham
VALUES
('Cold',N'Đá xay'),
('PhinDi',N'PhinDi'),
('Coffee',N'Cà phê'),
('Cake',N'Bánh ngọt'),
('Tea',N'Trà'),
('MilkTea',N'Trà sữa')


INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà ô long dừa',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Nhãn đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà ô long mãng cầu',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hồng trà chanh',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà sữa matcha',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hồng trà đào sữa',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Chanh đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Matcha đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Oreo cà phê sữa đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Cà phê đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà sữa berry berry',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà đào đá xay',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Sữa chua phúc bồn tử đác cam',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Sữa chua xoài đác thơm',65000,'Cold');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Cappuchino',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hồng trà đá cam đá xay',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hoa tuyết Berry Berry',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Latte',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Kafo de lakto',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà lài đác thơm',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà nhãn sen',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà vải lài',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Lucky tea',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hồng trà sữa',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Vanilla latte',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Hồng trà đào',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà sữa phúc long',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Trà ô long dâu',55000,'Tea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'trà ô long sữa',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Phin choco',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Bạc xĩu',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Caramel macchiato',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Matcha đậu đỏ',55000,'MilkTea');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Phindi hạnh nhân',55000,'PhinDi');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Freeze kem sữa',55000,'PhinDi');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Mocha macchiato',45000,'Coffee');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Bánh mì pate',35000,'Cake');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Bánh phô mai chanh dây',35000,'Cake');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Phin đen đá',55000,'PhinDi');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Phin sữa đá',55000,'PhinDi');
INSERT INTO SanPham(TenSanPham, GiaBan, MaLoai) VALUES(N'Bánh mouse đào',35000,'Cake');


INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('03/05/2024 12:11:56', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('04/05/2024 13:04:32', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('06/05/2024 8:37:45', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('06/05/2024 8:40:00', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('09/05/2024 14:37:01', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('10/05/2024 9:32:48', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('11/05/2024 14:39:43', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('13/05/2024 14:01:57', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('14/05/2024 12:42:39', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('14/05/2024 15:02:33', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('15/05/2024 11:35:43', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('17/05/2024 17:21:36', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('17/05/2024 18:14:46', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('18/05/2024 8:07:31', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('20/05/2024 14:08:30', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('20/05/2024 15:20:48', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('21/05/2024 15:16:43', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('23/05/2024 15:26:44', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('25/05/2024 14:26:44', 'NV002');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('27/05/2024 9:26:56', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('28/05/2024 9:22:11', 'NV003');
INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES('28/05/2024 12:04:31', 'NV002');

INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong) VALUES
('HD001','SP040',3),
('HD001','SP037',2),
('HD001','SP012',2),
('HD001','SP035',2),
('HD002','SP024',2),
('HD002','SP025',2),
('HD002','SP032',2),
('HD002','SP016',3),
('HD003','SP008',1),
('HD003','SP038',2),
('HD003','SP040',3),
('HD004','SP027',2),
('HD004','SP025',3),
('HD004','SP036',1),
('HD004','SP032',1),
('HD005','SP020',3),
('HD005','SP017',2),
('HD005','SP031',1),
('HD006','SP012',2),
('HD006','SP019',3),
('HD007','SP015',2),
('HD007','SP002',1),
('HD007','SP020',3),
('HD007','SP010',3),
('HD007','SP034',1),
('HD008','SP034',2),
('HD008','SP036',3),
('HD008','SP013',2),
('HD008','SP031',2),
('HD008','SP029',2),
('HD009','SP011',2),
('HD009','SP012',1),
('HD009','SP018',2),
('HD009','SP017',1),
('HD009','SP021',2),
('HD009','SP034',3),
('HD010','SP001',3),
('HD010','SP024',1),
('HD010','SP021',1),
('HD010','SP008',2),
('HD010','SP041',3),
('HD011','SP014',3),
('HD011','SP026',3),
('HD011','SP015',2),
('HD012','SP024',3),
('HD012','SP029',3),
('HD013','SP031',2),
('HD013','SP029',1),
('HD013','SP041',3),
('HD013','SP026',3),
('HD014','SP028',3),
('HD014','SP017',2),
('HD014','SP023',2),
('HD015','SP003',3),
('HD015','SP041',1),
('HD015','SP014',3),
('HD015','SP008',3),
('HD015','SP001',1),
('HD016','SP031',1),
('HD016','SP023',2),
('HD016','SP004',2),
('HD016','SP005',2),
('HD017','SP041',2),
('HD017','SP033',3),
('HD017','SP010',3),
('HD018','SP012',2),
('HD018','SP025',1),
('HD018','SP037',2),
('HD018','SP005',2),
('HD019','SP040',2),
('HD019','SP019',3),
('HD019','SP030',2),
('HD019','SP020',2),
('HD020','SP031',2),
('HD020','SP029',2),
('HD020','SP013',3),
('HD021','SP040',3),
('HD021','SP032',2),
('HD021','SP034',2),
('HD021','SP009',3),
('HD022','SP009',2),
('HD022','SP013',1),
('HD022','SP040',1);
go

INSERT INTO CaLam (GioBatDau, GioKetThuc, TongGio) VALUES('8:00', '12:00', '4');
INSERT INTO CaLam (GioBatDau, GioKetThuc, TongGio) VALUES('12:00', '18:00', '6');
INSERT INTO CaLam (GioBatDau, GioKetThuc, TongGio) VALUES('18:00', '22:00', '4');

INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '29/04/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '29/04/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '29/04/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '29/04/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '29/04/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '03/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '04/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '05/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '06/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '07/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '08/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '09/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '10/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '11/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '12/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '13/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '14/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '15/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '16/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '17/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '18/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '19/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '20/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '21/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '22/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '23/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '24/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '25/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '26/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV001', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV002', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV003', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV004', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV004', '27/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV001', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV001', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL001', 'NV002', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV002', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV003', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL003', 'NV003', '28/05/2024');
INSERT INTO ChiTietCaLam VALUES('CL002', 'NV004', '28/05/2024');

select * from HoaDon
select * from ChiTietHoaDon order by MaHoaDon

select * from NguyenLieu
select * from PhieuNhap
select * from ChiTietPhieuNhap order by MaPhieuNhap