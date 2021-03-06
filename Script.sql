USE [master]
GO
/****** Object:  Database [UngDungBanTraSua]    Script Date: 13/11/2018 10:55:02 PM ******/
CREATE DATABASE [UngDungBanTraSua]
GO
USE [UngDungBanTraSua]
GO
ALTER DATABASE [UngDungBanTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UngDungBanTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UngDungBanTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UngDungBanTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UngDungBanTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET RECOVERY FULL 
GO
ALTER DATABASE [UngDungBanTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [UngDungBanTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UngDungBanTraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UngDungBanTraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UngDungBanTraSua] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UngDungBanTraSua] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UngDungBanTraSua', N'ON'
GO
ALTER DATABASE [UngDungBanTraSua] SET QUERY_STORE = OFF
GO
USE [UngDungBanTraSua]
GO
/****** Object:  UserDefinedFunction [dbo].[f_Login]    Script Date: 13/11/2018 10:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_Login] (@username nvarchar(255),@password nvarchar(255))
 returns int 
 as
 begin
 declare @msnv nvarchar(255)
 declare @loaiNV nvarchar(255)
 set @msnv = 'null'
 select @msnv = TaiKhoan.MaNV from TaiKhoan 
 where @username = TaiKhoan.TenDN and @password = TaiKhoan.MatKhau
 if(@msnv = 'null')
	return 0
 else
 begin
	select @loaiNV = NhanVien.LoaiNV from NhanVien 
	where NhanVien.MaNV = @msnv
	if(@loaiNV = 'A')
		return 1	
	else 
		return 2

 end
 return 0
 end
GO
/****** Object:  UserDefinedFunction [dbo].[fn_DangNhapAdmin]    Script Date: 13/11/2018 10:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_DangNhapAdmin](@username nvarchar(255), @password nvarchar(255))
returns bit
as
begin 
	declare @ma nvarchar(255)
	set @ma = null
	select @ma = TaiKhoang.MaNV 
	from TaiKhoang
	where @username = TaiKhoang.TenDN and @password = TaiKhoang.MatKhau

	if(@ma = null)
		return 0;

	declare @loai nvarchar(255)
	set @loai = null
	select @loai = NhanVien.LoaiNV
	from NhanVien
	where NhanVien.MaNV = @ma

	if(@loai = 'A')
		return 1
	return 0 
end
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 13/11/2018 10:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [varchar](255) NULL,
	[MaSP] [nvarchar](255) NULL,
	[SoLuongDat] [int] NOT NULL,
	[GiaBan] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_tableHD]    Script Date: 13/11/2018 10:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_tableHD] (@mahd nvarchar(255))
returns table
as
return (select *from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon=@mahd)
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 13/11/2018 10:55:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoai] [nvarchar](255) NOT NULL,
	[TenLoai] [nvarchar](255) NOT NULL,
	[ChiTiet] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](255) NOT NULL,
	[MaLoai] [nvarchar](255) NULL,
	[TenSP] [nvarchar](255) NOT NULL,
	[ChiTiet] [nvarchar](1000) NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[f_LayMonTheoLoai]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[f_LayMonTheoLoai] (@tensp nvarchar(255))
returns table
as
return (select TenSP from SanPham where SanPham.MaLoai = (select MaLoai 
from LoaiSP
where TenLoai=@tensp))
GO
/****** Object:  View [dbo].[view_LoaiSP]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_LoaiSP] as
select TenLoai from LoaiSP
GO
/****** Object:  View [dbo].[cthd]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[cthd] as
select s.MaSP,s.TenSP, SUM(c.SoLuongDat) as SoLuong, SUM(c.GiaBan) as Tien, c.MaHoaDon
from SanPham s, ChiTietHoaDon c
where c.MaSP = s.MaSP
group by c.MaHoaDon,s.MaSP,s.TenSP;
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](255) NOT NULL,
	[MaNVPV] [nvarchar](255) NULL,
	[Ngay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TongTien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[TongTien] as
select HoaDon.MaHD, sum(GiaBan) as ThanhTien
from ChiTietHoaDon,HoaDon
where ChiTietHoaDon.MaHoaDon = HoaDon.MaHD
group by HoaDon.MaHD
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [nvarchar](255) NOT NULL,
	[TenDN] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachTaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachTaiKhoan]()
returns table
as
return (select * from TaiKhoan)
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoai] [nvarchar](255) NOT NULL,
	[TenLoai] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachLoaiNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachLoaiNhanVien]()
returns table
return(select * from LoaiNhanVien)
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](255) NOT NULL,
	[TenNV] [nvarchar](255) NOT NULL,
	[CMND] [int] NULL,
	[NgaySinh] [date] NOT NULL,
	[LoaiNV] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachNhanVien]()
returns table
return(select * from NhanVien)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachLoaiSanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachLoaiSanPham]()
returns table
return(select * from LoaiSP)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachSanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachSanPham]()
returns table
return(select * from SanPham)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachHoaDon]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachHoaDon]()
returns table
return(select * from HoaDon)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_LayDanhSachChiTietHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_LayDanhSachChiTietHD]()
returns table
return(select * from ChiTietHoaDon)
GO
/****** Object:  UserDefinedFunction [dbo].[fn_ThongTinTaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_ThongTinTaiKhoan](@manv nvarchar(255))
returns table
return( select NhanVien.MaNV, NhanVien.TenNV, TaiKhoan.TenDN as TenDN, TaiKhoan.MatKhau from NhanVien, TaiKhoan where NhanVien.MaNV = @manv and TaiKhoan.MaNV = @manv);
GO
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (N'A', N'AD')
INSERT [dbo].[LoaiNhanVien] ([MaLoai], [TenLoai]) VALUES (N'N', N'NV')
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [ChiTiet]) VALUES (N'SP1', N'Trà Sữa', N'')
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [ChiTiet]) VALUES (N'SP2', N'Hồng trà', N'')
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [ChiTiet]) VALUES (N'SP3', N'Topping', N'')
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [ChiTiet]) VALUES (N'SP4', N'Sinh tố', N'')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [CMND], [NgaySinh], [LoaiNV]) VALUES (N'1', N'Hoàng Phong Sang', 123456789, CAST(N'1998-10-05' AS Date), N'N')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [CMND], [NgaySinh], [LoaiNV]) VALUES (N'2', N'Liên Minh Quang', 123121232, CAST(N'1998-04-02' AS Date), N'A')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [CMND], [NgaySinh], [LoaiNV]) VALUES (N'3', N'Phan Vũ Minh Hiển', 120001232, CAST(N'1998-04-02' AS Date), N'N')
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'1A', N'SP1', N'Trà Sữa Olong', N'', N'', 10, 30000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'1B', N'SP1', N'Trà Sữa Thái', N'', N'', 10, 28000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'1C', N'SP1', N'Trà Sữa Matcha', N'', N'', 10, 32000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'1D', N'SP1', N'Sữa tươi chân trâu đường đen', N'', N'', 10, 40000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'2A', N'SP2', N'Hồng Trà Vải', N'', N'', 10, 25000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'2B', N'SP2', N'Trà Đào', N'', N'', 10, 28000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'2C', N'SP2', N'Hồng Trà Tắc', N'', N'', 10, 22000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'2D', N'SP2', N'Hồng Trà Chanh', N'', N'', 10, 23000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'3A', N'SP3', N'Chân Trâu', N'', N'', 10, 5000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'3B', N'SP3', N'Thạch Thủy Tinh', N'', N'', 10, 2000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'3C', N'SP3', N'Thạch Socola', N'', N'', 10, 2000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'3D', N'SP3', N'Thạch trái cây', N'', N'', 10, 3000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'3E', N'SP3', N'Bánh Plan', N'', N'', 10, 7000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'4A', N'SP4', N'Sinh tố bơ', N'', N'', 10, 35000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'4B', N'SP4', N'Sinh tố mãng cầu', N'', N'', 10, 25000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'4C', N'SP4', N'Sinh tố dừa', N'', N'', 10, 28000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'4D', N'SP4', N'Sinh tố thập cẩm', N'', N'', 10, 30000.0000)
INSERT [dbo].[SanPham] ([MaSP], [MaLoai], [TenSP], [ChiTiet], [GhiChu], [SoLuong], [Gia]) VALUES (N'4E', N'SP4', N'Sinh tố đu đủ', N'', N'', 10, 27000.0000)
INSERT [dbo].[TaiKhoan] ([MaNV], [TenDN], [MatKhau]) VALUES (N'1', N'sang', N'123')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenDN], [MatKhau]) VALUES (N'2', N'quang', N'123')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNVPV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([LoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSP] ([MaLoai])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [c_GiaBan] CHECK  (([GiaBan]>(0)))
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [c_GiaBan]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [c_SoLuongSP] CHECK  (([SoLuongDat]>(0)))
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [c_SoLuongSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [c_Gia] CHECK  (([Gia]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [c_Gia]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [c_SoLuong] CHECK  (([SoLuong]>=(0)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [c_SoLuong]
GO
/****** Object:  StoredProcedure [dbo].[p_NhapHang]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_NhapHang]
	@ma nvarchar(255),
	@soLuong int
as
begin
	if(not exists (select * from SanPham where SanPham.MaSP = @ma))
	begin
		raiserror(N'Sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	update SanPham
	set SoLuong = SoLuong + @soLuong
	where MaSP = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaCTHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_SuaCTHD]
	@maHD nvarchar(255),
	@maSP nvarchar(255),
	@soluong int, 	 
	@gia money
as
begin
	if(not exists (select * from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon = @maHD and MaSP = @maSP))
	begin
		raiserror(N'Chi tiết hóa đơn không tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from SanPham where SanPham.MaLoai = @maSP))
	begin
		raiserror(N'Sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from HoaDon where HoaDon.MaHD = @maHD))
	begin
		raiserror(N'Hóa đơn không tồn tại.', 11, 1)
		return -1
	end

	update ChiTietHoaDon
	set SoLuongDat = @soluong, GiaBan = @gia
	where ChiTietHoaDon.MaHoaDon = @maHD and ChiTietHoaDon.MaSP = @maSP

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaHoaDon]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[p_SuaHoaDon]
	@ma nvarchar(255),
	@manv nvarchar(255),
	@ngay date
as
begin
	if(not exists (select * from HoaDon where HoaDon.MaHD = @ma))
	begin
		raiserror(N'Mã không hóa đơn đã tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Nhân viên không tồn tại.', 11, 1)
		return -1
	end

	update HoaDon
	set MaNVPV = @manv, Ngay = @ngay
	where MaHD = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaLoaiNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_SuaLoaiNhanVien]
	@ma nvarchar(255),
	@ten nvarchar(255)
as
begin
	if(not exists (select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @ma))
	begin
		raiserror(N'Mã loại không tồn tại.', 11, 1)
		return -1
	end

	update LoaiNhanVien
	set TenLoai = @ten
	where LoaiNhanVien.MaLoai = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaLoaiSP]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_SuaLoaiSP]
	@ma nvarchar(255),
	@ten nvarchar(255), 
	@chitiet nvarchar(255)
as
begin
	if(not exists (select * from LoaiSP where LoaiSP.MaLoai = @ma))
	begin
		raiserror(N'Loại sản phẩm không tồn tại.', 11, 1)
		return -1
	end
	update LoaiSP
	set TenLoai = @ten, ChiTiet = @chitiet
	where LoaiSP.MaLoai = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_SuaNhanVien]
	@ma nvarchar(255),
	@ten nvarchar(255), 
	@cmnd int, 
	@ngaysinh date, 
	@loai nvarchar(255)
as
begin
	if(not exists (select * from NhanVien where NhanVien.MaNV = @ma))
	begin
		raiserror(N'Nhân viên không tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @loai))
	begin
		raiserror(N'Loại nhân viên không tồn tại.', 11, 1)
		return -1
	end

	update NhanVien
	set TenNV = @ten, CMND = @cmnd, NgaySinh = @ngaysinh, LoaiNV = @loai
	where NhanVien.MaNV = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaSanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_SuaSanPham]
	@ma nvarchar(255),
	@maloai nvarchar(255),
	@ten nvarchar(255), 
	@chitiet nvarchar(255), 
	@ghichu nvarchar(255),
	@soluong int,
	@gia money
as
begin
	if(not exists (select * from SanPham where SanPham.MaSP = @ma))
	begin
		raiserror(N'Sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from LoaiSP where LoaiSP.MaLoai = @maloai))
	begin
		raiserror(N'Loại sản phẩm không tồn tại.', 11, 1)
		return -1
	end
	 
	update SanPham
	set TenSP = @ten, MaLoai = @maloai, ChiTiet = @chitiet, GhiChu = @ghichu, SoLuong = @soluong, Gia = @gia
	where SanPham.MaSP = @ma

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_SuaTaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[p_SuaTaiKhoan]
	@manv nvarchar(255),
	@username nvarchar(255),
	@old_password nvarchar(255),
	@new_password nvarchar(255)
as
begin
	if(not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Mã nhân viên không tồn tại.', 11, 1)
		
		return -3
	end

	if(not exists (select * from TaiKhoan where TaiKhoan.MaNV = @manv))
	begin
		raiserror(N'Tài khoản không tồn tại.', 11, 1)
		return -1
	end

	if(@old_password != (select TaiKhoan.MatKhau from TaiKhoan where TaiKhoan.MaNV = @manv))
	begin
		raiserror(N'Mật khẩu cũ không đúng.', 11, 1)
		return -2
	end


	

	update TaiKhoan
	set TenDN = @username, MatKhau = @new_password
	where TaiKhoan.MaNV = @manv

	return 0
end

GO
/****** Object:  StoredProcedure [dbo].[p_ThemCTHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemCTHD]
	@maHD nvarchar(255),
	@maSP nvarchar(255),
	@soluong int, 	 
	@gia money
as
begin
	if(exists (select * from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon = @maHD and MaSP = @maSP))
	begin
		raiserror(N'Chi tiết hóa đơn đã tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from SanPham where SanPham.MaLoai = @maSP))
	begin
		raiserror(N'Sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from HoaDon where HoaDon.MaHD = @maHD))
	begin
		raiserror(N'Hóa đơn không tồn tại.', 11, 1)
		return -1
	end

	insert into ChiTietHoaDon values(@maHD, @maSP, @soluong, @gia)

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_ThemHoaDon]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemHoaDon]
	@ma nvarchar(255),
	@manv nvarchar(255),
	@ngay date
as
begin
	if(exists (select * from HoaDon where HoaDon.MaHD = @ma))
	begin
		raiserror(N'Mã hóa đơn đã tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Nhân viên không tồn tại.', 11, 1)
		return -1
	end

	insert into HoaDon values(@ma, @manv, @ngay)

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_ThemLoaiNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemLoaiNhanVien] 
	@ma nvarchar(255), 
	@ten nvarchar(255)
as
begin 
	if(exists (select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @ma))
	begin
		raiserror(N'Mã loại đã tồn tại.', 11, 1)
		return -1
	end

	insert into LoaiNhanVien values(@ma, @ten)

	return 0
end

GO
/****** Object:  StoredProcedure [dbo].[p_ThemLoaiSP]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemLoaiSP]
	@ma nvarchar(255),
	@ten nvarchar(255), 
	@chitiet nvarchar(255)
as
begin
	if(exists (select * from LoaiSP where LoaiSP.MaLoai = @ma))
	begin
		raiserror(N'Mã loại đã tồn tại.', 11, 1)
		return -1
	end

	insert into LoaiSP values(@ma, @ten, @chitiet)

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_ThemNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemNhanVien]
	@ma nvarchar(255),
	@ten nvarchar(255), 
	@cmnd int, 
	@ngaysinh date, 
	@loai nvarchar(255)
as
begin
	if(exists (select * from NhanVien where NhanVien.MaNV = @ma))
	begin
		raiserror(N'Mã nhân viên đã tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @loai))
	begin
		raiserror(N'Loại nhân viên không tồn tại.', 11, 1)
		return -1
	end

	insert into NhanVien values(@ma, @ten, @cmnd, @ngaysinh, @loai)

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_ThemSanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_ThemSanPham]
	@ma nvarchar(255),
	@maLoai nvarchar(255),
	@ten nvarchar(255), 
	@chitiet nvarchar(255), 
	@ghichu nvarchar(255),
	@soluong int, 
	@gia money
as
begin
	if(exists (select * from SanPham where SanPham.MaSP = @ma))
	begin
		raiserror(N'Mã sản phẩm đã tồn tại.', 11, 1)
		return -1
	end

	if( not exists (select * from LoaiSP where LoaiSP.MaLoai = @maloai))
	begin
		raiserror(N'Loại sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	insert into SanPham values(@ma, @maLoai, @ten, @chitiet, @ghichu, @soluong, @gia)

	return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_ThemTaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ThemTaiKhoan] 
    @manv nvarchar(255),
    @username nvarchar(255),
	@password nvarchar(255)
AS
begin
	if(exists (select * from TaiKhoan where TaiKhoan.MaNV = @manv))
	begin
		raiserror(N'Tài khoản đã tồn tại với nhân viên này.', 11, 1)
		
		return 0
	end

	if(not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Mã nhân viên không tồn tại.', 11, 1)
		
		return -1
	end

	insert into TaiKhoan(MaNV, TenDN, MatKhau) values(@manv, @username, @password)

	return 1
end 

GO
/****** Object:  StoredProcedure [dbo].[p_XoaCTHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaCTHD]
	@maHD nvarchar(255),
	@maSP nvarchar(255)
as begin
	if(not exists (select * from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon = @maHD and MaSP = @maSP))
	begin
		raiserror(N'Chi tiết hóa đơn không tồn tại.', 11, 1)
		return -1
	end

	delete from ChiTietHoaDon
	where MaSP = @maSP and MaHoaDon = @maHD

return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaHoaDon]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaHoaDon]
	@ma nvarchar(255)
as begin
	if(exists (select * from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon = @ma))
	begin
		raiserror(N'Hóa đơn không thể xóa vì còn chi tiết hóa đơn liên kết đến.', 11, 1)
		return -1
	end

	if(not exists (select * from HoaDon where HoaDon.MaHD = @ma))
	begin
		raiserror(N'Hóa đơn không tồn tại.', 11, 1)
		return -1
	end

	delete from HoaDon
	where HoaDon.MaHD = @ma

return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaLoaiNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaLoaiNhanVien] 
	@ma nvarchar(255)
as
begin
	if(not exists (select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @ma))
	begin
		raiserror(N'Mã không đã tồn tại.', 11, 1)
		return -1
	end

	delete from LoaiNhanVien
	where LoaiNhanVien.MaLoai = @ma
	return 1
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaLoaiSP]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaLoaiSP]
	@ma nvarchar(255)
as begin
	if(not exists (select * from LoaiSP where LoaiSP.MaLoai = @ma))
	begin
		raiserror(N'Loại sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	delete from LoaiSP
	where LoaiSP.MaLoai = @ma

return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaNhanVien]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[p_XoaNhanVien]
	@ma nvarchar(255)
as begin
	
	
	if(not exists (select * from NhanVien where NhanVien.MaNV = @ma))
	begin
		raiserror(N'Nhân viên không tồn tại.', 11, 1)
		return -1
	end

	delete from NhanVien
	where NhanVien.MaNV = @ma

return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaSanPham]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaSanPham]
	@ma nvarchar(255)
as begin
	if(not exists (select * from SanPham where SanPham.MaSP = @ma))
	begin
		raiserror(N'Sản phẩm không tồn tại.', 11, 1)
		return -1
	end

	if(exists (select * from ChiTietHoaDon where ChiTietHoaDon.MaSP = @ma))
	begin
		raiserror(N'Không thể xóa sản phẩm vì còn tồn tại trong hóa đơn.', 11, 1)
		return -1
	end

	delete from SanPham
	where SanPham.MaSP = @ma

return 0
end
GO
/****** Object:  StoredProcedure [dbo].[p_XoaTaiKhoan]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[p_XoaTaiKhoan] 
	@manv nvarchar(255)
as 
begin
	if(not exists (select * from TaiKhoan where TaiKhoan.MaNV = @manv))
	begin
		raiserror(N'Tài khoản không tồn tại.', 11, 1)
		return -1
	end

	delete from TaiKhoan where TaiKhoan.MaNV = @manv
end

GO
/****** Object:  StoredProcedure [dbo].[pr_insertCTHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_insertCTHD] (@mahd nvarchar (255),@masp nvarchar (255),@soluongdat int)
as
begin
declare @giaban money
set @giaban = (select Gia from SanPham where @masp=SanPham.MaSP)*@soluongdat
insert into ChiTietHoaDon (MaHoaDon,MaSP,SoLuongDat,GiaBan)
values (@mahd,@masp,@soluongdat,@giaban)
select * from SanPham where MaSP = @masp;
end
GO
/****** Object:  StoredProcedure [dbo].[pr_insertHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_insertHD] (@mahd nvarchar (255),@maNVPV nvarchar (255),@ngay date)
as
begin
insert into HoaDon(MaHD,MaNVPV,Ngay)
values (@mahd,@maNVPV,@ngay)
end
GO
/****** Object:  StoredProcedure [dbo].[pr_insertSP]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_insertSP] (@masp nvarchar (255),@maloai nvarchar (255),@tensp nvarchar(255),@chitiet nvarchar(255),@ghichu nvarchar (255),@soluong int,@gia money)
as
begin
declare @kiemtra int
	if((select count(MaSP) from SanPham where SanPham.MaSP=@masp)>1)
		begin
			set @kiemtra = 0
		end
	else
		begin
			set @kiemtra = 1
			insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
			values (@masp,@maloai,@tensp,@chitiet,@ghichu,@soluong,@gia)
		end
select @kiemtra
end
GO
/****** Object:  StoredProcedure [dbo].[pr_ThemHang]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_ThemHang] (@masp nvarchar(255),@soluongcapnhat int)
as 
begin
declare @soluongcu int ,@soluonghientai int
select @soluongcu = SanPham.SoLuong from SanPham where @masp=SanPham.MaSP
	set  @soluonghientai = @soluongcu + @soluongcapnhat
	update SanPham set SoLuong=@soluonghientai where SanPham.MaSP=@masp
end
GO
/****** Object:  StoredProcedure [dbo].[pr_TuSinhMaHD]    Script Date: 13/11/2018 10:55:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[pr_TuSinhMaHD] (@manv nvarchar(255), @day nvarchar(255))
as 
begin
declare @ma_next varchar (255)
declare @max int
select @max = count (MaHD) + 1 from HoaDon where MaHD like 'HD'
set @ma_next = 'HD' +RIGHT('0' + CAST (@max as varchar (18)),18)
while (exists (select MaHD from HoaDon where MaHD=@ma_next))
begin
	set @max = @max +1
	set @ma_next = 'HD'+ RIGHT ('0' + CAST (@max as varchar (18)),18)
end
select @ma_next
insert into HoaDon values (@ma_next,@manv,@day)
end
GO
USE [master]
GO
ALTER DATABASE [UngDungBanTraSua] SET  READ_WRITE 
GO
