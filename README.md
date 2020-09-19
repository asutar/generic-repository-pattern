# generic-repository-pattern

 Table script 
 
 CREATE TABLE [dbo].[EmployeeMaster](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [int] NULL,
	[Designation] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_EmployeeMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

This article introduces the Generic Repository pattern and Unit of Work in ASP.NET MVC applications. We are developing an application for a Employee entity on which we can do Create, Read, Update and Delete operations. To keep the article simple and to make it easy to understand, the Generic Repository pattern and Unit of Work, we use a single employee entity in the application.
********Please use table script and download asp.net mvc code********

