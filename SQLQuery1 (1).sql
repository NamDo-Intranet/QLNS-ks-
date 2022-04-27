Create Database QLCBNV
use QLCBNV
create table NhanVien(
MaNV char(5) primary key NOT NULL,
TenNV NVARCHAR(20),
NgaySinh Date,
GioiTinh Bit,
SoDT int,
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
Values('01', 'Tran Cao Duyen', '02/12/2001', '0', '02932423', 'TC' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('02', 'Pham Ngoc Thai', '05/09/2003', '1', '02932882', 'HC' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('03', 'Tran Thai Cong', '06/30/2002', '1', '02325325', 'KT' ,NULL)
INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, SoDT, MaPB, Picture)
Values('04', 'Nguyen Yen Linh', '05/20/2002', '0', '02923523', 'HC' ,NULL)