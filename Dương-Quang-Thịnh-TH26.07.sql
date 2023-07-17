create database QLSV1
use QLSV1

create table KHOA		
(
	MaKhoa varchar(10) primary key,
	TenKhoa Nvarchar(100) not null,
)
go

create table NGANH
(
	MaNganh varchar(10) primary key,
	TenNganh Nvarchar(100) not null,
	Makhoa varchar(10),
	constraint fk_Makhoa foreign key(Makhoa) references KHOA(Makhoa),

)
go

create table LOP
(
	MaLop varchar(10) primary key,
	TenLop Nvarchar(50) not null,
	MaNganh varchar(10)  not null,
	KhoaHoc int not null,
	HeDT char(10),
	NamNhapHoc int,
	constraint fk_MaNganh foreign key(MaNganh) references NGANH(MaNganh),

)
create table SINHVIEN
(
	MaSV varchar(10) not null primary key,
	HoTen Nvarchar(100) not null,
	MaLop varchar(10) not null,
	GioiTinh bit,
	NgaySinh datetime,
	DiaChi Nvarchar(200),
		constraint fk_MaLop foreign key(MaLop) references LOP(MaLop),
)
go

create table HOCPHAN
(
	MaHP varchar(10) primary key,
	TenHP Nvarchar(100) not null,
	Sodvht int,
	MaNganh varchar(10),
	HocKy int,
)	
go

create table DIEMHP
(
	MaSV varchar(10),
	MaHP varchar(10),
	DiemHP float,
	constraint fk_MaSV foreign key(MaSV) references SINHVIEN(MaSV),
	constraint fk_MaHP foreign key(MaHP) references HOCPHAN(MaHP),
)
--Insert:

insert into KHOA values('CNTT', N'Công nghệ thông tin')
insert into KHOA values('KT', N'Kế toán')
insert into KHOA values('SP', N'Sư phạm')
insert into KHOA values('QTKD',N'Quản Trị Kinh Doanh')

insert into NGANH values('140902',N'Sư phạm toán tin','SP')
insert into NGANH values('480202',N'Tin học ứng dụng','CNTT')

insert into LOP values('CT11',N'Cao đắng tin học','480202', 11, 'TC',2013 )
insert into LOP values('CT12',N'Cao đắng tin học','480202', 12, 'CĐ', 2013)
insert into LOP values('CT13',N'Cao đắng tin học','480202', 13, 'CĐ', 2014)
insert into LOP values('CT14',N'Cao đắng tin học','140902', 10, 'CĐ', 2014)

insert into SINHVIEN values('001', N'Phan Thanh', 'CT12', 'False', '09/12/1990', N'Tuy Phước')
insert into SINHVIEN values('002', N'Nguyễn Thị Cẩm Nhung', 'CT12', 'True', '01/12/1994', N'Quy Nhơn')
insert into SINHVIEN values('003', N'Võ Thị Hà', 'CT12', 'True', '07/02/1995', N'An Nhơn')
insert into SINHVIEN values('004', N'Trần Hoài Nam', 'CT12', 'False', '04/05/1994', N'Tây Sơn')
insert into SINHVIEN values('005', N'Trần Văn Hoàng', 'CT13', 'False', '08/04/1995', N'Vĩnh Thạnh')
insert into SINHVIEN values('006', N'Đặng Thị Thảo', 'CT13', 'True', '06/12/1995', N'Quy Nhơn')
insert into SINHVIEN values('007', N'Lê Thị Sen', 'CT13', 'True', '08/12/1994', N'Phủ Cát')
insert into SINHVIEN values('008', N'Nguyễn Văn Huy', 'CT11', 'False', '06/04/1995', N'Phủ Mỹ')
insert into SINHVIEN values('009', N'Trần Thị Hoa', 'CT11', 'True', '08/09/1994', N'Hoài Nhơn')

insert into HOCPHAN values('001', N'Toán cao cấp A1', 4, '480202', 1)
insert into HOCPHAN values('002', N'Tiếng Anh 1', 3, '480202', 1)
insert into HOCPHAN values('003', N'Vật lý đại cương', 4, '480202', 1)
insert into HOCPHAN values('004', N'Tiếng Anh 2', 7, '480202', 1)
insert into HOCPHAN values('005', N'Tiếng Anh 1', 3, '140909', 2)
insert into HOCPHAN values('006', N'Xác suất thống kê', 3, '140909', 2)

insert into DIEMHP values('002', '002', 5.9)
insert into DIEMHP values('002', '003', 4.5)
insert into DIEMHP values('003', '001', 4.3)
insert into DIEMHP values('003', '002',	6.7)
insert into DIEMHP values('003', '003', 7.3)
insert into DIEMHP values('004', '001', 4.0)
insert into DIEMHP values('004', '002', 5.2)
insert into DIEMHP values('004', '003', 3.5)
insert into DIEMHP values('005', '001', 9.8)
insert into DIEMHP values('005', '002', 7.9)
insert into DIEMHP values('005', '003', 7.5)
insert into DIEMHP values('006', '001', 6.1)
insert into DIEMHP values('006', '002', 5.6)
insert into DIEMHP values('006', '003', 4.0)
insert into DIEMHP values('007', '001', 6.2)

select * from SINHVIEN a join DIEMHP b on a.MaSV=b.MaSV
select a.MaSV,HoTen,MaLop,GioiTinh,NgaySinh,DiaChi,DiemHP from SINHVIEN a join DIEMHP b on a.MaSV=b.MaSV where a.MaSV='002'
