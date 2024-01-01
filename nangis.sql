-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 01, 2024 at 07:20 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nangis`
--

-- --------------------------------------------------------

--
-- Table structure for table `komputer_warnet`
--

CREATE TABLE `komputer_warnet` (
  `ID_Komputer` varchar(3) NOT NULL,
  `Ketersediaan` int(1) NOT NULL,
  `ID_Pelanggan` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `komputer_warnet`
--

INSERT INTO `komputer_warnet` (`ID_Komputer`, `Ketersediaan`, `ID_Pelanggan`) VALUES
('PC1', 1, NULL),
('PC2', 0, 'Cust2'),
('PC3', 0, 'Cust3'),
('PC4', 0, 'Cust4'),
('PC5', 0, 'Cust5'),
('PC6', 0, 'Cust6'),
('PC7', 1, NULL),
('PC8', 1, NULL),
('PC9', 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `operator`
--

CREATE TABLE `operator` (
  `ID_Operator` varchar(3) NOT NULL,
  `Nama` varchar(30) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `Umur` int(11) DEFAULT NULL,
  `Mulai_Shift` datetime DEFAULT NULL,
  `Akhir_Shift` datetime DEFAULT NULL,
  `Username` varchar(15) DEFAULT NULL,
  `Password` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `operator`
--

INSERT INTO `operator` (`ID_Operator`, `Nama`, `Alamat`, `Umur`, `Mulai_Shift`, `Akhir_Shift`, `Username`, `Password`) VALUES
('Op1', 'Joko Susilo', 'Sleman', 23, '2023-12-26 07:00:00', '2023-12-26 13:00:00', 'joko', 'joko'),
('Op2', 'Hendro Budi', 'Kasihan, Yogyakarta', 25, '2023-12-27 13:00:00', '2023-12-27 21:00:00', 'budi', 'budi'),
('Op3', 'Ahmad Rizky', 'Jetis, Yogyakarta', 25, '2023-12-27 21:00:00', '2023-12-27 07:00:00', 'ahmad', 'ahmad');

-- --------------------------------------------------------

--
-- Table structure for table `paket`
--

CREATE TABLE `paket` (
  `ID_Paket` varchar(4) NOT NULL,
  `Nama` varchar(25) DEFAULT NULL,
  `Menit` int(11) DEFAULT NULL,
  `Harga` int(11) DEFAULT NULL,
  `Jumlah` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `paket`
--

INSERT INTO `paket` (`ID_Paket`, `Nama`, `Menit`, `Harga`, `Jumlah`) VALUES
('pkt1', '30 menit', 30, 3000, 3000),
('pkt2', '1 Jam', 60, 60, 3000),
('pkt3', '2 Jam', 120, 9500, 3000),
('pkt4', '3 Jam', 180, 14000, 3000),
('pkt5', '4 Jam', 240, 18500, 3000),
('pkt6', '5 Jam', 300, 23000, 3000);

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_Pelanggan` varchar(50) NOT NULL,
  `NamaPelanggan` varchar(100) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `Alamat` varchar(150) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `NomerHp` varchar(20) DEFAULT NULL,
  `SisaWaktu` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`ID_Pelanggan`, `NamaPelanggan`, `Username`, `Password`, `Alamat`, `Email`, `NomerHp`, `SisaWaktu`) VALUES
('Cust11', 'Dewi Lestari', 'dewi_lestari', 'password11', 'Jl. Magelang No. 67, Yogyakarta', 'dewi.lestari@example.com', '081234567810', '09:15:00'),
('Cust13', 'Anita Putri', 'anita_putri', 'password13', 'Jl. Gedong Kuning No. 45, Yogyakarta', 'anita.putri@example.com', '081234567812', '12:00:00'),
('Cust15', 'Rini Rahmawati', 'rini_rahmawati', 'password15', 'Jl. Pangeran Diponegoro No. 78, Yogyakarta', 'rini.rahmawati@example.com', '081234567814', '15:15:00'),
('Cust16', 'Budi Santoso', 'budi_santoso', 'password16', 'Jl. Margo Mulyo No. 89, Yogyakarta', 'budi.santoso@example.com', '081234567815', '16:30:00'),
('Cust18', 'Arief Susanto', 'arief_susanto', 'password18', 'Jl. Gejayan No. 12, Yogyakarta', 'arief.susanto@example.com', '081234567817', '19:45:00'),
('Cust19', 'Dian Pratiwi', 'dian_pratiwi', 'password19', 'Jl. Kranggan No. 56, Yogyakarta', 'dian.pratiwi@example.com', '081234567818', '21:00:00'),
('Cust2', 'Jane Smith', 'jane_smith', 'password2', 'Jl. Sosrowijayan No. 45, Yogyakarta', 'jane.smith@example.com', '081234567891', '09:30:00'),
('Cust20', 'Ariawan Setiawan', 'ariawan_setiawan', 'password20', 'Jl. Sudirman No. 67, Yogyakarta', 'ariawan.setiawan@example.com', '081234567819', '26:30:00'),
('Cust3', 'Ahmad Budi', 'ahmad', '', 'Jl. Prawirotaman No. 67, Yogyakarta', 'ahmad.budi@example.com', '081234567892', '10:45:00'),
('Cust4', 'Siti Rahayu', 'siti_rahayu', 'password4', 'Jl. Tirtodipuran No. 89, Yogyakarta', 'siti.rahayu@example.com', '081234567893', '12:15:00'),
('Cust5', 'Agus Budiono', 'agus_santoso', '', 'Jl. Urip Sumoharjo No. 34, Yogyakarta', 'agus.santoso@example.com', '081234567894', '26:00:00'),
('Cust6', 'Rini Susanti', 'rini_susanti', 'password6', 'Jl. Imogiri Timur No. 56, Yogyakarta', 'rini.susanti@example.com', '081234567895', '15:30:00'),
('Cust7', 'Iwan Setiawan', 'iwan_setiawan', 'password7', 'Jl. Cik Di Tiro No. 78, Yogyakarta', 'iwan.setiawan@example.com', '081234567896', '16:45:00'),
('Cust9', 'Bambang Susilo', 'bambang_susilo', 'password9', 'Jl. Solo No. 12, Yogyakarta', 'bambang.susilo@example.com', '081234567898', '19:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_warnet`
--

CREATE TABLE `transaksi_warnet` (
  `ID_Transaksi` varchar(5) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Tanggal` datetime(6) NOT NULL,
  `Harga` int(11) NOT NULL,
  `Waktu` int(11) NOT NULL,
  `Operator` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi_warnet`
--

INSERT INTO `transaksi_warnet` (`ID_Transaksi`, `Username`, `Tanggal`, `Harga`, `Waktu`, `Operator`) VALUES
('tr1', 'Cust2', '2023-01-01 12:30:00.000000', 5000, 60, 'op1'),
('tr2', 'user2', '2023-02-15 15:45:00.000000', 10000, 120, 'op2'),
('tr3', 'user3', '2023-03-22 10:00:00.000000', 5000, 30, 'op3'),
('tr4', 'user4', '2023-04-10 18:20:00.000000', 7500, 90, 'op1'),
('tr5', 'user5', '2023-05-05 08:45:00.000000', 15000, 180, 'op2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `komputer_warnet`
--
ALTER TABLE `komputer_warnet`
  ADD PRIMARY KEY (`ID_Komputer`),
  ADD KEY `fk_Pelanggan` (`ID_Pelanggan`);

--
-- Indexes for table `operator`
--
ALTER TABLE `operator`
  ADD PRIMARY KEY (`ID_Operator`);

--
-- Indexes for table `paket`
--
ALTER TABLE `paket`
  ADD PRIMARY KEY (`ID_Paket`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indexes for table `transaksi_warnet`
--
ALTER TABLE `transaksi_warnet`
  ADD PRIMARY KEY (`ID_Transaksi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `komputer_warnet`
--
ALTER TABLE `komputer_warnet`
  ADD CONSTRAINT `fk_Pelanggan` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `pelanggan` (`ID_Pelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
