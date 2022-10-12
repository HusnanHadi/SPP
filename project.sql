-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: project
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbkelas`
--

DROP TABLE IF EXISTS `tbkelas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbkelas` (
  `kode_kelas` int(5) NOT NULL AUTO_INCREMENT,
  `nama_kelas` varchar(20) NOT NULL,
  PRIMARY KEY (`kode_kelas`)
) ENGINE=InnoDB AUTO_INCREMENT=100001 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbkelas`
--

LOCK TABLES `tbkelas` WRITE;
/*!40000 ALTER TABLE `tbkelas` DISABLE KEYS */;
INSERT INTO `tbkelas` VALUES (10001,'elektronika'),(10002,'multimedia'),(10003,'tkj'),(10004,'desain grafis'),(10005,'body otomotif'),(10007,'model');
/*!40000 ALTER TABLE `tbkelas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbsiswa`
--

DROP TABLE IF EXISTS `tbsiswa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbsiswa` (
  `nis` int(10) NOT NULL AUTO_INCREMENT,
  `nama_siswa` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL,
  `tanggal_lahir` datetime NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `telpon` varchar(12) NOT NULL,
  `agama` varchar(10) NOT NULL,
  `tahun_masuk` varchar(10) NOT NULL,
  `kode_kelas` int(5) NOT NULL,
  PRIMARY KEY (`nis`),
  KEY `fk_siswa_kelas` (`kode_kelas`),
  CONSTRAINT `fk_siswa_kelas` FOREIGN KEY (`kode_kelas`) REFERENCES `tbkelas` (`kode_kelas`)
) ENGINE=InnoDB AUTO_INCREMENT=2147483648 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbsiswa`
--

LOCK TABLES `tbsiswa` WRITE;
/*!40000 ALTER TABLE `tbsiswa` DISABLE KEYS */;
INSERT INTO `tbsiswa` VALUES (2003060001,'Siti','Perempuan','2001-08-16 00:00:00','Gunung Sari','085876432165','Islam','2020',10004),(2003060002,'Peter','Laki-Laki','2001-06-19 00:00:00','Pagutan','081907880978','Kristen','2021',10001),(2003060003,'Made','Laki-Laki','2001-07-10 00:00:00','Gerung','087860907876','Hindu','2021',10004),(2003060004,'zayya','Laki-Laki','2000-06-14 00:00:00','paok kambut','087908987642','Islam','2020',10001),(2003060005,'toti','Laki-Laki','2009-06-13 00:00:00','labuapi','081097745271','Islam','2025',10005);
/*!40000 ALTER TABLE `tbsiswa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbspp`
--

DROP TABLE IF EXISTS `tbspp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbspp` (
  `no_pembayaran` int(10) NOT NULL AUTO_INCREMENT,
  `spp_bulan` varchar(10) NOT NULL,
  `tanggal_bayar` datetime NOT NULL,
  `jumlah` int(20) NOT NULL,
  `nis` int(10) NOT NULL,
  `nama_siswa` varchar(50) NOT NULL,
  PRIMARY KEY (`no_pembayaran`),
  KEY `fk_spp_siswa` (`nis`),
  CONSTRAINT `fk_spp_siswa` FOREIGN KEY (`nis`) REFERENCES `tbsiswa` (`nis`)
) ENGINE=InnoDB AUTO_INCREMENT=2147483648 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbspp`
--

LOCK TABLES `tbspp` WRITE;
/*!40000 ALTER TABLE `tbspp` DISABLE KEYS */;
INSERT INTO `tbspp` VALUES (1002003001,'Juli','2022-07-01 00:00:00',600000,2003060001,'haidar'),(1002003002,'Juni','2022-07-04 00:00:00',600000,2003060002,'Peter'),(1002003003,'Mei','2022-05-02 00:00:00',600000,2003060001,'siti'),(1002003004,'Juni','2022-07-05 00:00:00',600000,2003060001,'siti');
/*!40000 ALTER TABLE `tbspp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-05 10:23:14
