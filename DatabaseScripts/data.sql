SET IDENTITY_INSERT [dbo].[Sponsor] ON
INSERT INTO [dbo].[Sponsor] ([Id], [Name], [Email]) VALUES (1, N'Will McDonald', N'will@tech.com')
INSERT INTO [dbo].[Sponsor] ([Id], [Name], [Email]) VALUES (2, N'Jim Kerry', N'jim@tech.com')
SET IDENTITY_INSERT [dbo].[Sponsor] OFF
SET IDENTITY_INSERT [dbo].[Speaker] ON
INSERT INTO [dbo].[Speaker] ([Id], [Name], [Email]) VALUES (1, N'Jake Wilson', N'jake@talks.com')
INSERT INTO [dbo].[Speaker] ([Id], [Name], [Email]) VALUES (2, N'Kim Harris', N'kim@talks.com')
SET IDENTITY_INSERT [dbo].[Speaker] OFF
SET IDENTITY_INSERT [dbo].[Discussion] ON
INSERT INTO [dbo].[Discussion] ([Id], [Topic], [Description]) VALUES (1, N'Micro-services And Web apps', N'Scaling systems using Micro services architecture')
INSERT INTO [dbo].[Discussion] ([Id], [Topic], [Description]) VALUES (2, N'AI and Machine Learning', N'AI and machine learning for robotics applications')
SET IDENTITY_INSERT [dbo].[Discussion] OFF
SET IDENTITY_INSERT [dbo].[Schedule] ON
INSERT INTO [dbo].[Schedule] ([Id], [SpeakerId], [SponsorId], [DiscussionId], [ScheduledTime]) VALUES (1, 1, 1, 1, N'2020-11-03 10:00:00')
INSERT INTO [dbo].[Schedule] ([Id], [SpeakerId], [SponsorId], [DiscussionId], [ScheduledTime]) VALUES (2, 2, 2, 2, N'2020-11-05 14:00:00')
SET IDENTITY_INSERT [dbo].[Schedule] OFF
