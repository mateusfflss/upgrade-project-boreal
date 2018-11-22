
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cadastros
-- ------------------------------------------------------
-- Server version	8.0.13

create database`cadastros`;
USE `cadastros`; 
create table registro
(login int(12) 
auto_increment not null, 
usuario varchar(50), 
senha varchar(50), 
nivel_acess varchar(50), 
primary key(login)); 

insert into registro 
(usuario,senha,nivel_acess) 
values 
('admin','123','1');
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `empregados`
--
create database`empregados`;

/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `empregados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `modelo` varchar(100) DEFAULT NULL,
  `data` varchar(15) DEFAULT NULL,
  `categoria` varchar(60) DEFAULT NULL,
  `altura` varchar(10) DEFAULT NULL,
  `nacionalidade` varchar(20) DEFAULT NULL,
  `preco` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empregados`
--

LOCK TABLES `empregados` WRITE;
/*!40000 ALTER TABLE `empregados` DISABLE KEYS */;
INSERT INTO `empregados` VALUES (4,'Shineray Phoenix 50','2010','City','1.00','China','5590.00'),(7,'Honda CG Titan 160 CBS','2015','City','1.10','Brasil','11000.00'),(8,'BMW G G310 GS','2017','ON road','1.20','brasileira','28000.00'),(9,'Kwasaki ninja 400 ABS','2018','Sport','1,00','japão','27000.00'),(10,'Honda NXR Bros 160 ESDD','2015','ON/OFF road','1,17','Brasil','12000.00');
/*!40000 ALTER TABLE `empregados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-17 19:44:02

create database`cadastros`;
USE `cadastros`; 
create table registro
(login int(12) 
auto_increment not null, 
usuario varchar(50), 
senha varchar(50), 
nivel_acess varchar(50), 
primary key(login)); 

insert into registro 
(usuario,senha,nivel_acess) 
values 
('admin','123','1');