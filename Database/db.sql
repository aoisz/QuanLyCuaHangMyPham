-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2022 at 05:18 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db`
--

-- --------------------------------------------------------

--
-- Table structure for table `chitiethoadon`
--

CREATE TABLE `chitiethoadon` (
  `MAHD` varchar(4) NOT NULL,
  `MASP` varchar(4) NOT NULL,
  `DONGIA` float NOT NULL,
  `SOLUONG` int(11) NOT NULL,
  `THANHTIEN` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chitiethoadon`
--

INSERT INTO `chitiethoadon` (`MAHD`, `MASP`, `DONGIA`, `SOLUONG`, `THANHTIEN`) VALUES
('HD01', 'SP16', 585000, 1, 585000),
('HD01', 'SP04', 328000, 1, 328000),
('HD01', 'SP01', 430000, 2, 860000),
('HD02', 'SP07', 156000, 1, 156000),
('HD02', 'SP12', 310000, 1, 310000),
('HD03', 'SP06', 166000, 1, 166000),
('HD03', 'SP30', 725000, 2, 1450000),
('HD04', 'SP26', 775000, 1, 775000),
('HD05', 'SP27', 699000, 1, 699000),
('HD05', 'SP21', 398000, 2, 796000),
('HD05', 'SP10', 929000, 1, 929000),
('HD05', 'SP03', 810000, 1, 810000),
('HD06', 'SP06', 166000, 2, 332000),
('HD06', 'SP20', 236000, 2, 472000),
('HD07', 'SP21', 398000, 3, 1194000),
('HD07', 'SP10', 929000, 1, 929000),
('HD08', 'SP15', 870000, 1, 870000),
('HD09', 'SP03', 810000, 1, 810000),
('HD09', 'SP30', 725000, 1, 725000),
('HD09', 'SP09', 1550000, 1, 1550000),
('HD10', 'SP15', 870000, 2, 1740000),
('HD10', 'SP19', 484000, 2, 968000),
('HD11', 'SP17', 665000, 1, 665000),
('HD11', 'SP11', 108000, 1, 108000),
('HD12', 'SP05', 274000, 3, 822000),
('HD12', 'SP28', 899000, 1, 899000),
('HD13', 'SP02', 405000, 1, 405000),
('HD13', 'SP22', 404000, 2, 808000),
('HD13', 'SP16', 585000, 1, 585000),
('HD14', 'SP08', 839000, 1, 274000),
('HD14', 'SP05', 274000, 1, 274000),
('HD15', 'SP06', 166000, 1, 166000),
('HD15', 'SP08', 839000, 2, 1678000),
('HD15', 'SP14', 1029000, 1, 1029000),
('HD15', 'SP02', 405000, 3, 1215000),
('HD16', 'SP01', 430000, 1, 430000),
('HD16', 'SP03', 810000, 2, 1620000),
('HD16', 'SP14', 1029000, 1, 1029000),
('HD17', 'SP03', 810000, 1, 810000),
('HD17', 'SP10', 929000, 1, 929000),
('HD17', 'SP04', 328000, 1, 328000),
('HD18', 'SP03', 810000, 1, 810000),
('HD18', 'SP02', 405000, 1, 405000),
('HD19', 'SP03', 810000, 2, 1620000),
('HD20', 'SP03', 810000, 1, 810000),
('HD20', 'SP10', 929000, 1, 929000),
('HD21', 'SP20', 236000, 1, 236000),
('HD22', 'SP03', 810000, 1, 810000),
('HD22', 'SP30', 725000, 1, 725000),
('HD22', 'SP04', 328000, 1, 328000),
('HD23', 'SP01', 430000, 3, 1290000),
('HD24', 'SP01', 430000, 1, 430000),
('HD24', 'SP02', 405000, 1, 405000),
('HD25', 'SP01', 430000, 1, 430000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietkho`
--

CREATE TABLE `chitietkho` (
  `MaKho` varchar(4) NOT NULL,
  `MaSP` varchar(4) NOT NULL,
  `SOLUONG` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chitietkho`
--

INSERT INTO `chitietkho` (`MaKho`, `MaSP`, `SOLUONG`) VALUES
('K01', 'SP01', 25),
('K01', 'SP02', 20),
('K01', 'SP03', 20),
('K01', 'SP04', 22),
('K01', 'SP05', 23),
('K01', 'SP06', 20),
('K01', 'SP07', 20),
('K01', 'SP08', 20),
('K01', 'SP09', 23),
('K01', 'SP10', 20),
('K01', 'SP11', 20),
('K01', 'SP12', 20),
('K01', 'SP13', 20),
('K01', 'SP14', 20),
('K01', 'SP15', 20),
('K01', 'SP16', 20),
('K01', 'SP17', 20),
('K01', 'SP18', 20),
('K01', 'SP19', 20),
('K01', 'SP20', 20),
('K01', 'SP21', 20),
('K01', 'SP22', 20),
('K01', 'SP23', 20),
('K01', 'SP24', 20),
('K01', 'SP25', 23),
('K01', 'SP26', 20),
('K01', 'SP27', 20),
('K01', 'SP28', 20),
('K01', 'SP29', 20),
('K01', 'SP30', 20),
('K02', 'SP01', 20),
('K02', 'SP02', 20),
('K02', 'SP03', 20),
('K02', 'SP04', 20),
('K02', 'SP05', 20),
('K02', 'SP06', 20),
('K02', 'SP07', 20),
('K02', 'SP08', 20),
('K02', 'SP09', 20),
('K02', 'SP10', 20),
('K02', 'SP11', 20),
('K02', 'SP12', 20),
('K02', 'SP13', 20),
('K02', 'SP14', 20),
('K02', 'SP15', 20),
('K02', 'SP16', 20),
('K02', 'SP17', 20),
('K02', 'SP18', 20),
('K02', 'SP19', 20),
('K02', 'SP20', 20),
('K02', 'SP21', 20),
('K02', 'SP22', 20),
('K02', 'SP23', 20),
('K02', 'SP24', 20),
('K02', 'SP25', 20),
('K02', 'SP26', 20),
('K02', 'SP27', 20),
('K02', 'SP28', 20),
('K02', 'SP29', 20),
('K02', 'SP30', 20),
('K01', 'K01', 1);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieunhap`
--

CREATE TABLE `chitietphieunhap` (
  `MAPN` varchar(4) NOT NULL,
  `MASP` varchar(4) NOT NULL,
  `DONGIA` int(11) NOT NULL,
  `SOLUONG` int(11) NOT NULL,
  `THANHTIEN` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chitietphieunhap`
--

INSERT INTO `chitietphieunhap` (`MAPN`, `MASP`, `DONGIA`, `SOLUONG`, `THANHTIEN`) VALUES
('PN01', 'SP01', 430000, 30, 12900000),
('PN01', 'SP02', 405000, 30, 12150000),
('PN01', 'SP03', 810000, 30, 24300000),
('PN01', 'SP04', 328000, 30, 9840000),
('PN01', 'SP05', 274000, 30, 8220000),
('PN01', 'SP06', 166000, 30, 4980000),
('PN01', 'SP07', 156000, 30, 4680000),
('PN01', 'SP08', 839000, 30, 25170000),
('PN01', 'SP09', 1550000, 30, 46500000),
('PN01', 'SP10', 929000, 30, 27870000),
('PN02', 'SP11', 108000, 30, 3240000),
('PN02', 'SP12', 310000, 30, 9300000),
('PN02', 'SP13', 92000, 30, 2760000),
('PN02', 'SP14', 1029000, 30, 30870000),
('PN02', 'SP15', 870000, 30, 26100000),
('PN02', 'SP16', 585000, 30, 17550000),
('PN02', 'SP17', 665000, 30, 19950000),
('PN02', 'SP18', 899000, 30, 26970000),
('PN02', 'SP19', 484000, 30, 14520000),
('PN02', 'SP20', 236000, 30, 7080000),
('PN03', 'SP21', 398000, 30, 11940000),
('PN03', 'SP22', 404000, 30, 12120000),
('PN03', 'SP23', 140000, 30, 4200000),
('PN03', 'SP24', 157000, 30, 4710000),
('PN03', 'SP25', 148000, 30, 4440000),
('PN03', 'SP26', 775000, 30, 23250000),
('PN03', 'SP27', 699000, 30, 20970000),
('PN03', 'SP28', 899000, 30, 26970000),
('PN03', 'SP29', 665000, 30, 19950000),
('PN03', 'SP30', 725000, 30, 21750000),
('PN04', 'SP01', 430000, 2, 860000),
('PN05', 'SP05', 274000, 3, 822000),
('PN06', 'SP01', 430000, 2, 860000),
('PN07', 'SP04', 328000, 2, 656000);

-- --------------------------------------------------------

--
-- Table structure for table `chitietquyen`
--

CREATE TABLE `chitietquyen` (
  `TENBANG` text NOT NULL,
  `CHUCNANG` text NOT NULL,
  `MAQ` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chitietquyen`
--

INSERT INTO `chitietquyen` (`TENBANG`, `CHUCNANG`, `MAQ`) VALUES
('sanpham', 'edit', 'Q01'),
('sanpham', 'view', 'Q02'),
('sanpham', 'view', 'Q03'),
('sanpham', 'none', 'Q04'),
('sanpham', 'view', 'Q05'),
('hoadon', 'edit', 'Q01'),
('hoadon', 'edit', 'Q02'),
('hoadon', 'none', 'Q03'),
('hoadon', 'none', 'Q04'),
('hoadon', 'none', 'Q05'),
('phieunhap', 'edit', 'Q01'),
('phieunhap', 'none', 'Q02'),
('phieunhap', 'edit', 'Q03'),
('phieunhap', 'none', 'Q04'),
('phieunhap', 'none', 'Q05'),
('ctkhuyenmai', 'edit', 'Q01'),
('ctkhuyenmai', 'view', 'Q02'),
('ctkhuyenmai', 'none', 'Q03'),
('ctkhuyenmai', 'none', 'Q04'),
('ctkhuyenmai', 'none', 'Q05'),
('khachhang', 'edit', 'Q01'),
('khachhang', 'view', 'Q02'),
('khachhang', 'none', 'Q03'),
('khachhang', 'edit', 'Q04'),
('khachhang', 'none', 'Q05'),
('nhanvien', 'edit', 'Q01'),
('nhanvien', 'none', 'Q02'),
('nhanvien', 'none', 'Q03'),
('nhanvien', 'none', 'Q04'),
('nhanvien', 'none', 'Q05'),
('nhasanxuat', 'edit', 'Q01'),
('nhasanxuat', 'view', 'Q02'),
('nhasanxuat', 'view', 'Q03'),
('nhasanxuat', 'none', 'Q04'),
('nhasanxuat', 'view', 'Q05'),
('quyen', 'edit', 'Q01'),
('quyen', 'none', 'Q02'),
('quyen', 'none', 'Q03'),
('quyen', 'none', 'Q04'),
('quyen', 'none', 'Q05'),
('taikhoan', 'edit', 'Q01'),
('taikhoan', 'none', 'Q02'),
('taikhoan', 'none', 'Q03'),
('taikhoan', 'none', 'Q04'),
('taikhoan', 'none', 'Q05'),
('kho', 'edit', 'Q01'),
('kho', 'view', 'Q02'),
('kho', 'view', 'Q03'),
('kho', 'none', 'Q04'),
('kho', 'edit', 'Q05');

-- --------------------------------------------------------

--
-- Table structure for table `ctkhuyenmai`
--

CREATE TABLE `ctkhuyenmai` (
  `MA` varchar(4) NOT NULL,
  `TEN` text NOT NULL,
  `TIENKM` text NOT NULL,
  `MUCTOITHIEU` text NOT NULL,
  `MUCTOIDA` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ctkhuyenmai`
--

INSERT INTO `ctkhuyenmai` (`MA`, `TEN`, `TIENKM`, `MUCTOITHIEU`, `MUCTOIDA`) VALUES
('KM01', 'Gi???m 10%', '0.1', '1500000', NULL),
('KM02', 'Gi???m 5%', '0.05', '900000', '1499000'),
('KM03', 'ccct', '2', '100', '0'),
('KM04', 'aaa', '0', '100', '1000'),
('KM05', 'cc', '0', '100', '10000'),
('KM06', 'cct', 'a', '1000', '10000000'),
('KM07', 'aaa', 'a', '1', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE `hoadon` (
  `MA` varchar(4) NOT NULL,
  `MANV` varchar(4) NOT NULL,
  `MAKH` varchar(4) NOT NULL,
  `NGAY` date NOT NULL,
  `TONGTIEN` float NOT NULL,
  `MACTKM` varchar(4) DEFAULT NULL,
  `TONGTIENSAUKM` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hoadon`
--

INSERT INTO `hoadon` (`MA`, `MANV`, `MAKH`, `NGAY`, `TONGTIEN`, `MACTKM`, `TONGTIENSAUKM`) VALUES
('HD01', 'NV10', 'KH01', '2022-01-24', 1773000, 'KM01', 1595700),
('HD02', 'NV03', 'KH09', '2022-01-28', 466000, NULL, 466000),
('HD03', 'NV09', 'KH02', '2022-01-24', 1616000, 'KM01', 1454400),
('HD04', 'NV04', 'KH10', '2022-01-29', 775000, NULL, 775000),
('HD05', 'NV08', 'KH03', '2022-01-24', 3234000, 'KM01', 2910600),
('HD06', 'NV04', 'KH11', '2022-01-29', 804000, NULL, 804000),
('HD07', 'NV08', 'KH04', '2022-01-25', 2123000, 'KM01', 1910700),
('HD08', 'NV02', 'KH12', '2022-01-30', 870000, NULL, 870000),
('HD09', 'NV07', 'KH05', '2022-01-25', 3085000, 'KM01', 2776500),
('HD10', 'NV06', 'KH06', '2022-01-25', 2708000, 'KM01', 2437200),
('HD11', 'NV01', 'KH13', '2022-01-31', 773000, NULL, 773000),
('HD12', 'NV05', 'KH07', '2022-01-26', 1721000, 'KM01', 1548900),
('HD13', 'NV04', 'KH08', '2022-01-26', 1798000, 'KM01', 1618200),
('HD14', 'NV04', 'KH08', '2022-01-27', 1113000, 'KM02', 1057350),
('HD15', 'NV09', 'KH01', '2021-02-12', 4088000, 'KM01', 3679200),
('HD16', 'NV01', 'KH04', '2021-05-20', 3079000, 'KM01', 2771100),
('HD17', 'NV06', 'KH11', '2021-07-20', 2067000, 'KM01', 1860300),
('HD18', 'NV03', 'KH12', '2021-12-20', 1215000, 'KM02', 1154250),
('HD19', 'NV05', 'KH11', '2022-04-23', 1620000, 'KM01', 1458000),
('HD20', 'NV05', 'KH01', '2022-04-28', 1739000, 'KM01', 1565100),
('HD21', 'NV01', 'KH06', '2022-05-01', 236000, NULL, 224200),
('HD22', 'NV05', 'KH07', '2022-05-11', 1863000, 'KM01', 1676700),
('HD23', 'NV02', 'KH01', '2022-05-26', 1290000, 'KM02', 1225500),
('HD24', 'NV03', 'KH03', '2022-05-27', 835000, 'KM01', 751500),
('HD25', 'NV01', 'KH01', '2022-05-12', 430000, NULL, 430000);

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `MAKH` varchar(4) NOT NULL,
  `HO` varchar(30) DEFAULT NULL,
  `TEN` varchar(10) DEFAULT NULL,
  `SDT` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`MAKH`, `HO`, `TEN`, `SDT`) VALUES
('KH01', 'Mai Thanh', 'An', '0939416854'),
('KH02', 'Ph???m L?? Huy???n', 'Trang', '0886081747'),
('KH03', '??inh V??n', 'Ki???t', '0918591823'),
('KH04', 'Tr????ng Tu???n', 'Ki???t', '0910134754'),
('KH05', 'Tr????ng Thanh', 'Phong', '0975399801'),
('KH06', 'Hu???nh Ph????ng', 'Vy', '0908261384'),
('KH07', 'Nguy???n Minh', 'Th??', '0941518656'),
('KH08', 'Nguy???n Ng???c Ph????ng', 'Thanh', '0942468772'),
('KH09', 'Hu???nh Ng???c Thi??n', 'H??', '0939516067'),
('KH10', 'L?? Tri???u Kh???', 'Nhi', '0998335370'),
('KH11', 'H??? Ng???c', 'T??', '0975410564'),
('KH12', 'L?? V??n', 'M???nh', '0954796347'),
('KH13', 'Ph???m Gia Kh???', 'S????ng', '0910350493'),
('KH14', 'Mai Tri???u', 'An', '0924001164'),
('KH15', 'Nguy???n Tr??c', 'Nh??n', '0977275559'),
('KH16', 'Tr????ng Gia', 'Minh', '0984695969'),
('KH17', 'Hu???nh Th??? Ng???c', 'Huy???n', '0995730078'),
('KH18', 'Nguy???n Thanh', 'Th???ng', '0949649994'),
('KH19', 'Cao Tr??c', 'Vy', '0944578319'),
('KH20', 'Nguy???n Ng???c', 'Hu???', '0945851846'),
('KH21', 'L?? M???nh', 'H??', '0955219092'),
('KH22', '??inh S??', 'Ti???n', '0995097249'),
('KH23', 'Ph???m Gia', 'Ph??t', '0954047885'),
('KH24', 'L?? Minh', 'H???i', '0989868888'),
('KH25', '?????ng Ki???u', 'V??', '0953854889'),
('KH26', 'Ph????ng Kh???', 'T??', '0979876846'),
('KH27', 'Ph??ng Thanh', 'S??n', '0993127055'),
('KH28', 'Gia C??c Ph????ng', 'Nghi', '0995240705'),
('KH29', 'Hu???nh Gia', 'Huy', '0919763137'),
('KH30', 'Tr????ng Minh', 'Sang', '0942877156'),
('KH31', 'H??? S??', 'Minh', '0978552846'),
('KH32', 'Mai Gia', 'Ph?????c', '0995766507'),
('KH33', 'H??? S??', 'Bang', '0931136553'),
('KH34', 'Hu???nh T???n', 'T??i', '0997031043'),
('KH35', 'Cao Minh', 'Ph??t', '0947182276'),
('KH36', 'Nguy???n Ng???c Ph????ng', 'Vy', '0953266718'),
('KH37', '?????ng T???n', 'Ph??t', '0975917984'),
('KH38', 'L?? H?? C???m', 'Nhung', '0917356062'),
('KH39', 'Nguy???n Th??? Ng???c', 'Dung', '0986592940'),
('KH40', '??o??n Minh', 'An', '0967203952'),
('KH41', '?????ng Ng???c', 'Minh', '0943711533'),
('KH42', '????o C??t', 'Minh', '0961893458'),
('KH43', 'Gia Tri???u', 'Ng???c', '0915805773'),
('KH44', 'Mai Tu???n', 'V??', '0983136740'),
('KH45', 'Nguy???n Th??nh', 'Tu???n', '0941851711'),
('KH46', 'Nguy???n Anh', 'Tu???n', '0934713863'),
('KH47', 'Nguy???n Ho??i', 'Nam', '0970011007'),
('KH48', 'L?? Thanh', 'S??', '0912881097'),
('KH49', 'Cao Gia Ho??i', 'V??', '0935363169'),
('KH50', 'L?? H?? C???m', 'T??', '0950147879'),
('KH51', 'Phan Kh???c', 'T?????ng', '0999942372'),
('KH52', 'Ph???m', 'Trang', '0886021747');

-- --------------------------------------------------------

--
-- Table structure for table `kho`
--

CREATE TABLE `kho` (
  `MA` varchar(4) NOT NULL,
  `TEN` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kho`
--

INSERT INTO `kho` (`MA`, `TEN`) VALUES
('K01', 'Kho ch??nh'),
('K02', 'Kho ph???');

-- --------------------------------------------------------

--
-- Table structure for table `loaihang`
--

CREATE TABLE `loaihang` (
  `MA` varchar(4) NOT NULL,
  `TEN` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `loaihang`
--

INSERT INTO `loaihang` (`MA`, `TEN`) VALUES
('ML01', 'Kem d?????ng'),
('ML02', 'M???t n???'),
('ML03', 'S???a r???a m???t');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `MANV` varchar(4) NOT NULL,
  `HO` varchar(20) DEFAULT NULL,
  `TEN` varchar(10) DEFAULT NULL,
  `DIACHI` varchar(30) DEFAULT NULL,
  `GIOITINH` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_520_ci DEFAULT NULL,
  `LUONG` int(11) DEFAULT NULL,
  `NAMSINH` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`MANV`, `HO`, `TEN`, `DIACHI`, `GIOITINH`, `LUONG`, `NAMSINH`) VALUES
('NV01', 'Tr????ng Tu???n', 'V??', 'TPHCM', 'Nam', 3700000, 2004),
('NV02', 'Nguy???n Ph????ng', '??nh', 'V??ng T??u', 'N???', 3800000, 2001),
('NV03', '????o ??nh', 'Tuy???t', '?????ng Nai', 'N???', 3800000, 2001),
('NV04', 'L?? Ph????ng Nguy???t', 'Nga', 'B???c Li??u', 'N???', 4100000, 2002),
('NV05', 'Ph???m Tri???u', 'Nam', 'Th??? ?????c', 'Nam', 3900000, 2000),
('NV06', 'L?? Thanh', 'Sang', 'TPHCM', 'Nam', 3700000, 2004),
('NV07', 'Nguy???n Ng???c', 'Ph????ng', 'B??nh D????ng', 'N???', 3900000, 2003),
('NV08', 'Hu???nh Thanh', 'Ki???t', 'TPHCM', 'Nam', 3800000, 2004),
('NV09', 'Nguy???n Gia', 'Tu???n', '?????ng Th??p', 'Nam', 4000000, 2001),
('NV10', 'Tr????ng ??nh', 'Ng???c', 'TPHCM', 'N???', 3800000, 2002);

-- --------------------------------------------------------

--
-- Table structure for table `nhasanxuat`
--

CREATE TABLE `nhasanxuat` (
  `MA` varchar(4) NOT NULL,
  `TEN` varchar(20) NOT NULL,
  `QUOCGIA` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nhasanxuat`
--

INSERT INTO `nhasanxuat` (`MA`, `TEN`, `QUOCGIA`) VALUES
('SX01', 'PAULAS CHOICE', 'M???'),
('SX02', 'LA ROCHE-POSAY', 'Ph??p'),
('SX03', 'The COCOON', 'Vi???t Nam');

-- --------------------------------------------------------

--
-- Table structure for table `phieunhap`
--

CREATE TABLE `phieunhap` (
  `MA` varchar(4) NOT NULL,
  `MAKHO` varchar(4) NOT NULL,
  `MANV` varchar(4) NOT NULL,
  `NGAY` varchar(10) NOT NULL,
  `TONGTIEN` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phieunhap`
--

INSERT INTO `phieunhap` (`MA`, `MAKHO`, `MANV`, `NGAY`, `TONGTIEN`) VALUES
('PN01', 'K01', 'NV01', '24/04/2021', 176610000),
('PN02', 'K01', 'NV02', '23/04/2021', 158340000),
('PN03', 'K02', 'NV03', '22/04/2021', 150300000),
('PN04', 'K01', 'NV01', '2022-12-05', 860000),
('PN05', 'K01', 'NV01', '2022-12-05', 822000),
('PN06', 'K01', 'NV01', '2022-12-05', 860000),
('PN07', 'K01', 'NV03', '2022-12-05', 656000);

-- --------------------------------------------------------

--
-- Table structure for table `quyen`
--

CREATE TABLE `quyen` (
  `MaQ` varchar(4) NOT NULL,
  `Ten` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `quyen`
--

INSERT INTO `quyen` (`MaQ`, `Ten`) VALUES
('Q01', 'Qu???n tr??? vi??n'),
('Q02', 'Nh??n vi??n b??n h??ng'),
('Q03', 'Nh??n vi??n nh???p h??ng'),
('Q04', 'Ch??m s??c kh??ch h??ng'),
('Q05', 'Qu???n l?? kho');

-- --------------------------------------------------------

--
-- Table structure for table `sanpham`
--

CREATE TABLE `sanpham` (
  `MA` varchar(4) NOT NULL,
  `TEN` varchar(100) NOT NULL,
  `LOAIHANG` varchar(4) NOT NULL,
  `NSX` varchar(4) NOT NULL,
  `DONGIA` int(11) NOT NULL,
  `HINHANH` varchar(100) NOT NULL,
  `THANHPHAN` text NOT NULL,
  `NGAYSX` varchar(10) NOT NULL,
  `HANSD` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sanpham`
--

INSERT INTO `sanpham` (`MA`, `TEN`, `LOAIHANG`, `NSX`, `DONGIA`, `HINHANH`, `THANHPHAN`, `NGAYSX`, `HANSD`) VALUES
('SP01', 'GEL D?????NG DA GI??U TINH CH???T L???I KHU???N PROBIOTIC NUTRIENT MOISTURIZER', 'ML01', 'SX01', 430000, 'https://drive.google.com/file/d/1ifVNC-WG8i-2YKc6Kkl7VBLJeGcDuVrV/view?usp=sharing', 'Water (Aqua), Isoamyl Laurate (emollient), Glycerin (skin-replenishing), Butylene Glycol (texture enhancer)', '01/01/2020', '01/01/2024'),
('SP02', 'KEM D?????NG ???M GI??U CH???T ??I???N GI???I WATER ??? INFUSING ELECTROLYTE MOISTURIZER', 'ML01', 'SX01', 405000, 'https://drive.google.com/file/d/1WGOviV8dUdLvRZdVi44XnSQlgNSdP4bC/view?usp=sharing', 'Water (Aqua,) Glycerin (skin-replenishing), Dimethicone (hydration/texture enhancer), Butylene Glycol (hydration)', '01/02/2020', '01/02/2024'),
('SP03', 'KEM D?????NG ???M NGU???N G???C THI??N NHI??N ANTIOXIDANT ENRICHED NATURAL MOISTURIZER', 'ML01', 'SX01', 810000, 'https://drive.google.com/file/d/1vQhitldQt-fnCZ34TIEaLZnE8rcHxetJ/view?usp=sharing', 'Water (Aqua), Theobroma Cacao (Cocoa) Seed Butter (cocoa seed butter/antioxidant/emollient), Glycerin (hydration/skin replenishing), Vitis Vinifera (Grape) Seed Oil (grape oil/non-fragrant oil/emollient/antioxidant)', '11/01/2020', '11/01/2024'),
('SP04', 'Effaclar Duo Plus (Kh??ng M??u) Gi???m M???n, Ng???a V???t Th??m 40ml', 'ML01', 'SX02', 328000, 'https://drive.google.com/file/d/1F3DBEueR8LaN_u7UVsKZAdMwlqt2UmNi/view?usp=sharing', 'Aqua / Water, Glycerin, Dimethicone, Isocetyl Stearate, Niacinamide, Isopropyl Lauroyl Sarcosinate, Silica', '20/01/2019', '20/01/2024'),
('SP05', 'Cicaplast Baume B5 Soothing Repairing Balm', 'ML01', 'SX02', 274000, 'https://drive.google.com/file/d/10a2lJ8ALEdZPsflv0v-YV-62UEM3_vSw/view?usp=sharing', 'Aqua/Water, Hydrogenated Polyisobutene, Dimethicone, Glycerin, Butyrospermum Parkii Butter/Shea Butter, Panthenol, Butylene Glycol', '17/01/2020', '17/01/2024'),
('SP06', 'The Cocoon Rose Aqua Gel Cream 30ml', 'ML01', 'SX03', 166000, 'https://drive.google.com/file/d/1N2rPYWOFU_b3dRCEOL2sY6MtQ_1T2qCX/view?usp=sharing', 'Aqua/Water, Rosa Damascena Flower Water, Dicaprylyl Carbonate, Hydroxyethyl Ac??Rylate/Sodium Acryloyldimethyl Taurate Copolymer, Betaine, Olus Oil', '01/01/2021', '01/01/2024'),
('SP07', 'Dak Lak Coffee Body Butte 200ml', 'ML01', 'SX03', 156000, 'https://drive.google.com/file/d/1h_X_2Dy5rYCjxFM2Bmi_Jr2cCxO_5oDl/view?usp=sharing', 'Aqua/Water, Caprylic/Capric Triglyceride, Glyceryl Stearate, Cetearyl Alcohol, C10-18 Triglycerides, Ceteareth-20, Ceteareth-12, Glycerin, Dicaprylyl Carbonate, Cetyl Palmitate', '01/01/2020', '01/01/2024'),
('SP08', 'KEM D?????NG ???M M???M M???N CHO DA D???U L??O H??A RESIST ANTI-AGING CLEAR SKIN HYDRATOR', 'ML01', 'SX01', 839000, 'https://drive.google.com/file/d/1oEotjhyrRESfVcok4RY5p0UkixTj28yn/view?usp=sharing', 'Water (Aqua), Cyclopentasiloxane (texture enhancer/hydration), Octyldodecyl Neopentanoate (texture enhancer), Vinyl Dimethicone', '02/09/2020', '02/09/2025'),
('SP09', 'KEM D?????NG ???M GI??P S??N CH???C DA T??NG C?????NG COLLAGEN CLINICAL CERAMIDE ??? ENRICHED FIRMING MOISTURIZER', 'ML01', 'SX01', 155000, 'https://drive.google.com/file/d/1tRWkrGBdCK6flehU5dykbRcpiiJBwaaf/view?usp=sharing', 'Water (Aqua), Sodium Ascorbyl Phosphate (vitamin C/antioxidant), Cetyl Alcohol (texture enhancer, Ascorbyl Glucoside', '30/04/2020', '01/01/2024'),
('SP10', 'KEM D?????NG ???M T??I T???O H??NG R??O B???O V??? DA RESIST BARRIER REPAIR MOISTURIZER WITH RETINOL', 'ML01', 'SX01', 929000, 'https://drive.google.com/file/d/1gRQa_ODWYprwFIrGcymfEe7BlrF994WL/view?usp=sharing', 'Water (Aqua), Dicaprylyl Carbonate (emollient), Glycerin (hydration/skin replenishing), Ethylhexyl Stearate (texture-enhancing)', '01/01/2019', '01/01/2024'),
('SP11', 'True Rose Face Mask 30ml', 'ML02', 'SX03', 108000, 'https://drive.google.com/file/d/1FdETX6KCfPUUyedYJ0bQVkLo3p10aGAD/view?usp=sharing', 'Aqua/Water, Rosa Damascena Flower Water, Inulin, Betaine, Propanediol, Glycerin, Butylene Glycol, Xylitylglucoside, Anhydroxylitol, Xylitol, 1,2-Hexanediol', '24/08/2020', '24/08/2024'),
('SP12', 'Hung Yen Turmeric Face Mask 100ml', 'ML02', 'SX03', 310000, 'https://drive.google.com/file/d/1nONSmtmwgp_Xm9MZhfnXyPa90gzrzVkt/view?usp=sharing', 'Hung Yen Turmeric Face Mask 100ml', '28/04/2020', '28/04/2024'),
('SP13', 'Winter Melon Face Mask 30ml', 'ML02', 'SX03', 92000, 'https://drive.google.com/file/d/1HVUtmVOAFiVDBeTItA1SespWeXlmgg68/view?usp=sharing', 'Water, Illite, Montmorillonite, Kaolin, Butylene Glycol, Niacinamide, Propanediol, Glycerin, Benincasa Cerifera Fruit Extract, Centella Asiatica Extract', '01/01/2020', '01/01/2024'),
('SP14', 'M???T N??? SI??U D?????NG ???M, L??M D???U DA SUPER HYDRATE OVERNIGHT MASK', 'ML02', 'SX01', 1029000, 'https://drive.google.com/file/d/1V4xa9xAM1zPJnkeoX0ay9NGHt3HW04Qf/view?usp=sharing', 'Water (Aqua), Butylene Glycol (hydration), Dimethicone (hydration), Hydroxyethyl Acrylate/Sodium Acryloyldimethyl Taurate Copolymer (thickener/emulsifier)', '01/01/2019', '01/01/2023'),
('SP15', 'M???T N??? THAN TRE D?????NG DA, GI???M D???U PORE CLARIFYING CHARCOAL GEL MASK', 'ML02', 'SX01', 870000, 'https://drive.google.com/file/d/1w3QbQdsec3d8-SjvT5BUqvrBtIO5qqMB/view?usp=sharing', 'Water (Aqua), Tapioca Starch (absorbent), Glycerin (skin-replenishing), Decyl Glucoside (gentle surfactant), Sodium Lauroyl Sarcosinate (gentle surfactant)', '17/01/2019', '17/01/2024'),
('SP16', 'M???T N??? D?????NG ???M CHO DA KH?? V?? K??CH ???NG SKIN RECOVERY HYDRATING TREATMENT MASK', 'ML02', 'SX01', 585000, 'https://drive.google.com/file/d/1ZXdeR-3OYo-Dxdmxu3z37T4ev0oFaQyG/view?usp=sharing', 'Skin-repairing ingredients, etrahydrobisdemethoxydiferuloylmethane, tetrahydrodemethoxydiferuloylmethane, tetrahexyldecyl ascorbate, adenosine , tocotrienols', '15/10/2020', '15/10/2024'),
('SP17', 'M???T N??? GI???M D???U SKIN BALANCING OIL-ABSORBING MASK', 'ML02', 'SX01', 665000, 'https://drive.google.com/file/d/1LbsNDNMnu4Ywhb-7jQ6NFjoqfAc5Z-dP/view?usp=sharing', 'Water (Aqua), Kaolin (clay absorbent), Bentonite (white clay/absorbent), Glycerin (hydration/skin replenishing), Salix Alba Extract (willow bark extract/skin-soothing),', '01/01/2019', '01/01/2024'),
('SP18', 'M???T N??? ?????T S??T KI???M SO??T D???U NH???N CLEAR PURIFYING CLAY MASK', 'ML02', 'SX01', 899000, 'https://drive.google.com/file/d/1UI7GyaTIr7TTNuW9TylZqDXGMuWteeLD/view?usp=sharing', 'Water (Aqua), Kaolin (absorbent), Bentonite (absorbent), Titanium Dioxide (texture enhancer/opacifier), Butylene Glycol (slip agent/hydration)', '01/05/2020', '01/05/2024'),
('SP19', 'Effaclar Sebo-Controlling Mask 100ml', 'ML02', 'SX02', 484000, 'https://drive.google.com/file/d/182U36OG3PujgbZneofIR4bUa7Hcz7C8U/view?usp=sharing', 'Aqua/Water, Kaolin, Argilla, Magnesium Aluminum Silicate, Propanediol, Panthenol, Glycerin, Caprylic/Capric Triglyceride, CI 77891/Titanium, Dioxide, Cetearyl Alcohol', '01/01/2020', '01/01/2025'),
('SP20', 'Winter Melon Face Mask 100ml', 'ML02', 'SX03', 236000, 'https://drive.google.com/file/d/1ZCTBZM9NL_LWEj6DXB8FXhFynRvG8iOO/view?usp=sharing', 'Water, Illite, Montmorillonite, Kaolin, Butylene Glycol, Niacinamide, Propanediol, Glycerin, Benincasa Cerifera Fruit Extract, Centella Asiatica Extract, Epilobium Angustifolium Flower/Leaf/Stem Extract, Phellodendron Amurense Bark Extract', '19/01/2020', '19/01/2024'),
('SP21', 'Effaclar Purifying Foaming Gel For Oily Sensitive Skin 400ml', 'ML03', 'SX02', 398000, 'https://drive.google.com/file/d/1uuE_l9kiqSZO3ZInNaW9-74JUU5cLT1v/view?usp=sharing', 'Aqua / Water, Sodium Laureth Sulfate, Peg-8, Coco-Betaine, Hexylene Glycol, Sodium Chloride, Peg-120 Methyl Glucose Dioleate, Zinc Pca, Sodium Hydroxide, Citric Acid, Sodium Benzoate, Phenoxyethanol, Caprylyl Glycol, Parfum / Fragrance', '01/09/2020', '01/09/2025'),
('SP22', 'Effaclar Micro-Peeling Purifying Gel 400ML', 'ML03', 'SX02', 404000, 'https://drive.google.com/file/d/1ngONT4noy_dQZB1crsywWUm3CE4QWwnr/view?usp=sharing\r\n', 'Aqua / Water, Sodium Laureth Sulfate, Decyl Glucoside, Glycerin, Sodium Chloride, Coco-betaine, Salicylic Acid, Peg-150 Pentaerythrityl Tetrastearate, Peg-6 Caprylic/capric Glycerides, Zinc Gluconate', '01/01/2019', '03/03/2024'),
('SP23', 'Hung Yen Turmeric Cleanser 140ML', 'ML03', 'SX03', 140000, 'https://drive.google.com/file/d/124N4A4o8EuxtQ6RhuqyE4OIV9qUWN5qn/view?usp=sharing', 'Aqua/Water, Disodium Cocoyl Glutamate, Potassium Laureth Phosphate, Sodium Laurylglucosides Hydroxypropylsulfonate, Lactic Acid, Glycerin, Polysorbate 20', '09/09/2020', '09/09/2025'),
('SP24', 'Winter Melon Cleanser 140ML', 'ML03', 'SX03', 157000, 'https://drive.google.com/file/d/11UeFnxyY7qFQ-GRKE8sos-vCvq1teTCx/view?usp=sharing', 'Water/Aqua, Potassium Laureth Phosphate, Cocamidopropyl Betaine, Acrylates/Steareth-20 Methacrylate Copolymer, Sodium Cocoyl Glycinate, Cocoyl Methyl Glucamide, PEG-7-Glyceryl Cocoate, Glycerin, Benincasa Cerifera (B?? ??ao) Fruit Extract', '01/01/2020', '01/01/2025'),
('SP25', 'Rose Cleanser 140ML', 'ML03', 'SX03', 148000, 'https://drive.google.com/file/d/1a1lYo3TDVdOxvk478EpCGcwsGkCSCf83/view?usp=sharing', 'Aqua/Water, Sodium Cocoyl Glycinate, Disodium Laureth Sulfosuccinate, Cocamidopropyl Betaine, Glycerin, Rosa Damascena Flower Water, Coco-Glucoside, PEG-120 Methyl Glucose Triisostearate, Cocoyl Methyl Glucamide', '23/07/2020', '23/07/2024'),
('SP26', 'S??P L??M S???CH BA T??C ?????NG OMEGA+ COMPLEX CLEANSING BALM', 'ML03', 'SX01', 775000, 'https://drive.google.com/file/d/1pW3P4agbk9VP1WwSckD8O_x21ocaxYOs/view?usp=sharing', 'Ethylhexyl Palmitate (emollient solvent), Caprylic/Capric Triglyceride (skin-replenishing), PEG-20 Glyceryl Triisostearate (emollient cleansing agent)', '01/01/2019', '17/08/2024'),
('SP27', 'GEL R???A M???T L??M S???CH PERFECTLY NATURAL CLEANSING GEL', 'ML03', 'SX01', 699000, 'https://drive.google.com/file/d/1HtncSBzvdPsHxF6i9tGaKDCwW3LwF4Pt/view?usp=sharing', 'Water (Aqua), Decyl Glucoside (cleansing), Glycerin (hydration/skin replenishing), Sodium Cocoamphoacetate (cleansing), Lauryl Glucoside (cleansing), Xanthan Gum (texture-enhancing)', '01/01/2020', '01/01/2025'),
('SP28', 'S???A R???A M???T D???U NH??? D???NG H???T TAN THE UNSCRUB', 'ML03', 'SX01', 899000, 'https://drive.google.com/file/d/17QPZ3VPxxx2TseYPaIRm7h3hCpMq-dCU/view?usp=sharing', 'Aqua (water), Jojoba Esters (cleansing beads), Caprylic/Capric Triglyceride (skin-replenishing), Glycerin (skin replenishing), PEG-20 Methyl Glucose Sesquistearate cleansing agent)', '01/12/2020', '01/12/2024'),
('SP29', 'S???A R???A M???T DIU NH??? DEFENSE HYDRATING GEL-TO-CREAM CLEANSER', 'ML03', 'SX01', 665000, 'https://drive.google.com/file/d/1xwJqCI41mtYIFl4azUimpl1NPEv__HHy/view?usp=sharing', 'Water, Sodium Cocoyl Glycinate (cleansing agent), Cocamidopropyl Hydroxysultaine (cleansing agent), Sodium Lauroamphoacetate (cleansing agent), Cocamidopropyl Betaine (cleansing/lather agent)', '22/06/2020', '22/06/2025'),
('SP30', 'S???A R???A M???T D?????NG ???M T???I ??U RESIST OPTIMAL RESULTS HYDRATING CLEANSER', 'ML03', 'SX01', 725000, 'https://drive.google.com/file/d/1AriWQbLLuBlboVHDhWofEvF370192aYf/view?usp=sharing', 'Water, Caprylic/Capric Triglyceride (emollient/texture-enhancing), Decyl Glucoside (cleansing), Glycerin (hydration/skin replenishing), PEG-20 Methyl Glucose Sesquistearate (cleansing)', '01/10/2019', '01/10/2024');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE `taikhoan` (
  `MA` varchar(4) NOT NULL,
  `TENDANGNHAP` varchar(20) NOT NULL,
  `MATKHAU` varchar(8) NOT NULL,
  `MaQ` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`MA`, `TENDANGNHAP`, `MATKHAU`, `MaQ`) VALUES
('TK01', 'QUANTRIVIEN', '11111111', 'Q01'),
('TK02', 'NVBANHANG', '22222222', 'Q02'),
('TK03', 'NVNHAPHANG', '33333333', 'Q03'),
('TK04', 'CHAMSOCKHACHHANG', '44444444', 'Q04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD KEY `CHITIETCUAHD` (`MAHD`),
  ADD KEY `SP` (`MASP`);

--
-- Indexes for table `chitietkho`
--
ALTER TABLE `chitietkho`
  ADD KEY `MaKho` (`MaKho`),
  ADD KEY `MaSP` (`MaSP`);

--
-- Indexes for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD KEY `CHITIETCUAPN` (`MAPN`),
  ADD KEY `SANPHAM` (`MASP`);

--
-- Indexes for table `chitietquyen`
--
ALTER TABLE `chitietquyen`
  ADD KEY `MAQ` (`MAQ`);

--
-- Indexes for table `ctkhuyenmai`
--
ALTER TABLE `ctkhuyenmai`
  ADD PRIMARY KEY (`MA`);

--
-- Indexes for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MA`),
  ADD KEY `NVTHANHTOAN` (`MANV`),
  ADD KEY `KHACHHANGMUA` (`MAKH`),
  ADD KEY `CTKM` (`MACTKM`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`MAKH`);

--
-- Indexes for table `kho`
--
ALTER TABLE `kho`
  ADD PRIMARY KEY (`MA`);

--
-- Indexes for table `loaihang`
--
ALTER TABLE `loaihang`
  ADD PRIMARY KEY (`MA`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`MANV`);

--
-- Indexes for table `nhasanxuat`
--
ALTER TABLE `nhasanxuat`
  ADD PRIMARY KEY (`MA`);

--
-- Indexes for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD PRIMARY KEY (`MA`),
  ADD KEY `NHANVIENNHAP` (`MANV`);

--
-- Indexes for table `quyen`
--
ALTER TABLE `quyen`
  ADD PRIMARY KEY (`MaQ`);

--
-- Indexes for table `sanpham`
--
ALTER TABLE `sanpham`
  ADD PRIMARY KEY (`MA`),
  ADD KEY `THUOCNHOM` (`LOAIHANG`),
  ADD KEY `THUOCNSX` (`NSX`);

--
-- Indexes for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`MA`),
  ADD KEY `QUYEN` (`MaQ`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chitietquyen`
--
ALTER TABLE `chitietquyen`
  ADD CONSTRAINT `chitietquyen_ibfk_1` FOREIGN KEY (`MAQ`) REFERENCES `quyen` (`MaQ`);

--
-- Constraints for table `sanpham`
--
ALTER TABLE `sanpham`
  ADD CONSTRAINT `THUOCNHOM` FOREIGN KEY (`LOAIHANG`) REFERENCES `loaihang` (`MA`),
  ADD CONSTRAINT `THUOCNSX` FOREIGN KEY (`NSX`) REFERENCES `nhasanxuat` (`MA`);

--
-- Constraints for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD CONSTRAINT `taikhoan_ibfk_1` FOREIGN KEY (`MaQ`) REFERENCES `quyen` (`MaQ`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
