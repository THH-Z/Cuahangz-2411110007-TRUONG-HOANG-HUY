USE master
GO

/*
IF EXISTS (SELECT * FROM sys.databases WHERE name='CuaHangz')
    BEGIN
    ALTER DATABASE CuaHangz
    SET SINGLE_USER
    WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CuaHangz;
END
GO*/

CREATE DATABASE CuaHangz
GO

USE CuaHangz
GO


CREATE TABLE NHANVIEN
(
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(20),
    VaiTro NVARCHAR(20) NOT NULL CHECK (VaiTro IN ('admin','quanly','nhanvien'))
         
)
GO

INSERT INTO NHANVIEN (TenNhanVien, DienThoai, VaiTro) VALUES
(N'Pascale Woodard','0900000001','admin'),
(N'Garret Blunsum','0900000002','nhanVien'),
(N'Salomi Barok','0900000003','nhanVien'),
(N'Etan Abad','0900000004','nhanVien'),
(N'Bernarr Davidescu','0900000005','nhanVien')
GO


CREATE TABLE TAIKHOAN
(
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL UNIQUE,
    MaNhanVien INT UNIQUE,
    Quyen NVARCHAR(50),
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
)
GO

INSERT INTO TAIKHOAN VALUES
('Admin','123',1,'admin'),
('nv1','124',2,'user'),
('nv2','125',3,'user')
GO


CREATE TABLE KHACHHANG
(
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    TenKhachHang NVARCHAR(100) NOT NULL,
    DienThoai NVARCHAR(20)
)
GO

INSERT INTO KHACHHANG (TenKhachHang,DienThoai) VALUES
(N'Twila OSherrin','0911111111'),
(N'Natka McGaughay','0911111112'),
(N'Boot Cino','0911111113'),
(N'Sharline Creagh','0911111114'),
(N'Astrid Mcall','0911111115')
GO


CREATE TABLE SANPHAM
(
    MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
    TenSanPham NVARCHAR(100) NOT NULL,
    SoLuongSanPham INT NOT NULL DEFAULT 0,
    Gia DECIMAL(10,2) NOT NULL
)
GO

INSERT INTO SANPHAM (TenSanPham, SoLuongSanPham, Gia) VALUES
(N'Sambuca', 100, 45.35),
(N'Lotus Root', 200, 5.56),
(N'Soya Sauce', 150, 8.95),
(N'Bread', 300, 1.61),
(N'Melon', 80, 30.06)
GO



CREATE TABLE DONHANG
(
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE NOT NULL ,
    MaKhachHang INT NOT NULL,
    MaNhanVien INT NOT NULL,

    FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
)
GO

SET DATEFORMAT DMY

INSERT INTO DONHANG (NgayTao,MaKhachHang,MaNhanVien) VALUES
('20-04-2024',1,1),
('20-04-2024',2,2),
('21-04-2024',3,2)
GO

CREATE TABLE CHITIETDONHANG
(
    MaDonHang INT,
    MaSanPham INT,
    SoLuong INT,

    PRIMARY KEY (MaDonHang,MaSanPham),

    FOREIGN KEY (MaDonHang) REFERENCES DONHANG(MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SANPHAM(MaSanPham)
)
GO

INSERT INTO CHITIETDONHANG VALUES
(1,1,2),
(1,2,1),
(2,3,5),
(3,1,1),
(3,5,2)
GO

-- xem danh sách đơn hàng
SELECT * FROM DONHANG

-- xem chi tiết đơn hàng
SELECT * FROM CHITIETDONHANG

--xem danh sách tài khoản
SELECT  Quyen,TenDangNhap FROM TAIKHOAN
--xem sản phẩm
SELECT * FROM SANPHAM

-- tổng tiền mỗi đơn
SELECT
    d.MaDonHang,
    kh.TenKhachHang,
    SUM(sp.Gia * ct.SoLuong) TongTien
FROM DONHANG d
JOIN KHACHHANG kh ON d.MaKhachHang = kh.MaKhachHang
JOIN CHITIETDONHANG ct ON d.MaDonHang = ct.MaDonHang
JOIN SANPHAM sp ON ct.MaSanPham = sp.MaSanPham
GROUP BY d.MaDonHang, kh.TenKhachHang
GO
--xem nhân viên 
select * from NHANVIEN

