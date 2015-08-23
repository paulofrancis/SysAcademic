USE [academic2]
GO

/****** Object:  Table [dbo].[curso]    Script Date: 24/07/2015 23:37:34 ******/
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'curso'))
BEGIN
    DROP TABLE [dbo].[curso]
END
GO

/****** Object:  Table [dbo].[curso]    Script Date: 24/07/2015 23:37:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[curso](
	[sigla] [varchar](5) NOT NULL,
	[nome] [varchar](255) NOT NULL,
 CONSTRAINT [PK_curso] PRIMARY KEY CLUSTERED 
(
	[sigla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[disciplina]    Script Date: 24/07/2015 23:37:41 ******/
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'disciplina'))
BEGIN
    DROP TABLE [dbo].[disciplina]
END
GO

/****** Object:  Table [dbo].[disciplina]    Script Date: 24/07/2015 23:37:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[disciplina](
	[sigla] [varchar](5) NOT NULL,
	[nome] [varchar](255) NOT NULL,
 CONSTRAINT [PK_disciplina] PRIMARY KEY CLUSTERED 
(
	[sigla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


/****** Object:  Table [dbo].[nota]    Script Date: 24/07/2015 23:37:45 ******/
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'nota'))
BEGIN
    DROP TABLE [dbo].[nota]
END
GO

/****** Object:  Table [dbo].[nota]    Script Date: 24/07/2015 23:37:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[nota](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[disciplina] [varchar](5) NOT NULL,
	[valor] [decimal](5, 2) NOT NULL,
	[data] [datetime] NOT NULL,
 CONSTRAINT [PK_nota] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


