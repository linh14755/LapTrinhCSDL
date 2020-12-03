CREATE DATABASE QuanLyBangDia
GO
USE QuanLyBangDia

GO
--Băng Đĩa
CREATE TABLE BangDia 
(
MaBD INT IDENTITY PRIMARY KEY, 
TenBD NVARCHAR(100), 
SoLuong INT NOT NULL, 
DonGia INT NOT NULL, 
TheLoai nvarchar(100)
)
GO
--Khách hàng
CREATE TABLE KhachHang 
(
MaKH INT IDENTITY PRIMARY KEY, 
TenKH NVARCHAR(100), 
SoDT NVARCHAR(100), 
DiaChi NVARCHAR(100)
)
GO
--Thuê
CREATE TABLE Thue 
(
Luot INT IDENTITY PRIMARY KEY, 
MaBD INT REFERENCES BangDia(MaBD), 
MAKH INT REFERENCES KhachHang(MaKH),
TienCoc int, 
NgayBD date,
NgayTra date,
TongTien int,
[status] bit default 0
)

go
--insert into KhachHang(TenKH,SoDT,DiaChi) values (N'Tường Vy' , N'0122344798' , N'Nguyen Du P9')

go
--------------------------------------------------
create proc USP_InsertKhachHang
@tenkh nvarchar(100), @sodt nvarchar(100), @diachi nvarchar(100)
as
begin
insert into KhachHang(TenKH,SoDT,DiaChi) values (@tenkh , @sodt , @diachi)
end
go
------------------------------------------------------
create proc USP_UpdateKhachHang
@makh int , @tenkh nvarchar(100), @sodt nvarchar(100), @diachi nvarchar(100)
as
begin
update KhachHang set TenKH = @tenkh , SoDT = @sodt , DiaChi = @diachi where MaKH = @makh
end
go
---------------------------------------------------------
create proc USP_InsertBangDia
@tenbd nvarchar(100), @soluong int ,@dongia int , @theloai nvarchar(100)
as
begin
insert into BangDia(TenBD,SoLuong,DonGia,TheLoai) values (@tenbd , @soluong , @dongia , @theloai)
end
go
---------------------------------------------------------
create proc USP_UpdateBangDia
@mabd int , @tenbd nvarchar(100), @soluong int ,@dongia int , @theloai nvarchar(100)
as
begin
update BangDia set TenBD = @tenbd , SoLuong = @soluong , DonGia = @dongia where MaBD = @mabd
end
GO
----------------------------------------------------
create proc USP_InsertThue
@mabd int , @makh int ,@tiencoc int , @ngaybd date , @ngaytra date , @tongtien int
as
declare @soluong int
select @soluong = SoLuong from BangDia where MaBD = @mabd
if(@soluong> 0)
	begin
		update	BangDia set SoLuong = @soluong - 1 where MaBD = @mabd
		insert into Thue(MaBD,MAKH,TienCoc,NgayBD, NgayTra, TongTien) values (@mabd , @makh , @tiencoc , @ngaybd , @ngaytra , @tongtien)
	end
go
------------------------------------------------------------
create proc USP_UpdateThue
@luot int , @mabd int, @makh int ,@tiencoc int , @ngaybd date , @ngaytra date , @tongtien int , @status bit
as
begin
	update Thue set MaBD = @mabd , MAKH = @makh , TienCoc = @tiencoc , NgayBD = @ngaybd , NgayTra = @ngaytra , TongTien = @tongtien where Luot = @luot and [status] = 0
end
GO
go
SELECT * FROM KhachHang
SELECT * FROM BangDia
SELECT * FROM Thue
go
--exec USP_InsertThue 1 , 1 , 10000 , '2020-10-10' , '2020-10-10' , 100000
--exec USP_UpdateThue @luot , @mabd , @makh , @tiencoc , '@ngaybd' , '@ngaytra' , @tongtien
