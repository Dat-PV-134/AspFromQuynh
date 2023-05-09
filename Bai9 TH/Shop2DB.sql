USE [master]
GO
--Tạo cơ sở dữ liệu
CREATE DATABASE [shop2db]
GO
USE [shop2db]
GO
--Tạo bảng
CREATE TABLE [dbo].[account](
[id] [int] IDENTITY(1,1) NOT NULL,
[username] [nvarchar](50) NOT NULL,
[fullname] [nvarchar](30) NOT NULL,
[phone] [nvarchar](20) NOT NULL,
[password] [nvarchar](30) NOT NULL,
[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[category](
[catid] [int] IDENTITY(1,1) NOT NULL,
[catname] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED
(
[catid] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[product](
[proid] [int] IDENTITY(1,1) NOT NULL,
[proname] [nvarchar](45) NOT NULL,
[price] [decimal](10, 2) NOT NULL,
[stock] [decimal](10, 2) NOT NULL,
[image] [nvarchar](100) NULL,
[description] [ntext] NULL,
[catid] [int] NOT NULL,
PRIMARY KEY CLUSTERED
(
[proid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
--Chèn dữ liệu cho các bảng
--Tạo các khóa ngoài
ALTER TABLE [dbo].[account] ADD UNIQUE NONCLUSTERED
(
[username] ASC
)ON [PRIMARY]
GO
ALTER TABLE [dbo].[product] WITH CHECK ADD FOREIGN KEY([catid])
REFERENCES [dbo].[category] ([catid])
GO
USE [master]
GO