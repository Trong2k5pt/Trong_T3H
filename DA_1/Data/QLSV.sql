create database QLSVDA1
go
use QLSVDA1
go

CREATE TABLE Chucvu (
	Macv VARCHAR(20) PRIMARY KEY not null,
    Chucvu NVARCHAR(30) not null,
)
go

-- Tạo bảng Login
CREATE TABLE TK (
	MaTK VARCHAR(20) PRIMARY KEY not null,
    Taikhoan VARCHAR(50) not null,
    Macv VARCHAR(20)not null,
	Trangthai NVARCHAR(20)not null,
    Matkhau VARCHAR(255) not null,
	FOREIGN KEY (Macv) REFERENCES Chucvu(Macv)
)
go

-- Tạo bảng GV (Giáo viên)
CREATE TABLE GV (
	MaTK VARCHAR(20) not null,
    Magv VARCHAR(20) PRIMARY KEY not null,
    Ten NVARCHAR(50) not null,
    Ngaysinh DATETIME not null,
	Gioi_tinh NVARCHAR(10),
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
)
go
-- Tạo bảng QLsv (Quản lý sinh viên)
CREATE TABLE SV (
    Masv VARCHAR(20) PRIMARY KEY not null,
	MaTK VARCHAR(20) not null,
    Ten NVARCHAR(50) not null,
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
    Que_quan NVARCHAR(100) not null,
    ngay_sinh DATETIME not null,
	Gioi_tinh NVARCHAR(10),
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
)
go
CREATE TABLE Lop (
	Malop VARCHAR(20) PRIMARY KEY not null,
	Tenlop NVARCHAR(50) not null,
)
go
CREATE TABLE Lopgv (
	malopgv int identity(1,1) PRIMARY KEY not null,
	Malop VARCHAR(20)  not null,
	Magv VARCHAR(20) not null,
	FOREIGN KEY (Magv) REFERENCES GV(Magv),
	FOREIGN KEY (Malop) REFERENCES Lop(Malop)
)
go

CREATE TABLE Lopchitiet (
	malopchitiet int identity(1,1) PRIMARY KEY not null,
	malopgv int  not null,
	Masv VARCHAR(20)  not null,
	FOREIGN KEY (Masv) REFERENCES SV(Masv),
	FOREIGN KEY (malopgv) REFERENCES Lopgv(malopgv)
)
go
-- Tạo bảng Qldiem (Quản lý điểm)
CREATE TABLE Qldiem (
    Masv VARCHAR(20) PRIMARY KEY  not null,
    TenSV NVARCHAR(50) not null,
    Toan Float not null,
    Van Float not null,
    Anh Float not null,
    Su Float not null,
    Dia Float not null,
    FOREIGN KEY (Masv) REFERENCES SV(Masv),
)
go

INSERT INTO Chucvu(Macv,Chucvu) VALUES
('CV1','Admin'),
('CV2','Staff'),
('CV3','Member')

INSERT INTO TK(MaTK,Taikhoan,Macv,Matkhau,Trangthai) VALUES
('TK1', 'admin', 'CV1', '123456',N'Hoạt Động'),
('TK2', 'gv0001', 'CV2', '123456',N'Hoạt Động'),
('TK3', 'gv0002', 'CV2', '123456',N'Hoạt Động'),
('TK4', 'gv0003', 'CV2', '123456',N'Hoạt Động'),
('TK5', 'gv0004', 'CV2', '123456',N'Không Hoạt Động'),
('TK6', 'gv0005', 'CV2', '123456',N'Không Hoạt Động'),
('TK7', 'hs0001', 'CV3', '123456',N'Hoạt Động'),
('TK8', 'hs0002', 'CV3', '123456',N'Hoạt Động'),
('TK9', 'hs0003', 'CV3', '123456',N'Hoạt Động'),
('TK10', 'hs0004', 'CV3', '123456',N'Hoạt Động'),
('TK11', 'hs0005', 'CV3', '123456',N'Hoạt Động'),
('TK12', 'hs0006', 'CV3', '123456',N'Hoạt Động'),
('TK13', 'hs0007', 'CV3', '123456',N'Hoạt Động'),
('TK14', 'hs0008', 'CV3', '123456',N'Hoạt Động'),
('TK15', 'hs0009', 'CV3', '123456',N'Hoạt Động'),
('TK16', 'hs0010', 'CV3', '123456',N'Hoạt Động'),
('TK17', 'hs0011', 'CV3', '123456',N'Hoạt Động'),
('TK18', 'hs0012', 'CV3', '123456',N'Hoạt Động'),
('TK19', 'hs0013', 'CV3', '123456',N'Hoạt Động'),
('TK20', 'hs0014', 'CV3', '123456',N'Hoạt Động'),
('TK21', 'hs0015', 'CV3', '123456',N'Hoạt Động'),
('TK22', 'hs0016', 'CV3', '123456',N'Hoạt Động'),
('TK23', 'hs0017', 'CV3', '123456',N'Hoạt Động'),
('TK24', 'hs0018', 'CV3', '123456',N'Hoạt Động'),
('TK25', 'hs0019', 'CV3', '123456',N'Hoạt Động'),
('TK26', 'hs0020', 'CV3', '123456',N'Hoạt Động'),
('TK27', 'hs0021', 'CV3', '123456',N'Hoạt Động'),
('TK28', 'hs0022', 'CV3', '123456',N'Hoạt Động'),
('TK29', 'hs0023', 'CV3', '123456',N'Hoạt Động'),
('TK30', 'hs0024', 'CV3', '123456',N'Hoạt Động'),
('TK31', 'hs0025', 'CV3', '123456',N'Hoạt Động'),
('TK32', 'hs0026', 'CV3', '123456',N'Không Hoạt Động'),
('TK33', 'hs0027', 'CV3', '123456',N'Không Hoạt Động'),
('TK34', 'hs0028', 'CV3', '123456',N'Không Hoạt Động'),
('TK35', 'hs0029', 'CV3', '123456',N'Không Hoạt Động'),
('TK36', 'hs0030', 'CV3', '123456',N'Không Hoạt Động');

-- Thêm dữ liệu mẫu cho bảng GV
INSERT INTO GV (MaTK, Magv, Ten, Ngaysinh, Gioi_tinh, Email, Sdt) VALUES
('TK2', 'GV01', N'Nguyễn Văn Anh', '1980-01-01', N'Nam', 'Anh@gmail.com', '0912345678'),
('TK3', 'GV02', N'Trần Thị Hà', '1985-05-15', N'Nữ', 'Ha@gmail.com', '0987654321'),
('TK4', 'GV03', N'Lê Quốc Bảo', '1990-10-20', N'Nam', 'Bao@gmail.com', '0934567890'),
('TK5', 'GV04', N'Đặng Thị Phương', '1978-03-08', N'Nữ', 'Phuong@gmail.com', '0912345679'),
('TK6', 'GV05', N'Phạm Văn Chiến', '1992-07-12', N'Nam', 'Chien@gmail.com', '0987654320');

INSERT INTO Lop (Malop, Tenlop) VALUES
('L01', N'Lớp 10A'),
('L02', N'Lớp 10B'),
('L03', N'Lớp 10C')

INSERT INTO Lopgv(Malop, Magv) VALUES
('L01', 'GV01'),
('L02', 'GV02')


-- Thêm dữ liệu mẫu cho bảng SV
INSERT INTO SV (Masv, MaTK, Ten, Email, Sdt, Que_quan, ngay_sinh, Gioi_tinh) VALUES
('SV01', 'TK7', N'Nguyễn Văn Minh', 'Minh@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam'),
('SV02', 'TK8', N'Trần Thị Giang', 'Giang@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ'),
('SV03', 'TK9', N'Lê Minh Hà', 'Ha@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam'),
('SV04', 'TK10', N'Đặng Thị Yến', 'Yen@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ'),
('SV05', 'TK11', N'Phạm Văn Quân', 'Quan@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam'),
('SV06', 'TK12', N'Nguyễn Thị Kiều', 'Kieu@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nữ'),
('SV07', 'TK13', N'Trần Minh Lê', 'Le@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nam'),
('SV08', 'TK14', N'Lê Thị My', 'My@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nữ'),
('SV09', 'TK15', N'Đặng Văn Nam', 'Nam@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nam'),
('SV10', 'TK16', N'Phạm Thị Uyên', 'Uyen@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nữ'),
('SV11', 'TK17', N'Nguyễn Văn Phát', 'Phat@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam'),
('SV12', 'TK18', N'Trần Thị Quỳnh', 'Quynh@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ'),
('SV13', 'TK19', N'Lê Minh Hoàng', 'Hoang@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam'),
('SV14', 'TK20', N'Đặng Thị Loan', 'Loan@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ'),
('SV15', 'TK21', N'Phạm Văn Thiện', 'Thien@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam'),
('SV16', 'TK22', N'Nguyễn Thị Ly', 'Ly@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nữ'),
('SV17', 'TK23', N'Trần Minh Vũ', 'Vu@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nam'),
('SV18', 'TK24', N'Lê Thị Hà', 'Ha@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nữ'),
('SV19', 'TK25', N'Đặng Văn Mạnh', 'Manh@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nam'),
('SV20', 'TK26', N'Phạm Thị Liên', 'Lien@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nữ'),
('SV21', 'TK27', N'Nguyễn Văn Thông', 'Thong@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam'),
('SV22', 'TK28', N'Trần Thị Bích', 'Bich@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ'),
('SV23', 'TK29', N'Lê Minh Bảo', 'Bao@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam'),
('SV24', 'TK30', N'Đặng Thị Hương', 'Huong@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ'),
('SV25', 'TK31', N'Phạm Văn Dũng', 'Dung@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam');

-- Thêm điểm cho 20 sinh viên
INSERT INTO Qldiem (Masv, TenSV, Toan, Van, Anh, Su, Dia) VALUES
('SV01', N'Nguyễn Văn Minh', 10, 10, 10, 10, 10),
('SV02', N'Trần Thị Giang', 7.0, 8.5, 8.0, 7.0, 8.0),
('SV03', N'Lê Minh Hà', 9.0, 8.0, 9.5, 8.5, 9.0),
('SV04', N'Đặng Thị Yến', 8.0, 7.5, 8.0, 8.5, 9.0),
('SV05', N'Phạm Văn Quân', 7.5, 8.0, 7.0, 8.0, 8.5),
('SV06', N'Nguyễn Thị Kiều', 8.0, 9.0, 8.5, 7.5, 8.0),
('SV07', N'Trần Minh Lê', 9.5, 8.0, 9.0, 8.5, 9.0),
('SV08', N'Lê Thị My', 7.0, 8.0, 7.5, 8.0, 8.5),
('SV09', N'Đặng Văn Nam', 5, 5.5, 5.6, 6, 5),
('SV10', N'Phạm Thị Uyên', 3, 3.5, 4, 4.5, 5),
('SV11', N'Nguyễn Văn Phát', 10, 10, 10, 10, 10),
('SV12', N'Trần Thị Quỳnh', 8.0, 7.5, 8.0, 8.5, 9.0),
('SV13', N'Lê Minh Hoàng', 7.5, 8.0, 7.0, 8.0, 8.5),
('SV14', N'Đặng Thị Loan', 8.5, 9.0, 8.0, 8.0, 8.5),
('SV15', N'Phạm Văn Thiện', 7.0, 8.0, 7.5, 8.0, 8.5),
('SV16', N'Nguyễn Thị Ly', 8.0, 9.0, 8.5, 7.5, 8.0),
('SV17', N'Trần Minh Vũ', 9.5, 8.0, 9.0, 8.5, 9.0),
('SV18', N'Lê Thị Hà', 7.0, 8.0, 7.5, 8.0, 8.5),
('SV19', N'Đặng Văn Mạnh', 5, 5.5, 5.6, 6, 5),
('SV20', N'Phạm Thị Liên', 3, 3.5, 4, 4.5, 5);

INSERT INTO Lopchitiet(malopgv, Masv) VALUES
('1', 'SV01'),
('1', 'SV02'),
('1', 'SV03'),
('1', 'SV04'),
('1', 'SV05'),
('1', 'SV06'),
('1', 'SV07'),
('1', 'SV08'),
('1', 'SV09'),
('1', 'SV10'),
('2', 'SV11'),
('2', 'SV12'),
('2', 'SV13'),
('2', 'SV14'),
('2', 'SV15'),
('2', 'SV16'),
('2', 'SV17'),
('2', 'SV18'),
('2', 'SV19'),
('2', 'SV20')
