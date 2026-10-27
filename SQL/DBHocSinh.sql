IF DB_ID(N'DBHocSinh') IS NULL
    CREATE DATABASE DBHocSinh;
GO

USE DBHocSinh;
GO

IF OBJECT_ID(N'dbo.Lop', N'U') IS NULL
CREATE TABLE dbo.Lop
(
    MaLop  VARCHAR(20)   NOT NULL PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    SiSo   SMALLINT      NULL CHECK (SiSo IS NULL OR SiSo >= 0)
);
GO

IF OBJECT_ID(N'dbo.HocSinh', N'U') IS NULL
CREATE TABLE dbo.HocSinh
(
    MaHS     VARCHAR(20)   NOT NULL PRIMARY KEY,
    TenHS    NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME      NULL,
    DiaChi   NVARCHAR(150) NULL,
    DTB      REAL          NULL CHECK (DTB IS NULL OR (DTB >= 0 AND DTB <= 10)),
    MaLop    VARCHAR(20)   NULL,
    CONSTRAINT FK_HocSinh_Lop FOREIGN KEY (MaLop) REFERENCES dbo.Lop (MaLop)
);
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Lop WHERE MaLop = 'CNTT1')
    INSERT dbo.Lop (MaLop, TenLop, SiSo) VALUES ('CNTT1', N'Công nghệ thông tin 1', 30);
IF NOT EXISTS (SELECT 1 FROM dbo.Lop WHERE MaLop = 'CNTT2')
    INSERT dbo.Lop (MaLop, TenLop, SiSo) VALUES ('CNTT2', N'Công nghệ thông tin 2', 28);

IF NOT EXISTS (SELECT 1 FROM dbo.HocSinh WHERE MaHS = 'HS001')
    INSERT dbo.HocSinh VALUES ('HS001', N'Nguyễn Minh Anh', '2007-03-12', N'TP. Hồ Chí Minh', 8.2, 'CNTT1');
IF NOT EXISTS (SELECT 1 FROM dbo.HocSinh WHERE MaHS = 'HS002')
    INSERT dbo.HocSinh VALUES ('HS002', N'Trần Gia Bảo', '2007-08-25', N'TP. Hồ Chí Minh', 7.6, 'CNTT1');
IF NOT EXISTS (SELECT 1 FROM dbo.HocSinh WHERE MaHS = 'HS003')
    INSERT dbo.HocSinh VALUES ('HS003', N'Lê Thu Hà', '2007-11-04', N'Đồng Nai', 9.1, 'CNTT2');
GO

SELECT * FROM dbo.Lop;
SELECT * FROM dbo.HocSinh;
GO
