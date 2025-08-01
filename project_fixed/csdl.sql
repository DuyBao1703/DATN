USE [master]
GO
/****** Object:  Database [Xuong_QuanLyXeMayLite]    Script Date: 5/31/2025 1:04:23 PM ******/
CREATE DATABASE [Xuong_QuanLyXeMayLite]
go
USE [Xuong_QuanLyXeMayLite]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [nvarchar](10) NOT NULL,
	[MaHD] [nvarchar](10) NOT NULL,
	[MaXe] [nvarchar](10) NOT NULL,
	[GiaBan] [decimal](10, 2) NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangXe]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHang] [nvarchar](10) NOT NULL,
	[TenHang] [nvarchar](255) NOT NULL,
	[QuocGia] [nvarchar](255) NOT NULL,
	[NamThanhLap] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[NgayBan] [date] NOT NULL,
	[NgayTao] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](255) NOT NULL,
	[SoDienThoai] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[CCCD] [nvarchar](20) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXeMay]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXeMay](
	[MaLoaiXe] [nvarchar](10) NOT NULL,
	[TenLoaiXe] [nvarchar](255) NOT NULL,
	[MoTa] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](255) NOT NULL,
	[TenTK] [nvarchar](255) NOT NULL,
	[MatKhauHash] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[SoDienThoai] [nvarchar](15) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[VaiTro] [bit] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[HinhAnh] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanKhoiXe]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanKhoiXe](
	[MaPhanKhoi] [nvarchar](10) NOT NULL,
	[DungTichCC] [int] NOT NULL,
	[MoTa] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhanKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiXe]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiXe](
	[MaTrangThaiXe] [nvarchar](10) NOT NULL,
	[TenTrangThaiXe] [nvarchar](255) NOT NULL,
	[GhiChu] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTrangThaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XeMay]    Script Date: 5/31/2025 1:04:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XeMay](
	[MaXe] [nvarchar](10) NOT NULL,
	[TenXe] [nvarchar](255) NOT NULL,
	[Mau] [nvarchar](255) NOT NULL,
	[MaHang] [nvarchar](10) NOT NULL,
	[MaLoaiXe] [nvarchar](10) NOT NULL,
	[GiaNhap] [decimal](10, 2) NOT NULL,
	[GiaBan] [decimal](10, 2) NOT NULL,
	[SoKhung] [nvarchar](255) NOT NULL,
	[SoMay] [nvarchar](255) NOT NULL,
	[HinhAnh] [text] NULL,
	[MaTrangThaiXe] [nvarchar](10) NOT NULL,
	[MaPhanKhoi] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaXe], [GiaBan], [SoLuong]) VALUES (N'CTHD001', N'HD00001', N'XM00001', CAST(18000000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaXe], [GiaBan], [SoLuong]) VALUES (N'CTHD002', N'HD00002', N'XM00002', CAST(31000000.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaXe], [GiaBan], [SoLuong]) VALUES (N'CTHD003', N'HD00003', N'XM00003', CAST(50000000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaXe], [GiaBan], [SoLuong]) VALUES (N'CTHD004', N'HD00004', N'XM00004', CAST(48000000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHD], [MaXe], [GiaBan], [SoLuong]) VALUES (N'CTHD005', N'HD00005', N'XM00005', CAST(17000000.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [QuocGia], [NamThanhLap]) VALUES (N'H001', N'Honda', N'Nhật Bản', 1948)
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [QuocGia], [NamThanhLap]) VALUES (N'H002', N'Yamaha', N'Nhật Bản', 1955)
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [QuocGia], [NamThanhLap]) VALUES (N'H003', N'Suzuki', N'Nhật Bản', 1909)
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [QuocGia], [NamThanhLap]) VALUES (N'H004', N'Piaggio', N'Ý', 1884)
INSERT [dbo].[HangXe] ([MaHang], [TenHang], [QuocGia], [NamThanhLap]) VALUES (N'H005', N'SYM', N'Ðài Loan', 1954)
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [NgayBan], [NgayTao]) VALUES (N'HD00001', N'NV00001', N'KH00001', CAST(N'2025-05-02' AS Date), CAST(N'2025-05-02' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [NgayBan], [NgayTao]) VALUES (N'HD00002', N'NV00002', N'KH00002', CAST(N'2025-05-03' AS Date), CAST(N'2025-05-03' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [NgayBan], [NgayTao]) VALUES (N'HD00003', N'NV00003', N'KH00003', CAST(N'2025-05-05' AS Date), CAST(N'2025-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [NgayBan], [NgayTao]) VALUES (N'HD00004', N'NV00004', N'KH00004', CAST(N'2025-05-10' AS Date), CAST(N'2025-05-10' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [NgayBan], [NgayTao]) VALUES (N'HD00005', N'NV00005', N'KH00005', CAST(N'2025-05-15' AS Date), CAST(N'2025-05-15' AS Date))
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [SoDienThoai], [DiaChi], [CCCD], [GioiTinh]) VALUES (N'KH00001', N'Nguyễn Thị Lan', N'0981234567', N'Hà Nội', N'001092000123', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [SoDienThoai], [DiaChi], [CCCD], [GioiTinh]) VALUES (N'KH00002', N'Trần Văn Bình', N'0976543210', N'TP. Hồ Chí Minh', N'002082301239', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [SoDienThoai], [DiaChi], [CCCD], [GioiTinh]) VALUES (N'KH00003', N'Lê Thị Hồng', N'0911122233', N'Thanh Hóa', N'003072002345', N'Nữ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [SoDienThoai], [DiaChi], [CCCD], [GioiTinh]) VALUES (N'KH00004', N'Phạm Văn Dũng', N'0909090909', N'Đà Nẵng', N'004062003456', N'Nam')
INSERT [dbo].[KhachHang] ([MaKH], [TenKhachHang], [SoDienThoai], [DiaChi], [CCCD], [GioiTinh]) VALUES (N'KH00005', N'Đào Thị Yến', N'0939988776', N'Huế', N'005052004567', N'Nữ')
GO
INSERT [dbo].[LoaiXeMay] ([MaLoaiXe], [TenLoaiXe], [MoTa]) VALUES (N'LX001', N'Xe số', N'Tiet kiem xang')
INSERT [dbo].[LoaiXeMay] ([MaLoaiXe], [TenLoaiXe], [MoTa]) VALUES (N'LX002', N'Xe tay ga', N'Thiet ke dep')
INSERT [dbo].[LoaiXeMay] ([MaLoaiXe], [TenLoaiXe], [MoTa]) VALUES (N'LX003', N'Xe côn tay', N'Cho nguoi thich the thao')
INSERT [dbo].[LoaiXeMay] ([MaLoaiXe], [TenLoaiXe], [MoTa]) VALUES (N'LX004', N'Xe điện', N'Than thien moi truong')
INSERT [dbo].[LoaiXeMay] ([MaLoaiXe], [TenLoaiXe], [MoTa]) VALUES (N'LX005', N'Xe phân khối lớn', N'Cong suat cao')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhauHash], [GioiTinh], [SoDienThoai], [DiaChi], [VaiTro], [Email], [HinhAnh]) VALUES (N'NV00001', N'Nguyễn Văn Hưng', N'nvhung', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nam', N'0909123456', N'Hà Nội', 1, N'hungnv@motobiz.vn', N'cap-nhat-gia-xe-honda_8948fd0abd9744baa1be91bdce540506.jpg')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhauHash], [GioiTinh], [SoDienThoai], [DiaChi], [VaiTro], [Email], [HinhAnh]) VALUES (N'NV00002', N'Trần Thị Mai', N'ttmai', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nữ', N'0912233445', N'TP. Hồ Chí Minh', 0, N'maitt@motobiz.vn', N'')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhauHash], [GioiTinh], [SoDienThoai], [DiaChi], [VaiTro], [Email], [HinhAnh]) VALUES (N'NV00003', N'Lê Văn Tùng', N'lvtung', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nam', N'0933455667', N'Đà Nẵng', 0, N'tunglv@motobiz.vn', N'')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhauHash], [GioiTinh], [SoDienThoai], [DiaChi], [VaiTro], [Email], [HinhAnh]) VALUES (N'NV00004', N'Phạm Thị Hằng', N'pthang', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nữ', N'0978765432', N'Cần Thơ', 0, N'hangpt@motobiz.vn', N'')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [TenTK], [MatKhauHash], [GioiTinh], [SoDienThoai], [DiaChi], [VaiTro], [Email], [HinhAnh]) VALUES (N'NV00005', N'Đỗ Minh Tuấn', N'dmtuan', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', N'Nam', N'0961234567', N'Hải Phòng', 0, N'tuandm@motobiz.vn', N'')
GO
INSERT [dbo].[PhanKhoiXe] ([MaPhanKhoi], [DungTichCC], [MoTa]) VALUES (N'PK001', 110, N'Xe số phổ thông 110cc')
INSERT [dbo].[PhanKhoiXe] ([MaPhanKhoi], [DungTichCC], [MoTa]) VALUES (N'PK002', 125, N'Xe tay ga 125cc')
INSERT [dbo].[PhanKhoiXe] ([MaPhanKhoi], [DungTichCC], [MoTa]) VALUES (N'PK003', 150, N'Xe thể thao 150cc')
INSERT [dbo].[PhanKhoiXe] ([MaPhanKhoi], [DungTichCC], [MoTa]) VALUES (N'PK004', 175, N'Xe phân khối lớn 175cc')
INSERT [dbo].[PhanKhoiXe] ([MaPhanKhoi], [DungTichCC], [MoTa]) VALUES (N'PK005', 50, N'Xe máy điện, dung tích nhỏ')
GO
INSERT [dbo].[TrangThaiXe] ([MaTrangThaiXe], [TenTrangThaiXe], [GhiChu]) VALUES (N'TT001', N'Còn hàng', N'Xe co san trong kho')
INSERT [dbo].[TrangThaiXe] ([MaTrangThaiXe], [TenTrangThaiXe], [GhiChu]) VALUES (N'TT002', N'Hết hàng', N'Xe da ban het')
INSERT [dbo].[TrangThaiXe] ([MaTrangThaiXe], [TenTrangThaiXe], [GhiChu]) VALUES (N'TT003', N'Đặt trước', N'Xe dang duoc dat truoc')
INSERT [dbo].[TrangThaiXe] ([MaTrangThaiXe], [TenTrangThaiXe], [GhiChu]) VALUES (N'TT004', N'Ngưng kinh doanh', N'Khong con phan phoi')
INSERT [dbo].[TrangThaiXe] ([MaTrangThaiXe], [TenTrangThaiXe], [GhiChu]) VALUES (N'TT005', N'Sắp về', N'Chuan bi nhap kho')
GO
INSERT [dbo].[XeMay] ([MaXe], [TenXe], [Mau], [MaHang], [MaLoaiXe], [GiaNhap], [GiaBan], [SoKhung], [SoMay], [HinhAnh], [MaTrangThaiXe], [MaPhanKhoi]) VALUES (N'XM00001', N'Honda Wave Alpha 110cc', N'Đen', N'H001', N'LX001', CAST(16000000.00 AS Decimal(10, 2)), CAST(18000000.00 AS Decimal(10, 2)), N'KH001', N'M001', NULL, N'TT001', N'PK001')
INSERT [dbo].[XeMay] ([MaXe], [TenXe], [Mau], [MaHang], [MaLoaiXe], [GiaNhap], [GiaBan], [SoKhung], [SoMay], [HinhAnh], [MaTrangThaiXe], [MaPhanKhoi]) VALUES (N'XM00002', N'Yamaha Janus 125cc', N'Trắng', N'H002', N'LX002', CAST(28000000.00 AS Decimal(10, 2)), CAST(31000000.00 AS Decimal(10, 2)), N'KH002', N'M002', NULL, N'TT001', N'PK002')
INSERT [dbo].[XeMay] ([MaXe], [TenXe], [Mau], [MaHang], [MaLoaiXe], [GiaNhap], [GiaBan], [SoKhung], [SoMay], [HinhAnh], [MaTrangThaiXe], [MaPhanKhoi]) VALUES (N'XM00003', N'Suzuki GSX150', N'Xanh', N'H003', N'LX003', CAST(45000000.00 AS Decimal(10, 2)), CAST(50000000.00 AS Decimal(10, 2)), N'KH003', N'M003', NULL, N'TT001', N'PK003')
INSERT [dbo].[XeMay] ([MaXe], [TenXe], [Mau], [MaHang], [MaLoaiXe], [GiaNhap], [GiaBan], [SoKhung], [SoMay], [HinhAnh], [MaTrangThaiXe], [MaPhanKhoi]) VALUES (N'XM00004', N'Piaggio Liberty 125cc', N'Đỏ', N'H004', N'LX002', CAST(45000000.00 AS Decimal(10, 2)), CAST(48000000.00 AS Decimal(10, 2)), N'KH004', N'M004', N'cap-nhat-gia-xe-honda_8948fd0abd9744baa1be91bdce540506.jpg', N'TT001', N'PK002')
INSERT [dbo].[XeMay] ([MaXe], [TenXe], [Mau], [MaHang], [MaLoaiXe], [GiaNhap], [GiaBan], [SoKhung], [SoMay], [HinhAnh], [MaTrangThaiXe], [MaPhanKhoi]) VALUES (N'XM00005', N'SYM Galaxy 50cc', N'Bạc', N'H005', N'LX004', CAST(15000000.00 AS Decimal(10, 2)), CAST(17000000.00 AS Decimal(10, 2)), N'KH005', N'M005', NULL, N'TT005', N'PK005')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__4CF9E7771C87C84C]    Script Date: 5/31/2025 1:04:24 PM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[XeMay] ([MaXe])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[XeMay]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangXe] ([MaHang])
GO
ALTER TABLE [dbo].[XeMay]  WITH CHECK ADD FOREIGN KEY([MaLoaiXe])
REFERENCES [dbo].[LoaiXeMay] ([MaLoaiXe])
GO
ALTER TABLE [dbo].[XeMay]  WITH CHECK ADD FOREIGN KEY([MaPhanKhoi])
REFERENCES [dbo].[PhanKhoiXe] ([MaPhanKhoi])
GO
ALTER TABLE [dbo].[XeMay]  WITH CHECK ADD FOREIGN KEY([MaTrangThaiXe])
REFERENCES [dbo].[TrangThaiXe] ([MaTrangThaiXe])
GO
USE [master]
GO
ALTER DATABASE [Xuong_QuanLyXeMayLite] SET  READ_WRITE 
GO
