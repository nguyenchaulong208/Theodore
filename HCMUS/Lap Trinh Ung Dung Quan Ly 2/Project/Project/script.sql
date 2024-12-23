USE [master]
GO
/****** Object:  Database [LTUDQL2-22880089]    Script Date: 08/12/2024 8:35:55 SA ******/
CREATE DATABASE [LTUDQL2-22880089]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LTUDQL2-22880089', FILENAME = N'D:\Github Code\Theodore\HCMUS\Lap Trinh Ung Dung Quan Ly 2\LTUDQL2-22880089.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LTUDQL2-22880089_log', FILENAME = N'D:\Github Code\Theodore\HCMUS\Lap Trinh Ung Dung Quan Ly 2\LTUDQL2-22880089_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LTUDQL2-22880089] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LTUDQL2-22880089].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LTUDQL2-22880089] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ARITHABORT OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LTUDQL2-22880089] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LTUDQL2-22880089] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LTUDQL2-22880089] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LTUDQL2-22880089] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LTUDQL2-22880089] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LTUDQL2-22880089] SET  MULTI_USER 
GO
ALTER DATABASE [LTUDQL2-22880089] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LTUDQL2-22880089] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LTUDQL2-22880089] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LTUDQL2-22880089] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LTUDQL2-22880089] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LTUDQL2-22880089] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LTUDQL2-22880089] SET QUERY_STORE = ON
GO
ALTER DATABASE [LTUDQL2-22880089] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LTUDQL2-22880089]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 08/12/2024 8:35:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[category_id] [int] NOT NULL,
	[category_name] [nvarchar](100) NOT NULL,
	[category_des] [nvarchar](max) NULL,
 CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_ITEM]    Script Date: 08/12/2024 8:35:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ITEM](
	[order_transaction_id] [int] NOT NULL,
	[order_number] [int] NULL,
	[order_product_id] [int] NOT NULL,
	[order_item_quantity] [int] NOT NULL,
	[order_item_sale_price] [int] NOT NULL,
	[order_item_total_price] [int] NOT NULL,
	[order_invoice_date] [varchar](50) NOT NULL,
	[order_product_date] [varchar](50) NOT NULL,
	[order_item_brand] [int] NOT NULL,
 CONSTRAINT [PK_ORDER_ITEM] PRIMARY KEY CLUSTERED 
(
	[order_transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 08/12/2024 8:35:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[products_code] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[products_name] [nvarchar](max) NOT NULL,
	[products_des] [nvarchar](max) NOT NULL,
	[products_image] [nvarchar](255) NOT NULL,
	[products_unit] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__PRODUCTS__7636B6F52946A981] PRIMARY KEY CLUSTERED 
(
	[products_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE_ITEM]    Script Date: 08/12/2024 8:35:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASE_ITEM](
	[purchase_id] [int] NOT NULL,
	[purchase_quantity] [int] NOT NULL,
	[purchase_price] [int] NOT NULL,
	[purchase_total_price] [int] NOT NULL,
	[purchase_product_id] [int] NOT NULL,
	[purchase_invoice_date] [nvarchar](50) NOT NULL,
	[purchase_brand] [int] NOT NULL,
	[purchase_description] [nvarchar](max) NOT NULL,
	[purchase_product_date] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PURCHASE_ITEM] PRIMARY KEY CLUSTERED 
(
	[purchase_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (1, N'Honda', N'Các loại xe mang thương hiệu Honda')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (2, N'Yamaha', N'Các loại xe mang thương hiệu Yamaha')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (3, N'KTM', N'Các loại xe mang thương hiệu KTM')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (4, N'BMW', N'Các loại xe mang thương hiệu BMW')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (5, N'Ducati', N'Các loại xe mang thương hiệu Ducati')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (6, N'Kawasaki', N'Các loại xe mang thương hiệu Kawasaki')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (7, N'Suzuki', N'Các loại xe mang thương hiệu Suzuki')
GO
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (1997, 1997, 1, 2, 2, 3, N'test2', N'2024-12-08', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (4768, 4768, 2, 3, 1, 3, N'2323', N'2024-12-07', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (11955, 11955, 2, 1, 2, 2, N'11', N'2024-12-07', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (26637, 26637, 3, 10, 10, 19, N'11', N'2024-12-07', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (40179, 40179, 5, 1, 250000000, 250000000, N'03/2024', N'2024-12-07', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (44125, 44125, 23, 1, 850000000, 850000000, N'04/04/2024', N'2024-12-07', 6)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (62231, 62231, 1, 1, 1, 1, N'test', N'2024-12-08', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (79631, 79631, 1, 1, 1, 1, N'2323', N'2024-12-07', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (85334, 85334, 2, 2, 2, 2, N'test', N'2024-12-08', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (89030, 89030, 24, 3, 150000000, 450000000, N'01/01/2024', N'2024-12-07', 6)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (98793, 98793, 3, 2, 2, 2, N'test', N'2024-12-08', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (112654, 2008, 1, 2, 3, 3, N'test3', N'2024-12-08', 1)
INSERT [dbo].[ORDER_ITEM] ([order_transaction_id], [order_number], [order_product_id], [order_item_quantity], [order_item_sale_price], [order_item_total_price], [order_invoice_date], [order_product_date], [order_item_brand]) VALUES (169670, 2008, 33, 3, 20, 60, N'test3', N'2024-12-08', 6)
GO
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (1, 1, N'CBR1000RR', N'1000cc', N'cbrr1000.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (2, 1, N'CBR600RR', N'600cc', N'cbr600.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (3, 1, N'CRF450R', N'450cc', N'crf450r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (4, 1, N'CBR500R', N'500cc', N'cbr500r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (5, 1, N'CB500X', N'500cc', N'cb500x.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (6, 1, N'CB650R', N'650cc', N'cb650r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (7, 1, N'CB1000R', N'1000cc', N'cb1000r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (8, 1, N'CRF250R', N'250cc', N'crf250r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (9, 1, N'CBR250R', N'250cc', N'cbr250r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (10, 1, N'CRF150R', N'150cc', N'crf150r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (11, 1, N'VFR800', N'800cc', N'vfr800.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (12, 1, N'SH150i', N'150cc', N'sh150i.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (13, 1, N'PCX150', N'150cc', N'pcx150.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (14, 1, N'CRF110F', N'110cc', N'crf110f.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (15, 1, N'CBR125R', N'125cc', N'cbr125r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (16, 1, N'NC750X', N'750cc', N'nc750x.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (17, 1, N'VTR250', N'250cc', N'vtr250.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (18, 1, N'CB190R', N'190cc', N'cb190r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (19, 1, N'CRF300L', N'300cc', N'crf300l.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (20, 1, N'GoldWing', N'1800cc', N'goldwing.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (21, 1, N'Civic Type R', N'2000cc', N'civic_type_r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (22, 1, N'CB1100EX', N'1100cc', N'cb1100ex.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (23, 6, N'ZX10R', N'1000cc', N'zx10r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (24, 6, N'Ninja 400', N'400cc', N'ninja400.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (25, 6, N'Z1000', N'1000cc', N'z1000.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (26, 6, N'KLR650', N'650cc', N'klr650.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (27, 6, N'Z650', N'650cc', N'z650.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (28, 6, N'Vulcan S', N'650cc', N'vulcans.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (29, 6, N'Z125 Pro', N'125cc', N'z125pro.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (30, 6, N'W800', N'800cc', N'w800.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (31, 6, N'Z900', N'900cc', N'z900.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (32, 6, N'Vulcan 900', N'900cc', N'vulcan900.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (33, 6, N'KX250F', N'250cc', N'kx250f.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (34, 6, N'KX450F', N'450cc', N'kx450f.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (35, 6, N'Ninja H2', N'998cc', N'ninjah2.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (36, 6, N'Ninja 650', N'650cc', N'ninja650.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (37, 6, N'Concours 14', N'1400cc', N'concours14.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (38, 6, N'KX85', N'85cc', N'kx85.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (39, 6, N'KLX110', N'110cc', N'klx110.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (40, 6, N'Z300', N'300cc', N'z300.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (41, 6, N'Ninja ZX-6R', N'600cc', N'ninjazx6r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (42, 6, N'Vulcan 1700', N'1700cc', N'vulcan1700.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (43, 6, N'KLR 650', N'650cc', N'klr650.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (44, 6, N'Z900RS', N'900cc', N'z900rs.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (45, 3, N'Duke 390', N'390cc', N'duke390.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (46, 3, N'Duke 200', N'200cc', N'duke200.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (47, 3, N'Duke 690', N'690cc', N'duke690.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (48, 3, N'RC 125', N'125cc', N'rc125.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (49, 3, N'RC 390', N'390cc', N'rc390.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (50, 3, N'Super Adventure', N'1290cc', N'superadventure.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (51, 3, N'Adventure R', N'1290cc', N'adventurer.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (52, 3, N'Supermoto 450', N'450cc', N'supermoto450.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (53, 3, N'790 Duke', N'790cc', N'790duke.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (54, 3, N'390 Adventure', N'390cc', N'390adventure.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (55, 3, N'250 EXC', N'250cc', N'250exc.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (56, 3, N'300 EXC', N'300cc', N'300exc.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (57, 3, N'SXT 300', N'300cc', N'sxt300.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (58, 3, N'125 Duke', N'125cc', N'125duke.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (59, 3, N'SM 450R', N'450cc', N'sm450r.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (60, 3, N'125 EXC', N'125cc', N'125exc.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (61, 3, N'X-Bow', N'2000cc', N'x-bow.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (62, 3, N'Duke 250', N'250cc', N'duke250.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (63, 3, N'790 Adventure', N'790cc', N'790adventure.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (64, 3, N'Enduro 350', N'350cc', N'enduro350.jpg', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (65, 3, N'Duke 125', N'125cc', N'duke125.jpg', N'Chiếc')
GO
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (1, 2, 500000000, 1000000000, 1, N'01/01/2023', 1, N'1000cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (2, 1, 300000000, 300000000, 2, N'02/01/2023', 1, N'600cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (3, 5, 20000000, 100000000, 23, N'03/01/2023', 6, N'1000cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (4, 3, 15000000, 45000000, 45, N'04/01/2023', 3, N'390cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (5, 4, 80000000, 320000000, 23, N'05/01/2023', 6, N'1000cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (171, 1, 250000000, 250000000, 4, N'04/05/2023', 1, N'500cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (6858309, 1, 500000000, 500000000, 4, N'01/01/2024', 1, N'500cc', N'2024')
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_CATEGORY] FOREIGN KEY([order_item_brand])
REFERENCES [dbo].[CATEGORY] ([category_id])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_CATEGORY]
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_PRODUCTS] FOREIGN KEY([order_product_id])
REFERENCES [dbo].[PRODUCTS] ([products_code])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_PRODUCTS]
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_PRODUCTS1] FOREIGN KEY([order_product_id])
REFERENCES [dbo].[PRODUCTS] ([products_code])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_PRODUCTS1]
GO
ALTER TABLE [dbo].[PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTS_CATEGORY] FOREIGN KEY([category_id])
REFERENCES [dbo].[CATEGORY] ([category_id])
GO
ALTER TABLE [dbo].[PRODUCTS] CHECK CONSTRAINT [FK_PRODUCTS_CATEGORY]
GO
ALTER TABLE [dbo].[PURCHASE_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_PURCHASE_ITEM_CATEGORY] FOREIGN KEY([purchase_brand])
REFERENCES [dbo].[CATEGORY] ([category_id])
GO
ALTER TABLE [dbo].[PURCHASE_ITEM] CHECK CONSTRAINT [FK_PURCHASE_ITEM_CATEGORY]
GO
ALTER TABLE [dbo].[PURCHASE_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_PURCHASE_ITEM_PRODUCTS] FOREIGN KEY([purchase_product_id])
REFERENCES [dbo].[PRODUCTS] ([products_code])
GO
ALTER TABLE [dbo].[PURCHASE_ITEM] CHECK CONSTRAINT [FK_PURCHASE_ITEM_PRODUCTS]
GO
USE [master]
GO
ALTER DATABASE [LTUDQL2-22880089] SET  READ_WRITE 
GO
