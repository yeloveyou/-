USE [EMS]
GO
/****** Object:  Table [dbo].[acnt]    Script Date: 2020/5/5 9:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[acnt](
	[msg_num] [varchar](50) NOT NULL,
	[acnt_pwd] [varchar](50) NOT NULL,
	[acnt_times] [int] NOT NULL,
	[acnt_updatetimes] [int] NULL,
 CONSTRAINT [PK_acnt] PRIMARY KEY CLUSTERED 
(
	[msg_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 2020/5/5 9:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[adminacnt] [nchar](10) NOT NULL,
	[adminpwd] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[msg]    Script Date: 2020/5/5 9:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msg](
	[msg_num] [varchar](50) NOT NULL,
	[msg_name] [varchar](20) NOT NULL,
	[msg_sex] [char](2) NOT NULL,
	[msg_birth] [date] NULL,
	[msg_native] [varchar](10) NULL,
	[msg_edu] [char](4) NOT NULL,
	[msg_add] [varchar](30) NULL,
	[msg_tel] [varchar](15) NULL,
	[msg_year] [int] NULL,
	[msg_sa] [int] NULL,
 CONSTRAINT [PK_msg] PRIMARY KEY CLUSTERED 
(
	[msg_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'001 ', N'2', 1, 3)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'002 ', N'1         ', 1, 1)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'003 ', N'1         ', 1, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'004 ', N'1         ', 1, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'005 ', N'1         ', 1, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'006 ', N'1         ', 1, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'007 ', N'1         ', 0, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'008 ', N'1         ', 0, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'009 ', N'1         ', 15, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'010 ', N'1         ', 20, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'011 ', N'1         ', 0, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'012 ', N'1         ', 5, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'013 ', N'1         ', 30, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'014 ', N'1         ', 10, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'015 ', N'1         ', 15, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'016 ', N'1         ', 10, NULL)
INSERT [dbo].[acnt] ([msg_num], [acnt_pwd], [acnt_times], [acnt_updatetimes]) VALUES (N'017 ', N'1         ', 0, NULL)
GO
INSERT [dbo].[admin] ([adminacnt], [adminpwd]) VALUES (N'admin     ', N'admin     ')
GO
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'001 ', N'有何', N'女', CAST(N'1999-01-01' AS Date), N'湖北', N'小学', N'武汉', N'17326', 10, 4700)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'002 ', N'叶震源', N'男', CAST(N'1900-01-01' AS Date), N'', N'本科', N'', N'', 10, 452412)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'003 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 323664)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'004 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 232223)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'005 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 544212)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'006 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 363323)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'007 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 512853)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'008 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 466654)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'009 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 346687)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'010 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 956233)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'011 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 542113)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'012 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 556230)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'013 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 845233)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'014 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 852637)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'015 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 956230)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'016 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 263263)
INSERT [dbo].[msg] ([msg_num], [msg_name], [msg_sex], [msg_birth], [msg_native], [msg_edu], [msg_add], [msg_tel], [msg_year], [msg_sa]) VALUES (N'017 ', N'enen ', N'男', CAST(N'1999-01-01' AS Date), N'湖北', N'本科', N'武汉', N'1111', 10, 915623)
GO
ALTER TABLE [dbo].[acnt] ADD  CONSTRAINT [DF_acnt_acnt_pwd]  DEFAULT ('1') FOR [acnt_pwd]
GO
ALTER TABLE [dbo].[acnt] ADD  CONSTRAINT [DF_acnt_acnt_times]  DEFAULT ((1)) FOR [acnt_times]
GO
ALTER TABLE [dbo].[acnt] ADD  CONSTRAINT [DF_acnt_acnt_updatetimes]  DEFAULT ((0)) FOR [acnt_updatetimes]
GO
ALTER TABLE [dbo].[msg]  WITH CHECK ADD  CONSTRAINT [FK_msg_acnt] FOREIGN KEY([msg_num])
REFERENCES [dbo].[acnt] ([msg_num])
GO
ALTER TABLE [dbo].[msg] CHECK CONSTRAINT [FK_msg_acnt]
GO
ALTER TABLE [dbo].[msg]  WITH CHECK ADD  CONSTRAINT [CK__msg__msg_edu__38996AB5] CHECK  (([msg_edu]='本科' OR [msg_edu]='小学' OR [msg_edu]='中学' OR [msg_edu]='其他'))
GO
ALTER TABLE [dbo].[msg] CHECK CONSTRAINT [CK__msg__msg_edu__38996AB5]
GO
ALTER TABLE [dbo].[msg]  WITH CHECK ADD  CONSTRAINT [CK__msg__msg_sex__37A5467C] CHECK  (([msg_sex]='男' OR [msg_sex]='女'))
GO
ALTER TABLE [dbo].[msg] CHECK CONSTRAINT [CK__msg__msg_sex__37A5467C]
GO
