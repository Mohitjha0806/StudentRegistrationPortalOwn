USE [StudentEducationPortalDb]
GO
/****** Object:  Table [dbo].[tblStudentRegTable]    Script Date: 12/28/2024 3:42:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudentRegTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AcademicYear] [bit] NOT NULL,
	[SchoolUDISECode] [char](11) NOT NULL,
	[SchoolName] [varchar](50) NOT NULL,
	[SchoolNameHindi] [nvarchar](50) NOT NULL,
	[YearOfEstablishment] [date] NOT NULL,
	[BoardTypeCode] [tinyint] NOT NULL,
	[BoardCode] [bit] NOT NULL,
	[SchoolTypeCode] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
