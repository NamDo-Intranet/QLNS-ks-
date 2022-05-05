﻿CREATE DATABASE QLCBNV
use QLCBNV
create table NhanVien(
MaNV char(5) primary key NOT NULL,
TenNV NVARCHAR(20),
NgaySinh Date,
GioiTinh Bit,
SoDT char(10),
MaPB char(10) NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPB) ON UPDATE CASCADE ON DELETE CASCADE,
Picture Varchar(10),
)
Create table PhongBan(
MaPB char(10) Primary key NOT NULL,
TenPB NVARCHAR(20),
)
INSERT INTO PhongBan(MaPB, TenPB)
Values('HC', N'HÀNH CHÍNH')
INSERT INTO PhongBan(MaPB, TenPB)
Values('TC', N'TÀI CHÍNH')
INSERT INTO PhongBan(MaPB, TenPB)
Values('KT', N'KINHTE')

INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('00001', N'Nguyễn Cao Kỳ Duyên', '02/12/2001', '0', '0293242374', 'TC' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('00002', N'Phạm Ngọc Thái', '05/09/2003', '1', '0293288283', 'HC' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('00003', N'Nguyễn Thái Công', '06/30/2002', '1', '0232532523', 'KT' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('00004', N'Trần Ngọc Yến Linh', '05/20/2002', '0','0292352377', 'HC' ,NULL)