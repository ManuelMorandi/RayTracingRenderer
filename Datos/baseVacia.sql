USE [master]
GO
/****** Object:  Database [RendererDB]    Script Date: 14/6/2023 18:25:50 ******/
CREATE DATABASE [RendererDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RendererDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RendererDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RendererDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\RendererDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RendererDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RendererDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RendererDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RendererDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RendererDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RendererDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RendererDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [RendererDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RendererDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RendererDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RendererDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RendererDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RendererDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RendererDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RendererDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RendererDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RendererDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RendererDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RendererDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RendererDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RendererDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RendererDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RendererDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [RendererDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RendererDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RendererDB] SET  MULTI_USER 
GO
ALTER DATABASE [RendererDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RendererDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RendererDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RendererDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RendererDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RendererDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RendererDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [RendererDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RendererDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialEntities](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Red] [float] NOT NULL,
	[Green] [float] NOT NULL,
	[Blue] [float] NOT NULL,
	[Roughness] [float] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[OwnerRefId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.MaterialEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModelEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModelEntities](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Preview] [nvarchar](max) NULL,
	[OwnerRefId] [nvarchar](128) NULL,
	[ShapeRefId] [nvarchar](128) NULL,
	[MaterialRefId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.ModelEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SceneEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SceneEntities](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[OwnerRefId] [nvarchar](128) NULL,
	[Creation] [datetime] NOT NULL,
	[LastModification] [datetime] NOT NULL,
	[LastRender] [datetime] NOT NULL,
	[LookFromX] [float] NOT NULL,
	[LookFromY] [float] NOT NULL,
	[LookFromZ] [float] NOT NULL,
	[LookAtX] [float] NOT NULL,
	[LookAtY] [float] NOT NULL,
	[LookAtZ] [float] NOT NULL,
	[Fov] [int] NOT NULL,
	[Render] [nvarchar](max) NULL,
	[Preview] [nvarchar](max) NULL,
	[Aperture] [float] NOT NULL,
	[Blurred] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.SceneEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SceneModelEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SceneModelEntities](
	[UsedModelId] [int] NOT NULL,
	[SceneId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.SceneModelEntities] PRIMARY KEY CLUSTERED 
(
	[UsedModelId] ASC,
	[SceneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SphereEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SphereEntities](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Radius] [float] NOT NULL,
	[OwnerRefId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.SphereEntities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsedModelEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsedModelEntities](
	[UsedModelId] [int] IDENTITY(1,1) NOT NULL,
	[PlaceX] [float] NOT NULL,
	[PlaceY] [float] NOT NULL,
	[PlaceZ] [float] NOT NULL,
	[ModelRefId] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.UsedModelEntities] PRIMARY KEY CLUSTERED 
(
	[UsedModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserEntities]    Script Date: 14/6/2023 18:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEntities](
	[UserName] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Creation] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.UserEntities] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OwnerRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_OwnerRefId] ON [dbo].[MaterialEntities]
(
	[OwnerRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MaterialRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRefId] ON [dbo].[ModelEntities]
(
	[MaterialRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OwnerRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_OwnerRefId] ON [dbo].[ModelEntities]
(
	[OwnerRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ShapeRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_ShapeRefId] ON [dbo].[ModelEntities]
(
	[ShapeRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OwnerRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_OwnerRefId] ON [dbo].[SceneEntities]
(
	[OwnerRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OwnerRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_OwnerRefId] ON [dbo].[SphereEntities]
(
	[OwnerRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ModelRefId]    Script Date: 14/6/2023 18:25:51 ******/
CREATE NONCLUSTERED INDEX [IX_ModelRefId] ON [dbo].[UsedModelEntities]
(
	[ModelRefId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaterialEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MaterialEntities_dbo.UserEntities_OwnerRefId] FOREIGN KEY([OwnerRefId])
REFERENCES [dbo].[UserEntities] ([UserName])
GO
ALTER TABLE [dbo].[MaterialEntities] CHECK CONSTRAINT [FK_dbo.MaterialEntities_dbo.UserEntities_OwnerRefId]
GO
ALTER TABLE [dbo].[ModelEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ModelEntities_dbo.MaterialEntities_MaterialRefId] FOREIGN KEY([MaterialRefId])
REFERENCES [dbo].[MaterialEntities] ([Id])
GO
ALTER TABLE [dbo].[ModelEntities] CHECK CONSTRAINT [FK_dbo.ModelEntities_dbo.MaterialEntities_MaterialRefId]
GO
ALTER TABLE [dbo].[ModelEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ModelEntities_dbo.SphereEntities_ShapeRefId] FOREIGN KEY([ShapeRefId])
REFERENCES [dbo].[SphereEntities] ([Id])
GO
ALTER TABLE [dbo].[ModelEntities] CHECK CONSTRAINT [FK_dbo.ModelEntities_dbo.SphereEntities_ShapeRefId]
GO
ALTER TABLE [dbo].[ModelEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ModelEntities_dbo.UserEntities_OwnerRefId] FOREIGN KEY([OwnerRefId])
REFERENCES [dbo].[UserEntities] ([UserName])
GO
ALTER TABLE [dbo].[ModelEntities] CHECK CONSTRAINT [FK_dbo.ModelEntities_dbo.UserEntities_OwnerRefId]
GO
ALTER TABLE [dbo].[SceneEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SceneEntities_dbo.UserEntities_OwnerRefId] FOREIGN KEY([OwnerRefId])
REFERENCES [dbo].[UserEntities] ([UserName])
GO
ALTER TABLE [dbo].[SceneEntities] CHECK CONSTRAINT [FK_dbo.SceneEntities_dbo.UserEntities_OwnerRefId]
GO
ALTER TABLE [dbo].[SphereEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SphereEntities_dbo.UserEntities_OwnerRefId] FOREIGN KEY([OwnerRefId])
REFERENCES [dbo].[UserEntities] ([UserName])
GO
ALTER TABLE [dbo].[SphereEntities] CHECK CONSTRAINT [FK_dbo.SphereEntities_dbo.UserEntities_OwnerRefId]
GO
ALTER TABLE [dbo].[UsedModelEntities]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UsedModelEntities_dbo.ModelEntities_ModelRefId] FOREIGN KEY([ModelRefId])
REFERENCES [dbo].[ModelEntities] ([Id])
GO
ALTER TABLE [dbo].[UsedModelEntities] CHECK CONSTRAINT [FK_dbo.UsedModelEntities_dbo.ModelEntities_ModelRefId]
GO
USE [master]
GO
ALTER DATABASE [RendererDB] SET  READ_WRITE 
GO
