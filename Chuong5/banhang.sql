create database banhang;
use banhang;
---- tạo bảng nhân viên-----
----- Vd 8.1---------
create table nhanvien
(
	manv nvarchar(10) not null,
	hoten nvarchar(50) not null,
	ngaysinh date null,
	diachi nvarchar(100) null,
	dienthoai nvarchar(10) null,
	hsluong decimal(3,2) default(1.92),
	madonvi nvarchar(10) not null
)
select * from nhanvien;
------------ tao rang buoc ngay sinh 
alter table nhanvien
add constraint CK_nhanvien_ngaysinh check (ngaysinh >'1/1/1990');
------------ tao rang buoc so dien thoai
alter table nhanvien
add constraint CK_nhanvien_sdt check(dienthoai like '[0-9][0-9][0-9][0-9][0-9][0-9]');
------------ tao khoa chinh la ma nhan vien
alter table nhanvien
add constraint PK_nhanvien_manv primary key(manv);
----------- khong cho cac nhan vien khac trung dien thoai voi nhau
alter table nhanvien
add constraint UNIQUE_nhanvien_dienthoai UNIQUE(dienthoai);
------------ tao bang don vi -------
create table donvi
(
  madonvi nvarchar(10)not null,
  tendonvi nvarchar(100) not null,
  dienthoai nvarchar(10)null,
  constraint PK_madonvi primary key(madonvi),
  constraint CK_donvi_sdt check(dienthoai like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
  constraint UNIQUE_donvi_sdt UNIQUE(dienthoai)
)
select *from donvi;
------- tạo FK với madonvi cua bang donvi
alter table nhanvien
add constraint FK_nhanvien_madonvi foreign key (madonvi)references donvi(madonvi);
----------- Xoa constraint ngaysinh
alter table nhanvien
drop constraint CK_nhanvien_ngaysinh;
---------- tao bang mat hang
create table mathang
(
	mahang nvarchar(10) not null primary key,
	tenhang nvarchar(100) not null,
	dongia float (10) not null
)
select * from mathang;
-------- tao bang nhat ki ban hang
create table nhatkibanhang
(
 ngayban date not null,
 mahang nvarchar(10),
 soluong int,
 thanhtien float,
 constraint FK_mahang foreign key (mahang) references mathang(mahang)
)
select * from nhatkibanhang;
------ tao bang luong_nhanvien
create table luong_nhanvien
(
 manv nvarchar(10) not null,
 hoten nvarchar(50) not null,
 luong float not null,
 constraint FK_manv foreign key (manv) references nhanvien(manv)
)
---------- Đổi tên các cột trong kết quả
---------HOTEN (họ tên) được đổi thành Họ và Tên, DIACHI (địa chỉ)
--được đổi thành Địa Chỉ của các nhân viên trong bảng NHANVIEN.
select hoten 'Họ và tên', diachi 'Địa chỉ'
from nhanvien;
----HOTEN (họ tên), HSLUONG (hệ số lương) và (xếp loại lương) của các nhân viên trong bảng NHANVIEN theo HSLUONG (hệ số lương).
select hoten 'họ và tên', hsluong 'hệ số lương', 
'hệ số lương' = case
					when hsluong = null then 'Không xác định'
					when hsluong <=2.11 then 'Lương thấp'
					else
					'Lương cao'
				end
from nhanvien;
-------cho thêm chuỗi 'Hệ số lương là:' ở trước cột HSLUONG (hệ số
--lương) trong từng dòng kết quả.
select hoten 'họ và tên', 'hệ số lương:', hsluong 'hệ số lương'
from nhanvien;
---- câu lệnh cho  HOTEN (họ tên) và LUONG (lương) của nhân viên theo công
--thức LUONG = HSLUONG * 730000.select hoten as 'Họ tên', 'Lương: ' = hsluong *730000 from nhanvien; select hsluong from nhanvien;---------- tạo bảng nhanvien_luu gom cac truong hoten, diachi, cua cac nhan vien có hsluong >2.11 của nhân vienselect hoten, diachiinto nhanvien_luufrom nhanvienwhere hsluong >2.11;select * from nhanvien_luu;--- sắp xếp nhân viên theo thứ tự giảm dần của hệ số lương nếu HSLUONG bằng nhau thì sắp xếp kết quả theo thứ tự tăng dần của NGAYSINH select hoten, ngaysinh, hsluongfrom nhanvienorder by hsluong desc, ngaysinh asc;----  cho biết HOTEN (họ tên), DIACHI (địa chỉ) của các nhân viên bằng
--cách gán bí danh (alias) cho bảng NHANVIEN
select hoten, diachi
from nhanvien n1;
--- cho biết HOTEN (họ tên), DIACHI (địa chỉ) và DIENTHOAI (điện
--thoại) của các nhân viên có HSLUONG (hệ số lương) lớn hơn 2.11
select hoten, diachi, dienthoai
from nhanvien
where hsluong >2.11
----  cho biết HOTEN (họ tên), DIACHI (địa chỉ) và DIENTHOAI (điện
--thoại) của các nhân viên có HSLUONG (hệ số lương) trong khoảng 1.92 đến 3.11select hoten, diachi, dienthoaifrom nhanvienwhere hsluong between 2.11 and 2.14;----- cho biết HOTEN (họ tên), DIACHI (địa chỉ) và DIENTHOAI (điện
--thoại) của các nhân viên có HSLUONG (hệ số lương) là 2.11 và 2.14
select hoten, diachi, dienthoai
from nhanvien 
where hsluong in(2.11,2.14);
---- cho biêt thong nhan vien co ten la "Hoa"
select * from nhanvien
where hoten like '%Hoa';
---- cho biet thong tin nhan vien co điện thoại
select * from nhanvien
where dienthoai is not null;
----- cho biet thong tin nhan vien hon có dien thoai
select * from nhanvien
where dienthoai is null;
--- thêm dữ liệu vào đơn vị
insert into donvi values('06', 'Phòng CT', '678901', 'hello');
--- thêm một dòng dữ liệu vào bảng NHANVIEN 
insert into nhanvien values ('nv04', 'Phúc Tạ', '1990-01-23', null,'523312',1.92,'02');
--- thêm một dòng dữ liệu vào bảng NHANVIEN nhưng chỉ điền dữ liệu
--vào một số cột.
insert into nhanvien (manv, hoten,diachi, madonvi) values ('nv05', 'Trương Thảo', 'cần thơ', '02');
select * from donvi;
--- Câu lệnh sau đây thêm dữ liệu vào bảng LUONG_NHANVIEN với dữ liệu lấy từ bảng
--NHANVIEN
insert into luong_nhanvien
select manv, hoten, hsluong*730000 from nhanvien;
select * from luong_nhanvien;
-- Câu lệnh sau đây thêm dữ liệu vào bảng LUONG_NHANVIEN với dữ liệu lấy từ bảng
--NHANVIEN
update nhanvien
set hsluong = hsluong + 0.2
where madonvi = '04';
select * from nhanvien;
select * from luong_nhanvien;
--- cập nhật giá trị cho field THANHTIEN (thành tiền) trong bảng
--NHATKYBANHANG theo công thức THANHTIEN = SOLUONG * DONGIA.
update nhatkybanhang
set thanhtien = soluong*mathang.dongia
from mathang
where nhatkybanghang.mahang = mathang.mahang;
select * from nhatkybanhang;
--- xóa dữ liệu delete
--xoá khỏi bảng NHANVIEN những nhân viên làm tại đơn vị có
--SODIENTHOAI (số điện thoại) là '848484'
delete from nhanvien
from donvi
where nhanvien.madonvi = donvi.madonvi
and donvi.dienthoai = '821451';
select * from donvi;
--- xóa toàn bộ dữ liệu nhân viên
delete from luong_nhanvien;
truncate table luong_nhanvien;

---upadte dia chi của nguyễn thị hoa thành hậu giang
update nhanvien
set diachi = 'Hau Giang'
where manv = '01';
select * from nhanvien;

delete from nhanvien 
where hoten = 'Phúc T?'