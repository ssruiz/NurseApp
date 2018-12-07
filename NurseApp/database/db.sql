/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.7.17-log : Database - nurseappdb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`nurseappdb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `nurseappdb`;

/*Table structure for table `patiente` */

DROP TABLE IF EXISTS `patiente`;

CREATE TABLE `patiente` (
  `id_patiente` int(11) NOT NULL AUTO_INCREMENT,
  `name_patiente` varchar(50) DEFAULT NULL,
  `age_patiente` int(11) DEFAULT NULL,
  `bloodp_patiente` int(11) DEFAULT NULL,
  `heartrate_patiente` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_patiente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Table structure for table `patientrecord` */

DROP TABLE IF EXISTS `patientrecord`;

CREATE TABLE `patientrecord` (
  `id_patient` int(11) DEFAULT NULL,
  `bloodp` int(11) DEFAULT NULL,
  `heartrate` int(11) DEFAULT NULL,
  `date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  KEY `id_patient` (`id_patient`),
  CONSTRAINT `patientrecord_ibfk_1` FOREIGN KEY (`id_patient`) REFERENCES `patiente` (`id_patiente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Table structure for table `currentvitals` */

DROP TABLE IF EXISTS `currentvitals`;

/*!50001 DROP VIEW IF EXISTS `currentvitals` */;
/*!50001 DROP TABLE IF EXISTS `currentvitals` */;

/*!50001 CREATE TABLE  `currentvitals`(
 `id_patient` int(11) ,
 `bloodp` int(11) ,
 `heartrate` int(11) ,
 `date` timestamp 
)*/;

/*Table structure for table `listpatients` */

DROP TABLE IF EXISTS `listpatients`;

/*!50001 DROP VIEW IF EXISTS `listpatients` */;
/*!50001 DROP TABLE IF EXISTS `listpatients` */;

/*!50001 CREATE TABLE  `listpatients`(
 `ID` int(11) ,
 `Name` varchar(50) ,
 `Age` int(11) ,
 `Initial Blood Pressure` int(11) ,
 `Initial Heart rate` int(11) 
)*/;

/*View structure for view currentvitals */

/*!50001 DROP TABLE IF EXISTS `currentvitals` */;
/*!50001 DROP VIEW IF EXISTS `currentvitals` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `currentvitals` AS (select `patientrecord`.`id_patient` AS `id_patient`,`patientrecord`.`bloodp` AS `bloodp`,`patientrecord`.`heartrate` AS `heartrate`,`patientrecord`.`date` AS `date` from `patientrecord` order by `patientrecord`.`date` desc limit 1) */;

/*View structure for view listpatients */

/*!50001 DROP TABLE IF EXISTS `listpatients` */;
/*!50001 DROP VIEW IF EXISTS `listpatients` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `listpatients` AS (select `patiente`.`id_patiente` AS `ID`,`patiente`.`name_patiente` AS `Name`,`patiente`.`age_patiente` AS `Age`,`patiente`.`bloodp_patiente` AS `Initial Blood Pressure`,`patiente`.`heartrate_patiente` AS `Initial Heart rate` from `patiente`) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
