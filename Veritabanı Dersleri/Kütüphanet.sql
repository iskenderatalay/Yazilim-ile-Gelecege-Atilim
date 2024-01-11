USE [master]
GO
/****** Object:  Database [Odev]    Script Date: 11.01.2024 20:56:24 ******/
CREATE DATABASE [Odev]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Odev', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Odev.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Odev_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Odev_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Odev] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Odev].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Odev] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Odev] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Odev] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Odev] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Odev] SET ARITHABORT OFF 
GO
ALTER DATABASE [Odev] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Odev] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Odev] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Odev] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Odev] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Odev] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Odev] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Odev] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Odev] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Odev] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Odev] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Odev] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Odev] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Odev] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Odev] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Odev] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Odev] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Odev] SET RECOVERY FULL 
GO
ALTER DATABASE [Odev] SET  MULTI_USER 
GO
ALTER DATABASE [Odev] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Odev] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Odev] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Odev] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Odev] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Odev] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Odev', N'ON'
GO
ALTER DATABASE [Odev] SET QUERY_STORE = ON
GO
ALTER DATABASE [Odev] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Odev]
GO
/****** Object:  Table [dbo].[Dil]    Script Date: 11.01.2024 20:56:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dil](
	[DilID] [int] IDENTITY(1,1) NOT NULL,
	[DAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dil] PRIMARY KEY CLUSTERED 
(
	[DilID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[KID] [int] IDENTITY(1,1) NOT NULL,
	[KAd] [nvarchar](50) NULL,
	[KYazarID] [int] NULL,
	[KAciklama] [nvarchar](50) NULL,
	[KYayinEvID] [int] NULL,
	[TurID] [int] NULL,
	[DilID] [int] NULL,
	[KitaplikID] [int] NULL,
 CONSTRAINT [PK_Kitap] PRIMARY KEY CLUSTERED 
(
	[KID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitaplik]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplik](
	[KitaplikID] [int] IDENTITY(1,1) NOT NULL,
	[KNo] [int] NULL,
	[KRafNo] [int] NULL,
 CONSTRAINT [PK_Kitaplik] PRIMARY KEY CLUSTERED 
(
	[KitaplikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciTur]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciTur](
	[KTID] [int] IDENTITY(1,1) NOT NULL,
	[KAd] [nvarchar](50) NULL,
	[KSoyad] [nvarchar](50) NULL,
	[KTuru] [nvarchar](50) NULL,
 CONSTRAINT [PK_KullaniciTur] PRIMARY KEY CLUSTERED 
(
	[KTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OID] [int] IDENTITY(1,1) NOT NULL,
	[ONo] [nvarchar](50) NULL,
	[KTID] [int] NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[PNo] [nvarchar](50) NULL,
	[KTID] [int] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tur]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tur](
	[TID] [int] IDENTITY(1,1) NOT NULL,
	[TAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tur] PRIMARY KEY CLUSTERED 
(
	[TID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ver]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ver](
	[VID] [int] IDENTITY(1,1) NOT NULL,
	[KTID] [int] NULL,
	[KID] [int] NULL,
	[VTarih] [date] NULL,
	[ATarih] [date] NULL,
	[ITarih] [datetime] NULL,
 CONSTRAINT [PK_Ver] PRIMARY KEY CLUSTERED 
(
	[VID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YayinEv]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YayinEv](
	[YEvID] [int] IDENTITY(1,1) NOT NULL,
	[YEvAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_YayinEv] PRIMARY KEY CLUSTERED 
(
	[YEvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 11.01.2024 20:56:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[YID] [int] IDENTITY(1,1) NOT NULL,
	[YAd] [nvarchar](50) NULL,
	[YSoyad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Yazar] PRIMARY KEY CLUSTERED 
(
	[YID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Dil] ON 

INSERT [dbo].[Dil] ([DilID], [DAd]) VALUES (1, N'Türkçe')
INSERT [dbo].[Dil] ([DilID], [DAd]) VALUES (2, N'İngilizce')
INSERT [dbo].[Dil] ([DilID], [DAd]) VALUES (3, N'Almanca')
SET IDENTITY_INSERT [dbo].[Dil] OFF
GO
SET IDENTITY_INSERT [dbo].[Kitap] ON 

INSERT [dbo].[Kitap] ([KID], [KAd], [KYazarID], [KAciklama], [KYayinEvID], [TurID], [DilID], [KitaplikID]) VALUES (1, N'Leyla ile Mecnun', 2, N'Dizinin Kitabı', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Kitap] OFF
GO
SET IDENTITY_INSERT [dbo].[Kitaplik] ON 

INSERT [dbo].[Kitaplik] ([KitaplikID], [KNo], [KRafNo]) VALUES (1, 1, 1)
INSERT [dbo].[Kitaplik] ([KitaplikID], [KNo], [KRafNo]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[Kitaplik] OFF
GO
SET IDENTITY_INSERT [dbo].[KullaniciTur] ON 

INSERT [dbo].[KullaniciTur] ([KTID], [KAd], [KSoyad], [KTuru]) VALUES (1, N'İskender', N'Atalay', N'Ogrenci')
INSERT [dbo].[KullaniciTur] ([KTID], [KAd], [KSoyad], [KTuru]) VALUES (2, N'Betül', N'Kara', N'Personel')
SET IDENTITY_INSERT [dbo].[KullaniciTur] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OID], [ONo], [KTID]) VALUES (1, N'2008', 1)
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PID], [PNo], [KTID]) VALUES (1, N'0453', 2)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Tur] ON 

INSERT [dbo].[Tur] ([TID], [TAd]) VALUES (1, N'Polisiye')
INSERT [dbo].[Tur] ([TID], [TAd]) VALUES (2, N'Siyasi')
SET IDENTITY_INSERT [dbo].[Tur] OFF
GO
SET IDENTITY_INSERT [dbo].[Ver] ON 

INSERT [dbo].[Ver] ([VID], [KTID], [KID], [VTarih], [ATarih], [ITarih]) VALUES (1, 1, 1, CAST(N'2024-04-01' AS Date), CAST(N'2024-05-01' AS Date), CAST(N'2024-04-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ver] OFF
GO
SET IDENTITY_INSERT [dbo].[YayinEv] ON 

INSERT [dbo].[YayinEv] ([YEvID], [YEvAd]) VALUES (1, N'İşBank')
INSERT [dbo].[YayinEv] ([YEvID], [YEvAd]) VALUES (2, N'YapıKredi')
INSERT [dbo].[YayinEv] ([YEvID], [YEvAd]) VALUES (3, N'İşBank')
INSERT [dbo].[YayinEv] ([YEvID], [YEvAd]) VALUES (4, N'YapıKredi')
SET IDENTITY_INSERT [dbo].[YayinEv] OFF
GO
SET IDENTITY_INSERT [dbo].[Yazar] ON 

INSERT [dbo].[Yazar] ([YID], [YAd], [YSoyad]) VALUES (1, N'Tess', N'Gerritsen')
INSERT [dbo].[Yazar] ([YID], [YAd], [YSoyad]) VALUES (2, N'Burak', N'Aksak')
SET IDENTITY_INSERT [dbo].[Yazar] OFF
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Dil] FOREIGN KEY([DilID])
REFERENCES [dbo].[Dil] ([DilID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Dil]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Kitaplik] FOREIGN KEY([KitaplikID])
REFERENCES [dbo].[Kitaplik] ([KitaplikID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Kitaplik]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Tur] FOREIGN KEY([TurID])
REFERENCES [dbo].[Tur] ([TID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Tur]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_YayinEv] FOREIGN KEY([KYayinEvID])
REFERENCES [dbo].[YayinEv] ([YEvID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_YayinEv]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yazar] FOREIGN KEY([KYazarID])
REFERENCES [dbo].[Yazar] ([YID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Yazar]
GO
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_KullaniciTur] FOREIGN KEY([KTID])
REFERENCES [dbo].[KullaniciTur] ([KTID])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_KullaniciTur]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_KullaniciTur] FOREIGN KEY([KTID])
REFERENCES [dbo].[KullaniciTur] ([KTID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_KullaniciTur]
GO
ALTER TABLE [dbo].[Ver]  WITH CHECK ADD  CONSTRAINT [FK_Ver_Kitap] FOREIGN KEY([KID])
REFERENCES [dbo].[Kitap] ([KID])
GO
ALTER TABLE [dbo].[Ver] CHECK CONSTRAINT [FK_Ver_Kitap]
GO
ALTER TABLE [dbo].[Ver]  WITH CHECK ADD  CONSTRAINT [FK_Ver_KullaniciTur] FOREIGN KEY([KTID])
REFERENCES [dbo].[KullaniciTur] ([KTID])
GO
ALTER TABLE [dbo].[Ver] CHECK CONSTRAINT [FK_Ver_KullaniciTur]
GO
USE [master]
GO
ALTER DATABASE [Odev] SET  READ_WRITE 
GO
