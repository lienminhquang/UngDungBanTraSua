CREATE DATABASE UngDungBanTraSua
go

USE UngDungBanTraSua
go

CREATE TABLE LoaiNhanVien(
	MaLoai varchar(255) primary key,
	TenLoai varchar(255)
)

go

CREATE TABLE NhanVien(
	MaNV varchar(255) primary key,
	TenNV varchar(255) not null,
	CMND int,
	NgaySinh date not null,
	LoaiNV varchar(255) foreign key references LoaiNhanVien(MaLoai) not null
)

go

CREATE TABLE TaiKhoang(
	MaNV varchar(255) primary key,
	TenDN varchar(255) not null,
	MatKhau varchar(255) not null,
	CONSTRAINT FK_TaiKhoang FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go

CREATE TABLE LoaiSP(
	MaLoai varchar(255) primary key,
	TenLoai varchar(255) not null,
	ChiTiet varchar(255)
)
go

CREATE TABLE SanPham(
	MaSP varchar(255) primary key,
	MaLoai varchar(255) foreign key references LoaiSP(MaLoai),
	TenSP varchar(255) not null, 
	ChiTiet varchar(1000),
	GhiChu varchar(1000),
	SoLuong int not null,
	Gia money not null,
	CONSTRAINT c_SoLuong CHECK(SoLuong >= 0),
	CONSTRAINT c_Gia CHECK(Gia >= 0)
)
go

CREATE TABLE HoaDon(
	MaHD varchar(255) primary key,
	MaNVPV varchar(255) FOREIGN KEY REFERENCES NhanVien(MaNV),
	Ngay date not null
)
GO

CREATE TABLE ChiTietHoaDon(
	MaHoaDon varchar(255) FOREIGN KEY REFERENCES HoaDon(MaHD),
	MaSP varchar(255) FOREIGN KEY REFERENCES SanPham(MaSP),
	SoLuong int not null,
	GiaBan money not null,
	CONSTRAINT c_SoLuongSP CHECK(SoLuong > 0),
	CONSTRAINT c_GiaBan CHECK(GiaBan > 0)
)

