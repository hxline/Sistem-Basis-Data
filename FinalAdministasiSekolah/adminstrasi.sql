/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.1.72-community : Database - administrasi
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`administrasi` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `administrasi`;

/*Table structure for table `tdaftar` */

DROP TABLE IF EXISTS `tdaftar`;

CREATE TABLE `tdaftar` (
  `id_daftar` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_daftar`),
  KEY `nis` (`nis`),
  KEY `id_tu` (`id_tu`),
  CONSTRAINT `tdaftar_ibfk_2` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tdaftar_ibfk_3` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tdaftar` */

insert  into `tdaftar`(`id_daftar`,`nis`,`jenis`,`jumlah`,`tanggal`,`id_tu`) values (2,101123,'Daftar Baru',1000000,'20-10-2013',1011);

/*Table structure for table `tpembayaran` */

DROP TABLE IF EXISTS `tpembayaran`;

CREATE TABLE `tpembayaran` (
  `id_pembayaran` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `spp` int(11) DEFAULT NULL,
  `cathering` int(11) DEFAULT NULL,
  `marching_band` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  `bulan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_pembayaran`),
  KEY `id_tu` (`id_tu`),
  KEY `nis` (`nis`),
  CONSTRAINT `tpembayaran_ibfk_1` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tpembayaran_ibfk_2` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tpembayaran` */

insert  into `tpembayaran`(`id_pembayaran`,`nis`,`spp`,`cathering`,`marching_band`,`total`,`tanggal`,`id_tu`,`bulan`) values (1,101123,250000,50000,100000,400000,'20-10-2013',1011,NULL),(2,101123,250000,50000,100000,400000,'23-10-2013',1011,'Juni');

/*Table structure for table `tsiswa` */

DROP TABLE IF EXISTS `tsiswa`;

CREATE TABLE `tsiswa` (
  `nis` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `kelas` int(11) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`nis`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tsiswa` */

insert  into `tsiswa`(`nis`,`nama`,`kelas`,`tanggal`) values (101122,'Aminah',5,'23-10-2013'),(101123,'Aminah Salim',1,'20-10-2013');

/*Table structure for table `tsurat` */

DROP TABLE IF EXISTS `tsurat`;

CREATE TABLE `tsurat` (
  `id_surat` int(11) NOT NULL AUTO_INCREMENT,
  `no_surat` varchar(50) DEFAULT NULL,
  `lampiran` varchar(50) DEFAULT NULL,
  `perihal` varchar(50) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `pengirim` varchar(50) DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_surat`),
  KEY `id_tu` (`id_tu`),
  CONSTRAINT `tsurat_ibfk_1` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tsurat` */

insert  into `tsurat`(`id_surat`,`no_surat`,`lampiran`,`perihal`,`tanggal`,`jenis`,`pengirim`,`id_tu`) values (1,'123','add','ddd','20-10-2013','Surat Masuk','ddd',1011);

/*Table structure for table `ttabungan` */

DROP TABLE IF EXISTS `ttabungan`;

CREATE TABLE `ttabungan` (
  `id_tabung` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  `id_tu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_tabung`),
  KEY `nis` (`nis`),
  KEY `id_tu` (`id_tu`),
  CONSTRAINT `ttabungan_ibfk_1` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ttabungan_ibfk_2` FOREIGN KEY (`id_tu`) REFERENCES `ttu` (`id_tu`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

/*Data for the table `ttabungan` */

insert  into `ttabungan`(`id_tabung`,`nis`,`jumlah`,`tanggal`,`id_tu`) values (9,101123,40000,'20-10-2013',1011),(10,101123,10000,'20-10-2013',1011),(11,101123,90000,'20-10-2013',1011),(12,101123,10000,'20-10-2013',1011),(13,101123,10000,'20-10-2013',1011),(14,101123,20000,'23-10-2013',1011),(15,101123,5555,'23-10-2013',1011),(16,101123,45555,'23-10-2013',1011),(17,101123,45666,'23-10-2013',1011),(18,101123,34444,'23-10-2013',1011),(19,101123,23333,'23-10-2013',1011),(20,101123,455544,'23-10-2013',1011),(21,101123,32111,'23-10-2013',1011),(22,101123,54444,'23-10-2013',1011),(23,101123,34533,'23-10-2013',1011),(24,101122,40000,'23-10-2013',1011),(25,101122,60000,'23-10-2013',1011);

/*Table structure for table `ttotal` */

DROP TABLE IF EXISTS `ttotal`;

CREATE TABLE `ttotal` (
  `id_total` int(11) NOT NULL AUTO_INCREMENT,
  `nis` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_total`),
  KEY `nis` (`nis`),
  CONSTRAINT `ttotal_ibfk_1` FOREIGN KEY (`nis`) REFERENCES `tsiswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `ttotal` */

insert  into `ttotal`(`id_total`,`nis`,`total`) values (4,101123,900000),(5,101122,99900);

/*Table structure for table `ttu` */

DROP TABLE IF EXISTS `ttu`;

CREATE TABLE `ttu` (
  `id_tu` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `tanggal` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_tu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `ttu` */

insert  into `ttu`(`id_tu`,`nama`,`password`,`tanggal`) values (1011,'Handoyo','9099','20-10-2013'),(1012,'asinaa','898833','20-10-2013');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
