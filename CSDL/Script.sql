USE [QuanLy_NhaTro]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Login]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[KHACHTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[DANGKYTHUEPHONG]    Script Date: 7/6/2020 4:37:05 PM ******/
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
	[TienDatCoc] [money] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_QUANLITHUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
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
	[SoNguoiHienTai] [smallint] NOT NULL,
 CONSTRAINT [PK_PHONGTRO] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_THONGTIN_KHACHTRO_PHONGTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_THONGTIN_KHACHTRO_PHONGTRO]
AS
SELECT        dbo.DANGKYTHUEPHONG.MaKhach, dbo.KHACHTRO.HoTen, dbo.KHACHTRO.GioiTinh, dbo.KHACHTRO.SDT, dbo.KHACHTRO.CMND, dbo.KHACHTRO.MaPhong, dbo.PHONGTRO.TenPhong, 
                         dbo.DANGKYTHUEPHONG.NgayVaoO
FROM            dbo.DANGKYTHUEPHONG INNER JOIN
                         dbo.KHACHTRO ON dbo.DANGKYTHUEPHONG.MaKhach = dbo.KHACHTRO.MaKhach AND dbo.DANGKYTHUEPHONG.MaKhach = dbo.KHACHTRO.MaKhach INNER JOIN
                         dbo.PHONGTRO ON dbo.KHACHTRO.MaPhong = dbo.PHONGTRO.MaPhong
WHERE        (dbo.DANGKYTHUEPHONG.TrangThai = 1) AND (dbo.PHONGTRO.TrangThai = 1)
GO
/****** Object:  View [dbo].[view_PHONG_DANGDUOC_THUE]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[view_PHONG_DANGDUOC_THUE]
AS
SELECT MaPhong, TenPhong FROM PHONGTRO WHERE TrangThai = 1
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  View [dbo].[view_DICHVU]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DICHVU]
as
SELECT MaDV, TenDV, DonGia  FROM DichVu
GO
/****** Object:  View [dbo].[view_TIENCOC_CHUATRA]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_TIENCOC_CHUATRA]
as
select TienDatCoc, MaKhach from DANGKYTHUEPHONG where TrangThai = 1
GO
/****** Object:  Table [dbo].[CTDICHVU]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[GiaTien]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[KHUVUC]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[QLTHUTIEN]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLTHUTIEN](
	[MaThu] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  Table [dbo].[TRAPHONG]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRAPHONG](
	[MaTraPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaPhong] [nvarchar](50) NULL,
	[MaKhach] [int] NULL,
	[NgayTra] [datetime] NULL,
	[TienTraLai] [money] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRAPHONG] PRIMARY KEY CLUSTERED 
(
	[MaTraPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DANGKYTHUEPHONG] ON 

INSERT [dbo].[DANGKYTHUEPHONG] ([MaPhieuThue], [MaKhach], [MaPhong], [NgayThue], [NgayVaoO], [TienDatCoc], [TrangThai]) VALUES (55, 1, N'p6', CAST(N'2020-07-02' AS Date), CAST(N'2020-07-02' AS Date), 500000.0000, 0)
SET IDENTITY_INSERT [dbo].[DANGKYTHUEPHONG] OFF
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv1', N'Điện', CAST(3000 AS Numeric(18, 0)), N'Kg')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv2', N'Nước', CAST(4000 AS Numeric(18, 0)), N'Khối')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [DonViTinh]) VALUES (N'dv3', N'Internet', CAST(30000 AS Numeric(18, 0)), N'Gói')
INSERT [dbo].[GiaTien] ([MaGiaTien], [MaKV], [GiaTien]) VALUES (N'gt1', N'kv1', CAST(1000000 AS Numeric(18, 0)))
INSERT [dbo].[GiaTien] ([MaGiaTien], [MaKV], [GiaTien]) VALUES (N'gt2', N'kv2', CAST(2000000 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[KHACHTRO] ON 

INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (1, NULL, N'Hoàng Tuyến', N'0347133942', N'012', N'Nam', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (20, NULL, N'Mai Thị Nga', N'123', N'442342', N'Nữ', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (22, NULL, N'Nguyễn Đức Long', N'0131', N'41231233', N'Nam ', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (23, NULL, N'Quốc Dũng', N'223', N'3123123', N'Nam', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (24, NULL, N'Thu Trang', N'002313', N'4234232', N'Nữ', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (25, NULL, N'Thu Thảo', N'9481293', N'423231948', N'Nữ', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (26, NULL, N'Quốc Cường', N'96787620', N'4123129003', N'Nam', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (27, NULL, N'Hạnh Dung', N'49218410', N'412313300928', N'Nữ', N'Sinh Viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (28, NULL, N'Ngọc Trinh', N'0123456789', N'0977312', N'Nữ', N'Diễn viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (29, NULL, N'Minh Hằng', N'98i3698360', N'107084093', N'Nữ', N'Người mẫu')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (30, NULL, N'Trấn Thành', N'02369587135', N'23147343234', N'Nam', N'MC')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (31, NULL, N'Hariwon', N'42343467', N'23467687', N'Nữ', N'Diễn viên')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (32, NULL, N'Nguyễn Thanh Tùng', N'12335516', N'125125613', N'Nam', N'Ca sĩ')
INSERT [dbo].[KHACHTRO] ([MaKhach], [MaPhong], [HoTen], [SDT], [CMND], [GioiTinh], [NgheNghiep]) VALUES (33, NULL, N'Chi Pu', N'2162623254', N'623452', N'Nữ', N'Ca sĩ')
SET IDENTITY_INSERT [dbo].[KHACHTRO] OFF
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'kv1', N'khu vực 1', N'1', N'1')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'kv2', N'khu vực 2', N'1', N'2')
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [TANG], [DAY]) VALUES (N'Lau1', N'lầu 1', N'1', N'1')
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p1', N'kv1', N' gt1', N'Phòng 1', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p2', N'kv1', N'gt1', N'Phòng 2', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p3', N'kv1', N'gt1', N'Phòng 3', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p4', N'kv1', N'gt1', N'Phòng 4', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p5', N'kv1', N'gt1', N'Phòng 5', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p6', N'kv1', N'gt1', N'Phòng 6', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p7', N'kv1', N'GT1', N'Phòng 7', 3, 0, 0)
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaKV], [MaGiaTien], [TenPhong], [SLToiDa], [TrangThai], [SoNguoiHienTai]) VALUES (N'p8', N'kv1', N'GT1', N'Phòng 8', 3, 0, 0)
INSERT [dbo].[TaiKhoan] ([Username], [Password]) VALUES (N'admin', N'1')
INSERT [dbo].[TaiKhoan] ([Username], [Password]) VALUES (N'hoangtuyen', N'1')
SET IDENTITY_INSERT [dbo].[TRAPHONG] ON 

INSERT [dbo].[TRAPHONG] ([MaTraPhong], [MaPhong], [MaKhach], [NgayTra], [TienTraLai], [GhiChu]) VALUES (12, N'p6', 1, CAST(N'2020-07-06T00:00:00.000' AS DateTime), 500000.0000, N'Tuyến trả lại phòng nè hihi')
SET IDENTITY_INSERT [dbo].[TRAPHONG] OFF
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
ALTER TABLE [dbo].[TRAPHONG]  WITH CHECK ADD  CONSTRAINT [khoa_ngoai] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGTRO] ([MaPhong])
GO
ALTER TABLE [dbo].[TRAPHONG] CHECK CONSTRAINT [khoa_ngoai]
GO
/****** Object:  StoredProcedure [dbo].[sp_DANGKY_THUEPHONG]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HOANG KIM TUYEN
-- Create date: 30/05/2020
-- Description:	ĐĂNG KÍ THUÊ PHÒNG
-- exec sp_DANGKY_THUEPHONG 1,'p1','7/2/2020','7/2/2020',500000
-- =============================================
CREATE PROCEDURE [dbo].[sp_DANGKY_THUEPHONG] 
	@makhach int,
	@maphong nvarchar(50),
	@ngaythue date,
	@ngayvao date,
	@tiendatcoc money
AS
BEGIN
		INSERT INTO DANGKYTHUEPHONG(MaKhach,MaPhong,NgayThue,NgayVaoO,TienDatCoc,TrangThai) 
								VALUES(@makhach,@maphong,@ngaythue,@ngayvao,@tiendatcoc,1)

		-- CẬP NHẬT THÔNG TIN KHÁCH TRỌ, PHÒNG TRỌ
		UPDATE PHONGTRO SET TrangThai = 1, SoNguoiHienTai = SoNguoiHienTai + 1 WHERE PHONGTRO.MaPhong = @maphong
		UPDATE KHACHTRO SET MaPhong = @maphong WHERE MaKhach = @makhach
		
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RENEW]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TUYEN
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_RENEW] 

AS
BEGIN
	UPDATE DANGKYTHUEPHONG SET TrangThai = 0
	UPDATE PHONGTRO SET TrangThai = 0, SoNguoiHienTai = 0
	UPDATE KHACHTRO SET MaPhong = NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SoNguoiHienTai]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TUYẾN
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_SoNguoiHienTai] 
	-- Add the parameters for the stored procedure here
	@ma_phong nvarchar(50)
AS
BEGIN
	SELECT SoNguoiHienTai FROM PHONGTRO WHERE MaPhong = @ma_phong
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SoNguoiToiDa]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TUYẾN
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_SoNguoiToiDa] 
	-- Add the parameters for the stored procedure here
	@ma_phong nvarchar(50)
AS
BEGIN
	SELECT SLToiDa FROM PHONGTRO WHERE MaPhong = @ma_phong
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SUA_THONGTIN_KHACHTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_THEM_THONGTIN_KHACHTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TRAPHONG]    Script Date: 7/6/2020 4:37:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HOANG TUYEN
-- Create date: 
-- Description:	TRẢ PHÒNG
-- exec sp_TRAPHONG 1,500000,'6/7/2020',N'Tuyến  trả phòng hehe'
-- =============================================
CREATE PROCEDURE [dbo].[sp_TRAPHONG]
	@ma_phong nvarchar(50),
	@ma_khach int,
	@ngay_tra datetime,
	@tien_tralai money,
	@ghi_Chu nvarchar(50)
AS
BEGIN
	INSERT INTO TRAPHONG(MaPhong,MaKhach,NgayTra,TienTraLai,GhiChu) 
				values(@ma_phong,@ma_khach,@ngay_tra,@tien_tralai,@ghi_Chu)
	-- CẬP NHẬT LẠI TRẠNG THÁI SAU KHI TRẢ PHÒNG
	UPDATE KHACHTRO SET MaPhong = NULL WHERE MaKhach = @ma_khach
	UPDATE PHONGTRO SET TrangThai = 0, SoNguoiHienTai = 0 WHERE MaPhong = @ma_phong
	UPDATE DANGKYTHUEPHONG SET TrangThai = 0 WHERE MaPhong = @ma_phong
	

END
-- exec sp_TRAPHONG p1,1,'7/6/2020',500000,N'Tuyến trả lại phòng nè hihi'
GO
/****** Object:  StoredProcedure [dbo].[sp_XOA_THONGTIN_KHACHTRO]    Script Date: 7/6/2020 4:37:05 PM ******/
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[11] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DANGKYTHUEPHONG"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 232
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KHACHTRO"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 234
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "PHONGTRO"
            Begin Extent = 
               Top = 37
               Left = 515
               Bottom = 239
               Right = 691
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_THONGTIN_KHACHTRO_PHONGTRO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_THONGTIN_KHACHTRO_PHONGTRO'
GO
