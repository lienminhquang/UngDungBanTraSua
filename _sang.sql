CREATE DATABASE UngDungBanTraSua
go

USE UngDungBanTraSua
go

CREATE TABLE LoaiNhanVien(
	MaLoai nvarchar(255) primary key,
	TenLoai nvarchar(255)
)

go

CREATE TABLE NhanVien(
	MaNV nvarchar(255) primary key,
	TenNV nvarchar(255) not null,
	CMND int,
	NgaySinh date not null,
	LoaiNV nvarchar(255) foreign key references LoaiNhanVien(MaLoai) not null
)

go

CREATE TABLE TaiKhoan(
	MaNV nvarchar(255) primary key,
	TenDN nvarchar(255) not null,
	MatKhau nvarchar(255) not null,
	CONSTRAINT FK_TaiKhoan FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
go

CREATE TABLE LoaiSP(
	MaLoai nvarchar(255) primary key,
	TenLoai nvarchar(255) not null,
	ChiTiet nvarchar(255)
)
go

CREATE TABLE SanPham(
	MaSP nvarchar(255) primary key,
	MaLoai nvarchar(255) foreign key references LoaiSP(MaLoai),
	TenSP nvarchar(255) not null, 
	ChiTiet nvarchar(1000),
	GhiChu nvarchar(1000),
	SoLuong int not null,
	Gia money not null,
	CONSTRAINT c_SoLuong CHECK(SoLuong >= 0),
	CONSTRAINT c_Gia CHECK(Gia >= 0)
)
go

CREATE TABLE HoaDon(
	MaHD varchar(255) primary key,
	MaNVPV nvarchar(255) FOREIGN KEY REFERENCES NhanVien(MaNV),
	Ngay date not null
)
GO

CREATE TABLE ChiTietHoaDon(
	MaHoaDon varchar(255) FOREIGN KEY REFERENCES HoaDon(MaHD),
	MaSP nvarchar(255) FOREIGN KEY REFERENCES SanPham(MaSP),
	SoLuongDat int not null,
	GiaBan money not null,
	CONSTRAINT c_SoLuongSP CHECK(SoLuongDat > 0),
	CONSTRAINT c_GiaBan CHECK(GiaBan > 0)
)
/* THÊM DỮ LIỆU CHO BẢNG*/
--dbo.TaiKhoan
insert into TaiKhoan(MaNV,TenDN,MatKhau)
values ('1','sang','123')
insert into TaiKhoan(MaNV,TenDN,MatKhau)
values ('2','quang','123')




--dbo.NhanVien

insert into NhanVien(MaNV,TenNV,CMND,NgaySinh,LoaiNV)
values('1','Hoàng Phong Sang','123456789','1998/10/05','N')
insert into NhanVien(MaNV,TenNV,CMND,NgaySinh,LoaiNV)
values('2','Liên Minh Quang','123121232','1998/4/2','A')
insert into NhanVien(MaNV,TenNV,CMND,NgaySinh,LoaiNV)
values('3',N'Phan Vũ Minh Hiển','120001232','1998/4/2','N')




--dbo.LoaiNhanVien
insert into LoaiNhanVien(MaLoai,TenLoai)
values('A','AD')
insert into LoaiNhanVien(MaLoai,TenLoai)
values('N','NV')


--dbo.ChiTietHoaDon



--dbo.HoaDon
Insert into HoaDon(MaHD,MaNVPV,Ngay)
values ('HD1','1','2018/10/4')
Insert into HoaDon(MaHD,MaNVPV,Ngay)
values ('HD2','1','2018/9/4')
Insert into HoaDon(MaHD,MaNVPV,Ngay)
values ('HD3','1','2018/10/12')
Insert into HoaDon(MaHD,MaNVPV,Ngay)
values ('HD3','1','2018/10/30')


--dbo.LoaiSP
Insert into LoaiSP(MaLoai,TenLoai,ChiTiet)
values ('SP1',N'Trà Sữa','')
Insert into LoaiSP(MaLoai,TenLoai,ChiTiet)
values ('SP2',N'Hồng trà','')
Insert into LoaiSP(MaLoai,TenLoai,ChiTiet)
values ('SP3',N'Topping','')
Insert into LoaiSP(MaLoai,TenLoai,ChiTiet)
values ('SP4',N'Sinh tố','')

---dbo.SanPham

--Trà sữa
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('1A','SP1',N'Trà Sữa Olong','','','10','30000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('1B','SP1',N'Trà Sữa Thái','','','10','28000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('1C','SP1',N'Trà Sữa Matcha','','','10','32000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('1D','SP1',N'Sữa tươi chân trâu đường đen','','','10','40000')
--Hồng trà
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('2A','SP2',N'Hồng Trà Vải','','','10','25000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('2B','SP2',N'Trà Đào','','','10','28000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('2C','SP2',N'Hồng Trà Tắc','','','10','22000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('2D','SP2',N'Hồng Trà Chanh','','','10','23000')
--Topping
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('3A','SP3',N'Chân Trâu','','','10','5000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('3B','SP3',N'Thạch Thủy Tinh','','','10','2000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('3C','SP3',N'Thạch Socola','','','10','2000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('3D','SP3',N'Thạch trái cây','','','10','3000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('3E','SP3',N'Bánh Plan','','','10','7000')
--Sinh tố
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('4A','SP4',N'Sinh tố bơ','','','10','35000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('4B','SP4',N'Sinh tố mãng cầu','','','10','25000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('4C','SP4',N'Sinh tố dừa','','','10','28000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('4D','SP4',N'Sinh tố thập cẩm','','','10','30000')
Insert into SanPham(MaSP,MaLoai,TenSP,ChiTiet,GhiChu,SoLuong,Gia)
values ('4E','SP4',N'Sinh tố đu đủ','','','10','27000')
go

 --trigger function & procedure----
 --function kiểm tra đăng nhập--
 create function f_Login (@username nvarchar(255),@password nvarchar(255))
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
 go
 --test check đăng nhập--
 select dbo.f_Login('sang','123')

 --trigger kiểm tra tài khoản trùng--
 create trigger tg_KTTaiKhoanTrung 
 on dbo.TaiKhoan
 for update,insert 
 as 
 begin
 declare @user nvarchar(255),@dem int
 select @user=inserted.TenDN from inserted
 select @dem = COUNT (*) from TaiKhoan
 where TenDN=@user
 if(@dem>1)
 begin
 print N'Tài khoản đã tồn tại'
 rollback tran
 end
 end
 go
 
 insert into TaiKhoan(MaNV,TenDN,MatKhau)
values ('3','hien','123')
delete from NhanVien where MaNV='3'
-- cập nhật lại số lượng sản phẩm trong table sản phẩm sau khi mua hàng hoặc cập nhật --
create trigger tg_DatHang on ChiTietHoaDon after insert as
begin
update SanPham
set SoLuong = SoLuong - (select SoLuongDat from inserted where MaSP= SanPham.MaSP)
from SanPham
join inserted on SanPham.MaSP = inserted.MaSP
end
go

--cập nhật lại số lượng sau khi hủy đơn hàng--
create trigger tg_HuyDatHang on ChiTietHoaDon for delete as
begin
update SanPham
set SoLuong = SoLuong + ( select SoLuongDat  from deleted where MaSP = SanPham.MaSP)
from SanPham
join deleted on SanPham.MaSP = deleted.MaSP
end

--cập nhật lại số lượng sản phẩm sau khi admin thêm sản phẩm--
create proc pr_ThemHang (@masp nvarchar(255),@soluongcapnhat int)
as 
begin
declare @soluongcu int ,@soluonghientai int
select @soluongcu = SanPham.SoLuong from SanPham where @masp=SanPham.MaSP
	set  @soluonghientai = @soluongcu + @soluongcapnhat
	update SanPham set SoLuong=@soluonghientai where SanPham.MaSP=@masp
end
exec pr_ThemHang '1C',4
--insert dữ liệu vào bảng chi tiết hóa đơn  và giá tiền tự tính ---
create proc pr_insertCTHD (@mahd nvarchar (255),@masp nvarchar (255),@soluongdat int)
as
begin
declare @giaban money
set @giaban = (select Gia from SanPham where @masp=SanPham.MaSP)*@soluongdat
insert into ChiTietHoaDon (MaHoaDon,MaSP,SoLuongDat,GiaBan)
values (@mahd,@masp,@soluongdat,@giaban)
end
exec pr_insertCTHD 'HD1','1A',2
--insert dữ liệu vào bảng hóa đơn
create proc pr_insertHD (@mahd nvarchar (255),@maNVPV nvarchar (255),@ngay date)
as
begin
insert into HoaDon(MaHD,MaNVPV,Ngay)
values (@mahd,@maNVPV,@ngay)
end
--insert dữ liệu vào bảng Sản phẩm
create proc pr_insertSP (@masp nvarchar (255),@maloai nvarchar (255),@tensp nvarchar(255),@chitiet nvarchar(255),@ghichu nvarchar (255),@soluong int,@gia money)
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


--hiển thị bảng hd
create function f_tableHD (@mahd nvarchar(255))
returns table
as
return ((select *from ChiTietHoaDon where ChiTietHoaDon.MaHoaDon=@mahd))
select * from  f_tableHD ('HD1')	
--lấy tên món theo từng loại
create function f_LayMonTheoLoai (@tensp nvarchar(255))
returns table
as
return (select TenSP from SanPham where SanPham.MaLoai = (select MaLoai 
from LoaiSP
where TenLoai=@tensp))

select* from f_LayMonTheoLoai(N'Trà Sữa')


--proc tự sinh mã hóa đơn
create proc pr_TuSinhMaHD
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
end



