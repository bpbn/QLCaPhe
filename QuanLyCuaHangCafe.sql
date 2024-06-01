CREATE DATABASE QuanLyCuaHangCafe
GO
USE QuanLyCuaHangCafe
GO
-- TABLE --
CREATE TABLE NhaCungCap
(
	MaNhaCungCap varchar(10) not null,
	TenNhaCungCap nvarchar(200),
	SoDienThoai varchar(12),
	Email varchar(100),
	DiaChi nvarchar(200)
)
CREATE TABLE PhieuNhap
(
	MaPhieuNhap varchar(10) not null,
	NgayNhap Date,
	ThanhTien int,
	MaNhaCungCap varchar(10),
	MaNhanVien varchar(10)
)
CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap varchar(10) not null,
	MaNguyenLieu varchar(10) not null,
	SoLuong int,
	DonGia int,
	GhiChu text
)

CREATE TABLE SanPham
(
	MaSanPham varchar(10) not null,
	TenSanPham nvarchar(200),
	HinhAnh varchar(max),
	GiaBan int,
	MaLoai varchar(10),
	TrangThai nvarchar(20)
)

CREATE TABLE LoaiSanPham
(
	MaLoai varchar(10) not null,
	TenLoai nvarchar(100)
)	

CREATE TABLE NhanVien
(
	MaNhanVien varchar(10) not null,
	TenNhanVien nvarchar(200),
	NgaySinh Date,
	GioiTinh bit,
	DiaChi nvarchar(200),
	NgayVaoLam Date,
	NgayNghi Date,
	MaChucVu varchar(10)
)

CREATE TABLE ChucVu
(
	MaChucVu varchar(10) not null,
	TenChucVu nvarchar(20),
	LuongCoBan int
)

CREATE TABLE CaLam
(
	MaCaLam varchar(10) not null,
	GioBatDau time,
	GioKetThuc time,
)

CREATE TABLE ChiTietCaLam
(
	MaCaLam varchar(10) not null,
	NgayLam date,
	MaNhanVien varchar(10) not null,
	LuongTheoCa int
)

CREATE TABLE TaiKhoan
(
	TenDangNhap varchar(50) not null,
	MatKhau varchar(50),
	MaNhanVien varchar(10)
)
CREATE TABLE HoaDon
(
	MaHoaDon varchar(10) not null,
	ThanhTien int,
	ThoiGianLap DateTime,
	ThoiGianThanhToan DateTime,
	SoKhach int,
	SoBan int,
	MaNhanVien varchar(10)
)
CREATE TABLE ChiTietHoaDon
(
	MaHoaDon varchar(10) not null,
	MaSanPham varchar(10) not null,
	SoLuong int,
	TongTien int,
	GhiChu text

)
CREATE TABLE Ban
(
	SoBan int not null,
	SoGhe int,
	KhuVuc nvarchar(10),
	TrangThai bit
)
CREATE TABLE NguyenLieu
(
	MaNguyenLieu varchar(10) not null,
	TenNguyenLieu nvarchar(100),
	DonViTinh nvarchar(20),
	SoLuongTon int
)

CREATE TABLE BangLuong
(
	MaBangLuong varchar(10) not null,
	MaNhanVien varchar(10) not null,
	ThoiGianChamCong time,
	ThoiGianTraLuong time,
	PhuCap int
)
GO
-- PRIMARY KEY --
ALTER TABLE NhaCungCap
ADD CONSTRAINT PK_NhaCungCap PRIMARY KEY(MaNhaCungCap)
ALTER TABLE ChucVu
ADD CONSTRAINT PK_ChucVu PRIMARY KEY (MaChucVu)
ALTER TABLE LoaiSanPham
ADD CONSTRAINT PK_LoaiSanPham PRIMARY KEY (MaLoai)
ALTER TABLE Ban
ADD CONSTRAINT PK_Ban PRIMARY KEY (SoBan)
ALTER TABLE NhanVien
ADD CONSTRAINT PK_NhanVien PRIMARY KEY (MaNhanVien)
ALTER TABLE HoaDon
ADD CONSTRAINT PK_HoaDon PRIMARY KEY (MaHoaDon)
ALTER TABLE SanPham
ADD CONSTRAINT PK_SanPham PRIMARY KEY (MaSanPham)
ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaSanPham, MaHoaDon)
ALTER TABLE PhieuNhap
ADD CONSTRAINT PK_PhieuNhap PRIMARY KEY (MaPhieuNhap)
ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT PK_ChiTietPhieuNhap PRIMARY KEY (MaPhieuNhap, MaNguyenLieu)
ALTER TABLE ChiTietCaLam
ADD CONSTRAINT PK_ChiTietCaLam PRIMARY KEY (MaCaLam, MaNhanVien)
ALTER TABLE TaiKhoan
ADD CONSTRAINT PK_TaiKhoan PRIMARY KEY (TenDangNhap)
ALTER TABLE NguyenLieu
ADD CONSTRAINT PK_NguyenLieu PRIMARY KEY(MaNguyenLieu)
ALTER TABLE CaLam
ADD CONSTRAINT PK_CaLam PRIMARY KEY(MaCaLam)
ALTER TABLE BangLuong
ADD CONSTRAINT PK_BangLuong PRIMARY KEY(MaBangLuong) 
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
ADD CONSTRAINT FK_HoaDon_Ban FOREIGN KEY (SoBan) REFERENCES Ban(SoBan),
	CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
	CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

ALTER TABLE ChiTietCaLam
ADD CONSTRAINT FK_ChiTietCaLam_CaLam FOREIGN KEY (MaCaLam) REFERENCES CaLam(MaCaLam),
	CONSTRAINT FK_ChiTietCaLam_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

ALTER TABLE BangLuong
ADD CONSTRAINT FK_BangLuong_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO

-- INSERT --
SET DATEFORMAT DMY

INSERT INTO ChucVu
VALUES
('QL', N'Quản lý', 40),
('BH', N'Nhân viên bán hàng', 25),
('K', N'Nhân viên kho', 20)
INSERT INTO NhanVien
VALUES
('NV001' , N'Nguyễn Quốc Thái', '28/8/2002', 1, N'Thành phố Hồ Chí Minh', '20/1/2023', null, 'QL'),
('NV002' , N'TNguyễn Phương Bảo Ngân', '21/7/2002', 0, N'Bình Thuận', '23/2/2023', null, 'BH'),
('NV003' , N'Nguyễn Phan Như Quỳnh', '20/2/2002', 1, N'Tây Ninh', '25/2/2023', '20/4/2023', 'BH'),
('NV004' , N'Bùi Phan Bảo Ngọc', '11/2/2003', 0, N'Thành phố Hồ Chí Minh', '25/3/2023', null, 'BH')

INSERT INTO TaiKhoan
VALUES
('ouoctiiai', '123', 1),
('npbn', '123', 2),
('win', '123', 3),
('bpbn', '123', 4)

INSERT INTO NhaCungCap
VALUES
(1, N'90S Coffee', '1800888906', 'info@90scoffee.vn', N'20 Đường số 3, Phường Trường Thọ, Thủ Đức, TPHCM'),
(2, N'YOTAFOOD', '0931766351', 'hongtuan104@gmail.com', N'347/40 Lê Văn Thọ Phường 9 Thành phố Hồ Chí Minh'),
(3, N'Buôn Mê Coffee', '0909555301', 'buonmecoffee@gmail.com', N'35/4A Ao Đôi, Bình Trị Đông A, Quận Bình Tân, Tp.HCM'),
(4, N'Pinocchio', '0908528233', 'cungcapnguyenlieu@gmail.com', N'30 Bế Văn Đàn Phường 14 Q.Tân Bình,TP.HCM')

INSERT INTO NguyenLieu
VALUES
(1, N'Cà Phê Arabica', '500gr', 0),
(2, N'Cà Phê Robusta', '500gr', 0),
(3, N'Khô gà lá chanh', '1kg', 0),
(4, N'Bim Bim que đậu hà lan', '500gr', 0),
(5, N'Robusta Mộc Espresso', '1kg', 0),
(6, N'Trà đen đặc biệt', '1kg', 0),
(7, N'Sữa Đặc LaRossé', '1kg', 0)
INSERT INTO PhieuNhap(MaPhieuNhap, NgayNhap, MaNhaCungCap, MaNhanVien)
VALUES
(1, '16/01/2023', 1,1),
(2, '16/01/2023', 2,1),
(3, '16/01/2023', 3,1),
(4, '16/01/2023', 4,1),
(5, '30/01/2023', 1,5),
(6, '30/01/2023', 2,5),
(7, '30/01/2023', 3,5),
(8, '30/01/2023', 4,5),
(9, '13/02/2023', 1,6),
(10, '13/02/2023', 2,6),
(11, '13/02/2023', 3,6),
(12, '13/02/2023', 4,6),
(13, '27/02/2023', 1,1),
(14, '27/02/2023', 2,1),
(15, '27/02/2023', 3,1),
(16, '27/02/2023', 4,1),
(17, '13/03/2023', 1,5),
(18, '13/03/2023', 2,5),
(19, '13/03/2023', 3,5),
(20, '13/03/2023', 4,5),
(21, '27/03/2023', 1,6),
(22, '27/03/2023', 2,6),
(23, '27/03/2023', 3,6),
(24, '27/03/2023', 4,6),
(25, '10/04/2023', 1,1),
(26, '10/04/2023', 2,1),
(27, '10/04/2023', 3,1),
(28, '10/04/2023', 4,1),
(29, '24/04/2023', 1,5),
(30, '24/04/2023', 2,5),
(31, '24/04/2023', 3,5),
(32, '24/04/2023', 4,5),
(33, '08/05/2023', 1,6),
(34, '08/05/2023', 2,6),
(35, '08/05/2023', 3,6),
(36, '08/05/2023', 4,6),
(37, '22/05/2023', 1,1),
(38, '22/05/2023', 2,1),
(39, '22/05/2023', 3,1),
(40, '22/05/2023', 4,1)

INSERT INTO ChiTietPhieuNhap
VALUES
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null),
(1, 1, 15, 120000, null),
(1, 2, 10, 96000, null),
(2, 3, 3, 119000, null),
(2, 4, 3, 29000, null),
(3, 5, 10, 100000, null),
(3, 6, 5, 100000, null),
(4, 7, 4, 110000, null),
(4, 8, 4, 44000, null)

INSERT INTO Ban(SoBan, SoGhe, KhuVuc, TrangThai)
VALUES
(0, 0, N'Mang về', 1),
(1, 4, N'Khu A', 0),
(2, 6, N'Khu A', 0),
(3, 4, N'Khu A', 0),
(4, 4, N'Khu A', 0),
(5, 4, N'Khu A', 0),
(6, 6, N'Khu A', 0),
(7, 4, N'Khu B', 0),
(8, 2, N'Khu B', 0),
(9, 2, N'Khu B', 0),
(10, 4, N'Khu B', 0),
(11, 2, N'Khu B', 0),
(12, 4, N'Khu B', 0)
INSERT INTO LoaiSanPham
VALUES
('Cold',N'Đá xay'),
('PhinDi',N'PhinDi'),
('Coffee',N'Cà phê'),
('Cake',N'Bánh ngọt'),
('Tea',N'Trà'),
('MilkTea',N'Trà sữa')
INSERT INTO SanPham
VALUES
(1,N'Trà ô long dừa','PL_1.png',55000,'Tea'),
(2,N'Nhãn đá xay','PL_2.png',65000,'Cold'),
(3,N'Trà ô long mãng cầu','PL_3.png',55000,'Tea'),
(4,N'Hồng trà chanh','PL_4.png',55000,'Tea'),
(5,N'Trà sữa matcha','PL_5.png',55000,'MilkTea'),
(6,N'Hồng trà đào sữa','PL_6.png',55000,'MilkTea'),
(7,N'Chanh đá xay','PL_7.png',65000,'Cold'),
(8,N'Matcha đá xay','PL_8.png',65000,'Cold'),
(9,N'Oreo cà phê sữa đá xay','PL_9.png',65000,'Cold'),
(10,N'Cà phê đá xay','PL_10.png',65000,'Cold'),
(11,N'Trà sữa berry berry','PL_11.png',55000,'MilkTea'),
(12,N'Trà đào đá xay','PL_12.png',65000,'Cold'),
(13,N'Sữa chua phúc bồn tử đác cam','PL_13.png',65000,'Cold'),
(14,N'Sữa chua xoài đác thơm','PL_14.png',65000,'Cold'),
(15,N'Cappuchino','PL_15.png',45000,'Coffee'),
(16,N'Hồng trà đá cam đá xay','PL_16.png',55000,'Tea'),
(17,N'Hoa tuyết Berry Berry','PL_17.png',55000,'MilkTea'),
(18,N'Latte','PL_18.png',45000,'Coffee'),
(19,N'Kafo de lakto','PL_19.png',45000,'Coffee'),
(20,N'Trà lài đác thơm','PL_20.png',55000,'Tea'),
(21,N'Trà nhãn sen','PL_21.png',55000,'Tea'),
(22,N'Trà vải lài','PL_22.png',55000,'Tea'),
(23,N'Lucky tea','PL_23.png',55000,'Tea'),
(24,N'Hồng trà sữa','PL_24.png',55000,'MilkTea'),
(25,N'Vanilla latte','PL_25.png',45000,'Coffee'),
(26,N'Hồng trà đào','PL_26.png',55000,'Tea'),
(27,N'Trà sữa phúc long','PL_27.png',55000,'MilkTea'),
(28,N'Trà ô long dâu','PL_28.png',55000,'Tea'),
(29,N'trà ô long sữa','PL_29.png',55000,'MilkTea'),
(30,N'Phin choco','Choco.png',45000,'Coffee'),
(31,N'Bạc xĩu','Bacxiu.png',45000,'Coffee'),
(32,N'Caramel macchiato','EA.png',45000,'Coffee'),
(33,N'Matcha đậu đỏ','GT.png',55000,'MilkTea'),
(34,N'Phindi hạnh nhân','HanhNhan.png',55000,'PhinDi'),
(35,N'Freeze kem sữa','KemSua.png',55000,'PhinDi'),
(36,N'Mocha macchiato','Mocha.png',45000,'Coffee'),
(37,N'Bánh mì pate','Pate.png',35000,'Cake'),
(38,N'Bánh phô mai chanh dây','PF.png',35000,'Cake'),
(39,N'Phin đen đá','PhinDenDa.png',55000,'PhinDi'),
(40,N'Phin sữa đá','PhinSuaDa.png',55000,'PhinDi'),
(41,N'Bánh mouse đào','PM.png',35000,'Cake')

INSERT INTO HoaDon(MaHoaDon, ThoiGianLap, ThoiGianThanhToan, SoKhach, SoBan) VALUES
(1, '01/02/2023 11:35:44', '01/02/2023 13:04:26', 2, 4),
(2, '01/02/2023 17:59:21', '01/02/2023 19:58:35', 4, 3),
(3, '03/02/2023 13:44:43', '03/02/2023 16:08:36', 4, 1),
(4, '05/02/2023 8:34:24', '05/02/2023 10:08:24', 1, 8),
(5, '06/02/2023 16:57:25', '06/02/2023 19:16:44', 5, 12),
(6, '07/02/2023 15:56:13', '07/02/2023 17:31:02', 3, 5),
(7, '08/02/2023 16:57:34', '08/02/2023 19:10:33', 4, 12),
(8, '10/02/2023 9:11:37', '10/02/2023 10:19:21', 1, 7),
(9, '10/02/2023 10:57:33', '10/02/2023 11:57:56', 2, 10),
(10, '11/02/2023 9:49:19', '11/02/2023 12:05:36', 1, 4),
(11, '13/02/2023 16:42:52', '13/02/2023 17:46:24', 1, 12),
(12, '15/02/2023 12:12:53', '15/02/2023 13:20:16', 5, 7),
(13, '16/02/2023 11:31:32', '16/02/2023 13:47:38', 2, 4),
(14, '17/02/2023 14:06:48', '17/02/2023 16:10:11', 3, 4),
(15, '17/02/2023 16:47:05', '17/02/2023 18:17:27', 2, 6),
(16, '17/02/2023 19:55:53', '17/02/2023 22:22:01', 1, 9),
(17, '18/02/2023 8:52:59', '18/02/2023 9:59:30', 3, 6),
(18, '20/02/2023 10:46:03', '20/02/2023 11:53:51', 4, 12),
(19, '21/02/2023 19:01:23', '21/02/2023 20:01:36', 2, 3),
(20, '23/02/2023 15:26:44', '23/02/2023 17:07:00', 1, 2),
(21, '27/02/2023 9:26:56', '27/02/2023 10:27:19', 3, 4),
(22, '28/02/2023 9:22:11', '28/02/2023 11:35:08', 5, 3),
(23, '28/02/2023 12:04:31', '28/02/2023 13:12:59', 5, 3),
(24, '03/03/2023 12:11:56', '03/03/2023 13:13:34', 3, 9),
(25, '04/03/2023 13:04:32', '04/03/2023 15:27:23', 4, 2),
(26, '06/03/2023 8:37:45', '06/03/2023 10:45:08', 5, 9),
(27, '06/03/2023 8:40:00', '06/03/2023 10:51:22', 5, 10),
(28, '09/03/2023 14:37:01', '09/03/2023 15:37:49', 5, 1),
(29, '10/03/2023 9:32:48', '10/03/2023 11:58:59', 4, 7),
(30, '11/03/2023 14:39:43', '11/03/2023 16:13:58', 5, 10),
(31, '13/03/2023 14:01:57', '13/03/2023 15:24:14', 2, 6),
(32, '14/03/2023 12:42:39', '14/03/2023 13:49:25', 1, 7),
(33, '14/03/2023 15:02:33', '14/03/2023 17:02:54', 3, 9),
(34, '15/03/2023 11:35:43', '15/03/2023 13:57:56', 2, 9),
(35, '17/03/2023 17:21:36', '17/03/2023 18:36:25', 4, 12),
(36, '17/03/2023 18:14:46', '17/03/2023 19:26:31', 1, 3),
(37, '18/03/2023 8:07:31', '18/03/2023 10:10:28', 2, 5),
(38, '20/03/2023 14:08:30', '20/03/2023 16:34:26', 2, 7),
(39, '20/03/2023 15:20:48', '20/03/2023 16:43:38', 2, 7),
(40, '21/03/2023 15:16:43', '21/03/2023 16:46:59', 5, 6),
(41, '21/03/2023 18:57:45', '21/03/2023 21:18:47', 5, 3),
(42, '22/03/2023 9:12:03', '22/03/2023 10:48:19', 3, 8),
(43, '24/03/2023 17:44:28', '24/03/2023 20:08:26', 1, 3),
(44, '25/03/2023 11:04:38', '25/03/2023 12:47:30', 2, 4),
(45, '26/03/2023 12:33:01', '26/03/2023 14:43:35', 1, 4),
(46, '30/03/2023 10:08:43', '30/03/2023 12:12:56', 2, 4),
(47, '31/03/2023 14:15:11', '31/03/2023 16:37:40', 1, 5),
(48, '01/04/2023 12:11:55', '01/04/2023 14:19:20', 2, 2),
(49, '04/04/2023 8:14:48', '04/04/2023 10:06:04', 1, 12),
(50, '05/04/2023 16:04:47', '05/04/2023 17:46:34', 3, 3),
(51, '05/04/2023 16:15:13', '05/04/2023 17:57:36', 2, 10),
(52, '10/04/2023 17:44:14', '10/04/2023 20:05:16', 2, 1),
(53, '12/04/2023 17:51:18', '12/04/2023 19:17:36', 4, 2),
(54, '13/04/2023 11:50:16', '13/04/2023 13:38:39', 1, 10),
(55, '13/04/2023 17:15:28', '13/04/2023 18:54:46', 3, 7),
(56, '13/04/2023 17:49:05', '13/04/2023 19:49:09', 4, 7),
(57, '14/04/2023 14:23:40', '14/04/2023 16:11:34', 4, 12),
(58, '18/04/2023 11:10:11', '18/04/2023 13:33:02', 1, 9),
(59, '20/04/2023 8:52:22', '20/04/2023 10:29:30', 1, 3),
(60, '23/04/2023 15:58:37', '23/04/2023 18:26:04', 1, 7),
(61, '24/04/2023 13:34:41', '24/04/2023 16:01:21', 3, 1),
(62, '25/04/2023 11:19:56', '25/04/2023 13:32:31', 3, 12),
(63, '25/04/2023 13:41:37', '25/04/2023 15:18:10', 3, 1),
(64, '26/04/2023 13:27:19', '26/04/2023 15:12:28', 2, 6),
(65, '26/04/2023 16:42:14', '26/04/2023 17:58:49', 2, 5),
(66, '27/04/2023 11:57:05', '27/04/2023 13:52:56', 3, 2),
(67, '28/04/2023 17:20:16', '28/04/2023 18:28:30', 5, 6),
(68, '30/04/2023 9:05:03', '30/04/2023 11:02:39', 1, 1),
(69, '03/05/2023 11:51:17', '03/05/2023 13:17:11', 1, 7),
(70, '03/05/2023 18:08:32', '03/05/2023 19:55:10', 1, 7),
(71, '05/05/2023 16:42:24', '05/05/2023 18:25:41', 5, 4),
(72, '07/05/2023 12:58:55', '07/05/2023 14:00:00', 4, 6),
(73, '08/05/2023 17:49:53', '08/05/2023 19:41:10', 5, 9),
(74, '10/05/2023 11:59:01', '10/05/2023 13:30:46', 4, 9),
(75, '10/05/2023 15:31:03', '10/05/2023 17:46:40', 5, 9),
(76, '10/05/2023 17:28:03', '10/05/2023 18:46:25', 5, 4),
(77, '11/05/2023 9:31:35', '11/05/2023 11:41:38', 5, 5),
(78, '11/05/2023 11:57:55', '11/05/2023 14:11:34', 2, 2),
(79, '13/05/2023 13:26:25', '13/05/2023 15:50:46', 1, 12),
(80, '15/05/2023 10:51:02', '15/05/2023 12:36:12', 1, 5),
(81, '16/05/2023 13:08:05', '16/05/2023 14:32:00', 1, 5),
(82, '17/05/2023 11:20:18', '17/05/2023 13:41:33', 4, 11),
(83, '17/05/2023 11:58:37', '17/05/2023 14:14:06', 3, 3),
(84, '18/05/2023 14:24:07', '18/05/2023 16:31:27', 5, 7),
(85, '19/05/2023 13:34:36', '19/05/2023 14:51:20', 1, 6),
(86, '21/05/2023 17:30:31', '21/05/2023 19:04:38', 3, 3),
(87, '22/05/2023 17:37:05', '22/05/2023 19:58:57', 2, 5),
(88, '24/05/2023 10:15:42', '24/05/2023 11:52:36', 3, 12),
(89, '25/05/2023 12:08:37', '25/05/2023 13:32:10', 2, 4),
(90, '25/05/2023 16:37:17', '25/05/2023 18:01:43', 4, 6),
(91, '28/05/2023 8:28:59', '28/05/2023 10:47:13', 4, 8),
(92, '28/05/2023 17:12:54', '28/05/2023 19:22:12', 1, 3),
(93, '30/05/2023 19:41:30', '30/05/2023 22:06:34', 2, 10),
(94, '31/05/2023 16:26:14', '31/05/2023 17:27:49', 5, 8),
(95, '31/05/2023 17:40:59', '31/05/2023 19:48:03', 4, 11)

INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong) VALUES
(1,40,3),
(1,37,2),
(1,12,2),
(1,35,2),
(2,24,2),
(2,36,2),
(2,32,2),
(2,16,3),
(3,8,1),
(3,38,2),
(3,40,3),
(4,27,2),
(4,35,3),
(4,36,1),
(4,32,1),
(5,20,3),
(5,17,2),
(5,31,1),
(6,12,2),
(6,26,3),
(7,15,2),
(7,2,1),
(7,20,3),
(7,10,3),
(7,34,1),
(8,34,2),
(8,36,3),
(8,13,2),
(8,31,2),
(8,29,2),
(9,11,2),
(9,12,1),
(9,18,2),
(9,17,1),
(9,21,2),
(9,34,3),
(10,40,3),
(10,24,1),
(10,21,1),
(10,8,2),
(10,41,3),
(11,14,3),
(11,26,3),
(11,15,2),
(12,24,3),
(12,29,3),
(13,31,2),
(13,29,1),
(13,41,3),
(13,26,3),
(14,28,3),
(14,17,2),
(14,23,2),
(15,3,3),
(15,41,1),
(15,14,3),
(15,8,3),
(15,1,1),
(16,31,1),
(16,23,2),
(16,4,2),
(16,5,2),
(17,41,2),
(17,33,3),
(17,10,3),
(18,12,2),
(18,25,1),
(18,37,2),
(18,5,2),
(19,40,2),
(19,19,3),
(19,30,2),
(19,20,2),
(20,31,2),
(20,17,2),
(20,13,3),
(21,40,3),
(21,32,2),
(21,34,2),
(21,9,3),
(22,20,1),
(22,33,1),
(22,37,1),
(22,41,3),
(23,17,1),
(23,41,2),
(23,6,3),
(24,28,3),
(24,39,2),
(25,31,1),
(26,23,2),
(26,26,3),
(27,27,2),
(27,21,1),
(28,14,1),
(28,25,3),
(29,12,2),
(29,4,1),
(29,9,3),
(29,16,2),
(30,36,2),
(30,25,2),
(30,39,1),
(30,18,2),
(30,10,1),
(31,12,1),
(31,24,1),
(31,2,1),
(31,17,3),
(32,18,2),
(32,26,2),
(32,32,2),
(32,1,1),
(33,29,2),
(33,19,2),
(33,39,1),
(33,33,1),
(33,24,2),
(34,2,3),
(34,26,1),
(35,14,1),
(35,17,1),
(35,21,3),
(35,2,1),
(36,32,3),
(37,41,2),
(37,27,1),
(38,16,2),
(38,21,2),
(39,41,3),
(40,32,2),
(40,39,3),
(40,15,2),
(40,19,3),
(41,22,1),
(41,18,2),
(42,35,3),
(42,12,3),
(43,28,2),
(43,35,2),
(43,24,1),
(43,32,3),
(43,11,3),
(44,38,1),
(44,33,3),
(44,18,1),
(45,18,3),
(45,36,1),
(46,31,3),
(46,16,1),
(46,12,3),
(47,4,3),
(47,32,2),
(47,17,1),
(48,14,2),
(48,32,1),
(49,7,2),
(49,39,3),
(49,31,3),
(50,33,2),
(50,26,3),
(50,15,1),
(51,36,3),
(52,38,1),
(52,29,2),
(52,4,1),
(53,10,2),
(53,12,2),
(53,21,3),
(53,32,2),
(54,32,2),
(54,22,3),
(55,26,3),
(55,13,1),
(56,6,1),
(56,32,2),
(56,40,1),
(57,18,2),
(57,29,3),
(58,27,3),
(58,20,2),
(59,40,2),
(59,17,1),
(59,1,3),
(60,6,2),
(60,2,3),
(60,9,2),
(60,15,3),
(61,2,2),
(61,9,1),
(61,19,1),
(62,6,3),
(63,26,1),
(63,19,3),
(64,26,2),
(64,3,2),
(65,32,1),
(65,26,2),
(65,29,1),
(65,41,2),
(66,31,2),
(66,2,2),
(66,38,3),
(67,15,3),
(67,4,1),
(67,17,3),
(68,39,2),
(68,31,1),
(69,36,2),
(69,39,2),
(70,21,3),
(70,19,3),
(71,36,1),
(71,28,2),
(71,39,2),
(72,18,2),
(73,41,3),
(74,20,2),
(75,5,1),
(75,41,1),
(76,32,3),
(76,36,3),
(76,41,2),
(76,26,3),
(77,23,2),
(77,14,3),
(77,41,2),
(78,35,2),
(78,41,1),
(78,36,2),
(78,6,2),
(79,15,3),
(79,3,2),
(79,11,1),
(80,3,2),
(80,26,2),
(80,38,2),
(81,10,2),
(81,33,3),
(81,9,1),
(82,26,1),
(83,5,3),
(83,2,1),
(83,31,1),
(83,11,2),
(84,10,2),
(84,32,1),
(85,9,2),
(85,12,1),
(86,32,3),
(87,27,1),
(87,18,2),
(88,27,2),
(88,14,3),
(89,30,2),
(89,7,2),
(89,15,1),
(90,24,3),
(90,39,3),
(90,6,1),
(91,17,3),
(91,36,3),
(92,29,2),
(92,1,1),
(93,39,1),
(93,18,3),
(94,25,3),
(94,31,2),
(94,36,3),
(94,13,1),
(95,16,2),
(95,11,3),
(95,40,1)
go


update PhieuNhap
	set ThanhTien = (Select sum(dongia * SoLuong)
				From ChiTietPhieuNhap
				where PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap
				group by ChiTietPhieuNhap.MaPhieuNhap)
go
update HoaDon
set ThanhTien = (Select sum(cthd.TongTien)
			from ChiTietHoaDon cthd
			where HoaDon.MaHoaDon = cthd.MaHoaDon)
go
update NguyenLieu
set SoLuongTon = (SELECT SUM(SoLuong) FROM ChiTietPhieuNhap CTPN WHERE CTPN.MaNguyenLieu = NguyenLieu.MaNguyenLieu)
SELECT * FROM ChiTietPhieuNhap
SELECT SUM(SOLUONG) FROM ChiTietPhieuNhap GROUP BY MaNguyenLieu
go
-- TRIGGER --
-- Trigger cap nhat phieu nhap
Create trigger TRG_CapNhatThanhTienPhieuNhap on ChiTietPhieuNhap
after insert, update, delete
as begin
	update PhieuNhap
	set ThanhTien = (Select sum(dongia * SoLuong)
				From ChiTietPhieuNhap
				where PhieuNhap.MaPhieuNhap = ChiTietPhieuNhap.MaPhieuNhap
				group by ChiTietPhieuNhap.MaPhieuNhap)
end
go
--drop trigger TRG_CapNhatThanhTienPhieuNhap

-- Trigger cap nhat thanh tien hoa don
Create trigger TRG_CapNhatThanhTienHoaDon on ChiTietHoaDon
for insert, update, delete
as begin
	update HoaDon
	set ThanhTien = (Select sum(cthd.TongTien)
				from ChiTietHoaDon cthd
				where HoaDon.MaHoaDon = cthd.MaHoaDon)
end
go
--drop trigger TRG_CapNhatThanhTienHoaDon
-- Trigger nhap kho (so luong ton tang)
Create Trigger TRG_NhapNguyenLieu ON chiTietPhieuNhap
for insert, update, delete
as begin
	if exists(select * from inserted)
	begin
		update NguyenLieu
		set SoLuongTon = SoLuongTon + (select inserted.SoLuong from inserted)
		where (select MaNguyenLieu from inserted) = NguyenLieu.MaNguyenLieu
		update PhieuNhap
		set ThanhTien = ThanhTien + (select (SoLuong * DonGia) from inserted)
		where PhieuNhap.MaPhieuNhap = (select MaPhieuNhap from inserted)
	end
	if exists(select * from deleted)
	begin
		update NguyenLieu
		set SoLuongTon = SoLuongTon - (select deleted.SoLuong from deleted)
		where (select MaNguyenLieu from deleted)= NguyenLieu.MaNguyenLieu
		update PhieuNhap
		set ThanhTien = ThanhTien - (select (SoLuong * DonGia) from inserted)
		where PhieuNhap.MaPhieuNhap = (select MaPhieuNhap from inserted)
	end
end
--drop trigger TRG_NhapNguyenLieu
go
--==--==--==--==--==--==--==--==--==--==--==--==--==--==--
--use master
--go
--drop database QuanLyCuaHangCafe
