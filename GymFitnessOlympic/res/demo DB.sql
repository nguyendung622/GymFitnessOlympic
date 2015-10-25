USE [master]
GO
/****** Object:  Database [GymFitness]    Script Date: 25/10/2015 8:59:48 AM ******/
CREATE DATABASE [GymFitness] ON  PRIMARY 

GO
ALTER DATABASE [GymFitness] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GymFitness] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GymFitness] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GymFitness] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GymFitness] SET ARITHABORT OFF 
GO
ALTER DATABASE [GymFitness] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GymFitness] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GymFitness] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GymFitness] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GymFitness] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GymFitness] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GymFitness] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GymFitness] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GymFitness] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GymFitness] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GymFitness] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GymFitness] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GymFitness] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GymFitness] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GymFitness] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GymFitness] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GymFitness] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GymFitness] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GymFitness] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GymFitness] SET  MULTI_USER 
GO
ALTER DATABASE [GymFitness] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GymFitness] SET DB_CHAINING OFF 
GO
USE [GymFitness]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 25/10/2015 8:59:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AppConfig]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppConfig](
	[_Key] [nvarchar](50) NOT NULL,
	[Value] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.AppConfig] PRIMARY KEY CLUSTERED 
(
	[_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[UserName] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Role] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.AppUser] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiamGia]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamGia](
	[MaGiamGia] [int] IDENTITY(1,1) NOT NULL,
	[TenGiamGia] [nvarchar](255) NULL,
	[NgayDau] [datetime] NOT NULL,
	[NgayCuoi] [datetime] NOT NULL,
	[PhanTramGiam] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.GiamGia] PRIMARY KEY CLUSTERED 
(
	[MaGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GoiTap]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiTap](
	[MaGoiTap] [int] IDENTITY(1,1) NOT NULL,
	[TenGoiTap] [nvarchar](max) NULL,
	[Gia] [int] NOT NULL,
	[SoThang] [int] NOT NULL,
	[PhongTap_MaPhongTap] [int] NULL,
 CONSTRAINT [PK_dbo.GoiTap] PRIMARY KEY CLUSTERED 
(
	[MaGoiTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HistoryHoiVien]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryHoiVien](
	[ThoiGian] [datetime] NOT NULL,
	[IsCheckin] [bit] NOT NULL,
	[HoiVien_MaHoiVien] [int] NULL,
 CONSTRAINT [PK_dbo.HistoryHoiVien] PRIMARY KEY CLUSTERED 
(
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HistoryNhanVien]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryNhanVien](
	[ThoiGian] [datetime] NOT NULL,
	[IsCheckin] [bit] NOT NULL,
	[NhanVien_MaNhanVien] [int] NULL,
 CONSTRAINT [PK_dbo.HistoryNhanVien] PRIMARY KEY CLUSTERED 
(
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NhanVien_MaNhanVien] [int] NULL,
 CONSTRAINT [PK_dbo.HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoiVien]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiVien](
	[MaHoiVien] [int] IDENTITY(1,1) NOT NULL,
	[TenHoiVien] [nvarchar](50) NOT NULL,
	[NgayDangKy] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
	[Phong_MaPhongTap] [int] NULL,
 CONSTRAINT [PK_dbo.HoiVien] PRIMARY KEY CLUSTERED 
(
	[MaHoiVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[Quyen_MaQuyen] [int] NULL,
	[PhongTap_MaPhongTap] [int] NULL,
 CONSTRAINT [PK_dbo.NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[MaPhieuThu] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[SoTien] [int] NOT NULL,
	[HoiVien_MaHoiVien] [int] NULL,
	[NhanVien_MaNhanVien] [int] NULL,
 CONSTRAINT [PK_dbo.PhieuThu] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongTap]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongTap](
	[MaPhongTap] [int] IDENTITY(1,1) NOT NULL,
	[TenPhongTap] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.PhongTap] PRIMARY KEY CLUSTERED 
(
	[MaPhongTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 25/10/2015 8:59:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](max) NOT NULL,
	[Gia] [bigint] NOT NULL,
	[PhongTap_MaPhongTap] [int] NULL,
 CONSTRAINT [PK_dbo.SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_MaHoaDon]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaHoaDon] ON [dbo].[ChiTietHoaDon]
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaSanPham]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_MaSanPham] ON [dbo].[ChiTietHoaDon]
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PhongTap_MaPhongTap]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_PhongTap_MaPhongTap] ON [dbo].[GoiTap]
(
	[PhongTap_MaPhongTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HoiVien_MaHoiVien]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_HoiVien_MaHoiVien] ON [dbo].[HistoryHoiVien]
(
	[HoiVien_MaHoiVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NhanVien_MaNhanVien]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_NhanVien_MaNhanVien] ON [dbo].[HistoryNhanVien]
(
	[NhanVien_MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NhanVien_MaNhanVien]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_NhanVien_MaNhanVien] ON [dbo].[HoaDon]
(
	[NhanVien_MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Phong_MaPhongTap]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Phong_MaPhongTap] ON [dbo].[HoiVien]
(
	[Phong_MaPhongTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PhongTap_MaPhongTap]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_PhongTap_MaPhongTap] ON [dbo].[NhanVien]
(
	[PhongTap_MaPhongTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Quyen_MaQuyen]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_Quyen_MaQuyen] ON [dbo].[NhanVien]
(
	[Quyen_MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HoiVien_MaHoiVien]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_HoiVien_MaHoiVien] ON [dbo].[PhieuThu]
(
	[HoiVien_MaHoiVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NhanVien_MaNhanVien]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_NhanVien_MaNhanVien] ON [dbo].[PhieuThu]
(
	[NhanVien_MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PhongTap_MaPhongTap]    Script Date: 25/10/2015 8:59:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_PhongTap_MaPhongTap] ON [dbo].[SanPham]
(
	[PhongTap_MaPhongTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GiamGia] ADD  DEFAULT ((0)) FOR [PhanTramGiam]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTietHoaDon_dbo.HoaDon_MaHoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_dbo.ChiTietHoaDon_dbo.HoaDon_MaHoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTietHoaDon_dbo.SanPham_MaSanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_dbo.ChiTietHoaDon_dbo.SanPham_MaSanPham]
GO
ALTER TABLE [dbo].[GoiTap]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GoiTap_dbo.PhongTap_PhongTap_MaPhongTap] FOREIGN KEY([PhongTap_MaPhongTap])
REFERENCES [dbo].[PhongTap] ([MaPhongTap])
GO
ALTER TABLE [dbo].[GoiTap] CHECK CONSTRAINT [FK_dbo.GoiTap_dbo.PhongTap_PhongTap_MaPhongTap]
GO
ALTER TABLE [dbo].[HistoryHoiVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HistoryHoiVien_dbo.HoiVien_HoiVien_MaHoiVien] FOREIGN KEY([HoiVien_MaHoiVien])
REFERENCES [dbo].[HoiVien] ([MaHoiVien])
GO
ALTER TABLE [dbo].[HistoryHoiVien] CHECK CONSTRAINT [FK_dbo.HistoryHoiVien_dbo.HoiVien_HoiVien_MaHoiVien]
GO
ALTER TABLE [dbo].[HistoryNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HistoryNhanVien_dbo.NhanVien_NhanVien_MaNhanVien] FOREIGN KEY([NhanVien_MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HistoryNhanVien] CHECK CONSTRAINT [FK_dbo.HistoryNhanVien_dbo.NhanVien_NhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HoaDon_dbo.NhanVien_NhanVien_MaNhanVien] FOREIGN KEY([NhanVien_MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_dbo.HoaDon_dbo.NhanVien_NhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[HoiVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HoiVien_dbo.PhongTap_Phong_MaPhongTap] FOREIGN KEY([Phong_MaPhongTap])
REFERENCES [dbo].[PhongTap] ([MaPhongTap])
GO
ALTER TABLE [dbo].[HoiVien] CHECK CONSTRAINT [FK_dbo.HoiVien_dbo.PhongTap_Phong_MaPhongTap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NhanVien_dbo.PhongTap_PhongTap_MaPhongTap] FOREIGN KEY([PhongTap_MaPhongTap])
REFERENCES [dbo].[PhongTap] ([MaPhongTap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_dbo.NhanVien_dbo.PhongTap_PhongTap_MaPhongTap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NhanVien_dbo.Quyen_Quyen_MaQuyen] FOREIGN KEY([Quyen_MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_dbo.NhanVien_dbo.Quyen_Quyen_MaQuyen]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PhieuThu_dbo.HoiVien_HoiVien_MaHoiVien] FOREIGN KEY([HoiVien_MaHoiVien])
REFERENCES [dbo].[HoiVien] ([MaHoiVien])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_dbo.PhieuThu_dbo.HoiVien_HoiVien_MaHoiVien]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PhieuThu_dbo.NhanVien_NhanVien_MaNhanVien] FOREIGN KEY([NhanVien_MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_dbo.PhieuThu_dbo.NhanVien_NhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPham_dbo.PhongTap_PhongTap_MaPhongTap] FOREIGN KEY([PhongTap_MaPhongTap])
REFERENCES [dbo].[PhongTap] ([MaPhongTap])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_dbo.SanPham_dbo.PhongTap_PhongTap_MaPhongTap]
GO
USE [master]
GO
ALTER DATABASE [GymFitness] SET  READ_WRITE 
GO
