create database QL_KTX
go
use QL_KTX
go

CREATE TABLE TaiKhoan (
    TaiKhoanID INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL
);

CREATE TABLE SinhVien (
    MSSV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh BIT,
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    Toa NVARCHAR(10),
    Phong NVARCHAR(10)
);

CREATE TABLE Phong (
    PhongID INT PRIMARY KEY IDENTITY(1,1),
    Toa NVARCHAR(10),
    SoPhong NVARCHAR(10),
    GiaTien DECIMAL(18, 2),
    SoNguoi INT
);

CREATE TABLE HopDong (
    HopDongID INT PRIMARY KEY IDENTITY(1,1),
    MSSV NVARCHAR(10) FOREIGN KEY REFERENCES SinhVien(MSSV),
    PhongID INT FOREIGN KEY REFERENCES Phong(PhongID),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    GhiChu NVARCHAR(255)
);

CREATE TABLE ThanhToan (
    ThanhToanID INT PRIMARY KEY IDENTITY(1,1),
    MSSV NVARCHAR(10) FOREIGN KEY REFERENCES SinhVien(MSSV),
    PhongID INT FOREIGN KEY REFERENCES Phong(PhongID),
    SoTien DECIMAL(18, 2),
    NgayThanhToan DATE
);



-- xuất dữ liệu ra xem nè ehehe
select * from TaiKhoan;
select * from SinhVien;
select * from Phong;
select * from HopDong;
select * from ThanhToan;


