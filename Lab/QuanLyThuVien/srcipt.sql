USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 12/8/2020 10:47:51 AM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MADG] [int] IDENTITY(1,1) NOT NULL,
	[TAIKHOAN] [nvarchar](100) NULL,
	[MATKHAU] [nvarchar](100) NULL,
	[HOTEN] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [bit] NULL,
	[SODT] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[GHICHU] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MADG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonSach](
	[MADG] [int] NULL,
	[MASACH] [int] NULL,
	[SOPHIEUMUON] [int] IDENTITY(1,1) NOT NULL,
	[NGAYMUON] [date] NULL,
	[NGAYTRA] [date] NULL,
	[XACNHANTRA] [int] NULL,
	[GHICHU] [nvarchar](100) NULL,
	[SOLUONG] [nvarchar](100) NULL,
	[TIENPHAT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SOPHIEUMUON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MASACH] [int] IDENTITY(1,1) NOT NULL,
	[TENSACH] [nvarchar](50) NULL,
	[TENTG] [nvarchar](100) NULL,
	[TENNXB] [nvarchar](100) NULL,
	[TENLV] [nvarchar](100) NULL,
	[NAMXB] [date] NULL,
	[SOLUONG] [int] NULL,
	[NGAYNHAP] [date] NULL,
	[GHICHU] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TAIKHOAN] [nvarchar](100) NOT NULL,
	[MATKHAU] [nvarchar](100) NOT NULL,
	[TEN] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[EMAIL] [nvarchar](100) NULL,
	[SODT] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DocGia] ON 

INSERT [dbo].[DocGia] ([MADG], [TAIKHOAN], [MATKHAU], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [DIACHI], [EMAIL], [GHICHU]) VALUES (1, N'docgia1', N'1', N'Nguyễn Văn A', CAST(N'2020-12-07' AS Date), 1, N'0776598805', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'vana@gmail.com', NULL)
INSERT [dbo].[DocGia] ([MADG], [TAIKHOAN], [MATKHAU], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [DIACHI], [EMAIL], [GHICHU]) VALUES (2, N'docgia2', N'1', N'Lê Nhật Ánh', CAST(N'2020-12-07' AS Date), 1, N'0123456788', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'nhatanh@gmail.com', NULL)
INSERT [dbo].[DocGia] ([MADG], [TAIKHOAN], [MATKHAU], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [DIACHI], [EMAIL], [GHICHU]) VALUES (3, N'docgia3', N'1', N'Nguyễn Văn B', CAST(N'1997-01-11' AS Date), 1, N'0123455667', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'vanb@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[DocGia] OFF
GO
SET IDENTITY_INSERT [dbo].[MuonSach] ON 

INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (1, 2, 1, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (1, 3, 2, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (1, 1, 3, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 1, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (1, 4, 4, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 1, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (2, 4, 5, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (2, 4, 6, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (2, 2, 7, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 1, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (2, 3, 8, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-08' AS Date), 1, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (3, 1, 9, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-23' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (3, 2, 10, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-23' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (3, 2, 11, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-23' AS Date), 0, N'', N'1', 0)
INSERT [dbo].[MuonSach] ([MADG], [MASACH], [SOPHIEUMUON], [NGAYMUON], [NGAYTRA], [XACNHANTRA], [GHICHU], [SOLUONG], [TIENPHAT]) VALUES (3, 3, 12, CAST(N'2020-12-07' AS Date), CAST(N'2020-12-23' AS Date), 1, N'', N'1', 0)
SET IDENTITY_INSERT [dbo].[MuonSach] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([MASACH], [TENSACH], [TENTG], [TENNXB], [TENLV], [NAMXB], [SOLUONG], [NGAYNHAP], [GHICHU]) VALUES (1, N'Đắc nhân tâm', N'Dale Carnegie', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'Self-Help', CAST(N'2016-03-01' AS Date), 9, CAST(N'2020-12-07' AS Date), N'')
INSERT [dbo].[Sach] ([MASACH], [TENSACH], [TENTG], [TENNXB], [TENLV], [NAMXB], [SOLUONG], [NGAYNHAP], [GHICHU]) VALUES (2, N'Bạn đắt giá bao nhiêu?', N'Vãn Tình', N'Nhà Xuất Bản Thế Giới', N'Truyện ngắn – Tản văn', CAST(N'2018-01-01' AS Date), 7, CAST(N'2020-12-07' AS Date), NULL)
INSERT [dbo].[Sach] ([MASACH], [TENSACH], [TENTG], [TENNXB], [TENLV], [NAMXB], [SOLUONG], [NGAYNHAP], [GHICHU]) VALUES (3, N'Đọc Vị Bất Kỳ Ai - Để Không Bị Lừa Dối Và Lợi Dụng', N'David J.Lieberman', N'Nhà Xuất Bản Lao Động - Xã Hội', N'Tâm lý - Kỹ Năng sống', CAST(N'2018-01-01' AS Date), 9, CAST(N'2020-12-07' AS Date), NULL)
INSERT [dbo].[Sach] ([MASACH], [TENSACH], [TENTG], [TENNXB], [TENLV], [NAMXB], [SOLUONG], [NGAYNHAP], [GHICHU]) VALUES (4, N'Tuổi Trẻ Đáng Giá Bao Nhiêu', N'Rosie Nguyễn', N'Nhà Xuất Bản Hội Nhà Văn', N'Tâm Lý - Kỹ Năng Sống', CAST(N'2017-01-01' AS Date), 8, CAST(N'2020-12-07' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
INSERT [dbo].[TaiKhoan] ([TAIKHOAN], [MATKHAU], [TEN], [DIACHI], [EMAIL], [SODT], [NGAYSINH], [GIOITINH]) VALUES (N'linh', N'1', N'Nguyễn Khánh Linh', N'01, Phù Đổng Thiên Vương, P9, Đà Lạt', N'khanhlinh1475@gmail.com', N'0776598805', CAST(N'2000-10-08' AS Date), 1)
GO
ALTER TABLE [dbo].[DocGia] ADD  DEFAULT (NULL) FOR [GHICHU]
GO
ALTER TABLE [dbo].[MuonSach] ADD  DEFAULT ((0)) FOR [XACNHANTRA]
GO
ALTER TABLE [dbo].[MuonSach] ADD  DEFAULT (NULL) FOR [GHICHU]
GO
ALTER TABLE [dbo].[MuonSach] ADD  DEFAULT (NULL) FOR [SOLUONG]
GO
ALTER TABLE [dbo].[MuonSach] ADD  DEFAULT ((0)) FOR [TIENPHAT]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT ((0)) FOR [SOLUONG]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT (NULL) FOR [GHICHU]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD FOREIGN KEY([MADG])
REFERENCES [dbo].[DocGia] ([MADG])
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD FOREIGN KEY([MASACH])
REFERENCES [dbo].[Sach] ([MASACH])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDSMuonTraByNgayMuon]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------
create proc [dbo].[USP_GetDSMuonTraByNgayMuon]
@datefrom date , @dateto date
as
begin
		select * from MuonSach where XACNHANTRA = 1 and NgayMuon between @datefrom and @dateto
end

GO
/****** Object:  StoredProcedure [dbo].[USP_GetDSMuonTraByNgayTra]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------
create proc [dbo].[USP_GetDSMuonTraByNgayTra]
@datefrom date , @dateto date
as
begin
		select * from MuonSach where XACNHANTRA = 1 and NGAYTRA between @datefrom and @dateto
end

GO
/****** Object:  StoredProcedure [dbo].[USP_GetListMuonSachByDateBorrow]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------
create proc [dbo].[USP_GetListMuonSachByDateBorrow]
@datefrom date	, @dateto date
as
begin
	select * from MuonSach where NGAYMUON between @datefrom and @dateto and XACNHANTRA = N'1'
end

GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Login
-----------------------------------------------------------------------
CREATE PROC [dbo].[USP_Login]
@account nvarchar(100), @password nvarchar(100)
as
begin
	select * from TaiKhoan where TAIKHOAN = @account and MATKHAU = @password
end

GO
/****** Object:  StoredProcedure [dbo].[USP_MuonSach]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------------------
create proc [dbo].[USP_MuonSach]
@madg int, @masach int , @ngaymuon date , @ngaytra date , @status int , @ghichu nvarchar(100)
as
declare @soluong int 
select @soluong = SOLUONG  from Sach
if(@soluong > 0)
	begin
		insert into MuonSach(MADG,MASACH, NGAYMUON,NGAYTRA,XACNHANTRA,GHICHU,soluong) values(@madg , @masach , @ngaymuon , @ngaytra , @status , @ghichu , N'1')
		--update sach
		update	Sach set SOLUONG = SOLUONG - 1 where MASACH = @masach
	end

GO
/****** Object:  StoredProcedure [dbo].[USP_TraSach]    Script Date: 12/8/2020 10:47:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------
create proc [dbo].[USP_TraSach]
@sophieumuon int
as
declare @soluong int, @masach int
select @masach = MASACH from MuonSach where SOPHIEUMUON = @sophieumuon
select @soluong = SOLUONG  from Sach where MASACH = @masach
	begin
	--update MuonSach
		update MuonSach set XacNhanTra = N'1' where SoPhieuMuon = @sophieumuon
		--update sach
		update	Sach set SOLUONG = SOLUONG + 1 where MASACH = @masach
	end

GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
