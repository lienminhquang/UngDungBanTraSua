Use QLNhanVien
go

create table NhanVien(
	Ho varchar(50),
	TenLot varchar(50),
	Ma int,
	luong int,
	phong int,

	
	primary key (Ma)
)
go

create table PhongBan(
	TenPB varchar(50),
	MaPB int primary key,
	)
	alter table PhongBan 
	add trPhong int

alter table NhanVien
add constraint aa foreign key (phong) references PhongBan(MaPB)

alter table PhongBan
add constraint ff foreign key (trPhong) references NhanVien(Ma)
go

create function Bai22()
	returns  table 
		
	
as

	
	return
	(
		select MaPB, AVG(NhanVien.luong) as luongTB from PhongBan, NhanVien where NhanVien.phong = PhongBan.MaPB group by PhongBan.MaPB 
	)

go

select * from Bai22();