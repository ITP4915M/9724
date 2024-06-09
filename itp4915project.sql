-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 2024-06-07 10:14:49
-- 服务器版本： 10.1.30-MariaDB
-- PHP Version: 5.6.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `itp4915project`
--

-- --------------------------------------------------------

--
-- 表的结构 `dealer`
--

CREATE TABLE `dealer` (
  `DealerID` char(10) NOT NULL,
  `DealerName` varchar(50) NOT NULL,
  `RegisterDate` date NOT NULL,
  `DealerAddress` varchar(100) NOT NULL,
  `PhoneNo` varchar(11) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `HandlerName` varchar(50) DEFAULT NULL,
  `HandlerPhoneNo` varchar(11) DEFAULT NULL,
  `HandlerPosition` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `dealer`
--

INSERT INTO `dealer` (`DealerID`, `DealerName`, `RegisterDate`, `DealerAddress`, `PhoneNo`, `Email`, `HandlerName`, `HandlerPhoneNo`, `HandlerPosition`) VALUES
('D220611002', 'auto guide limited', '2022-06-11', 'Xi San Qi Qi Sheng Jia Yuan 14-1-602\r\nCity Area - Haidian District\r\nBeijing', '61181561', 'agl@autoMail.com', 'Jiang Xinjia', '13826213302', 'Manager'),
('D220818089', 'road ster hotline Inc.', '2022-08-18', 'Huai Ning Xian Gao He Zhen Hong Qi Lu 24hao Bdong 301shi,\r\nAnqing - Huainingcounty,\r\nAnhui', '32682945', 'roadSter@roadInc.com.cn', 'Shi Guozheng', '15391645438', 'supervisor'),
('D220914114', 'Second Gear Limited branch 03', '2022-09-14', 'Da Qing Cai You Ba Chang 4-19-4-201,Daqing - Datong District,Heilongjiang', '13057480443', 'SGL@2gear.com', 'Kong Jiehao', '13057480443', 'Inventory Manager'),
('D221020514', 'Spare Savior limit', '2022-10-20', 'Wu Gong Li Xue Fu Da Dao Zhong Qing Gong Shang Da Xue,ZhongqingState/province/area:   Chongqing', '66692694', 'SpareSaviorlimit@gmail.com', 'Yang Xianghao', '13612534873', 'Senior Sales'),
('D230207547', 'Drive Spare company', '2023-02-07', 'Gui Zhou Sheng Cen Gong Xian Yin Lian Jiao Che Wei Xiu Chang,Guizhou', '61621577', 'driveSpare@driveSpare.com', 'Cao Jianjin', '13063746863', 'Manager'),
('D230317198', 'Tire Care Limited', '2023-03-17', 'Xiang Chun Lu Bei Zheng Jie 325hao,\r\nChangsha - Kaifu District,Hunan', '64675491', 'tirecare@tirecare.mail.com', 'Zhu Shentu', '13989971433', 'Sales Representative'),
('D230712329', 'Speed Spare inc.', '2023-07-12', 'Ren Min Da Xue Yi Yuan floor 2 room 906,\r\nHaidian District,Beijing', '27136243', 'Speedspare@outlook.com', 'Wang Shishang', '13052862570', 'Senior assistant'),
('D230810547', 'Best Spare limited', '2023-08-10', 'Ri Tan Lu 6hao Xin Zu Da Xia 2,City Area - Chaoyang District,Beijing', '37382689', 'bestSpare@qq.com', 'Zhang Maying', '13664711099', 'Dealer Manager');

-- --------------------------------------------------------

--
-- 表的结构 `department`
--

CREATE TABLE `department` (
  `DepartmentID` varchar(4) NOT NULL,
  `DepartmentName` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `department`
--

INSERT INTO `department` (`DepartmentID`, `DepartmentName`) VALUES
('A01', 'Accounting Department1'),
('A02', 'Accounting Department2'),
('A03', 'Accounting Department3'),
('IT01', 'IT Department1'),
('IT02', 'IT Department2'),
('IT03', 'IT Department3'),
('P01', 'Purchasing Department1'),
('P02', 'Purchasing Department2'),
('P03', 'Purchasing Department3'),
('S01', 'Sales Department1'),
('S02', 'Sales Department2'),
('S03', 'Sales Department3'),
('SD01', 'Spare Despatch Department1'),
('SD02', 'Spare Despatch Department2'),
('WH01', 'Warehouse Department1'),
('WH02', 'Warehouse Department2');

-- --------------------------------------------------------

--
-- 表的结构 `diset`
--

CREATE TABLE `diset` (
  `OrderID` char(10) NOT NULL,
  `ItemID` char(8) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Remark` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `diset`
--

INSERT INTO `diset` (`OrderID`, `ItemID`, `Quantity`, `Remark`) VALUES
('2203120004', 'A1000001', 12, NULL),
('2203120004', 'A1000024', 45, NULL),
('2203120004', 'B0400057', 20, 'No'),
('2203120004', 'B2000023', 12, NULL),
('2207110061', 'C3000045', 0, NULL),
('2207110061', 'C3000057', 20, NULL);

-- --------------------------------------------------------

--
-- 表的结构 `goodrecievenote`
--

CREATE TABLE `goodrecievenote` (
  `GRNID` char(10) NOT NULL,
  `SupplierID` char(9) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `goodrecievenote`
--

INSERT INTO `goodrecievenote` (`GRNID`, `SupplierID`, `Price`, `Date`) VALUES
('2301230017', 'SP2204001', '0.00', '2023-01-23'),
('2302160011', 'SP2204014', '0.00', '2023-02-16'),
('2303110053', 'SP2205027', '0.00', '2023-03-11'),
('2303140034', 'SP2206042', '0.00', '2023-03-14');

-- --------------------------------------------------------

--
-- 表的结构 `grnitem`
--

CREATE TABLE `grnitem` (
  `GRNID` char(10) NOT NULL,
  `ItemID` char(8) NOT NULL,
  `Quantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `grnitem`
--

INSERT INTO `grnitem` (`GRNID`, `ItemID`, `Quantity`) VALUES
('2301230017', 'A1000001', 10),
('2301230017', 'A1000024', 20),
('2301230017', 'B0400057', 10),
('2301230017', 'B2000023', 10),
('2301230017', 'C3000057', 20),
('2301230017', 'C3400075', 20),
('2301230017', 'D4000054', 20),
('2302160011', 'A0500001', 10),
('2302160011', 'A1000024', 20),
('2303140034', 'D4100067', 20);

-- --------------------------------------------------------

--
-- 表的结构 `iteminfo`
--

CREATE TABLE `iteminfo` (
  `Image` char(100) DEFAULT NULL,
  `ItemID` char(8) NOT NULL COMMENT 'Item unique ID',
  `ItemName` char(50) NOT NULL,
  `Quantity` int(6) NOT NULL COMMENT 'Item quantity\n',
  `Category` set('A - Sheet Metal','B - Major Assemblies','C - Light Components','D - Accessories') NOT NULL,
  `Weight` decimal(10,2) NOT NULL COMMENT 'per kg',
  `Description` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL COMMENT 'per quantity',
  `StockLevel` set('Safe','Low','Danger','Overflow') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `iteminfo`
--

INSERT INTO `iteminfo` (`Image`, `ItemID`, `ItemName`, `Quantity`, `Category`, `Weight`, `Description`, `Price`, `StockLevel`) VALUES
(NULL, 'A0500001', 'Door Outer Panel', 213, 'A - Sheet Metal', '2.10', 'I am item A050001', '1.20', 'Low'),
('', 'A1000001', 'Hood', 246, 'A - Sheet Metal', '3.10', 'I am Item A100001', '2.30', 'Low'),
('', 'A1000024', 'Trunk Lid', 426, 'A - Sheet Metal', '30.10', 'I am item A1000024', '30.00', 'Safe'),
('', 'A2000004', 'Fender', 353, 'A - Sheet Metal', '23.10', 'I am item A2000004', '40.00', 'Safe'),
('', 'B0200034', 'Engine Assembly', 342, 'B - Major Assemblies', '15.10', 'I am item B0200034', '14.10', 'Safe'),
('', 'B0400057', 'Transmission', 978, 'B - Major Assemblies', '13.10', 'I am item B0400057', '33.00', 'Overflow'),
('', 'B0700046', 'Front Suspension Assembly', 435, 'B - Major Assemblies', '2.40', 'I am item B0700046', '35.00', 'Safe'),
('', 'B2000023', 'Rear Axle Assembly', 534, 'B - Major Assemblies', '12.20', 'I am item B20000023', '20.00', 'Safe'),
('', 'C3000045', 'Headlight', 1348, 'C - Light Components', '3.00', 'I am item C3000045', '10.00', 'Overflow'),
('', 'C3000057', 'Tail Light', 120, 'C - Light Components', '12.20', 'I am item C3000057', '42.00', 'Low'),
('', 'C3100541', 'Turn Signal Light', 347, 'C - Light Components', '2.30', 'I am item C3100541', '32.40', 'Safe'),
('', 'C3400075', 'Interior Light', 913, 'C - Light Components', '4.70', 'I am item C3400075', '12.00', 'Overflow'),
('', 'D4000054', 'Navigation System', 23, 'D - Accessories', '23.00', 'Item D4000054', '43.00', 'Danger'),
('', 'D4000079', 'Car Bluetooth Device', 547, 'D - Accessories', '4.20', 'Item D4000079', '32.50', 'Safe'),
('', 'D4100067', 'Dash Cam', 274, 'D - Accessories', '14.00', 'Item D4100067', '17.00', 'Low');

-- --------------------------------------------------------

--
-- 表的结构 `order`
--

CREATE TABLE `order` (
  `OrderID` char(10) NOT NULL,
  `DealerID` char(10) NOT NULL,
  `PaymentName` varchar(50) DEFAULT NULL,
  `StaffID` char(6) DEFAULT NULL,
  `Status` set('Processing','Shipped','Delivered','Cancelled','Pending','Draft') NOT NULL,
  `Descrption` varchar(255) DEFAULT NULL,
  `OrderDate` date NOT NULL,
  `OrderAmounts` decimal(10,2) NOT NULL,
  `TotalItem` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `order`
--

INSERT INTO `order` (`OrderID`, `DealerID`, `PaymentName`, `StaffID`, `Status`, `Descrption`, `OrderDate`, `OrderAmounts`, `TotalItem`) VALUES
('2203120004', 'D220818089', 'Bank of China', 'S01001', 'Pending', 'No descrption', '2022-03-12', '2037.60', 77),
('2203200024', 'D220818089', 'Bank of China', 'S01003', 'Shipped', 'No descrption', '2022-03-20', '0.00', 0),
('2207110061', 'D221020514', 'ICBN', 'S01005', 'Shipped', 'No Descrption', '2022-07-11', '0.00', 0),
('2207110062', 'D221020514', 'ICBN', 'S01001', 'Pending', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110064', 'D221020514', 'ICBN', 'S01003', 'Pending', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110065', 'D221020514', 'Bank of China', 'S01006', 'Pending', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110066', 'D221020514', 'Bank of China', 'S01006', 'Processing', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110067', 'D220818089', 'Bank of China', 'S01005', 'Cancelled', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110068', 'D220818089', 'Bank of China', 'S01001', 'Cancelled', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110069', 'D220818089', 'Bank of China', 'S01001', 'Draft', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110070', 'D220818089', 'Bank of China', 'S01001', 'Draft', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110071', 'D220818089', 'Bank of China', 'S01006', 'Draft', 'No Descrption', '2024-05-14', '123.00', 12),
('2207110072', 'D221020514', NULL, 'S02037', 'Draft', NULL, '2024-06-05', '0.00', 0),
('2207110073', 'D220818089', NULL, 'S02037', 'Pending', NULL, '2024-06-05', '0.00', 0),
('2207110074', 'D220818089', NULL, 'S02037', 'Pending', NULL, '2024-06-06', '0.00', 0),
('2207110075', 'D220818089', NULL, 'S02037', 'Draft', NULL, '2024-06-06', '0.00', 0),
('2207110076', 'D220818089', NULL, NULL, 'Pending', NULL, '2024-06-07', '0.00', 0);

-- --------------------------------------------------------

--
-- 表的结构 `paymentgateway`
--

CREATE TABLE `paymentgateway` (
  `PaymentName` varchar(50) NOT NULL COMMENT 'bank name',
  `DealerID` char(10) NOT NULL COMMENT 'The dealer ID',
  `CardNo` varchar(30) NOT NULL COMMENT 'The payment card number',
  `BankCode` int(3) NOT NULL,
  `VertNo` varchar(30) NOT NULL,
  `ExpirationDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `paymentgateway`
--

INSERT INTO `paymentgateway` (`PaymentName`, `DealerID`, `CardNo`, `BankCode`, `VertNo`, `ExpirationDate`) VALUES
('Bank of China', 'D220611002', '6216345678901234', 103, 'XYZ987PQR654LMN', '2028-03-16'),
('ICBN', 'D220818089', '6221456789012345', 105, 'ABC123DEF456GHI', '2029-11-15'),
('China Construction Bank', 'D220914114', '6227567890123456', 107, 'MNO789PQR012STU', '2030-03-31'),
('Agricultural Bank of China', 'D221020514', '62286789012345', 109, 'VWX456YZA789BCD', '2026-09-01');

-- --------------------------------------------------------

--
-- 表的结构 `reorder`
--

CREATE TABLE `reorder` (
  `ReOrderNo` char(10) NOT NULL,
  `PurchasingID` char(3) NOT NULL,
  `SupplierID` char(9) NOT NULL,
  `Date` date NOT NULL,
  `ItemID` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `reorder`
--

INSERT INTO `reorder` (`ReOrderNo`, `PurchasingID`, `SupplierID`, `Date`, `ItemID`) VALUES
('R220116009', 'P01', 'SP2204014', '2022-01-16', 'D4000054'),
('R220522005', 'P01', 'SP2204014', '2022-05-14', 'B0700046'),
('R220716020', 'P02', 'SP2204014', '2022-07-16', 'D4000054'),
('R220822005', 'P02', 'SP2204014', '2022-08-22', 'A2000004');

-- --------------------------------------------------------

--
-- 表的结构 `staff`
--

CREATE TABLE `staff` (
  `StaffID` char(6) NOT NULL,
  `StaffName` varchar(50) NOT NULL COMMENT 'the name of staff',
  `DepartmentID` varchar(4) NOT NULL,
  `Position` varchar(30) NOT NULL,
  `Age` int(2) NOT NULL COMMENT 'the age of staff',
  `Password` varchar(15) NOT NULL COMMENT 'the login password of staff',
  `CNID` char(18) NOT NULL COMMENT 'chinese identity card number',
  `PhoneNo` char(11) NOT NULL COMMENT 'the phone number of the staff',
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `staff`
--

INSERT INTO `staff` (`StaffID`, `StaffName`, `DepartmentID`, `Position`, `Age`, `Password`, `CNID`, `PhoneNo`, `Email`) VALUES
('A01001', 'Tao HaoHao', 'A01', 'Accounting Manager', 36, 'mnbvcxz', '420101197304227311', '15081802601', 'THH420@gmail.com'),
('A01008', 'Zhao Quanchi', 'A01', 'Accounting assistant', 29, 'lkjhgfdsa', '420101196805110045', '15798627792', 'Zqc157@gmail.com'),
('A01038', 'Qin Zichen', 'A01', 'Accounting assistant', 31, 'qpqpq228922', '420101197606295969', '13901408392', 'Qin2241@outlook.com'),
('A01046', 'Chu Houya', 'A01', 'Accounting assistant', 24, 'qpwoei980', '42010119930221521X', '13728668359', 'ChuHoyo@sina.com'),
('A01048', 'Zhao Taohan', 'A01', 'Accounting assistant', 27, 'duryq4645', '420101199902176613', '13541962864', 'Zhao223@qq.com'),
('A01418', 'Sun Yiqian', 'A01', 'Accounting assistant', 36, 'alalal101010', '420101198202162320', '13737298061', 'SunY235@163.com'),
('A02016', 'Chen Yiyue', 'A01', 'Accounting Manager', 21, 'oot4909', '420101197804121804', '13542065133', 'CYgames@qq.com'),
('A02067', 'Hayato nanami', 'A02', 'Accounting assistant', 34, 'mie34211', '420101199106125719', '13722817504', 'hayato404@126.com'),
('A02073', 'Zhou Xinjun', 'A02', 'Accounting assistant', 22, 'houiygi987', '420101197707204608', '13738303225', 'Xinjun241@gmail.com'),
('A03014', 'Sun Suoshi', 'A03', 'Accounting Manager', 31, 'roroke323', '420101199607168653', '13674465415', 'suoshi153@sina.com'),
('admin', 'admin', 'IT01', 'IT Manager', 18, 'admin', '440111111111111', '11111111111', 'it@legendmotor.com'),
('IT0102', 'Li Menghui', 'IT01', 'IT Manager', 26, 'plokijuh666', '420101199506180207', '13756785427', 'lmh098@gmail.com'),
('IT0104', 'Lu Yiyu', 'IT01', 'IT deloveper ', 23, 'asdkjh12345', '420101196509217016', '13519282754', 'Luasd@gmail.com'),
('IT0121', 'Qian Linling', 'IT01', 'IT deloveper', 21, 'poiqwe123', '420101196205250714', '13978325115', 'Qli756@gmail.com'),
('IT0213', 'Qin Hanhui', 'IT02', 'IT Manager', 31, '1212121212', '420101198701125022', '13899219232', 'QinHan214@qq.com'),
('IT0242', 'Chu Qingwei', 'IT02', 'IT deloveper', 32, 'slslsl202020', '420101196104129421', '13853105994', 'Chufake@163.com'),
('IT0268', 'Zhang Shangzi', 'IT02', 'IT deloveper', 41, 'qpqpqpq59595', '420101196406217240', '15729177719', 'zhangEmail@sina.com'),
('IT0321', 'Shen Xinhe', 'IT03', 'IT Manager', 23, 'cmcmcm328383', '420101197205260044', '15199271576', 'Shen215@qq.com'),
('IT0338', 'Chutian sakamata', 'IT03', 'IT deloveper', 26, 'alalal929292', '420101197201243773', '15794262482', 'ChSaka@qq.com'),
('IT0357', 'Jiang Mingyong', 'IT03', 'IT deloveper', 27, 'dkdkdk99292', '420101197709113873', '13993861753', 'Jiang24@qq.com'),
('IT0361', 'Li Mingxuan', 'IT03', 'IT deloveper', 39, 'wowow29292', '420101196102247803', '15857812377', 'Li46193@outlook.com'),
('P01041', 'Chen Tangyi', 'P01', 'Purchasing Manager', 26, 'Asdfgh765', '420101196801299856', '15139677270', 'CT256@gmail.com'),
('P01047', 'Zhao Aoma', 'P01', 'Purchasing Assistant', 31, 'zxcvb12345', '420101196708102326', '13968154224', 'ZAwarudo@gmail.com'),
('P01051', 'Zheng Haao', 'P01', 'Purchasing Assistant', 23, 'ert4565', '42010119700224487X', '15195954974', 'ZH356@gmail.com'),
('P01053', 'Yang Danyou', 'P01', 'Purchasing Assistant', 35, 'dsfa1234', '420101199409126727', '13506636330', 'YDuuu645@gmail.com'),
('P02035', 'Wang Zixian', 'P02', 'Purchasing Manager', 32, '3631efewe', '420101198306288809', '13839554157', 'Wang363@qq.com'),
('P02044', 'Li Zhengma', 'P02', 'Purchasing Assistant', 36, 'eoeoeo399393', '420101197204272203', '13704776177', '678198Li@outlook.com'),
('P02046', 'Zheng Rongjia', 'P02', 'Purchasing Assistant', 25, 'dkalauw4657', '420101199909281408', '15198051431', 'zheng253@qq.com'),
('P02061', 'Xu Xianqi', 'P02', 'Purchasing Assistant', 29, 'ksksks29210', '420101196904155265', '15104388434', 'Xu3242@qq.com'),
('P03034', 'Zhu Qiyue', 'P03', 'Purchasing Manager', 27, 'qoqoq29292', '420101196602272378', '15045109245', 'vwwd@qq.com'),
('P03056', 'Jin Mingyu', 'P03', 'Purchasing Assistant', 29, 'scmcm2121', '420101198904289756', '15815423751', 'Jinq653@outlook.com'),
('P03061', 'Jiang Jingxin', 'P03', 'Purchasing Assistant', 36, 'qlqalsk3910', '420101199001117982', '15264208659', 'Jiang3523@outlook.com'),
('P03069', 'Ho Ziyi', 'P03', 'Purchasing Assistant', 28, 'qwks9352', '420101197503164106', '15259624518', 'Ho3235@outlook.com'),
('P03084', 'Sun Huifan', 'P03', 'Purchasing Assistant', 42, 'ghghgh3535', '420101197702195853', '15803262750', ''),
('P03092', 'Chen Yuchen', 'P03', 'Purchasing Assistant', 45, 'eyeye27272', '420101198306159492', '13961862332', 'Chenc@qq.com'),
('S01001', 'Chan Tai Man', 'S01', 'Sales Manager', 24, '12345abc', '528023198001014755', '15847233687', 'CTM@gmail.com'),
('S01003', 'Chen Houhe', 'S01', 'Sales Assistant', 20, '56789cde', '42010119950120111X', '15036216526', 'Ch567@gmail.com'),
('S01005', 'Wang Xijian', 'S01', 'Sales Assistant', 21, '897Cwwed', '420101198505282573', '15172772613', 'WXabc@gmail.com'),
('S01006', 'Yan Suiyue', 'S01', 'Sales Assistant', 19, 'qwertyu123', '420101197308232783', '13534289247', 'YSfff@gmail.com'),
('S02013', 'Feng Xinhui', 'S02', 'Sales Manager', 31, 'cvx789', '420101197501107597', '15741803845', 'Feng153@outlook.com'),
('S02037', 'Ho Yuma', 'S02', 'Sales Assistant', 33, 'fdbr4341', '420101197707293786', '13617586576', 'Yuma774@163.com'),
('S02057', 'Yan Jiashu', 'S02', 'Sales Assistant', 33, 'sdq789', '420101198809209519', '15263890378', 'Yan251@qq.com'),
('S03028', 'Chen Yuexiao', 'S03', 'Sales Manager', 34, 'qwqet124', '420101197205295941', '13656058252', 'ejeje@qq.com'),
('S03063', 'Lee Tin Suo', 'S03', 'Sales Assistant', 33, 'homo114514', '420101145141919810', '13535277108', 'monsterHome114@outlook.com'),
('SD0124', 'Qin Yuezi', 'SD01', 'Spare Despatch Manger', 34, 'www445', '420101197902226159', '13583063249', 'QY435@gmail.com'),
('SD0126', 'Chu Xinji', 'SD01', 'Spare Despatch Assistant', 29, 'qew125', '420101196704297154', '13693250491', 'CX420@gmail.com'),
('SD0131', 'Wei Linmiao', 'SD01', 'Spare Despatch Assistant', 31, 'kdjfh23', '420101198106285064', '15876658362', '1234WLm@gmail.com'),
('SD0139', 'Yan Haocheng', 'SD01', 'Spare Despatch Assistant', 40, 'fetq24', '420101198101241345', '13804102687', 'Yan135@gmail.com'),
('test', 'test', 'A01', 'Warehouse Manager', 5, 'test', 'test', 'test', 'test'),
('WH0103', 'He Yahao', 'WH01', 'Warehouse Manager', 34, 'qwert576', '420101196209146893', '15751609416', 'HYman@126.com'),
('WH0126', 'Zhu Xiaoyu', 'WH01', 'Warehouse Assistant', 28, 'qwas241', '420101197406154563', '13834476954', 'ghghg@hotmail.com'),
('WH0165', 'Zhang Dele', 'WH01', 'Warehouse Assistant', 35, 'aszx245', '42010119860622265X', '15788140705', 'unfulfilled@hotmail.com'),
('WH0198', 'Shi Buhan', 'WH01', 'Warehouse Assistant', 24, 'lkjhg555', '420101198201203442', '15179610550', 'SBisY@qq.com'),
('WH0209', 'Qian Xuanyi', 'WH02', 'Warehouse Manager', 27, 'qweqe12513', '420101198609165558', '13756005370', 'Qian756@qq.com'),
('WH0218', 'Lu Xiaoyi', 'WH02', 'Warehouse Assistant', 23, 'dgfgfg35353', '420101197504201968', '13634795313', 'Lu321@sina.com'),
('WH0221', 'Chu Qianhe', 'WH02', 'Warehouse Assistant', 35, 'qwd2124', '420101199006186872', '13778680212', 'Chu3536@qq.com'),
('WH0257', 'Sun Junmei', 'WH02', 'Warehouse Assistant', 42, 'qwet351', '420101199505260985', '13859355041', 'Sun231@gmail.com'),
('WH0268', 'Chen Zizhen', 'WH02', 'Warehouse Assistant', 45, 'asdwe242', '420101196306199217', '13770319311', 'ejtg33@outlook.com');

-- --------------------------------------------------------

--
-- 表的结构 `stocklevel`
--

CREATE TABLE `stocklevel` (
  `Safe` int(11) NOT NULL,
  `Low` int(11) NOT NULL,
  `Danger` int(11) NOT NULL,
  `Overflow` int(11) NOT NULL,
  `ItemID` char(8) CHARACTER SET utf8mb4 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 转存表中的数据 `stocklevel`
--

INSERT INTO `stocklevel` (`Safe`, `Low`, `Danger`, `Overflow`, `ItemID`) VALUES
(2, 2, 2, 2, 'A0500001'),
(2, 2, 2, 2, 'A0500001'),
(0, 0, 0, 0, 'A0500001'),
(1, 1, 1, 1, 'A0500001');

-- --------------------------------------------------------

--
-- 表的结构 `stockrecord`
--

CREATE TABLE `stockrecord` (
  `StockRecordID` int(20) NOT NULL,
  `ItemID` char(8) CHARACTER SET utf8mb4 NOT NULL,
  `Quantity` int(11) NOT NULL,
  `RecordType` set('In','Out') NOT NULL,
  `RecordTime` date NOT NULL,
  `DangerLevelStock` int(11) DEFAULT NULL,
  `CurrentStock` int(11) DEFAULT NULL,
  `ReorderStock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 转存表中的数据 `stockrecord`
--

INSERT INTO `stockrecord` (`StockRecordID`, `ItemID`, `Quantity`, `RecordType`, `RecordTime`, `DangerLevelStock`, `CurrentStock`, `ReorderStock`) VALUES
(2, 'A1000001', 12, 'Out', '2022-03-12', 50, 246, 10),
(3, 'A1000024', 45, 'Out', '2022-03-12', 50, 426, 11),
(4, 'B0400057', 20, 'Out', '2022-03-12', 30, 968, 17),
(5, 'A1000024', 20, 'In', '2023-01-23', 60, 446, 5),
(6, 'B0400057', 10, 'In', '2023-01-23', 40, 978, 9),
(7, 'B2000023', 10, 'In', '2024-06-07', 37, 534, 5);

-- --------------------------------------------------------

--
-- 表的结构 `supplier`
--

CREATE TABLE `supplier` (
  `SupplierID` char(9) NOT NULL,
  `SupplierName` varchar(50) NOT NULL,
  `SupplierAddress` varchar(255) NOT NULL,
  `PhoneNo` bigint(11) NOT NULL,
  `Website` varchar(100) DEFAULT NULL,
  `Payment` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `SupplierName`, `SupplierAddress`, `PhoneNo`, `Website`, `Payment`, `Email`) VALUES
('SP2204001', 'Spare Hero', 'Guang Zhou Shi Jie Fang Bei Lu Xiang Gang Shan 25f rm704, Guangzhou,Guangdong', 15060416248, 'https://www.sparehero.org', 'Credit Card ', 'info@sparehero.org'),
('SP2204014', 'Remn Spare', 'Jin Qian Song Zhong Lu Jin Hui Bin Li Min Dian', 15191945032, 'RemnSpare.com', 'Credit Card', 'info@RemnSpare.com'),
('SP2205027', 'Spare Up', 'Zhong Gong Yan Bian Zhou Wei Zheng Fa Wei', 13774531283, 'SpareUp.com.cn', 'Credit Card', 'info@Sapreup.com'),
('SP2206042', 'Suplify', 'Tong An Lu 566hao Fu Shan Hou Bu Xi Hua Yuan 8hao Lou Yi Dan Yuan 502', 13694691406, 'Suplify.net', 'Credit Card', 'info@suplify.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dealer`
--
ALTER TABLE `dealer`
  ADD PRIMARY KEY (`DealerID`),
  ADD UNIQUE KEY `DealerID` (`DealerID`,`DealerAddress`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepartmentID`);

--
-- Indexes for table `diset`
--
ALTER TABLE `diset`
  ADD PRIMARY KEY (`OrderID`,`ItemID`),
  ADD KEY `diset_itmeID_fk` (`ItemID`);

--
-- Indexes for table `goodrecievenote`
--
ALTER TABLE `goodrecievenote`
  ADD PRIMARY KEY (`GRNID`),
  ADD KEY `GRN_supplierID_fk` (`SupplierID`);

--
-- Indexes for table `grnitem`
--
ALTER TABLE `grnitem`
  ADD PRIMARY KEY (`GRNID`,`ItemID`),
  ADD KEY `grnitem_itemID_fk` (`ItemID`);

--
-- Indexes for table `iteminfo`
--
ALTER TABLE `iteminfo`
  ADD PRIMARY KEY (`ItemID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `order_dealerID_fk` (`DealerID`),
  ADD KEY `order_Payment_fk` (`PaymentName`),
  ADD KEY `order_staff_StaffID_fk` (`StaffID`);

--
-- Indexes for table `paymentgateway`
--
ALTER TABLE `paymentgateway`
  ADD PRIMARY KEY (`CardNo`),
  ADD KEY `PaymentGateWay_dealerID_fk` (`DealerID`),
  ADD KEY `PaymentName` (`PaymentName`);

--
-- Indexes for table `reorder`
--
ALTER TABLE `reorder`
  ADD PRIMARY KEY (`ReOrderNo`),
  ADD KEY `ReOrder_PurchasingID_fk` (`PurchasingID`),
  ADD KEY `ReOrder_Supplier_fk` (`SupplierID`),
  ADD KEY `reORder_ItemID_fk` (`ItemID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `CNID` (`CNID`),
  ADD UNIQUE KEY `StaffID` (`StaffID`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD KEY `Staff_DepartmentID_fk` (`DepartmentID`);

--
-- Indexes for table `stocklevel`
--
ALTER TABLE `stocklevel`
  ADD KEY `stocklevel_itemID_fk` (`ItemID`);

--
-- Indexes for table `stockrecord`
--
ALTER TABLE `stockrecord`
  ADD PRIMARY KEY (`StockRecordID`),
  ADD KEY `stockrecord_itemID_fk` (`ItemID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SupplierID`),
  ADD UNIQUE KEY `SupplierID` (`SupplierID`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `stockrecord`
--
ALTER TABLE `stockrecord`
  MODIFY `StockRecordID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- 限制导出的表
--

--
-- 限制表 `diset`
--
ALTER TABLE `diset`
  ADD CONSTRAINT `diset_itmeID_fk` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`),
  ADD CONSTRAINT `diset_orderID_FK` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`);

--
-- 限制表 `goodrecievenote`
--
ALTER TABLE `goodrecievenote`
  ADD CONSTRAINT `GRN_supplierID_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 限制表 `grnitem`
--
ALTER TABLE `grnitem`
  ADD CONSTRAINT `grnitem_GRNID_fk` FOREIGN KEY (`GRNID`) REFERENCES `goodrecievenote` (`GRNID`),
  ADD CONSTRAINT `grnitem_itemID_fk` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`);

--
-- 限制表 `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_Payment_fk` FOREIGN KEY (`PaymentName`) REFERENCES `paymentgateway` (`PaymentName`),
  ADD CONSTRAINT `order_dealerID_fk` FOREIGN KEY (`DealerID`) REFERENCES `dealer` (`DealerID`),
  ADD CONSTRAINT `order_staff_StaffID_fk` FOREIGN KEY (`StaffID`) REFERENCES `staff` (`StaffID`);

--
-- 限制表 `paymentgateway`
--
ALTER TABLE `paymentgateway`
  ADD CONSTRAINT `PaymentGateWay_dealerID_fk` FOREIGN KEY (`DealerID`) REFERENCES `dealer` (`DealerID`);

--
-- 限制表 `reorder`
--
ALTER TABLE `reorder`
  ADD CONSTRAINT `reORder_ItemID_fk` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`),
  ADD CONSTRAINT `reOrder_purchasingID_fk` FOREIGN KEY (`PurchasingID`) REFERENCES `department` (`DepartmentID`),
  ADD CONSTRAINT `reOrder_supplierID_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`SupplierID`);

--
-- 限制表 `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `Staff_DepartmentID_fk` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`DepartmentID`);

--
-- 限制表 `stocklevel`
--
ALTER TABLE `stocklevel`
  ADD CONSTRAINT `stocklevel_itemID_fk` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`);

--
-- 限制表 `stockrecord`
--
ALTER TABLE `stockrecord`
  ADD CONSTRAINT `stockrecord_itemID_fk` FOREIGN KEY (`ItemID`) REFERENCES `iteminfo` (`ItemID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
