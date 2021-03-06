USE [master]
GO
/****** Object:  Database [QuanLiDiemSV]    Script Date: 5/25/2020 7:32:32 ******/
CREATE DATABASE [QuanLiDiemSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiDiemSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiDiemSV.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiDiemSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLiDiemSV_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiDiemSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiDiemSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiDiemSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiDiemSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiDiemSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiDiemSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiDiemSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiDiemSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiDiemSV] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiDiemSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiDiemSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiDiemSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiDiemSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiDiemSV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLiDiemSV]
GO
/****** Object:  Table [dbo].[DiemHP]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DiemHP](
	[MaSV] [char](15) NULL,
	[MaMH] [char](5) NULL,
	[DiemKT1] [float] NULL,
	[DiemKT2] [float] NULL,
	[Diemthi] [float] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HeDT]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HeDT](
	[MaHeDT] [char](5) NOT NULL,
	[TenHeDT] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHeDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHK] [char](10) NOT NULL,
	[TenHK] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [char](5) NOT NULL,
	[TenKhoa] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [char](5) NOT NULL,
	[TenKhoaHoc] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](5) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
	[MaKhoa] [char](5) NULL,
	[MaHeDT] [char](5) NULL,
	[MaKhoaHoc] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [char](5) NOT NULL,
	[TenMH] [nvarchar](30) NOT NULL,
	[SoTC] [int] NOT NULL,
	[MaHK] [char](10) NULL,
	[MaKhoa] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](15) NOT NULL,
	[TenSV] [nvarchar](20) NULL,
	[NgaySinh] [datetime] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[MaLop] [char](5) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[MaKhoa] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTin]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTin](
	[Tinh] [nvarchar](50) NULL,
	[DonViChuQuan] [nvarchar](100) NULL,
	[TenTruong] [nvarchar](100) NULL,
	[KhoaHoc] [nvarchar](100) NULL,
	[NganhHoc] [nvarchar](100) NULL,
	[ChuyenNganh] [nvarchar](100) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[DiemHP]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaHeDT])
REFERENCES [dbo].[HeDT] ([MaHeDT])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD FOREIGN KEY([MaHK])
REFERENCES [dbo].[HocKy] ([MaHK])
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD CHECK  (([SoTC]>(0) AND [SoTC]<(5)))
GO
/****** Object:  StoredProcedure [dbo].[BangDiemHP]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BangDiemHP](@MaLop char(5),@MaMH char(5) )
as
Begin
	SELECT        dbo.SinhVien.MaSV, dbo.SinhVien.TenSV, dbo.SinhVien.NgaySinh, dbo.DiemHP.DiemKT1, dbo.DiemHP.DiemKT2, dbo.DiemHP.Diemthi
FROM            dbo.SinhVien INNER JOIN
                         dbo.DiemHP ON dbo.SinhVien.MaSV = dbo.DiemHP.MaSV  where SinhVien.MaLop = @MaLop and DiemHP.MaMH = @MaMH
end
GO
/****** Object:  StoredProcedure [dbo].[DanhsachdiemSV]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhsachdiemSV]

as
SELECT        dbo.SinhVien.MaSV, dbo.SinhVien.TenSV, dbo.MonHoc.MaMH, dbo.MonHoc.TenMH, dbo.MonHoc.SoTC, dbo.DiemSV.HocKy, dbo.DiemSV.Lanhoc, dbo.DiemSV.Lanthi, dbo.DiemSV.Danhgia, 
                         dbo.DiemSV.DiemKT1, dbo.DiemSV.DiemKT2, dbo.DiemSV.ThiketthucHP, dbo.DiemSV.TongketHP, dbo.DiemSV.Diemchu
FROM            dbo.DiemSV INNER JOIN
                         dbo.SinhVien ON dbo.DiemSV.MaSV = dbo.SinhVien.MaSV INNER JOIN
                        dbo.MonHoc ON dbo.DiemSV.MaMH = dbo.MonHoc.MaMH

GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectAll]
   as
   begin
	Select * from DiemHP
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectHK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectHK](@MaHK char(10))
   as
   begin
	Select * from DiemHP   where MaHK=@MaHK
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectHK1]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Diem_HPSelectHK1](@MaSV char(15),@MaMH char (5),@MaLop char (5),@MaHK char(10))
   as
   begin
	Select * from DiemHP   where MaHK=@MaHK and MaSV =@MaSV and MaLop = @MaLop and MaMH = @MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectMH]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectMH](@MaMH char(5))
   as
   begin
	Select * from DiemHP   where MaMH=@MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectMH1]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectMH1](@MaSV char(15),@MaMH char (5),@MaLop char (5),@MaHK char(10))
   as
   begin
	Select * from DiemHP   where MaHK=@MaHK and MaSV =@MaSV and MaLop = @MaLop and MaMH = @MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectML]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectML](@MaLop char(5))
   as
   begin
	Select * from DiemHP   where MaLop=@MaLop
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectML1]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	 create proc [dbo].[Diem_HPSelectML1](@MaSV char(15),@MaMH char (5),@MaLop char (5),@MaHK char(10))
   as
   begin
	Select * from DiemHP   where MaHK=@MaHK and MaSV =@MaSV and MaLop = @MaLop and MaMH = @MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectSV]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Diem_HPSelectSV](@MaSV char(15))
   as
   begin
	Select * from DiemHP   where MaSV=@MaSV
	end
GO
/****** Object:  StoredProcedure [dbo].[Diem_HPSelectSV1]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		 create proc [dbo].[Diem_HPSelectSV1](@MaSV char(15),@MaMH char (5),@MaLop char (5),@MaHK char(10))
   as
   begin
	Select * from DiemHP   where MaHK=@MaHK and MaSV =@MaSV and MaLop = @MaLop and MaMH = @MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_Delete](@id int)
as
begin
	delete from DiemHP where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DiemHP_Insert](@MaSV char(15),@MaMH char(5))
as
begin
	Insert into DiemHP(MaSV,MaMH) Values (@MaSV,@MaMH)
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_MaHK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[DiemHP_MaHK]
as
begin
	select DISTINCT MaHK from DiemHP 
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_MaLop]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[DiemHP_MaLop]
as
begin
	select DISTINCT MaLop from DiemHP
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_MaMH]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[DiemHP_MaMH]
as
begin
	select DISTINCT MaMH from DiemHP 
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_MaSV]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[DiemHP_MaSV]
as
begin
	select DISTINCT MaSV from DiemHP 
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Search]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DiemHP_Search] (@MaMH char (5),@MaSV char (15))
as
begin
	Select * from DiemHP Where MaMH=@MaMH and MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[DiemHP_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DiemHP_Update](@MaSV char(15),@MaMH char (5),@DiemKT1 float,@DiemKT2 float,@Diemthi float)
as
begin
	Update DiemHP set DiemKT1=@DiemKT1,DiemKT2=@DiemKT2,DiemThi=@Diemthi   where MaSV=@MaSV and MaMH=@MaMH
	end
GO
/****** Object:  StoredProcedure [dbo].[HeDT_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HeDT_Delete](@MaHeDT char(5))
 as
begin
delete from HeDT where MaHeDT=@MaHeDT
end
GO
/****** Object:  StoredProcedure [dbo].[HeDT_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HeDT_Insert](@MaHeDT char(5),@TenHeDT nvarchar(40))
 as
begin
Insert into HeDT values (@MaHeDT,@TenHeDT)
end
GO
/****** Object:  StoredProcedure [dbo].[HeDT_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HeDT_SelectAll]
as 
begin
select * from HeDT
end
GO
/****** Object:  StoredProcedure [dbo].[HeDT_SelectMHDT]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HeDT_SelectMHDT]
as
begin
	Select DISTINCT MaHeDT from HeDT
end
GO
/****** Object:  StoredProcedure [dbo].[HeDT_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HeDT_Update](@MaHeDT char(5),@TenHeDT nvarchar(40))
 as
begin
update HeDT set TenHeDT=@TenHeDT where MaHeDT=@MaHeDT
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[HocKy_Delete](@MaHK char (10))
as
Begin 
	DELETE FROM HocKy where MaHK=@MaHK
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[HocKy_Insert](@MaHK char (10),@TenHK nvarchar(50))
as
Begin 
	INSERT INTO HocKy VALUES(@MaHK,@TenHK)
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[HocKy_SelectAll]
as
Begin 
	Select * from HocKy
end
GO
/****** Object:  StoredProcedure [dbo].[HocKy_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[HocKy_Update](@MaHK char (10),@TenHK nvarchar(50))
as
Begin 
	update HocKy set TenHK=@TenHK where MaHK=@MaHK
end
GO
/****** Object:  StoredProcedure [dbo].[Khoa_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khoa_Delete](@MaKhoa char(5))	
 as
begin 
delete from Khoa where MaKhoa=@MaKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[Khoa_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khoa_Insert](@MaKhoa char(5),@TenKhoa nvarchar(30),@DiaChi nvarchar(100),@DienThoai varchar(20))	
 as
begin 
insert into Khoa Values (@MaKhoa,@TenKhoa,@DiaChi,@DienThoai)
end
GO
/****** Object:  StoredProcedure [dbo].[Khoa_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khoa_SelectAll] as
begin 
select * from Khoa
end
GO
/****** Object:  StoredProcedure [dbo].[Khoa_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khoa_Update](@MaKhoa char(5),@TenKhoa nvarchar(30),@DiaChi nvarchar(100),@DienThoai varchar(20))	
 as
begin 
Update Khoa Set TenKhoa=@TenKhoa,DiaChi=@DiaChi,DienThoai=@DienThoai where MaKhoa=@MaKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[KhoaHoc_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KhoaHoc_Delete](@MaKhoaHoc char(5))
 as
begin
delete from KhoaHoc where MaKhoaHoc=@MaKhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[KhoaHoc_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KhoaHoc_Insert](@MaKhoaHoc char(5),@TenKhoaHoc nvarchar(20))
 as
begin
insert into KhoaHoc values (@MaKhoaHoc,@TenKhoaHoc)
end
GO
/****** Object:  StoredProcedure [dbo].[KhoaHoc_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KhoaHoc_SelectAll] as
begin
Select * from KhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[Khoahoc_SelectKH]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khoahoc_SelectKH]
as
begin
	Select DISTINCT MaKhoaHoc from KhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[KhoaHoc_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KhoaHoc_Update](@MaKhoaHoc char(5),@TenKhoaHoc nvarchar(20))
 as
begin
update KhoaHoc set TenKhoaHoc=@TenKhoaHoc where MaKhoaHoc=@MaKhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Lop_Delete](@MaLop char(5))
as 
begin
	DELETE From Lop  where MaLop=@MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[Lop_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_Insert] (@MaLop char (5),@TenLop nvarchar(30),@Makhoa char (5),@MaHeDT char (5),@MaKhoaHoc char(5))
as
begin
	insert into Lop values (@MaLop,@TenLop,@Makhoa,@MaHeDT,@MaKhoaHoc) 
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create proc [dbo].[Lop_SelectAll]
   as
   begin
		Select *  from Lop
	END
GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectMaHeDT]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_SelectMaHeDT] (@MaHeDT char(5))
as
begin 
select * from Lop where MaHeDT=@MaHeDT
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectMaKhoa]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_SelectMaKhoa] (@MaKhoa char(5))
as
begin 
select * from Lop where MaKhoa=@MaKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectMaKhoaHoc]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_SelectMaKhoaHoc] (@MaKhoaHoc char(5))
as
begin 
select * from Lop where MaKhoaHoc=@MaKhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_SelectMK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Lop_SelectMK]
as
begin
	Select DISTINCT MaKhoa from Lop
end
GO
/****** Object:  StoredProcedure [dbo].[Lop_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Lop_Update](@MaLop char (5),@TenLop nvarchar(30),@Makhoa char (5),@MaHeDT char (5),@MaKhoaHoc char(5))
as 
begin
	UPDATE Lop SET TenLop=@TenLop,MaKhoa=@Makhoa,MaHeDT=@MaHeDT,MaKhoaHoc=@MaKhoaHoc where MaLop=@MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[MonHP_Delete](@MaMH char(5))
as
begin
	Delete from MonHoc where MaMH=@MaMH
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MonHP_Insert](@MaMH char(5),@TenMH nvarchar(30),@SoTC int, @MaHK char(10),@MaKhoa char(5))
as
begin
	Insert into MonHoc values (@MaMH,@TenMH,@SoTC,@MaHK,@MaKhoa)
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectAll]
as
begin
	Select * from MonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectHK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectHK] (@MaHK char (5))
as
begin
	Select DISTINCT MaMH from MonHoc  where MaHK=@MaHK
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectMaHK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MonHP_SelectMaHK](@MaHK char(10))
as
begin
	select * from MonHoc where MaHK=@MaHK
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectMaKhoa]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectMaKhoa](@MaKhoa char(5))
as
begin
	select * from MonHoc where MaKhoa=@MaKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_SelectMK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MonHP_SelectMK]
as
begin
	Select DISTINCT MaKhoa from MonHoc
end
GO
/****** Object:  StoredProcedure [dbo].[MonHP_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MonHP_Update](@MaMH char(5),@TenMH nvarchar(30),@SoTC int,@MaHK char(10),@MaKhoa char(5))
as
begin
	Update MonHoc Set TenMH=@TenMH,SoTC=@SoTC,MaHK=@MaHK,MaKhoa=@MaKhoa where MaMH=@MaMH
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Delete]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SinhVien_Delete](@MaSV char(15))
as
begin
	Delete from SinhVien where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Insert]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SinhVien_Insert](@MaSV char(15),@TenSV nvarchar (20),@NgaySinh datetime,@QueQuan nvarchar(50),@MaLop char (5),@GioiTinh nvarchar(5),@MaKhoa char(5))
as
begin
	INSERT into SinhVien Values (@MaSV,@TenSV,@NgaySinh,@QueQuan,@MaLop,@GioiTinh,@MaKhoa)
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Search]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SinhVien_Search](@TenSV nvarchar(20))
as
begin
	SELECT * FROM SinhVien where TenSV LIKE '%+@TenSV+%' 
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_SelectAll]
as
begin
	Select * from SinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectMaKhoa]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[SinhVien_SelectMaKhoa]( @MaKhoa char(5)  )
as
Begin
Select	* from SinhVien where MaKhoa=@MaKhoa
end

GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectMaLop]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[SinhVien_SelectMaLop]( @MaLop char(5)  )
as
Begin
Select	* from SinhVien where MaLop=@MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectMaSV]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SinhVien_SelectMaSV](@MaSV char (15))
 as
 begin
		select * from SinhVien where MaSV=@MaSV
		end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectMK]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_SelectMK]
as
begin
	Select DISTINCT MaKhoa from SinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectML]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_SelectML]
as
begin
	Select DISTINCT MaLop from SinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[SinhVien_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SinhVien_Update](@MaSV char(15),@TenSV nvarchar (20),@NgaySinh date,@QueQuan nvarchar(50),@MaLop char (5),@GioiTinh nvarchar(5),@MaKhoa char(5))
as
begin
	Update SinhVien set TenSV=@TenSV,NgaySinh=@NgaySinh,QueQuan=@QueQuan,MaLop=@MaLop,GioiTinh=@GioiTinh,MaKhoa=@MaKhoa  where MaSV=@MaSV
end
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_SelecAll]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongTin_SelecAll]
as
begin
	select * from ThongTin
end
GO
/****** Object:  StoredProcedure [dbo].[ThongTin_Update]    Script Date: 5/25/2020 7:32:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongTin_Update](@Tinh nvarchar(50),@DonViChuQuan nvarchar (100),@TenTruong nvarchar(100),@KhoaHoc nvarchar (100),@NganhHoc nvarchar(100),@ChuyenNganh nvarchar(100))
as
begin
	update ThongTin set Tinh=@Tinh,DonViChuQuan=@DonViChuQuan,TenTruong =@TenTruong,KhoaHoc=@KhoaHoc,NganhHoc=@NganhHoc,ChuyenNganh=@ChuyenNganh
end
GO
USE [master]
GO
ALTER DATABASE [QuanLiDiemSV] SET  READ_WRITE 
GO
