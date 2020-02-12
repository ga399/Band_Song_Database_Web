SET IDENTITY_INSERT [dbo].[Song] ON
INSERT INTO [dbo].[Song] ([Id], [Title], [AlbumId], [MusicBandId], [ProducerId]) VALUES (1, N'In the End', 1, 1, 2)
INSERT INTO [dbo].[Song] ([Id], [Title], [AlbumId], [MusicBandId], [ProducerId]) VALUES (2, N'Larger Than life', 2, 2, 1)
SET IDENTITY_INSERT [dbo].[Song] OFF
