USE [band_tracker]
GO
/****** Object:  Table [dbo].[bands]    Script Date: 3/3/2017 3:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bands_venues]    Script Date: 3/3/2017 3:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bands_venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[band_id] [int] NULL,
	[venue_id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[venues]    Script Date: 3/3/2017 3:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[bands] ON 

INSERT [dbo].[bands] ([id], [name]) VALUES (5, N'Radiohead')
INSERT [dbo].[bands] ([id], [name]) VALUES (6, N'Fleetwood Mac')
INSERT [dbo].[bands] ([id], [name]) VALUES (7, N'U2')
SET IDENTITY_INSERT [dbo].[bands] OFF
SET IDENTITY_INSERT [dbo].[bands_venues] ON 

INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (1, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (2, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (3, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (4, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (5, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (6, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (7, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (8, 3, 4)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (9, 3, 5)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (10, 4, 8)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (11, 4, 8)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (12, 4, 10)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (13, 5, 13)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (14, 5, 15)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (15, 5, 17)
INSERT [dbo].[bands_venues] ([id], [band_id], [venue_id]) VALUES (16, 6, 17)
SET IDENTITY_INSERT [dbo].[bands_venues] OFF
SET IDENTITY_INSERT [dbo].[venues] ON 

INSERT [dbo].[venues] ([id], [name]) VALUES (17, N'Key Arena')
SET IDENTITY_INSERT [dbo].[venues] OFF
