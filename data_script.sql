USE [master]
GO
/****** Object:  Database [DBS]    Script Date: 7/12/2022 9:01:19 PM ******/
CREATE DATABASE [DBS]

GO
ALTER DATABASE [DBS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBS] SET  MULTI_USER 
GO
ALTER DATABASE [DBS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBS] SET QUERY_STORE = OFF
GO
USE [DBS]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[gender] [bit] NOT NULL,
	[role] [decimal](1, 0) NOT NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[dentist_id] [int] NOT NULL,
	[time] [date] NOT NULL,
	[working_hour] [nvarchar](15) NOT NULL,
	[description] [nvarchar](max) NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment_Service]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment_Service](
	[appointment_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC,
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[phone] [nvarchar](10) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[DOB] [date] NOT NULL,
	[gender] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[service_type_id] [int] NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[description] [nvarchar](max) NULL,
	[estimated_time] [float] NOT NULL,
	[status] [decimal](1, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service_Type]    Script Date: 7/12/2022 9:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service_Type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (1, N'admin123', N'admin123', N'admin123', 0, CAST(1 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (2, N'staffstaff1', N'staff123abc', N'staff staff staff', 1, CAST(2 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (3, N'doctordoctor1', N'12345678', N'Nguyen Van A', 1, CAST(3 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (4, N'doctor2doctor2', N'12345678', N'Ngyen Van B', 1, CAST(3 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (5, N'staff12345678', N'12345678', N'Huynh Thi C', 0, CAST(2 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (6, N'doctor12345678', N'12345678', N'Tran Thi D', 0, CAST(3 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (7, N'username1', N'12345678', N'Nguyen Thi E', 0, CAST(1 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (8, N'username2', N'12345678', N'Nguyen Van F', 0, CAST(2 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (9, N'username3', N'12345678', N'Tran Van G', 1, CAST(3 AS Decimal(1, 0)), CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (10, N'abcdefgh', N'12345678', N'Nong Cao Van', 1, CAST(2 AS Decimal(1, 0)), CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Account] ([id], [username], [password], [name], [gender], [role], [status]) VALUES (11, N'abcd1234', N'12345678', N'Tran Van Thanh', 1, CAST(3 AS Decimal(1, 0)), CAST(2 AS Decimal(1, 0)))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (19, 11, 3, CAST(N'2022-07-11' AS Date), N'07:00-13:00', N'răng tốt', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (20, 12, 4, CAST(N'2022-07-12' AS Date), N'07:00-12:00', N'Răng tốt', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (21, 13, 3, CAST(N'2022-07-12' AS Date), N'07:00-12:00', N'Răng tốt', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (22, 14, 6, CAST(N'2022-07-12' AS Date), N'07:00-12:00', N'Răng đều đẹp', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (23, 15, 9, CAST(N'2022-07-12' AS Date), N'07:00-10:30', NULL, CAST(3 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (24, 16, 9, CAST(N'2022-07-12' AS Date), N'13:00-16:00', N'Răng tốt. Tháng sau cần tái khám', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (25, 53, 4, CAST(N'2022-07-12' AS Date), N'12:00-17:30', N'Cần vệ sinh răng kĩ hơn', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (26, 11, 3, CAST(N'2022-07-14' AS Date), N'07:00-09:30', N'Răng tốt', CAST(2 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (27, 11, 3, CAST(N'2022-07-13' AS Date), N'07:00-09:00', NULL, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (28, 12, 3, CAST(N'2022-07-22' AS Date), N'07:00-09:00', NULL, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (29, 14, 3, CAST(N'2022-07-19' AS Date), N'07:00-09:30', NULL, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (30, 55, 4, CAST(N'2022-07-09' AS Date), N'07:30-10:00', NULL, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Appointment] ([id], [customer_id], [dentist_id], [time], [working_hour], [description], [status]) VALUES (31, 16, 6, CAST(N'2022-07-12' AS Date), N'07:00-09:00', NULL, CAST(1 AS Decimal(1, 0)))
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (19, 4)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (19, 5)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (19, 11)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (20, 3)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (20, 4)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (20, 5)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (21, 6)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (21, 10)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (21, 12)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (22, 3)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (22, 6)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (22, 19)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (23, 5)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (23, 6)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (23, 19)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (24, 3)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (24, 9)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (25, 5)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (25, 6)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (25, 11)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (26, 4)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (27, 22)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (28, 21)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (29, 4)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (30, 4)
INSERT [dbo].[Appointment_Service] ([appointment_id], [service_id]) VALUES (31, 3)
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (11, N'0123456789', N'Nguyen Tung Duong', CAST(N'2008-11-11' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (12, N'0987654321', N'Nguyen Quoc Bao', CAST(N'2000-10-11' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (13, N'0123123123', N'Nguyen Trung Hieu', CAST(N'2001-02-20' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (14, N'1234512345', N'Pham Xuan Kien', CAST(N'2000-01-11' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (15, N'1122334455', N'LÝ Nhã Kỳ', CAST(N'1980-11-11' AS Date), 0)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (16, N'0980980980', N'Trường Giang', CAST(N'1980-11-11' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (53, N'1222222222', N'vcdavcsf', CAST(N'1912-12-12' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (54, N'2221212121', N'2312321221', CAST(N'2001-11-11' AS Date), 1)
INSERT [dbo].[Customer] ([id], [phone], [name], [DOB], [gender]) VALUES (55, N'0986724745', N'Nguyễn Trần Trung Quân', CAST(N'1990-12-12' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (2, 1, N'Trồng răng sứ', N'Trồng răng sứ', 1.5, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (3, 1, N'Trồng răng vàng', N'Trồng răng vàng chất lượng cao', 2, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (4, 1, N'Trồng răng kim cương ', N'Trồng răng kim cương ', 2.5, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (5, 2, N'Nhổ răng sữa', N'Nhổ răng sữa', 0.5, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (6, 2, N'Nhổ răng khôn', N'Nhổ răng khôn', 2, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (9, 2, N'Nhổ răng sâu', N'Nhổ răng sâu', 1, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (10, 3, N'Tẩy trắng răng ', N'Tẩy trắng răng bị vàng do hút thuốc', 2, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (11, 4, N'Trám răng bằng amalgam', N'Trám răng bằng amalgam', 3, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (12, 4, N'Trám răng composite', N'Trám răng composite', 1, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (13, 4, N'Trám răng bằng vàng', N'Trám răng bằng vàng', 1, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (14, 4, N'rám răng bằng sứ', N'Trám răng bằng sứ (inlay, onlay) ', 1, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (19, 5, N'Niềng răng ngoài', N'Niềng răng mắc cài kim loại mặt ngoài', 1, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (20, 5, N'Niềng răng trong', N'Niềng răng mắc cài kim loại mặt trong (niềng răng mặt lưỡi)', 2, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (21, 5, N'Niềng răng nắp cài tự động', N'Niềng răng nắp cài tự động', 2, CAST(1 AS Decimal(1, 0)))
INSERT [dbo].[Service] ([id], [service_type_id], [name], [description], [estimated_time], [status]) VALUES (22, 6, N'Cạo vôi', N'Cạo vôi', 2, CAST(1 AS Decimal(1, 0)))
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[Service_Type] ON 

INSERT [dbo].[Service_Type] ([id], [name]) VALUES (1, N'Trồng răng')
INSERT [dbo].[Service_Type] ([id], [name]) VALUES (2, N'Nhổ răng')
INSERT [dbo].[Service_Type] ([id], [name]) VALUES (3, N'Làm trắng răng')
INSERT [dbo].[Service_Type] ([id], [name]) VALUES (4, N'Trám răng')
INSERT [dbo].[Service_Type] ([id], [name]) VALUES (5, N'Niềng răng')
INSERT [dbo].[Service_Type] ([id], [name]) VALUES (6, N'Khác')
SET IDENTITY_INSERT [dbo].[Service_Type] OFF
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD FOREIGN KEY([dentist_id])
REFERENCES [dbo].[Account] ([id])
GO
ALTER TABLE [dbo].[Appointment_Service]  WITH CHECK ADD FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointment] ([id])
GO
ALTER TABLE [dbo].[Appointment_Service]  WITH CHECK ADD FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([service_type_id])
REFERENCES [dbo].[Service_Type] ([id])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([role]>(0)))
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([estimated_time]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD CHECK  (([status]>(0)))
GO
ALTER TABLE [dbo].[Service_Type]  WITH CHECK ADD CHECK  (([id]>(0)))
GO
USE [master]
GO
ALTER DATABASE [DBS] SET  READ_WRITE 
GO
