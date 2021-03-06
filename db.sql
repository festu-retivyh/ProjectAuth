USE [master]
GO
CREATE DATABASE [ProjectAuth_DB]
GO
ALTER DATABASE [ProjectAuth_DB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectAuth_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectAuth_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectAuth_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectAuth_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectAuth_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectAuth_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectAuth_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectAuth_DB] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectAuth_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectAuth_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectAuth_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectAuth_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectAuth_DB', N'ON'
GO
USE [ProjectAuth_DB]
GO

/****** Object:  StoredProcedure [dbo].[AddProfileForClient]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[AddProfileForClient] 
	@clientId int,
	@profileId int
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [dbo].[ClientProfile] VALUES(@clientId, @profileId)
	--SELECT 'good' as g
END

GO
/****** Object:  StoredProcedure [dbo].[ClearClientProfile]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ClearClientProfile] 
	@clientId int
AS
BEGIN
	SET NOCOUNT ON;

    DELETE FROM [dbo].[ClientProfile] WHERE [ClientProfile].clientid=@clientId

	--SELECT 'good' as g
END

GO
/****** Object:  StoredProcedure [dbo].[GetCertificate]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCertificate] 
	@guid nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * from [dbo].[Certificate] where [guid] = @guid
END

GO
/****** Object:  StoredProcedure [dbo].[GetClientProfiles]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientProfiles] 
	@clientId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Port AS Port, Srv AS [Address], profId AS profileId  
	FROM 
		(SELECT [profile].id AS profId, 
			[profile].programId AS Prog, 
			(Select [address] 
			from 
				[server] 
			where 
				[Server].id = [Profile].serverId) AS Srv 
	FROM 
		[profile] 
			right outer join 
		(SELECT ClientProfile.profileId from ClientProfile Where ClientProfile.clientId=@clientId) as filter 
			on 
		[Profile].id = filter.profileId) AS myprofile left outer join [Port] on [Port].programId=Prog

END

GO
/****** Object:  StoredProcedure [dbo].[GetPartKey]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPartKey] 
	@guid nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT TOP(1) [partKey] from [dbo].[Usb] inner join [dbo].[Client] on [usbId]=[dbo].[Usb].[id] Where [dbo].[Client].[guid]=@guid
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsbCert]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsbCert]
	-- Add the parameters for the stored procedure here
	@guid nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [Certificate].[guid],[publicKey],[dateStart],[dateStop],[date],[delated] FROM [dbo].[Certificate] inner join [dbo].[Usb] on [certificateId] = [Certificate].[id]
		where [dbo].[Usb].[guid] = @guid
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsbCertificateOfClient]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUsbCertificateOfClient] 
	
	@guid nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    Select [publicKey],[dateStart],[dateStop],[date],[delated],2 as [type] FROM (SELECT [certificateId] AS Cert from (Select TOP(1) [usbId] AS Usb from [dbo].[Client] where [guid]=@guid) AS tclient Left join [dbo].[Usb] on tclient.usb=[dbo].[Usb].[id]) AS Usb left join [dbo].[Certificate] on Usb.[Cert]=[dbo].[Certificate].[id]

END

GO
/****** Object:  StoredProcedure [dbo].[InsertCertificate]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCertificate] 
	@publicKey nvarchar(MAX), 
	@type int,
	@start date,
	@stop date,
	@date datetime,
	@sign nvarchar(100),
	@guid nvarchar(100) = null
AS
BEGIN
	declare @idCertificate int;
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Certificate] ([publicKey], [typeId], [dateStart], [dateStop], [date], [delated], [Sing],[guid]) VALUES (@publicKey, @type, @start, @stop, @date, 0, @sign, @guid);
	SELECT @idCertificate = SCOPE_IDENTITY();
	EXEC [dbo].[InsertCertStatus] @idCert=@idCertificate , @idStatus=1
	select @idCertificate
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCertStatus]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCertStatus] 
	@idCert int, 
	@idStatus int
	/*,@date DateTime*/

AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO [dbo].[CertificateStatus] ([CertificateId], [statusId], [date]) VALUES (@idCert, @idStatus, GETDATE());
END

GO
/****** Object:  StoredProcedure [dbo].[InsertClient]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertClient] 
	@usbId int,
	@userId int,
	@guid nvarchar(100) = '', 
	@certificateId int = Null
AS
BEGIN
	SET NOCOUNT ON;
	declare @id int;

	INSERT INTO [dbo].[Client] ([guid], [cerificateId], [usbId], [userId]) VALUES (@guid, @certificateId, @usbId, @userId);
	
	SELECT @id = SCOPE_IDENTITY();
	/*INSERT INTO [dbo].[ClientState] ([date], [clientId], [stateId]) VALUES (GETDATE(), @id, 1);*/
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[InsertServer]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertServer] 
	@name nvarchar(50), 
	@address nvarchar(50),
	@guid nvarchar(100),
	@certId int
AS
BEGIN
	
	SET NOCOUNT ON;
	declare @id int;

	INSERT INTO [dbo].[Server] ([date], [name], [address], [guid], [certificateId]) VALUES (GETDATE(), @name, @address,@guid, @certId);
	
	SELECT @id = SCOPE_IDENTITY();
	
	UPDATE [dbo].[Certificate]
	SET [guid] = @guid
	WHERE [id] = @id
	
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[insertTempGuid]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertTempGuid] 
	@guid nvarchar(100),
	@guidObj nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @idObj int = 0;
    select @idObj=id from [dbo].[Client] WHERE [guid]=@guidObj
	if  @idObj=0 
		select @idObj=id from [dbo].[Server] WHERE [guid]=@guidObj
	If @idObj=0
		select @idObj=id from [dbo].[Usb] WHERE [guid]=@guidObj
	if @idObj=0 
		select 0;
	else
		begin
			INSERT INTO [dbo].[TempGuid] ([guid], [date], [clientId]) VALUES (@guid, GETDATE(), @idObj);
			select 1;
		end

END

GO
/****** Object:  StoredProcedure [dbo].[InsertUsb]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUsb] 
	@guid nvarchar(100), 
	@certificateId int,
	@hash nvarchar(100),
	@partKey nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	declare @id int;
    INSERT INTO [dbo].[Usb] ([guid], [certificateId], [partKey], [hash]) VALUES (@guid, @certificateId, @partKey, @hash);
	SELECT @id = SCOPE_IDENTITY();
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUser] 
	@fname nvarchar(25), 
	@name nvarchar(25),
	@sname nvarchar(25),
	@login nvarchar(25),
	@domain nvarchar(25)
AS
BEGIN
	SET NOCOUNT ON;
	declare @id int;
    INSERT INTO [dbo].[User] ([fname], [name], [sname], [login], [domain], [delated]) VALUES (@fname, @name, @sname, @login, @domain, 0);
	SELECT @id = SCOPE_IDENTITY();
	select @id
END

GO
/****** Object:  StoredProcedure [dbo].[RegistrateClient]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[RegistrateClient]
	
	@guidUsb nvarchar(100), 
	@guidClient nvarchar(100),
	@idCert int
AS
BEGIN
	SET NOCOUNT ON;
	Declare @idUSB int
	Declare @idClient int
	Declare @idCertUSB int
	Select @idUSB = id, @idCertUSB = [certificateId] from [dbo].[Usb] WHERE [guid]=@guidUsb
	Select @idClient = client.id from [dbo].[Client] inner join [dbo].[Usb] on usbId=usb.id WHERE usb.id=@idUsb
	UPDATE [dbo].[Client]
	SET [guid] = @guidClient, [cerificateId] = @idCert
	WHERE [usbId] = @idUSB
	UPDATE [dbo].[Certificate]
	SET [guid] = @guidClient
	WHERE [id] = @idCert
	UPDATE [dbo].[Certificate]
	SET [guid] = @guidUsb
	WHERE [id] = @idCertUSB
	select Top(1) id from [dbo].[Client] where [guid] = @guidClient
END

GO
/****** Object:  Table [dbo].[Certificate]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guid] [nvarchar](100) NULL,
	[publicKey] [nvarchar](max) NOT NULL,
	[typeId] [int] NOT NULL,
	[dateStart] [date] NOT NULL,
	[dateStop] [date] NOT NULL,
	[date] [datetime] NOT NULL,
	[delated] [bit] NOT NULL,
	[Sing] [nvarchar](100) NULL,
 CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CertificateStatus]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CertificateStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CertificateId] [int] NOT NULL,
	[statusId] [int] NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK_ClientStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guid] [nvarchar](100) NULL,
	[cerificateId] [int] NULL,
	[usbId] [int] NULL,
	[userId] [int] NOT NULL,
	[address] [nvarchar](15) NULL,
 CONSTRAINT [PK_Client_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientProfile]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientProfile](
	[clientId] [int] NOT NULL,
	[profileId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientState]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientState](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NOT NULL,
	[clientId] [int] NOT NULL,
	[stateId] [int] NOT NULL,
 CONSTRAINT [PK_ClientState] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Group]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_typeClient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupProfile]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProfile](
	[groupId] [int] NOT NULL,
	[profileId] [int] NOT NULL,
 CONSTRAINT [PK_GroupProfile] PRIMARY KEY CLUSTERED 
(
	[groupId] ASC,
	[profileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Log]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[text] [nvarchar](max) NULL,
	[date] [datetime] NOT NULL,
	[typeLogId] [int] NOT NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profile]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[programId] [int] NOT NULL,
	[serverId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_profile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Program]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Program](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[port] [nvarchar](150) NOT NULL,
	[protocol] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_Program] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Server]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Server](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](15) NOT NULL,
	[guid] [nvarchar](100) NOT NULL,
	[certificateId] [int] NULL,
	[protocols] [nvarchar](60) NULL,
 CONSTRAINT [PK_Server] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[State]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Status]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempGuid]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempGuid](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guid] [nvarchar](100) NOT NULL,
	[date] [datetime] NOT NULL,
	[clientId] [int] NOT NULL,
 CONSTRAINT [PK_TempGuid] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parametrs]    Script Date: 05.06.2016 19:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametrs](
	[property] [nvarchar](50) NOT NULL,
	[value] [nvarchar](max) NULL,
 CONSTRAINT [PK_Parametrs] PRIMARY KEY CLUSTERED 
(
	[property] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeCertificate]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeCertificate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_TypeCertificate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeLog]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeLog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usb]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usb](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[guid] [nvarchar](100) NOT NULL,
	[certificateId] [int] NULL,
	[partKey] [nvarchar](50) NULL,
	[hash] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Usb] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](25) NOT NULL,
	[name] [nvarchar](25) NOT NULL,
	[sname] [nvarchar](25) NULL,
	[login] [nvarchar](50) NOT NULL,
	[domain] [nvarchar](50) NULL,
	[delated] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[LastClientsStates]    Script Date: 04.06.2016 17:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LastClientsStates]
AS
SELECT        ClientState_1.id, ClientState_1.date, ClientState_1.clientId, ClientState_1.stateId, dbo.Client.address, dbo.[User].fname + ' ' + dbo.[User].name + ' ' + dbo.[User].sname AS NameUser, dbo.[User].login
FROM            (SELECT        MAX(date) AS maxDate, clientId
                          FROM            dbo.ClientState
                          GROUP BY clientId) AS filter LEFT OUTER JOIN
                         dbo.ClientState AS ClientState_1 ON filter.clientId = ClientState_1.clientId AND filter.maxDate = ClientState_1.date LEFT OUTER JOIN
                         dbo.Client ON ClientState_1.clientId = dbo.Client.id LEFT OUTER JOIN
                         dbo.[User] ON dbo.Client.userId = dbo.[User].id

GO
ALTER TABLE [dbo].[Certificate]  WITH CHECK ADD  CONSTRAINT [FK_Certificate_TypeCertificate] FOREIGN KEY([typeId])
REFERENCES [dbo].[TypeCertificate] ([id])
GO
ALTER TABLE [dbo].[Certificate] CHECK CONSTRAINT [FK_Certificate_TypeCertificate]
GO
ALTER TABLE [dbo].[CertificateStatus]  WITH CHECK ADD  CONSTRAINT [FK_CertificateStatus_Certificate] FOREIGN KEY([CertificateId])
REFERENCES [dbo].[Certificate] ([id])
GO
ALTER TABLE [dbo].[CertificateStatus] CHECK CONSTRAINT [FK_CertificateStatus_Certificate]
GO
ALTER TABLE [dbo].[CertificateStatus]  WITH CHECK ADD  CONSTRAINT [FK_ClientStatus_Status] FOREIGN KEY([statusId])
REFERENCES [dbo].[Status] ([id])
GO
ALTER TABLE [dbo].[CertificateStatus] CHECK CONSTRAINT [FK_ClientStatus_Status]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Certificate] FOREIGN KEY([cerificateId])
REFERENCES [dbo].[Certificate] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Certificate]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Usb] FOREIGN KEY([usbId])
REFERENCES [dbo].[Usb] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Usb]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_User]
GO
ALTER TABLE [dbo].[ClientProfile]  WITH CHECK ADD  CONSTRAINT [FK_ClientProfile_Client] FOREIGN KEY([clientId])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[ClientProfile] CHECK CONSTRAINT [FK_ClientProfile_Client]
GO
ALTER TABLE [dbo].[ClientProfile]  WITH CHECK ADD  CONSTRAINT [FK_ClientProfile_Profile] FOREIGN KEY([profileId])
REFERENCES [dbo].[Profile] ([id])
GO
ALTER TABLE [dbo].[ClientProfile] CHECK CONSTRAINT [FK_ClientProfile_Profile]
GO
ALTER TABLE [dbo].[ClientState]  WITH CHECK ADD  CONSTRAINT [FK_ClientState_Client] FOREIGN KEY([clientId])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[ClientState] CHECK CONSTRAINT [FK_ClientState_Client]
GO
ALTER TABLE [dbo].[ClientState]  WITH CHECK ADD  CONSTRAINT [FK_ClientState_State] FOREIGN KEY([stateId])
REFERENCES [dbo].[State] ([id])
GO
ALTER TABLE [dbo].[ClientState] CHECK CONSTRAINT [FK_ClientState_State]
GO
ALTER TABLE [dbo].[GroupProfile]  WITH CHECK ADD  CONSTRAINT [FK_GroupProfile_Group] FOREIGN KEY([groupId])
REFERENCES [dbo].[Group] ([id])
GO
ALTER TABLE [dbo].[GroupProfile] CHECK CONSTRAINT [FK_GroupProfile_Group]
GO
ALTER TABLE [dbo].[GroupProfile]  WITH CHECK ADD  CONSTRAINT [FK_GroupProfile_profile] FOREIGN KEY([profileId])
REFERENCES [dbo].[Profile] ([id])
GO
ALTER TABLE [dbo].[GroupProfile] CHECK CONSTRAINT [FK_GroupProfile_profile]
GO
ALTER TABLE [dbo].[Log]  WITH CHECK ADD  CONSTRAINT [FK_Log_TypeLog] FOREIGN KEY([typeLogId])
REFERENCES [dbo].[TypeLog] ([id])
GO
ALTER TABLE [dbo].[Log] CHECK CONSTRAINT [FK_Log_TypeLog]
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_profile_Program] FOREIGN KEY([programId])
REFERENCES [dbo].[Program] ([id])
GO
ALTER TABLE [dbo].[Profile] CHECK CONSTRAINT [FK_profile_Program]
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_profile_Server] FOREIGN KEY([serverId])
REFERENCES [dbo].[Server] ([id])
GO
ALTER TABLE [dbo].[Profile] CHECK CONSTRAINT [FK_profile_Server]
GO
ALTER TABLE [dbo].[Server]  WITH CHECK ADD  CONSTRAINT [FK_Server_Certificate] FOREIGN KEY([certificateId])
REFERENCES [dbo].[Certificate] ([id])
GO
ALTER TABLE [dbo].[Server] CHECK CONSTRAINT [FK_Server_Certificate]
GO
ALTER TABLE [dbo].[TempGuid]  WITH CHECK ADD  CONSTRAINT [FK_TempGuid_Client] FOREIGN KEY([clientId])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[TempGuid] CHECK CONSTRAINT [FK_TempGuid_Client]
GO
ALTER TABLE [dbo].[Usb]  WITH CHECK ADD  CONSTRAINT [FK_Usb_Certificate] FOREIGN KEY([certificateId])
REFERENCES [dbo].[Certificate] ([id])
GO
ALTER TABLE [dbo].[Usb] CHECK CONSTRAINT [FK_Usb_Certificate]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "filter"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ClientState_1"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 136
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Client"
            Begin Extent = 
               Top = 6
               Left = 462
               Bottom = 136
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 232
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LastClientsStates'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LastClientsStates'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LastClientsStates'
GO
USE [master]
GO
ALTER DATABASE [ProjectAuth_DB] SET  READ_WRITE 
GO
USE [ProjectAuth_DB]
Insert INTO [dbo].[State] (name) VALUES ('Отключен');
Insert INTO [dbo].[State] (name) VALUES ('Подключен');
Insert INTO [dbo].[State] (name) VALUES ('Аутентификация');

Insert INTO [dbo].[Status] (name) VALUES ('Не активирован');
Insert INTO [dbo].[Status] (name) VALUES ('Действует');
Insert INTO [dbo].[Status] (name) VALUES ('Заблокирован');
Insert INTO [dbo].[Status] (name) VALUES ('Недействителен');

Insert INTO [dbo].[TypeCertificate] (name) VALUES ('USB');
Insert INTO [dbo].[TypeCertificate] (name) VALUES ('Клиент');
Insert INTO [dbo].[TypeCertificate] (name) VALUES ('Сервер');

Insert INTO [dbo].[TypeLog] (name) VALUES ('Событие');
Insert INTO [dbo].[TypeLog] (name) VALUES ('Возможное нарушение');
Insert INTO [dbo].[TypeLog] (name) VALUES ('Нарушение');
Insert INTO [dbo].[TypeLog] (name) VALUES ('Критическое нарушение');