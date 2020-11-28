create database QuanLyThuVien
go
use QuanLyThuVien
go
--Tao Bang TacGia
GO
CREATE TABLE Sach
(
	MASACH INT NOT NULL IDENTITY PRIMARY KEY,
	TENSACH NVARCHAR(50),
	TENTG NVARCHAR(100),
	TENNXB NVARCHAR(100),
	TENLV NVARCHAR(100),
	NAMXB DATE,
	SOLUONG INT DEFAULT 0,
	NGAYNHAP DATE,
	GHICHU NVARCHAR(100) default null
)
GO

CREATE TABLE DocGia
(
	MADG INT IDENTITY PRIMARY KEY,
	TAIKHOAN NVARCHAR(100),
	MATkHAU NVARCHAR(100),
	HOTEN NVARCHAR(100),
	NGAYSINH date,
	GIOITINH bit,
	SODT NVARCHAR(100),
	DIACHI NVARCHAR(100),
	EMAIL NVARCHAR(100),
	GHICHU NVARCHAR(100) default null
)
GO

CREATE TABLE TaiKhoan
(
	TAIKHOAN NVARCHAR(100)NOT NULL,
	MATKHAU NVARCHAR(100)NOT NULL,
	TEN NVARCHAR(100),
	DIACHI NVARCHAR(100),
	EMAIL NVARCHAR(100),
	SODT NVARCHAR(100),
	NGAYSINH date,
	GIOITINH bit
)
GO
CREATE TABLE MuonSach
(
	MADG INT REFERENCES DocGia(MADG),
	MASACH INT REFERENCES Sach(MASACH),
	SOPHIEUMUON INT IDENTITY PRIMARY KEY,
	NGAYMUON DATE,
	NGAYTRA DATE,
	XACNHANTRA INT DEFAULT 0, -- 0 LA CHUA TRA --1 DA TRA
	GHICHU NVARCHAR(100) default null,
	SOLUONG NVARCHAR(100) default null
)

GO
--select * from TaiKhoan where TAIKHOAN = N'Linh' and MATKHAU = N'1'
--INSERT TAIKHOAN
INSERT INTO TaiKhoan(TAIKHOAN, MATKHAU, TEN, DIACHI, EMAIL, SODT,NGAYSINH,GIOITINH) VALUES (N'Linh',N'1', N'Khánh Linh', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'linh1475@gmail.com', N'01445554444',GETDATE(),1)
INSERT INTO TaiKhoan(TAIKHOAN, MATKHAU, TEN, DIACHI, EMAIL, SODT,NGAYSINH,GIOITINH) VALUES (N'Staff',N'1', N'Staff', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'staff@gmail.com', N'0144588944',GETDATE(),1)
GO
--INSERT SACH
INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'Chính trị Mác - Lênin', N'Xuân Quỳnh', N'Nhà xuất bản Kim Đồng', N'Tài Liệu Học tập', GETDATE(), 10, GETDATE())
INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'Tiếng Anh Giao Tiếp', N'Xuân Quỳnh', N'Nhà xuất bản Kim Đồng', N'Tài Liệu Học tập', GETDATE(), 10, GETDATE())
INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'Kỹ năng soạn thảo văn bản', N'Xuân Quỳnh', N'Nhà xuất bản Kim Đồng', N'Tài Liệu Học tập', GETDATE(), 10, GETDATE())
INSERT INTO Sach(TENSACH,TENTG,TENNXB,TENLV,NAMXB,SOLUONG,NGAYNHAP) VALUES (N'Nhập môn công nghệ thông tin', N'Xuân Quỳnh', N'Nhà xuất bản Kim Đồng', N'Tài Liệu Học tập', GETDATE(), 10, GETDATE())
GO
--INSERT DOCGIA
INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, SODT, DIACHI, EMAIL) VALUES (N'docgia1',N'1',N'Nguyễn Khánh Linh', GETDATE(), 1, N'0776598805', N'Ai Biết',N'linh14751@gmail.com')
INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, SODT, DIACHI, EMAIL) VALUES (N'docgia2',N'1',N'Lê Nhật Ánh',  GETDATE(), 1, N'0123456788', N'Ai Biết',N'nhatanh@gmail.com')
go
--INSERT MUONSACH
INSERT INTO MuonSach(MADG, MASACH, NGAYMUON, NGAYTRA, XACNHANTRA) VALUES (1,2,GETDATE(),GETDATE(),0)
INSERT INTO MuonSach(MADG, MASACH, NGAYMUON, NGAYTRA, XACNHANTRA) VALUES (2,3,GETDATE(),GETDATE(),0)
INSERT INTO MuonSach(MADG, MASACH, NGAYMUON, NGAYTRA, XACNHANTRA) VALUES (2,3,GETDATE(),GETDATE(),1)



GO
--Login
CREATE PROC USP_Login
@account nvarchar(100), @password nvarchar(100)
as
begin
	select * from TaiKhoan where TAIKHOAN = @account and MATKHAU = @password
end
go
--exec USP_Login N'staff' , N'2'
go
--select * from TaiKhoan where QUYENHAN = 1

select* from  DocGia 

select* from  MuonSach
select* from  TaiKhoan

select* from  Sach
go
--INSERT INTO DocGia(TAIKHOAN, MATKHAU, HOTEN, NGAYSINH, GIOITINH, LOP, DIACHI, EMAIL) VALUES (N'docgia1',N'1',N'Nguyễn Khánh Linh', GETDATE(), 1, N'CTK42', N'Ai Biết',N'linh14751@gmail.com')
go
--update DocGia set	TAIKHOAN = N'docgia2' , MATkHAU = N'1' , HOTEN = N'Lê Nhật Ánh' , NGAYSINH = '2020-11-27' ,GIOITINH = 0 , LOP = N'CTK42' , DIACHI = N'Ai Biết' ,EMAIL = N'nhatanh@gmail.com' where MADG = 5

go
create proc USP_MuonSach
@madg nvarchar(100), @masach nvarchar(100), @ngaymuon date	,@ngaytra date, @status nvarchar(10), @ghichu nvarchar(100)
as
declare @soluong int 
select @soluong = SOLUONG  from Sach
if(@soluong > 0)
begin
	insert into MuonSach(MADG,MASACH, NGAYMUON,NGAYTRA,XACNHANTRA,GHICHU,soluong) values(@madg,@masach,@ngaymuon,@ngaytra,@status,@ghichu,N'1')
	--update sach
	update	Sach set SOLUONG = SOLUONG - 1 where MASACH = @masach
end
go
--exec USP_MuonSach N'madg' , N'masach' , 'ngaymuon' , 'ngaytra' , 'status' , N'ghichu'
--select * from MuonSach where ngaytra < '" + datecurrent + "'
--delete MuonSach where MADG = N'2'