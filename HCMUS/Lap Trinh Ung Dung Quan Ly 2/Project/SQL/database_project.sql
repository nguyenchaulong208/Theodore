USE [master]
GO
/****** Object:  Database [LTUDQL2-22880089]    Script Date: 07/12/2024 8:23:45 SA ******/
CREATE DATABASE [LTUDQL2-22880089]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LTUDQL2-22880089', FILENAME = N'D:\Github Code\Theodore\HCMUS\Lap Trinh Ung Dung Quan Ly 2\Project\SQL\LTUDQL2-22880089.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LTUDQL2-22880089_log', FILENAME = N'D:\Github Code\Theodore\HCMUS\Lap Trinh Ung Dung Quan Ly 2\Project\SQL\LTUDQL2-22880089_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 07/12/2024 8:23:45 SA ******/
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
/****** Object:  Table [dbo].[ORDER_ITEM]    Script Date: 07/12/2024 8:23:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ITEM](
	[order_item_id] [int] NOT NULL,
	[order_item_quantity] [int] NOT NULL,
	[order_item_sale_price] [int] NOT NULL,
	[order_item_total_price] [int] NOT NULL,
	[order_product_id] [int] NOT NULL,
 CONSTRAINT [PK_ORDER_ITEM] PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 07/12/2024 8:23:45 SA ******/
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
/****** Object:  Table [dbo].[PURCHASE_ITEM]    Script Date: 07/12/2024 8:23:45 SA ******/
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
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (4, N'BWM', N'Các loại xe mang thương hiệu BMW')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (5, N'Ducati', N'Các loại xe mang thương hiệu Ducati')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (6, N'Kawasaki', N'Các loại xe mang thương hiệu Kawasaki')
INSERT [dbo].[CATEGORY] ([category_id], [category_name], [category_des]) VALUES (8, N'Suzuki', N'Các loại xe mang thương hiệu Suzuki')
GO
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (1, 1, N'CBR1000RR', N'1000cc', N'test2', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (3, 2, N'R15', N'150cc', N'test', N'Chiếc')
INSERT [dbo].[PRODUCTS] ([products_code], [category_id], [products_name], [products_des], [products_image], [products_unit]) VALUES (54, 3, N'Duke', N'200cc', N'13143', N'Chiếc')
GO
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (1, 2, 500000000, 1000000000, 1, N'01/01/2023', 1, N'1000cc', N'2023')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (3, 2, 1000, 2000, 3, N'41414', 2, N'test2', N'2022')
INSERT [dbo].[PURCHASE_ITEM] ([purchase_id], [purchase_quantity], [purchase_price], [purchase_total_price], [purchase_product_id], [purchase_invoice_date], [purchase_brand], [purchase_description], [purchase_product_date]) VALUES (13213, 1, 200, 200, 54, N'asdq', 3, N'wwww', N'2023')
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_PRODUCTS] FOREIGN KEY([order_product_id])
REFERENCES [dbo].[PRODUCTS] ([products_code])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_PRODUCTS]
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
