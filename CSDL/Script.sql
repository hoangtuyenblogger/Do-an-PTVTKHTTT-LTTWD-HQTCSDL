USE [master]
GO
/****** Object:  Database [QuanLy_NhaTro]    Script Date: 6/24/2020 4:50:33 PM ******/
CREATE DATABASE [QuanLy_NhaTro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLy_NhaTro', FILENAME = N'D:\Nam II Dai Hoc Thu Dau Mot\Hoc ki II\Do an PTKTHTTT & Lap trinh tren Windows\CSDL\QuanLy_NhaTro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLy_NhaTro_log', FILENAME = N'D:\Nam II Dai Hoc Thu Dau Mot\Hoc ki II\Do an PTKTHTTT & Lap trinh tren Windows\CSDL\QuanLy_NhaTro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLy_NhaTro] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLy_NhaTro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLy_NhaTro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLy_NhaTro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLy_NhaTro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLy_NhaTro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLy_NhaTro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLy_NhaTro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLy_NhaTro] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLy_NhaTro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLy_NhaTro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLy_NhaTro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLy_NhaTro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLy_NhaTro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLy_NhaTro] SET QUERY_STORE = OFF
GO
USE [QuanLy_NhaTro]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Login]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hoang Tuyen
-- Create date: 2020
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[fn_Login] 
(
	@tk nvarchar(50),
	@mk nvarchar(50)
)
RETURNS bit
AS
BEGIN
	
	DECLARE @Result bit

	-- 
	IF EXISTS
	(
	SELECT *
	FROM TaiKhoan
	WHERE Username = @tk and Password = @mk
	)
	BEGIN
		SET @Result = 1
	END
	ELSE
		BEGIN
			SET @Result = 0
		END
	RETURN @Result
END
GO
/****** Object:  Table [dbo].[CTDICHVU]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDICHVU](
	[MaCTDV] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [nvarchar](50) NOT NULL,
	[MaDV] [nvarchar](20) NOT NULL,
	[SoLuong] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CTDICHVU] PRIMARY KEY CLUSTERED 
(
	[MaCTDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGKYTHUEPHONG]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKYTHUEPHONG](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[MaKhach] [int] NULL,
	[MaPhong] [nvarchar](50) NULL,
	[NgayThue] [date] NULL,
	[NgayVaoO] [date] NULL,
	[TienDatCoc] [numeric](18, 0) NULL,
 CONSTRAINT [PK_QUANLITHUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nvarchar](20) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DonGia] [numeric](18, 0) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaTien]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaTien](
	[MaGiaTien] [nvarchar](50) NOT NULL,
	[MaKV] [nvarchar](50) NULL,
	[GiaTien] [numeric](18, 0) NULL,
 CONSTRAINT [PK_BangGiaTien] PRIMARY KEY CLUSTERED 
(
	[MaGiaTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHTRO]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHTRO](
	[MaKhach] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgheNghiep] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHTRO] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUVUC](
	[MaKV] [nvarchar](50) NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[TANG] [nvarchar](50) NULL,
	[DAY] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGTRO]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGTRO](
	[MaPhong] [nvarchar](50) NOT NULL,
	[MaKV] [nvarchar](50) NULL,
	[MaGiaTien] [nvarchar](50) NULL,
	[TenPhong] [nvarchar](50) NULL,
	[SLToiDa] [int] NULL,
	[TrangThai] [bit] NULL,
	[SoNguoiHienTai] [int] NULL,
 CONSTRAINT [PK_PHONGTRO] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLTHUTIEN]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLTHUTIEN](
	[MaThu] [nvarchar](20) NOT NULL,
	[MaDV] [nvarchar](20) NULL,
	[MaPhong] [nvarchar](50) NULL,
	[MaKhach] [int] NULL,
	[GiaDien] [numeric](18, 0) NULL,
	[GiaNuoc] [numeric](18, 0) NULL,
	[GiaInternet] [numeric](18, 0) NULL,
	[TongGia] [numeric](18, 0) NULL,
 CONSTRAINT [PK_QUANLITHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRAPHONG]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRAPHONG](
	[MaTraPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaKhach] [int] NULL,
	[NgayTra] [datetime] NULL,
	[TienTraLai] [numeric](18, 0) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRAPHONG] PRIMARY KEY CLUSTERED 
(
	[MaTraPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv1', N'Điện', CAST(3000 AS Numeric(18, 0)), N'Kg')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv2', N'Nước', CAST(4000 AS Numeric(18, 0)), N'Khối')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv3', N'Internet', CAST(30000 AS Numeric(18, 0)), N'Gói')
INSERT [dbo].[GiaTien] ([MaGiaTien], [MaKV], [GiaTien]) VALUES (N'gt1', N'kv1', CAST(1000000 AS Numeric(18, 0)))
INSERT [dbo].[GiaTien] ([MaGiaTien], [MaKV], [GiaTien]) VALUES (N'gt2', N'kv2', CAST(2000000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[KHACHTRO] ON 

INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (1, N'p1', N'Hoàng Tuyến', N'0347133942', N'012', N'Nam', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (18, N'p2', N'Hoàng Kim Tuân', N'2131', N'1232', N'Nam', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (19, NULL, N'Tuyết Hoa Xinh đẹp', N'35123', N'1', N'Nữ', N'Sinh Viên')
SET IDENTITY_INSERT [dbo].[KHACHTRO] OFF
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'kv1', N'khu vực 1', N'1', N'1')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'kv2', N'khu vực 2', N'1', N'2')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'Lau1', N'lầu 1', N'1', N'1')
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p1', N'kv1', N' gt1', N'Phòng 1', 3, 1, 2)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p2', N'kv1', N'gt1', N'Phòng 2', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p3', N'kv1', N'gt1', N'Phòng 3', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p4', N'kv1', N'gt1', N'Phòng 4', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'P5', N'kv1', N'gt1', N'Phong 5', 3, 0, 0)
INSERT [dbo].[TaiKhoan] ([Username], [Password]) VALUES (N'admin', N'1')
INSERT [dbo].[TaiKhoan] ([Username], [Password]) VALUES (N'hoangtuyen', N'1')
ALTER TABLE [dbo].[QLTHUTIEN] ADD  CONSTRAINT [DF_QLTHUTIEN_GiaDien]  DEFAULT ((50000)) FOR [GiaDien]
GO
ALTER TABLE [dbo].[QLTHUTIEN] ADD  CONSTRAINT [DF_QLTHUTIEN_GiaNuoc]  DEFAULT ((50000)) FOR [GiaNuoc]
GO
ALTER TABLE [dbo].[QLTHUTIEN] ADD  CONSTRAINT [DF_QLTHUTIEN_GiaInternet]  DEFAULT ((30000)) FOR [GiaInternet]
GO
ALTER TABLE [dbo].[CTDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CTDICHVU_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTDICHVU] CHECK CONSTRAINT [FK_CTDICHVU_DichVu]
GO
ALTER TABLE [dbo].[CTDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CTDICHVU_PHONGTRO] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGTRO] ([MaPhong])
GO
ALTER TABLE [dbo].[CTDICHVU] CHECK CONSTRAINT [FK_CTDICHVU_PHONGTRO]
GO
ALTER TABLE [dbo].[CTDICHVU]  WITH CHECK ADD  CONSTRAINT [khoa_ngoai_1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTDICHVU] CHECK CONSTRAINT [khoa_ngoai_1]
GO
ALTER TABLE [dbo].[DANGKYTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_DANGKYTHUEPHONG_KHACHTRO] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACHTRO] ([MaKhach])
GO
ALTER TABLE [dbo].[DANGKYTHUEPHONG] CHECK CONSTRAINT [FK_DANGKYTHUEPHONG_KHACHTRO]
GO
ALTER TABLE [dbo].[DANGKYTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_DANGKYTHUEPHONG_KHACHTRO1] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACHTRO] ([MaKhach])
GO
ALTER TABLE [dbo].[DANGKYTHUEPHONG] CHECK CONSTRAINT [FK_DANGKYTHUEPHONG_KHACHTRO1]
GO
ALTER TABLE [dbo].[GiaTien]  WITH CHECK ADD  CONSTRAINT [FK_GiaTien_KHUVUC] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
GO
ALTER TABLE [dbo].[GiaTien] CHECK CONSTRAINT [FK_GiaTien_KHUVUC]
GO
ALTER TABLE [dbo].[KHACHTRO]  WITH CHECK ADD  CONSTRAINT [FK_KHACHTRO_PHONGTRO] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGTRO] ([MaPhong])
GO
ALTER TABLE [dbo].[KHACHTRO] CHECK CONSTRAINT [FK_KHACHTRO_PHONGTRO]
GO
ALTER TABLE [dbo].[PHONGTRO]  WITH CHECK ADD  CONSTRAINT [FK_PHONGTRO_KHUVUC] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KHUVUC] ([MaKV])
GO
ALTER TABLE [dbo].[PHONGTRO] CHECK CONSTRAINT [FK_PHONGTRO_KHUVUC]
GO
ALTER TABLE [dbo].[QLTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_QLTHUTIEN_KHACHTRO1] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACHTRO] ([MaKhach])
GO
ALTER TABLE [dbo].[QLTHUTIEN] CHECK CONSTRAINT [FK_QLTHUTIEN_KHACHTRO1]
GO
ALTER TABLE [dbo].[QLTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_QLTHUTIEN_PHONGTRO] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGTRO] ([MaPhong])
GO
ALTER TABLE [dbo].[QLTHUTIEN] CHECK CONSTRAINT [FK_QLTHUTIEN_PHONGTRO]
GO
ALTER TABLE [dbo].[TRAPHONG]  WITH CHECK ADD  CONSTRAINT [FK_TRAPHONG_KHACHTRO] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACHTRO] ([MaKhach])
GO
ALTER TABLE [dbo].[TRAPHONG] CHECK CONSTRAINT [FK_TRAPHONG_KHACHTRO]
GO
/****** Object:  StoredProcedure [dbo].[sp_DANGKY_THUEPHONG]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HOANG KIM TUYEN
-- Create date: 30/05/2020
-- Description:	ĐĂNG KÍ THUÊ PHÒNG
-- exec sp_DANGKY_THUEPHONG N'',N'',N'',N'',N''
-- =============================================
CREATE PROCEDURE [dbo].[sp_DANGKY_THUEPHONG] 
	@makhach nvarchar(50),
	@maphong nvarchar(50),
	@ngaythue date,
	@ngayvao date,
	@tiendatcoc numeric(18, 0)
AS
BEGIN
	INSERT INTO DANGKYTHUEPHONG(MaKhach,MaPhong,NgayThue,NgayVaoO,TienDatCoc) VALUES(@makhach,@maphong,@ngaythue,@ngayvao,@tiendatcoc)
	UPDATE PHONGTRO SET TrangThai = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SoNguoiHienTai]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tuyen
-- Create date: 2020
-- Description:	Kiem tra so nguoi hien tai
-- exec sp_SoNguoiHienTai 'p1'
-- =============================================
CREATE PROCEDURE [dbo].[sp_SoNguoiHienTai] 
	@ma_phong nvarchar(50)
AS
BEGIN
	SELECT SoNguoiHienTai FROM PHONGTRO WHERE MaPhong = @ma_phong
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SUA_THONGTIN_KHACHTRO]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hoang Tuyen
-- Create date: 2020
-- Description:	Sửa thông tin khách trọ
-- exec sp_SUA_THONGTIN_KHACHTRO N'Thu Trang',N'02342344','5',N'Nữ',N'Sinh viên'
-- =============================================
CREATE PROCEDURE [dbo].[sp_SUA_THONGTIN_KHACHTRO] 
	@hoten nvarchar(50),
	@sdt nvarchar(50),
	@cmnd nvarchar(50),
	@gt nvarchar(10),
	@nghenghiep nvarchar(50)
AS
BEGIN
	-- Kiểm tra cmnd
	IF EXISTS 
	(
		SELECT CMND
		FROM KHACHTRO
		WHERE CMND = @cmnd
	)
	-- Sửa thông tin khách trọ 
	BEGIN
		UPDATE KHACHTRO 
		SET HoTen = @hoten,
			SDT = @sdt,
			CMND = @cmnd,
			GioiTinh = @gt,
			NgheNghiep = @nghenghiep
		WHERE CMND = @cmnd
			PRINT N'Đã sửa thành công'
	END

	ELSE
		BEGIN
			PRINT N'Có lỗi!'
		END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_THEM_THONGTIN_KHACHTRO]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HOANG KIM TUYEN
-- Create date: 30/05/2020
-- exec sp_THEM_THONGTIN_KHACHTRO N'',N'',N'',N'',N''
-- =============================================
CREATE PROCEDURE [dbo].[sp_THEM_THONGTIN_KHACHTRO] 
	@hoten nvarchar(50),
	@sdt nvarchar(50),
	@cmnd nvarchar(50),
	@gt nvarchar(10),
	@nghenghiep nvarchar(50)
AS
BEGIN
	IF NOT EXISTS -- Nếu không tồn tại thì thêm vào
	(
	SELECT CMND
	FROM KHACHTRO
	WHERE CMND = @cmnd
	)
	BEGIN
		INSERT INTO KHACHTRO(HoTen,SDT,CMND,GioiTinh,NgheNghiep) VALUES(@hoten,@sdt,@cmnd,@gt,@nghenghiep)
	END

	ELSE -- Nếu đã tồn tại 
		BEGIN
		 PRINT N'Đã có người có số CMND này!'
		END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XOA_THONGTIN_KHACHTRO]    Script Date: 6/24/2020 4:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hoàng Tuyến
-- Create date: 2020
-- Description:	Xóa khách trọ
-- exec 
-- =============================================
CREATE PROCEDURE [dbo].[sp_XOA_THONGTIN_KHACHTRO] 
	@cmnd nvarchar(50)
AS
BEGIN
	DELETE FROM KHACHTRO WHERE CMND = @cmnd
END
GO
USE [master]
GO
ALTER DATABASE [QuanLy_NhaTro] SET  READ_WRITE 
GO
