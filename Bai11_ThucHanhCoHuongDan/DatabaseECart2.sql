-- DROP DATABASE [ECartDB2]
USE [master]
GO
/****** Object:  Database [ECartDB2]    Script Date: 13/11/2021 8:28:37 AM ******/
CREATE DATABASE [ECartDB2]  
GO
USE [ECartDB2]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[Adminid] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Typeacc] [tinyint] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Adminid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Categoryid] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](150) NOT NULL,
	[MetaTitle] [varchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Categoryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Orderdetailid] [int] IDENTITY(1,1) NOT NULL,
	[Orderid] [int] NOT NULL,
	[Pid] [int] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Orderdetailid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[Orderid] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[OrderNumber] [varchar](50) NULL,
	[Status] [tinyint] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Tel] [varchar](10) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Pid] [int] IDENTITY(1,1) NOT NULL,
	[Categoryid] [int] NOT NULL,
	[ProdName] [nvarchar](250) NOT NULL,
	[MetaTitle] [varchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[ImagePath] [nvarchar](550) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 13/11/2021 8:28:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Userid] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

GO
INSERT [dbo].[Admin] ([Adminid], [Username], [Password], [Typeacc], [Name], [Phone], [Address], [Email], [Status]) VALUES (1, N'1', N'1', 1, N'1', N'1          ', N'1', N'1', 0)
GO
INSERT [dbo].[Admin] ([Adminid], [Username], [Password], [Typeacc], [Name], [Phone], [Address], [Email], [Status]) VALUES (2, N'2', N'2', 2, N'2', N'2          ', N'2', N'2', 0)
GO
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

GO
INSERT [dbo].[Category] ([Categoryid], [CategoryName], [MetaTitle]) VALUES (1, N'Điện thoại', N'dien-thoai')
GO
INSERT [dbo].[Category] ([Categoryid], [CategoryName], [MetaTitle]) VALUES (2, N'Gia dụng', N'gia-dung')
GO
INSERT [dbo].[Category] ([Categoryid], [CategoryName], [MetaTitle]) VALUES (3, N'Làm đẹp', N'lam-dep')
GO
INSERT [dbo].[Category] ([Categoryid], [CategoryName], [MetaTitle]) VALUES (4, N'Trang phục', N'trang-phuc')
GO
INSERT [dbo].[Category] ([Categoryid], [CategoryName], [MetaTitle]) VALUES (5, N'Giày dép', N'giay-dep')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (1, 1, 11, CAST(1.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (2, 1, 5, CAST(2.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), CAST(1600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (3, 1, 2, CAST(3.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (4, 2, 3, CAST(2.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (5, 2, 8, CAST(4.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (6, 3, 11, CAST(6.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(7200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (7, 4, 11, CAST(1.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (8, 4, 5, CAST(1.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (9, 4, 4, CAST(1.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (10, 5, 7, CAST(1.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (11, 5, 2, CAST(1.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (12, 6, 3, CAST(1.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (13, 7, 11, CAST(1.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (14, 7, 5, CAST(1.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (15, 7, 7, CAST(4.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (16, 8, 5, CAST(1.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (17, 9, 4, CAST(1.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (18, 10, 7, CAST(1.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (19, 15, 16, CAST(2.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (20, 15, 15, CAST(3.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (21, 15, 11, CAST(2.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(2400.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (22, 15, 7, CAST(2.00 AS Decimal(18, 2)), CAST(450.00 AS Decimal(18, 2)), CAST(900.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (23, 16, 15, CAST(1.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (24, 17, 15, CAST(10.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (25, 18, 11, CAST(1.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (26, 18, 3, CAST(5.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[OrderDetail] ([Orderdetailid], [Orderid], [Pid], [Quantity], [UnitPrice], [Total]) VALUES (27, 18, 12, CAST(1.00 AS Decimal(18, 2)), CAST(1150.00 AS Decimal(18, 2)), CAST(1150.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (11, CAST(N'2021-09-04 16:59:52.760' AS DateTime), N'040921045952', 0, N'Nga', N'Hà Nội', N'96896844')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (12, CAST(N'2021-09-04 17:27:29.960' AS DateTime), N'040921052729', 0, N'9', N'6', N'6')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (13, CAST(N'2021-09-05 12:28:40.273' AS DateTime), N'050921122840', 0, N'1', N'2', N'3')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (14, CAST(N'2021-09-05 12:53:31.593' AS DateTime), N'050921125331', 0, N'Tú', N'Hà Nội', N'0423895')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (15, CAST(N'2021-09-05 13:09:25.757' AS DateTime), N'050921010925', 0, N'Nga', N'1', N'1')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (16, CAST(N'2021-09-05 13:10:22.983' AS DateTime), N'050921011022', 0, N'QA', N'1', N'1')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (17, CAST(N'2021-09-05 13:11:01.420' AS DateTime), N'050921011101', 0, N'ha', N'2', N'2')
GO
INSERT [dbo].[Orders] ([Orderid], [OrderDate], [OrderNumber], [Status], [Name], [Address], [Tel]) VALUES (18, CAST(N'2021-11-12 11:08:55.170' AS DateTime), N'121121110855', 0, N'Hoàng', N'Hà Nội', N'095985634')
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (2, 1, N'Điện thoại 1', N'dien-thoai1', N'Loại mới nhất', N'hoa (10).jpg', CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (3, 1, N'Điện thoại 2', N'dien-thoai2', N'Sản xuất năm 2017', N'hoa (13).jpg', CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (4, 2, N'Gia dụng 1', N'gia-dung1', N'Cây lau nhà', N'hoa (14).jpg', CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (5, 3, N'Nước hoa hồng', N'nuoc-hoa-hong', N'Hương hoa hồng', N'hoa (16).jpg', CAST(800.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (7, 2, N'Nồi chiên không dầu', N'noi-chien', N'Nồi chiên Hàn quốc', N'hoa (19).jpg', CAST(450.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (8, 4, N'Váy công sở', N'vay-cong-so', N'Váy thanh lịch', N'hoa (30).jpg', CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (11, 1, N'Điện thoại 3', N'dien-thoai-3', N'Điện thoại màn ảnh rộng', N'hoa (36).jpg', CAST(1200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (12, 1, N'Điện thoại 4', N'dien-thoai-4', N'Điện thoại cảm ứng tốt', N'hoa (39).jpg', CAST(1150.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (13, 1, N'Điện thoại 5', N'dien-thoai-5', N'Điện thoại bộ nhớ lớn', N'hoa (17).jpg', CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (14, 1, N'Điện thoại 6', N'dien-thoai-6', N'Giá tiền phù hợp', N'hoa (19).jpg', CAST(350.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (15, 3, N'Dưỡng ẩm da', N'duong-am-da', N'Dưỡng ẩm da', N'flower (6).jpg', CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (16, 3, N'Nước cân bằng', N'nuoc-can-bang', N'Nước cân bằng', N'flower (1).jpg', CAST(1500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (17, 4, N'Áo sơ mi', N'ao-so-mi', N'Sơ mi nữ', N'flower (3).jpg', CAST(650.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Product] ([Pid], [Categoryid], [ProdName], [MetaTitle], [Description], [ImagePath], [Price]) VALUES (18, 2, N'Bộ nồi inox 304', N'noi-inox', N'Bộ nồi 5 chiếc', N'flower (5).jpg', CAST(1200.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([Userid], [Username], [Password], [Name], [Phone], [Address], [Email], [Status]) VALUES (1, N'admin', N'1', N'1', N'1          ', N'1', N'1', 1)
GO
INSERT [dbo].[User] ([Userid], [Username], [Password], [Name], [Phone], [Address], [Email], [Status]) VALUES (2, N'ngadq', N'1', N'1', N'1          ', N'1', N'1', 1)
GO

SELECT * FROM Product
SELECT * FROM Orders

SELECT * 
FROM OrderDetail
GROUP BY Pid
 