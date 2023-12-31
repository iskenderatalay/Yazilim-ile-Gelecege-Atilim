USE [master]
GO
/****** Object:  Database [TrendDuzce]    Script Date: 8.01.2024 16:25:49 ******/
CREATE DATABASE [TrendDuzce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrendDuzce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TrendDuzce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TrendDuzce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TrendDuzce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TrendDuzce] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrendDuzce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrendDuzce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrendDuzce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrendDuzce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrendDuzce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrendDuzce] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrendDuzce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrendDuzce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrendDuzce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrendDuzce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrendDuzce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrendDuzce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrendDuzce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrendDuzce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrendDuzce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrendDuzce] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TrendDuzce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrendDuzce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrendDuzce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrendDuzce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrendDuzce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrendDuzce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrendDuzce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrendDuzce] SET RECOVERY FULL 
GO
ALTER DATABASE [TrendDuzce] SET  MULTI_USER 
GO
ALTER DATABASE [TrendDuzce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrendDuzce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrendDuzce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrendDuzce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TrendDuzce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TrendDuzce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrendDuzce', N'ON'
GO
ALTER DATABASE [TrendDuzce] SET QUERY_STORE = ON
GO
ALTER DATABASE [TrendDuzce] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TrendDuzce]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 8.01.2024 16:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[KategoriID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[KategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 8.01.2024 16:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 8.01.2024 16:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[MarkaID] [int] IDENTITY(1,1) NOT NULL,
	[MarkaAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[MarkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satici]    Script Date: 8.01.2024 16:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satici](
	[SaticiID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[FirmaGorsel] [nvarchar](50) NULL,
	[KullaniciID] [int] NULL,
 CONSTRAINT [PK_Satici] PRIMARY KEY CLUSTERED 
(
	[SaticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaticiUrun]    Script Date: 8.01.2024 16:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaticiUrun](
	[SaticiUrunID] [int] IDENTITY(1,1) NOT NULL,
	[SaticiID] [int] NULL,
	[UrunID] [int] NULL,
	[Fiyat] [float] NULL,
 CONSTRAINT [PK_SaticiUrun] PRIMARY KEY CLUSTERED 
(
	[SaticiUrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 8.01.2024 16:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[MarkaID] [int] NULL,
	[KullaniciID] [int] NULL,
	[KategoriID] [int] NULL,
	[Model] [nvarchar](50) NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kategori] ON 

INSERT [dbo].[Kategori] ([KategoriID], [KategoriAdi]) VALUES (1, N'Ayakkabı')
SET IDENTITY_INSERT [dbo].[Kategori] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciID], [Ad], [Soyad], [KullaniciAdi], [Sifre]) VALUES (1, N'İskender', N'Atalay', N'zeebody', N'12345')
INSERT [dbo].[Kullanici] ([KullaniciID], [Ad], [Soyad], [KullaniciAdi], [Sifre]) VALUES (2, N'Ali', N'Veli', N'xene', N'7889')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Marka] ON 

INSERT [dbo].[Marka] ([MarkaID], [MarkaAdi]) VALUES (1, N'Adidas')
INSERT [dbo].[Marka] ([MarkaID], [MarkaAdi]) VALUES (2, N'Nike')
INSERT [dbo].[Marka] ([MarkaID], [MarkaAdi]) VALUES (3, N'Kinetix')
SET IDENTITY_INSERT [dbo].[Marka] OFF
GO
SET IDENTITY_INSERT [dbo].[Satici] ON 

INSERT [dbo].[Satici] ([SaticiID], [FirmaAdi], [Adres], [FirmaGorsel], [KullaniciID]) VALUES (1, N'XZCorp', N'Duzce', N'Gorsel', 1)
INSERT [dbo].[Satici] ([SaticiID], [FirmaAdi], [Adres], [FirmaGorsel], [KullaniciID]) VALUES (2, N'XZ', N'Duzce', N'Gorsel', 2)
SET IDENTITY_INSERT [dbo].[Satici] OFF
GO
SET IDENTITY_INSERT [dbo].[SaticiUrun] ON 

INSERT [dbo].[SaticiUrun] ([SaticiUrunID], [SaticiID], [UrunID], [Fiyat]) VALUES (1, 1, 1, 200)
INSERT [dbo].[SaticiUrun] ([SaticiUrunID], [SaticiID], [UrunID], [Fiyat]) VALUES (2, 2, 2, 300)
SET IDENTITY_INSERT [dbo].[SaticiUrun] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([UrunID], [MarkaID], [KullaniciID], [KategoriID], [Model]) VALUES (1, 1, 1, 1, N'SporAyakkabı')
INSERT [dbo].[Urun] ([UrunID], [MarkaID], [KullaniciID], [KategoriID], [Model]) VALUES (2, 3, 2, 1, N'GundelikAyakkabı')
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
ALTER TABLE [dbo].[Satici]  WITH CHECK ADD  CONSTRAINT [FK_Satici_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[Satici] CHECK CONSTRAINT [FK_Satici_Kullanici]
GO
ALTER TABLE [dbo].[SaticiUrun]  WITH CHECK ADD  CONSTRAINT [FK_SaticiUrun_Satici] FOREIGN KEY([SaticiID])
REFERENCES [dbo].[Satici] ([SaticiID])
GO
ALTER TABLE [dbo].[SaticiUrun] CHECK CONSTRAINT [FK_SaticiUrun_Satici]
GO
ALTER TABLE [dbo].[SaticiUrun]  WITH CHECK ADD  CONSTRAINT [FK_SaticiUrun_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[SaticiUrun] CHECK CONSTRAINT [FK_SaticiUrun_Urun]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Kategori] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[Kategori] ([KategoriID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Kategori]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Marka] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Marka] ([MarkaID])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Marka]
GO
USE [master]
GO
ALTER DATABASE [TrendDuzce] SET  READ_WRITE 
GO
