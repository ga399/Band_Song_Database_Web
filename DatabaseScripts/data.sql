SET IDENTITY_INSERT [dbo].[Album] ON
INSERT INTO [dbo].[Album] ([Id], [AlbumName], [ReleaseDate]) VALUES (1, N'Hybrid Theory', N'2000-02-20 00:00:00')
INSERT INTO [dbo].[Album] ([Id], [AlbumName], [ReleaseDate]) VALUES (2, N'Millenium', N'2000-05-21 00:00:00')
SET IDENTITY_INSERT [dbo].[Album] OFF
SET IDENTITY_INSERT [dbo].[MusicBand] ON
INSERT INTO [dbo].[MusicBand] ([Id], [Name], [Established]) VALUES (1, N'Linkin Park', 1996)
INSERT INTO [dbo].[MusicBand] ([Id], [Name], [Established]) VALUES (2, N'Backstreet Boys', 1993)
SET IDENTITY_INSERT [dbo].[MusicBand] OFF
SET IDENTITY_INSERT [dbo].[Producer] ON
INSERT INTO [dbo].[Producer] ([Id], [Name], [WebSite]) VALUES (1, N'ABC Entertainment', N'http://www.abcent.com')
INSERT INTO [dbo].[Producer] ([Id], [Name], [WebSite]) VALUES (2, N'Rock''n''roll Music', N'http://rocknrolmusic.com')
SET IDENTITY_INSERT [dbo].[Producer] OFF
SET IDENTITY_INSERT [dbo].[Song] ON
INSERT INTO [dbo].[Song] ([Id], [Title], [AlbumId], [MusicBandId], [ProducerId]) VALUES (1, N'In the End', 1, 1, 2)
INSERT INTO [dbo].[Song] ([Id], [Title], [AlbumId], [MusicBandId], [ProducerId]) VALUES (2, N'Larger Than life', 2, 2, 1)
SET IDENTITY_INSERT [dbo].[Song] OFF
