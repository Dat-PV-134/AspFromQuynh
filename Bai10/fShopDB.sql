USE [master]
GO
--Tạo cơ sở dữ liệu
CREATE DATABASE [fShopDB]
GO
USE [fShopDB]
GO
--Tạo bảng
CREATE TABLE [dbo].[Hang](
[MaHang] [char](10) NOT NULL,
[MaNCC] [char](10) NOT NULL,
[TenHang] [nvarchar](255) NOT NULL,
[Gia] [decimal](8, 2) NULL,
[LuongCo] [decimal](8, 2) NOT NULL,
[MoTa] [nvarchar](1000) NULL,
[ChietKhau] [decimal](8, 2) NULL,
[HinhAnh] [nvarchar](100) NULL,
CONSTRAINT [PKh_Hang] PRIMARY KEY CLUSTERED
(
[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[nguoidung](
[manguoidung] [int] IDENTITY(1,1) NOT NULL,
[hoten] [nvarchar](30) NOT NULL,
[matkhau] [nvarchar](50) NOT NULL,
[email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED
([manguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Nha_CC](
[MaNCC] [char](10) NOT NULL,
[TenNCC] [nvarchar](50) NOT NULL,
[DiaChi] [nvarchar](50) NULL,
[DienThoai] [char](15) NULL,
[Email] [nvarchar](50) NULL,
CONSTRAINT [PK_Nha_CC] PRIMARY KEY CLUSTERED
(
[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Chèn dữ liệu cho các bảng
--Tạo các khóa ngoài
ALTER TABLE [dbo].[Hang] WITH CHECK ADD CONSTRAINT [FKh_Hang_Nha_CC] FOREIGN
KEY([MaNCC])
REFERENCES [dbo].[Nha_CC] ([MaNCC])
GO
ALTER TABLE [dbo].[Hang] CHECK CONSTRAINT [FKh_Hang_Nha_CC]
GO
USE [master]
GO
Select * From Hang
