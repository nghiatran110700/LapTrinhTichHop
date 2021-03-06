USE [master]
GO
/****** Object:  Database [DEMO_SHOP_WCF]    Script Date: 12/31/2021 11:19:17 AM ******/
CREATE DATABASE [DEMO_SHOP_WCF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DEMO_SHOP_WCF', FILENAME = N'D:\Sql\MSSQL15.MSSQLSERVER\MSSQL\DATA\DEMO_SHOP_WCF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DEMO_SHOP_WCF_log', FILENAME = N'D:\Sql\MSSQL15.MSSQLSERVER\MSSQL\DATA\DEMO_SHOP_WCF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DEMO_SHOP_WCF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ARITHABORT OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET RECOVERY FULL 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET  MULTI_USER 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DEMO_SHOP_WCF', N'ON'
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET QUERY_STORE = OFF
GO
USE [DEMO_SHOP_WCF]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/31/2021 11:19:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 12/31/2021 11:19:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[phone] [nvarchar](20) NULL,
	[address] [nvarchar](100) NULL,
	[status] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[billDetail]    Script Date: 12/31/2021 11:19:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idProduct] [int] NOT NULL,
	[amount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 12/31/2021 11:19:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[idCategory] [int] IDENTITY(1,1) NOT NULL,
	[nameCategory] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/31/2021 11:19:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[idProduct] [int] IDENTITY(1,1) NOT NULL,
	[nameProduct] [nvarchar](50) NULL,
	[price] [int] NULL,
	[amuont] [int] NULL,
	[photo] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[idCategory] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [fullname], [username], [password], [status]) VALUES (1, N'Trần Nghĩa', N'admin@gmail.com', N'123456', 1)
INSERT [dbo].[Account] ([id], [fullname], [username], [password], [status]) VALUES (2, N'Đức Đô', N'nghia123@gmail.com', N'123456', 0)
INSERT [dbo].[Account] ([id], [fullname], [username], [password], [status]) VALUES (3, N'Trần Nam', N'admin123@gmail.com', N'123456', 0)
INSERT [dbo].[Account] ([id], [fullname], [username], [password], [status]) VALUES (6, N'Trần Trọng Đạt', N'admin12345678@gmail.com', N'123456789', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[bill] ON 

INSERT [dbo].[bill] ([idBill], [phone], [address], [status]) VALUES (1, N'0124568', N'hà nội ', N'đã gói')
INSERT [dbo].[bill] ([idBill], [phone], [address], [status]) VALUES (2, N'0123', N'Hà nội', N'chưa xử lý')
INSERT [dbo].[bill] ([idBill], [phone], [address], [status]) VALUES (3, N'0123', N'Hà nội', N'chưa xử lý')
INSERT [dbo].[bill] ([idBill], [phone], [address], [status]) VALUES (12, N'0376798320', N'Hà Nội', N'Đơn mới')
INSERT [dbo].[bill] ([idBill], [phone], [address], [status]) VALUES (15, N'037', N'Hà Nội', N'Đơn mới')
SET IDENTITY_INSERT [dbo].[bill] OFF
GO
SET IDENTITY_INSERT [dbo].[billDetail] ON 

INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (1, 1, 2, 1)
INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (2, 1, 1, 2)
INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (3, 2, 3, 1)
INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (4, 2, 3, 4)
INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (5, 2, 3, 3)
INSERT [dbo].[billDetail] ([id], [idBill], [idProduct], [amount]) VALUES (6, 12, 1, 3)
SET IDENTITY_INSERT [dbo].[billDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([idCategory], [nameCategory]) VALUES (1, N'Son')
INSERT [dbo].[category] ([idCategory], [nameCategory]) VALUES (2, N'Sữa Rửa Mặt')
INSERT [dbo].[category] ([idCategory], [nameCategory]) VALUES (3, N'Sữa Tắm')
INSERT [dbo].[category] ([idCategory], [nameCategory]) VALUES (4, N'Nước Hoa')
INSERT [dbo].[category] ([idCategory], [nameCategory]) VALUES (5, N'Kem Dưỡng Da')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (1, N'Mascara Ohui Proof - All', 198000, 100, N'imge1.jpg                                                                                                                       ', N'Với sự thiết kế đầu chải của mascara cong giúp chải mi nhanh hơn từ gốc tới ngọn. Hình dáng của mascara sang trọng, nhỏ gọn có thể dễ dàng sử dụng mọi lúc', 2)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (2, N'Kem lót Ohui', 891000, 120, N'imge2.jpg           ', N'Kem lót trang điểm Ohui Second Skin Sheer Base dạng primer chứa siêu phân tử ngọc trai giúp hiệu chỉnh tone da, mang lại sắc da tỏa sáng rạng rỡ ba chiều.', 5)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (3, N'Kem lot nâng tông Ohui', 690000, 120, N'imge3.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 5)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (4, N'Nước hoa Ohui mỉaclin', 790000, 90, N'imge4.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 4)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (5, N'Son dưỡng Ohui', 690000, 80, N'imge5.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 1)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (6, N'Son lot Ohui', 590000, 230, N'imge6.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 1)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (7, N'Son lì Ohui', 800000, 231, N'imge7.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 1)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (8, N'Sữa Rửa Mặt Ohui', 300000, 123, N'imge8.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 2)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (9, N'Sữa Rửa Mặt Ban Đêm Whoo', 390000, 564, N'imge9.jpg           ', N'Sản phẩm chiết xuất từ thiên nhiên', 2)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (10, N'Sữa Tắm Who Dimond', 129000, 123, N'imge10.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 3)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (11, N'Sữa Tắm Ohui', 349000, 123, N'imge11.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 3)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (12, N'Sữa Rửa Mặt Omo', 123000, 78, N'imge12.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 2)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (13, N'Sữa Tắm vathelin', 290000, 130, N'imge13.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 3)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (14, N'Nước Hoa Whoo Thần Bí', 899000, 129, N'imge14.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 4)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (15, N'Nước Hoa Channel', 1090000, 50, N'imge15.jpg          ', N'Sản phẩm chiết xuất từ thiên nhiên', 4)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (19, N'Bàn phím', 200000, 123456, N'img26.jpg', N'ok', 3)
INSERT [dbo].[Product] ([idProduct], [nameProduct], [price], [amuont], [photo], [description], [idCategory]) VALUES (21, N'ádas', 200, 6, NULL, N'oke', 3)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[billDetail]  WITH CHECK ADD  CONSTRAINT [FK_billDetail_bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[bill] ([idBill])
GO
ALTER TABLE [dbo].[billDetail] CHECK CONSTRAINT [FK_billDetail_bill]
GO
ALTER TABLE [dbo].[billDetail]  WITH CHECK ADD  CONSTRAINT [FK_billDetail_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([idProduct])
GO
ALTER TABLE [dbo].[billDetail] CHECK CONSTRAINT [FK_billDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_category] FOREIGN KEY([idCategory])
REFERENCES [dbo].[category] ([idCategory])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_category]
GO
USE [master]
GO
ALTER DATABASE [DEMO_SHOP_WCF] SET  READ_WRITE 
GO
