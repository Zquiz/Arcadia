-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.17-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for arcadia
CREATE DATABASE IF NOT EXISTS `arcadia` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `arcadia`;

-- Dumping structure for table arcadia.tblcountrystats
CREATE TABLE IF NOT EXISTS `tblcountrystats` (
  `fldID` int(11) NOT NULL AUTO_INCREMENT,
  `fldName` varchar(50) DEFAULT '0',
  `fldNumber` float DEFAULT '0',
  PRIMARY KEY (`fldID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table arcadia.tblcountrystats: ~3 rows (approximately)
/*!40000 ALTER TABLE `tblcountrystats` DISABLE KEYS */;
INSERT INTO `tblcountrystats` (`fldID`, `fldName`, `fldNumber`) VALUES
	(1, 'Denmark', 6.8),
	(2, 'Canada', 13.5),
	(3, 'China', 7.6);
/*!40000 ALTER TABLE `tblcountrystats` ENABLE KEYS */;

-- Dumping structure for table arcadia.tblsignup
CREATE TABLE IF NOT EXISTS `tblsignup` (
  `fldID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fldName` varchar(200) DEFAULT NULL,
  `fldMail` varchar(200) DEFAULT NULL,
  `fldLowImage` char(50) DEFAULT NULL,
  `fldHighImage` char(50) DEFAULT NULL,
  `fldGHG` decimal(65,0) DEFAULT NULL,
  PRIMARY KEY (`fldID`)
) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=utf8;

-- Dumping data for table arcadia.tblsignup: ~1 rows (approximately)
/*!40000 ALTER TABLE `tblsignup` DISABLE KEYS */;
INSERT INTO `tblsignup` (`fldID`, `fldName`, `fldMail`, `fldLowImage`, `fldHighImage`, `fldGHG`) VALUES
	(75, 'sdf', 'sdfs@sf.dk', '~/Image_Upload/lowsdf.png', '~/Image_Upload/highsdf.png', 2);
/*!40000 ALTER TABLE `tblsignup` ENABLE KEYS */;

-- Dumping structure for table arcadia.tbluser
CREATE TABLE IF NOT EXISTS `tbluser` (
  `fldID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fldUserName` varchar(50) DEFAULT NULL,
  `fldPassword` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`fldID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table arcadia.tbluser: ~0 rows (approximately)
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` (`fldID`, `fldUserName`, `fldPassword`) VALUES
	(1, 'admin', 'Greenhorn');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
