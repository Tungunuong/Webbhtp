USE [BanHangThucPham]
GO
/****** Object:  Table [dbo].[tb_About]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_About](
	[AboutId] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_About] PRIMARY KEY CLUSTERED 
(
	[AboutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Adv]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Adv](
	[AdvId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[Type] [int] NULL,
	[Link] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Adv] PRIMARY KEY CLUSTERED 
(
	[AdvId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Blog]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Blog](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](500) NULL,
	[CreatedDate] [nvarchar](150) NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[Description] [nvarchar](4000) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Blog] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Cart]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Cart](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[Close] [nvarchar](150) NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[Price] [ntext] NULL,
	[Quantity] [int] NULL,
	[Total] [ntext] NULL,
	[IsNew] [bit] NOT NULL,
	[IsBestSeller] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Cart] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CategoryProduct]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CategoryProduct](
	[CategoryProductId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[Icon] [nvarchar](500) NULL,
	[Position] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_CategoryProduct] PRIMARY KEY CLUSTERED 
(
	[CategoryProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Comment_Home]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Comment_Home](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](500) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Comment_Home] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Contact]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](150) NULL,
	[Message] [nvarchar](max) NULL,
	[IsRead] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_tb_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Menu]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Menu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[Position] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Menu_1] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_News]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_News](
	[NewsId] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](500) NULL,
	[CreatedDate] [nvarchar](150) NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[Description] [nvarchar](4000) NULL,
	[Detail] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_News] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Order]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nchar](10) NULL,
	[CustomerName] [nvarchar](150) NULL,
	[Phone] [nvarchar](15) NULL,
	[Address] [nvarchar](250) NULL,
	[TotalAmount] [int] NULL,
	[Quanlity] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](150) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](150) NULL,
 CONSTRAINT [PK_tb_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_OrderDetail]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_OrderDetail](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tb_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Product]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Product](
	[ProductdID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Alias] [nvarchar](250) NULL,
	[Image] [nvarchar](500) NULL,
	[Price] [ntext] NULL,
	[PriceSale] [ntext] NULL,
	[Quantity] [int] NULL,
	[IsNew] [bit] NOT NULL,
	[IsBestSeller] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CategoryProductId] [int] NULL,
 CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED 
(
	[ProductdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ProductHome]    Script Date: 14/12/2022 3:06:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ProductHome](
	[ProductHomeIdID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Alias] [nvarchar](250) NULL,
	[Image] [nvarchar](500) NULL,
	[Price] [ntext] NULL,
	[PriceSale] [ntext] NULL,
	[Quantity] [int] NULL,
	[IsNew] [bit] NOT NULL,
	[IsBestSeller] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_ProductHome] PRIMARY KEY CLUSTERED 
(
	[ProductHomeIdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Setting]    Script Date: 14/12/2022 3:06:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Setting](
	[SettingId] [int] IDENTITY(1,1) NOT NULL,
	[SettingKey] [nvarchar](100) NULL,
	[SettingValue] [nvarchar](max) NULL,
	[SettingDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_tb_Setting] PRIMARY KEY CLUSTERED 
(
	[SettingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ShopNow_Home]    Script Date: 14/12/2022 3:06:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ShopNow_Home](
	[ShopNowId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](500) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_ShopNow_Home] PRIMARY KEY CLUSTERED 
(
	[ShopNowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Slide]    Script Date: 14/12/2022 3:06:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Slide](
	[SlideId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](500) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Slide] PRIMARY KEY CLUSTERED 
(
	[SlideId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Subscribe]    Script Date: 14/12/2022 3:06:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Subscribe](
	[SubscribeId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](250) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_tb_Subscribe] PRIMARY KEY CLUSTERED 
(
	[SubscribeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Wishlist]    Script Date: 14/12/2022 3:06:53 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Wishlist](
	[WishlistId] [int] IDENTITY(1,1) NOT NULL,
	[Close] [nvarchar](150) NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Detail] [nvarchar](max) NULL,
	[Price] [ntext] NULL,
	[Quantity] [int] NULL,
	[Total] [ntext] NULL,
	[IsNew] [bit] NOT NULL,
	[IsBestSeller] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Wishlist] PRIMARY KEY CLUSTERED 
(
	[WishlistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_Blog] ON 

INSERT [dbo].[tb_Blog] ([BlogId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [IsActive]) VALUES (1, N'/images/image_1.jpg', N'July 20, 2019', N'Admin', N'Even the all-powerful Pointing has no control about the blind texts', N'Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.', 1)
INSERT [dbo].[tb_Blog] ([BlogId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [IsActive]) VALUES (3, N'/images/image_2.jpg', N'July 20, 2019', N'Admin', N'Even the all-powerful Pointing has no control about the blind texts', N'Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.', 1)
INSERT [dbo].[tb_Blog] ([BlogId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [IsActive]) VALUES (4, N'/images/image_3.jpg', N'July 20, 2019', N'Admin', N'Even the all-powerful Pointing has no control about the blind texts', N'Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.', 1)
SET IDENTITY_INSERT [dbo].[tb_Blog] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_CategoryProduct] ON 

INSERT [dbo].[tb_CategoryProduct] ([CategoryProductId], [Title], [Alias], [Description], [Icon], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (1, N'Vegetables', N'Vegetables', N'/Vegetables', NULL, 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_CategoryProduct] ([CategoryProductId], [Title], [Alias], [Description], [Icon], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (2, N'Fruits', N'Fruits', N'/Fruits', NULL, 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_CategoryProduct] ([CategoryProductId], [Title], [Alias], [Description], [Icon], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (3, N'Fresh meat', N'Fresh meat', N'/Freshmeat', NULL, 3, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_CategoryProduct] ([CategoryProductId], [Title], [Alias], [Description], [Icon], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (4, N'Organic food', N'Organic food', N'/Organicfood', NULL, 4, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_CategoryProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Comment_Home] ON 

INSERT [dbo].[tb_Comment_Home] ([CommentId], [Title], [Alias], [Description], [Detail], [Image], [IsActive]) VALUES (1, N'Garreth Smith', N'Garreth Smith', N'Marketing Manager', N'Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.', N'/images/person_1.jpg', 1)
INSERT [dbo].[tb_Comment_Home] ([CommentId], [Title], [Alias], [Description], [Detail], [Image], [IsActive]) VALUES (2, N'Tu', N'tu', N'Marketing Manager', N'Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.', N'/images/person_2.jpg', 1)
SET IDENTITY_INSERT [dbo].[tb_Comment_Home] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Contact] ON 

INSERT [dbo].[tb_Contact] ([ContactId], [Name], [Phone], [Email], [Message], [IsRead], [CreatedDate]) VALUES (1, N'User name', N'User name', N'daoviettu26@gmail.com', N'test', 0, CAST(N'2022-12-12T11:31:39.870' AS DateTime))
INSERT [dbo].[tb_Contact] ([ContactId], [Name], [Phone], [Email], [Message], [IsRead], [CreatedDate]) VALUES (2, N'đào viết tú', N'đào viết tú', N'19574802010047@vinhuni.edu', N'test', 0, CAST(N'2022-12-12T11:35:48.167' AS DateTime))
INSERT [dbo].[tb_Contact] ([ContactId], [Name], [Phone], [Email], [Message], [IsRead], [CreatedDate]) VALUES (3, N'tu dao', N'123', N'tudao@gmail.com', N'noi', 0, CAST(N'2022-12-12T15:06:22.967' AS DateTime))
INSERT [dbo].[tb_Contact] ([ContactId], [Name], [Phone], [Email], [Message], [IsRead], [CreatedDate]) VALUES (4, N'tu', N'123', N'19574802010047@vinhuni.edu', N'ok', 0, CAST(N'2022-12-14T10:13:42.907' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_Contact] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Menu] ON 

INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (1, N'Home', N'Home', NULL, 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (2, N'News', N'news', NULL, 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (3, N'Shop', N'shop', NULL, 3, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (4, N'Category', N'category', NULL, 4, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (5, N'About', N'about', NULL, 5, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (6, N'Review', N'review', NULL, 6, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (7, N'Blog', N'blog', NULL, 7, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tb_Menu] ([MenuId], [Title], [Alias], [Description], [Position], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsActive]) VALUES (8, N'Contact', N'contact', NULL, 8, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_News] ON 

INSERT [dbo].[tb_News] ([NewsId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [Link], [IsActive]) VALUES (1, N'/images/news_1.jpg', N'10/12/2022', N'Admin', N'Giá cả thị trường hôm nay 10/12/2022: Rau củ quả tươi các loại chất lượng, giá tốt tại siêu thị', N'Giá cả thị trường hôm nay (10/12) ghi nhận, giá nhiều loại rau củ tươi xanh tại hệ thống siêu thị Farmers'' Market và Co.op Mart đều ổn định. Trong khi đó, gạo, dầu ăn và hóa mỹ phẩm các loại...', N'https://vietnammoi.vn/gia-ca-thi-truong-hom-nay-10122022-rau-cu-qua-tuoi-cac-loai-chat-luong-gia-tot-tai-sieu-thi-202212108195044.htm', 1)
INSERT [dbo].[tb_News] ([NewsId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [Link], [IsActive]) VALUES (3, N'/images/news_2.jpg', N'09/12/2022', N'Admin', N'Giá heo hơi hôm nay 9/12: Tăng rải rác 1.000 đồng/kg', N'Giá heo hơi hôm nay (9/12) tăng nhẹ 1.000 đồng/kg tại một vài địa phương. Các hợp tác xã chăn nuôi mong đợi chính sách điều tiết của ngành chức năng để tiêu thụ nhanh, đảm bảo người...', N'https://vietnammoi.vn/gia-heo-hoi-hom-nay-912-tang-rai-rac-1000-dongkg-202212815486297.htm', 1)
INSERT [dbo].[tb_News] ([NewsId], [Image], [CreatedDate], [CreatedBy], [Description], [Detail], [Link], [IsActive]) VALUES (4, N'/images/news_3.jpg', N'08/12/2022', N'Admin', N'Giá cả thị trường hôm nay 8/12/2022: Rau củ quả giữ giá ổn định tại các siêu thị', N'Giá cả thị trường hôm nay (8/12) ghi nhận, rau củ quả các loại được ghi nhận bán với giá không đổi. Tương tự, giá các loại thịt bò và trái cây tại các hệ thống siêu thị cũng không tăng giảm...', N'https://vietnammoi.vn/gia-ca-thi-truong-hom-nay-8122022-rau-cu-qua-giu-gia-on-dinh-tai-cac-sieu-thi-202212872752280.htm', 1)
SET IDENTITY_INSERT [dbo].[tb_News] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Product] ON 

INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (2, N'Bell Pepper', N'Bell Pepper', N'/images/product-1.jpg', N'$120.00', N'$80.00', 1, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (3, N'Strawberry', N'Strawberry', N'/images/product-2.jpg', NULL, N'$120.00', 1, 1, 1, 1, 2)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (5, N'Green Beans', N'Green Beans', N'/images/product-3.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (6, N'Purple Cabbage', N'Purple Cabbage', N'/images/product-4.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (7, N'TOMATOE', N'TOMATOE', N'/images/product-5.jpg', N'$120.00', N'$80.00', NULL, 1, 1, 1, 2)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (8, N'BROCOLLI', N'BROCOLLI', N'/images/product-6.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (9, N'CARROTS', N'CARROTS', N'/images/product-7.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (10, N'FRUIT JUICE', N'FRUIT JUICE', N'/images/product-8.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 4)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (11, N'ONION', N'ONION', N'/images/product-9.jpg', N'$120.00', N'$80.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (12, N'APPLE', N'APPLE', N'/images/product-10.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 2)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (14, N'GARLIC', N'GARLIC', N'/images/product-11.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (16, N'CHILLI', N'CHILLI', N'/images/product-12.jpg', NULL, N'$120.00', NULL, 1, 1, 1, 1)
INSERT [dbo].[tb_Product] ([ProductdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive], [CategoryProductId]) VALUES (17, N'Beef', N'Beef', N'/images/product-13.jpg', N'$120.00', N'$80.00', NULL, 1, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[tb_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_ProductHome] ON 

INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (1, N'Bell Pepper', N'Bell Pepper', N'/images/product-1.jpg', N'$120.00', N'$80.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (7, N'Strawberry', N'Strawberry', N'/images/product-2.jpg', N'', N'$120.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (9, N'Green Beans', N'Green Beans', N'/images/product-3.jpg', N'', N'$120.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (10, N'Purple Cabbage', N'Purple Cabbage', N'/images/product-4.jpg', N'', N'$120.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (12, N'Tomatoe', N'Tomatoe', N'/images/product-5.jpg', N'$120.00', N'$80.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (13, N'Brocolli', N'Brocolli', N'/images/product-6.jpg', N'', N'$120.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (14, N'Carrots', N'Carrots', N'/images/product-7.jpg', N'', N'$120.00', 1, 1, 1, 1)
INSERT [dbo].[tb_ProductHome] ([ProductHomeIdID], [Title], [Alias], [Image], [Price], [PriceSale], [Quantity], [IsNew], [IsBestSeller], [IsActive]) VALUES (15, N'Fruit Juice', N'Fruit Juice', N'/images/product-8.jpg', N'', N'$120.00', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[tb_ProductHome] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_ShopNow_Home] ON 

INSERT [dbo].[tb_ShopNow_Home] ([ShopNowId], [Title], [Alias], [Description], [Detail], [Image], [IsActive]) VALUES (1, NULL, NULL, NULL, NULL, N'/images/category.jpg', 1)
SET IDENTITY_INSERT [dbo].[tb_ShopNow_Home] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Slide] ON 

INSERT [dbo].[tb_Slide] ([SlideId], [Title], [Alias], [Description], [Detail], [Image], [IsActive]) VALUES (1, NULL, NULL, N'We serve Fresh Vegestables & Fruits', N'We deliver organic vegetables & fruits', N'/images/bg_1.jpg', 1)
INSERT [dbo].[tb_Slide] ([SlideId], [Title], [Alias], [Description], [Detail], [Image], [IsActive]) VALUES (2, NULL, NULL, N'100% Fresh & Organic Foods', N'We deliver organic vegetables & fruits', N'/images/bg_2.jpg', 1)
SET IDENTITY_INSERT [dbo].[tb_Slide] OFF
GO
ALTER TABLE [dbo].[tb_Menu] ADD  CONSTRAINT [DF_tb_Menu_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tb_OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tb_OrderDetail_tb_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[tb_Order] ([OrderId])
GO
ALTER TABLE [dbo].[tb_OrderDetail] CHECK CONSTRAINT [FK_tb_OrderDetail_tb_Order]
GO
ALTER TABLE [dbo].[tb_Product]  WITH CHECK ADD  CONSTRAINT [fk_CategoryProductId] FOREIGN KEY([CategoryProductId])
REFERENCES [dbo].[tb_CategoryProduct] ([CategoryProductId])
GO
ALTER TABLE [dbo].[tb_Product] CHECK CONSTRAINT [fk_CategoryProductId]
GO
