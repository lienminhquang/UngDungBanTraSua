use UngDungBanTraSua;
go



create function fn_DangNhapAdmin(@username nvarchar(255), @password nvarchar(255))
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
go



create function fn_LayDanhSachTaiKhoan()
returns table
as
return (select * from TaiKhoang)
go



CREATE PROCEDURE dbo.p_ThemTaiKhoan 
    @manv nvarchar(255),
    @username nvarchar(255),
	@password nvarchar(255)
AS
begin
	if(exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Tài khoản đã tồn tại với nhân viên này.', 11, 1)
		
		return 0
	end

	if(not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Mã nhân viên không tồn tại.', 11, 1)
		
		return -1
	end

	insert into TaiKhoang(MaNV, TenDN, MatKhau) values(@manv, @username, @password)

	return 1
end 

go



create proc p_SuaTaiKhoan 
	@manv nvarchar(255),
	@username nvarchar(255),
	@password nvarchar(255)

as
begin
	
	if(not exists (select * from NhanVien where NhanVien.MaNV = @manv))
	begin
		raiserror(N'Mã nhân viên không tồn tại.', 11, 1)
		
		return -1
	end

	update TaiKhoang
	set TenDN = @username, MatKhau = @password
	where TaiKhoang.MaNV = @manv

	return 0
end

go


alter proc dbo.p_SuaTaiKhoan
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

	if(not exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Tài khoản không tồn tại.', 11, 1)
		return -1
	end

	if(@old_password != (select TaiKhoang.MatKhau from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Mật khẩu cũ không đúng.', 11, 1)
		return -2
	end


	

	update TaiKhoang
	set TenDN = @username, MatKhau = @new_password
	where TaiKhoang.MaNV = @manv

	return 0
end

go


create proc p_XoaTaiKhoan 
	@manv nvarchar(255)
as 
begin
	if(not exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Tài khoản không tồn tại.', 11, 1)
		return -1
	end

	delete from TaiKhoang where TaiKhoang.MaNV = @manv
end

go




-- Loaị nhân viên--

create function fn_LayDanhSachLoaiNhanVien()
returns table
return(select * from LoaiNhanVien)
go

create function fn_LayLoaiNhanVien(@maloai nvarchar(255))
returns table
return(select * from LoaiNhanVien where LoaiNhanVien.MaLoai = @maloai)
go

select * from SanPham
create proc p_ThemLoaiNhanVien 
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

go



create proc p_SuaLoaiNhanVien
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
go


create proc p_XoaLoaiNhanVien 
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
go


-- Nhan vien--
create function fn_LayDanhSachNhanVien()
returns table
return(select * from NhanVien)
go

create function fn_LayNhanVien(@manv nvarchar(255))
returns table
return (select * from NhanVien where NhanVien.MaNV = @manv)
go

create proc p_ThemNhanVien
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
go



create proc p_SuaNhanVien
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
go






create proc p_XoaNhanVien
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
go




-- Loai San pham--
use UngDungBanTraSua
go

create function fn_LayDanhSachLoaiSanPham()
returns table
return(select * from LoaiSP)
go

create function fn_LayLoai2(@maloai nvarchar(255))
returns table
return (select * from LoaiSP where LoaiSP.MaLoai = @maloai)
go

select * from fn_LayLoai('1')


create proc p_ThemLoaiSP
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
go


create proc p_SuaLoaiSP
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
go



create proc p_XoaLoaiSP
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
go




-- San pham -- 

create function fn_LayDanhSachSanPham()
returns table
return(select * from SanPham)
go

create function fn_LaySanPham(@masp nvarchar(255))
returns table
return(select * from SanPham where @masp = SanPham.MaSP)
go

create proc p_ThemSanPham
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
go



create proc p_SuaSanPham
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
go


create proc p_XoaSanPham
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
go


create proc p_NhapHang
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
go

--Hoa don --
create function fn_LayDanhSachHoaDon()
returns table
return(select * from HoaDon)
go


create proc p_ThemHoaDon
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
go


create proc p_SuaHoaDon
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
go

create proc p_XoaHoaDon
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
go


--chi tiet hoa don--

create function fn_LayDanhSachChiTietHD()
returns table
return(select * from ChiTietHoaDon)
go

create proc p_ThemCTHD
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
go


create proc p_SuaCTHD
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
	set SoLuong = @soluong, GiaBan = @gia
	where ChiTietHoaDon.MaHoaDon = @maHD and ChiTietHoaDon.MaSP = @maSP

	return 0
end
go


create proc p_XoaCTHD
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
go

use UngDungBanTraSua

create function fn_ThongTinTaiKhoan(@manv nvarchar(255))
returns table
return( select NhanVien.MaNV, NhanVien.TenNV, TaiKhoang.TenDN as TenDN, TaiKhoang.MatKhau from NhanVien, TaiKhoang where NhanVien.MaNV = @manv and TaiKhoang.MaNV = @manv);
go

alter proc p_Admin_DoiMatKhau
	@manv nvarchar(255),
	@mk_moi nvarchar(255)
as
begin
	if( not exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Không tồn tại tài khoản.', 11, 1)
		return -1 
	end
	
	update TaiKhoang
	set MatKhau = @mk_moi
	where TaiKhoang.MaNV = @manv
	declare @login nvarchar(255)
	set @login = (select TaiKhoang.TenDN from TaiKhoang where TaiKhoang.MaNV = @manv)
	declare @safe_login varchar(200)
	declare @safe_password varchar(200)
	set @safe_login = replace(@login,'''', '''''')
	set @safe_password = replace(@mk_moi,'''', '''''')
	
	declare @sql nvarchar(max)
	set @sql =	'drop login ' + @safe_login + ';' +
				'create login ' + @safe_login + 
               ' with password = ''' + @safe_password + ''';'
           
	exec(@sql)
return 0
end
go


alter proc p_DoiMatKhau
	@manv nvarchar(255),
	@mk_cu nvarchar(255),
	@mk_moi nvarchar(255)
as
begin
	if( not exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Không tồn tại tài khoản.', 11, 1)
		return -1 
	end

	if(@mk_cu != (select TaiKhoang.MatKhau from  TaiKhoang where TaiKhoang.MaNV = @manv))
	begin
		raiserror(N'Mật khẩu cũ không đúng', 11, 1)
		return -1
	end

	update TaiKhoang
	set MatKhau = @mk_moi
	where TaiKhoang.MaNV = @manv
	declare @login nvarchar(255)
	set @login = (select TaiKhoang.TenDN from TaiKhoang where TaiKhoang.MaNV = @manv)
	declare @safe_login varchar(200)
	declare @safe_password varchar(200)
	set @safe_login = replace(@login,'''', '''''')
	set @safe_password = replace(@mk_moi,'''', '''''')
	
	declare @sql nvarchar(max)
	set @sql =	'drop login ' + @safe_login + ';' +
				'create login ' + @safe_login + 
               ' with password = ''' + @safe_password + ''';'
           
	exec(@sql)
return 0
end
go

select * from TaiKhoang
exec p_DoiMatKhau '7', 'admin', '1'

alter login tin with password = 'admin'

--------------------Tao role cho nhan vien-------------------------
create role r_NhanVien
grant select on dbo.fn_ThongTinTaiKhoan to r_NhanVien
grant select on fn_LayDanhSachLoaiSanPham to r_NhanVien
grant select on fn_LayDanhSachSanPham to r_NhanVien
grant exec on p_ThemHoaDon to r_NhanVien
grant select on fn_LayDanhSachChiTietHD to r_NhanVien
grant exec on p_ThemCTHD to r_NhanVien
grant exec on p_SuaCTHD to r_NhanVien

---------------------
go


create procedure p_TaoTK(
		@manv nvarchar(255),
        @login varchar(100),
        @password varchar(100))
as

if(not exists (select * from NhanVien where NhanVien.MaNV = @manv))
begin
	raiserror(N'Nhân viên không tồn tại.', 11, 1)
	return -1
end
if(exists (select * from TaiKhoang where TaiKhoang.MaNV = @manv))
begin
	raiserror(N'Tài khoản cho nhan vien đã tồn tại không tồn tại.', 11, 1)
	return -1
end

insert into TaiKhoang values(@manv, @login, @password)

declare @safe_login varchar(200)
declare @safe_password varchar(200)
set @safe_login = replace(@login,'''', '''''')
set @safe_password = replace(@password,'''', '''''')

declare @sql nvarchar(max)

if((select NhanVien.LoaiNV from NhanVien where NhanVien.MaNV = @manv) = 'N')
begin
	set @sql = 'create login ' + @safe_login + 
               ' with password = ''' + @safe_password + '''; ' +
           'create user NV_' + @safe_login + ' from login ' + @safe_login + ';' +
		   'alter role r_NhanVien add member NV_' + @safe_login + ';'
end
else
begin
	set @sql = 'create login ' + @safe_login + 
               ' with password = ''' + @safe_password + '''; ' +
           'create user AD_' + @safe_login + ' from login ' + @safe_login + ';' +
		   'alter role r_Admin add member AD_' + @safe_login + ';'
end
exec (@sql)

go

use UngDungBanTraSua
exec p_ThemNhanVien  '6', 'bro', 123, '1/1/1998', 'A'
select * from NhanVien

exec p_TaoTK '6', 'bro', '1'
select * from TaiKhoang
go

