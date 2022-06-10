CREATE DATABASE [KodotiSells]
GO
USE [KodotiSells]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 1/10/2019 11:57:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 1/10/2019 11:57:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Iva] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 1/10/2019 11:57:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Iva] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 1/10/2019 11:57:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([id], [Name]) VALUES (1, N'KODOTI')
INSERT [dbo].[Clients] ([id], [Name]) VALUES (2, N'Microsoft Inc')
INSERT [dbo].[Clients] ([id], [Name]) VALUES (3, N'Oracle Inc')
INSERT [dbo].[Clients] ([id], [Name]) VALUES (4, N'Java Inc')
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[InvoiceDetail] ON 

INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (1, 1, 1, 1, CAST(1500.00 AS Decimal(18, 2)), CAST(270.00 AS Decimal(18, 2)), CAST(1230.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (3, 1, 7, 3, CAST(250.00 AS Decimal(18, 2)), CAST(135.00 AS Decimal(18, 2)), CAST(615.00 AS Decimal(18, 2)), CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (4, 2, 7, 5, CAST(250.00 AS Decimal(18, 2)), CAST(225.00 AS Decimal(18, 2)), CAST(1025.00 AS Decimal(18, 2)), CAST(1250.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (5, 2, 8, 3, CAST(125.00 AS Decimal(18, 2)), CAST(67.50 AS Decimal(18, 2)), CAST(307.50 AS Decimal(18, 2)), CAST(375.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (67, 34, 1, 5, CAST(1500.00 AS Decimal(18, 2)), CAST(1350.00 AS Decimal(18, 2)), CAST(6150.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceDetail] ([id], [InvoiceId], [ProductId], [Quantity], [Price], [Iva], [SubTotal], [Total]) VALUES (68, 34, 8, 15, CAST(125.00 AS Decimal(18, 2)), CAST(337.50 AS Decimal(18, 2)), CAST(1537.50 AS Decimal(18, 2)), CAST(1875.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[InvoiceDetail] OFF
SET IDENTITY_INSERT [dbo].[Invoices] ON 

INSERT [dbo].[Invoices] ([id], [ClientId], [Iva], [SubTotal], [Total]) VALUES (1, 1, CAST(405.00 AS Decimal(18, 2)), CAST(1845.00 AS Decimal(18, 2)), CAST(2250.00 AS Decimal(18, 2)))
INSERT [dbo].[Invoices] ([id], [ClientId], [Iva], [SubTotal], [Total]) VALUES (2, 2, CAST(292.50 AS Decimal(18, 2)), CAST(1332.50 AS Decimal(18, 2)), CAST(1625.00 AS Decimal(18, 2)))
INSERT [dbo].[Invoices] ([id], [ClientId], [Iva], [SubTotal], [Total]) VALUES (34, 1, CAST(1687.50 AS Decimal(18, 2)), CAST(7687.50 AS Decimal(18, 2)), CAST(9375.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Invoices] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (1, N'Laptop de 14'''' Acer Core I3', CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (2, N'Laptop de 15'''' Asus Core I3', CAST(1700.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (4, N'Laptop de 15'''' Asus Core I5', CAST(2200.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (6, N'Laptop de 15'''' Acer Core I5', CAST(1900.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (7, N'Disco Sólido 1TB Samsung', CAST(250.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([id], [Name], [Price]) VALUES (8, N'Disco Sólido 500MB Kingston', CAST(125.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoices] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoices] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoices]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([id])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Products]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Clients] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Clients]
GO