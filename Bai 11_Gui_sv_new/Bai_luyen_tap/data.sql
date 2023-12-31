USE [master]
GO
if DB_ID('QLSanpham') is not null
	drop database QLSanpham
go
CREATE DATABASE [QLSanpham]
GO
 
USE [QLSanpham]
GO
 
CREATE TABLE [Danhmuc](
	[MaDanhmuc] [int] IDENTITY(1,1) NOT NULL Primary Key,
	[TenDanhmuc] [nvarchar](50) NOT NULL,
	[Mota] [varchar](100) NULL)
go	
  
  insert into Danhmuc values(N'Đèn phát sáng',N'Trang trí nhà cửa')
  insert into Danhmuc values(N'Đồ dùng nhà bếp',N'Vật dụng nấu ăn')

CREATE TABLE [Sanpham](
	[Mavd] [int] IDENTITY(1,1) NOT NULL Primary key,
	[Tenvd] [nvarchar](100) NOT NULL,
	[TenAnh] [nvarchar](250) NULL,	
	[Mota] [nvarchar](250) NOT NULL,	
	[Giatien] [decimal](18, 2) NOT NULL,
	[Soluong] [int],
	[MaDanhmuc] [int] NOT NULL foreign key references [Danhmuc]([MaDanhmuc]))

go
   
insert into [Sanpham] values(N'Đèn phát sáng mẫu 1','Den (1).jpg',N'Đèn phát sáng trang trí nhà đẹp',10,1000,1)
insert into [Sanpham] values(N'Đèn phát sáng mẫu 2','Den (2).jpg',N'Đèn phát sáng trang trí nhà đẹp',15,700,1)
insert into [Sanpham] values(N'Đèn phát sáng mẫu 3','Den (3).jpg',N'Đèn phát sáng trang trí nhà đẹp',10,1500,1)
insert into [Sanpham] values(N'Đèn phát sáng mẫu 4','Den (4).jpg',N'Đèn phát sáng trang trí nhà đẹp',30,500,1)
insert into [Sanpham] values(N'Đèn phát sáng mẫu 5','Den (5).jpg',N'Đèn phát sáng trang trí nhà đẹp',20,1000,1)
insert into [Sanpham] values(N'Đèn phát sáng mẫu 6','Den (6).jpg',N'Đèn phát sáng trang trí nhà đẹp',20,1200,1)
 
insert into [Sanpham] values(N'Thiết bị mài dao','Bep (1).jpg',N'Thiết bị mài dao hình con voi',10,200,2)
insert into [Sanpham] values(N'4 đế silicon để xoong nồi','Bep (2).jpg',N'Hình tròn, chất liệu silicon',5,500,2)
insert into [Sanpham] values(N'4 thìa inox màu vàng','Bep (3).jpg',N'Inox 304 sáng đẹp',20,200,2)
insert into [Sanpham] values(N'6 thìa gỗ','Bep (4).jpg',N'Thìa làm bằng gỗ đã qua xử lý',10,100,2)
insert into [Sanpham] values(N'Chổi quét dầu','Bep (5).jpg',N'Chất liệu silicon',15,90,2)
insert into [Sanpham] values(N'2 thìa inox dài','Bep (6).jpg',N'Chất liệu inox 304 bền đẹp',10,300,2)

SELECT * FROM Sanpham