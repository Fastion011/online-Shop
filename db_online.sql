-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2022 at 10:50 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_online`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`) VALUES
(10701);

-- --------------------------------------------------------

--
-- Table structure for table `baju`
--

CREATE TABLE `baju` (
  `id_baju` int(12) NOT NULL,
  `nama_baju` varchar(100) NOT NULL,
  `ukuran_baju` varchar(50) NOT NULL,
  `jenis_kain` varchar(50) NOT NULL,
  `Harga` int(100) NOT NULL,
  `url` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `baju`
--

INSERT INTO `baju` (`id_baju`, `nama_baju`, `ukuran_baju`, `jenis_kain`, `Harga`, `url`) VALUES
(1, 'Kaos Polos', 'L', 'Katun', 50000, 'D:\\1\\kaos_polos.jpg'),
(2, 'Baju flanel perempuan', 'M', 'Flanel', 70000, 'D:\\1\\baju_perempuan_flanel.jfif'),
(3, 'Kemeja kotak - kotak', 'L', 'Flanel', 90000, 'D:\\1\\gambar 6.jpg'),
(4, 'Switer Perempuan', 'M', 'Baby Terry', 60000, 'D:\\1\\gamabar 11.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `celana`
--

CREATE TABLE `celana` (
  `id_celana` int(12) NOT NULL,
  `nama_celana` varchar(100) NOT NULL,
  `ukuran_celana` varchar(100) NOT NULL,
  `jenis_kain` varchar(50) NOT NULL,
  `Harga` int(100) NOT NULL,
  `url` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `celana`
--

INSERT INTO `celana` (`id_celana`, `nama_celana`, `ukuran_celana`, `jenis_kain`, `Harga`, `url`) VALUES
(1, 'jeans', 'L', 'Jeans', 60000, 'D:\\1\\6.jfif');

-- --------------------------------------------------------

--
-- Table structure for table `detail`
--

CREATE TABLE `detail` (
  `nama_baju` varchar(50) NOT NULL,
  `ukuran_baju` varchar(50) NOT NULL,
  `jenis_kain` varchar(50) NOT NULL,
  `harga` int(100) NOT NULL,
  `pembayaran` varchar(50) NOT NULL,
  `jumlah` int(100) NOT NULL,
  `total` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail`
--

INSERT INTO `detail` (`nama_baju`, `ukuran_baju`, `jenis_kain`, `harga`, `pembayaran`, `jumlah`, `total`) VALUES
('Baju flanel perempuan', 'M', 'Flanel', 70000, '0', 2, 140000),
('jeans', 'L', 'Jeans', 60000, 'COD', 2, 120000),
('Kaos Polos', 'L', 'Katun', 50000, 'ALFAMART', 2, 100000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` varchar(50) NOT NULL,
  `tanggal_lahir` int(100) NOT NULL,
  `No` int(12) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `tanggal_lahir`, `No`, `Password`) VALUES
('jani', 98765, 786767, 'aaaa'),
('oti', 107201, 90874, 'asadad'),
('rrr', 333, 555, 'gggg'),
('toti', 99, 87, 'sss');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `baju`
--
ALTER TABLE `baju`
  ADD PRIMARY KEY (`id_baju`);

--
-- Indexes for table `celana`
--
ALTER TABLE `celana`
  ADD PRIMARY KEY (`id_celana`);

--
-- Indexes for table `detail`
--
ALTER TABLE `detail`
  ADD PRIMARY KEY (`nama_baju`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
