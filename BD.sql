-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: proyectoprogramacion
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `adicion`
--

DROP TABLE IF EXISTS `adicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adicion` (
  `ID_ADICION` int NOT NULL AUTO_INCREMENT,
  `TIPO` varchar(15) NOT NULL,
  `FECHA` date DEFAULT NULL,
  `PRECIO` decimal(11,2) unsigned DEFAULT '0.00',
  `NOMBRE_VENDEDOR` varchar(45) DEFAULT NULL,
  `ID_ALMACENAMIENTO` int unsigned NOT NULL,
  `ID_MATERIAL` int NOT NULL,
  `CANTIDAD` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_ADICION`),
  KEY `FK_ADISION_ALMACENAMIENTO_idx` (`ID_MATERIAL`),
  CONSTRAINT `FK_ADISION_ALMACENAMIENTO` FOREIGN KEY (`ID_MATERIAL`) REFERENCES `almacenamiento` (`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_ADISION_MATERIAL` FOREIGN KEY (`ID_MATERIAL`) REFERENCES `material` (`ID_MATERIAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adicion`
--

LOCK TABLES `adicion` WRITE;
/*!40000 ALTER TABLE `adicion` DISABLE KEYS */;
/*!40000 ALTER TABLE `adicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacenamiento`
--

DROP TABLE IF EXISTS `almacenamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacenamiento` (
  `ID_ALMACENAMIENTO` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(45) NOT NULL,
  `ID_SALAS` int NOT NULL,
  PRIMARY KEY (`ID_ALMACENAMIENTO`),
  KEY `FK_SALAS` (`ID_SALAS`),
  CONSTRAINT `FK_SALAS` FOREIGN KEY (`ID_SALAS`) REFERENCES `sala` (`ID_SALA`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenamiento`
--

LOCK TABLES `almacenamiento` WRITE;
/*!40000 ALTER TABLE `almacenamiento` DISABLE KEYS */;
INSERT INTO `almacenamiento` VALUES (1,'Armario 1',1),(2,'Armario 2',1),(3,'Armario 3',1);
/*!40000 ALTER TABLE `almacenamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material` (
  `ID_MATERIAL` int NOT NULL AUTO_INCREMENT,
  `TIPO` varchar(45) NOT NULL,
  `NOMBRE` varchar(45) NOT NULL,
  `CODIGO_BARRA` bigint DEFAULT NULL,
  `IMAGEN` blob,
  `CARACTERISTICAS` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID_MATERIAL`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
INSERT INTO `material` VALUES (1,'Procesador','RyZEN 4500',NULL,NULL,'8 nucleos, 2,3GHz'),(2,'RAM','KINGSTONE 8 GBs',NULL,NULL,'DDR5, LATENCIA...');
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material_almacenamiento`
--

DROP TABLE IF EXISTS `material_almacenamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material_almacenamiento` (
  `ID_MATERIAL` int NOT NULL,
  `ID_ALMACENAMIENTO` int NOT NULL,
  `CANTIDAD` int unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID_MATERIAL`,`ID_ALMACENAMIENTO`),
  KEY `FK_ALMACENAMIENTO` (`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_ALMACENAMIENTO` FOREIGN KEY (`ID_ALMACENAMIENTO`) REFERENCES `almacenamiento` (`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_MATERIAL` FOREIGN KEY (`ID_MATERIAL`) REFERENCES `material` (`ID_MATERIAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material_almacenamiento`
--

LOCK TABLES `material_almacenamiento` WRITE;
/*!40000 ALTER TABLE `material_almacenamiento` DISABLE KEYS */;
INSERT INTO `material_almacenamiento` VALUES (1,1,5),(1,3,2),(2,1,10);
/*!40000 ALTER TABLE `material_almacenamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento` (
  `ID_MOVIMIENTO` int NOT NULL AUTO_INCREMENT,
  `ID_ALMACENAMIENTO_ANTERIOR` int NOT NULL,
  `ID_ALMACENAMIENTO_NUEVO` int NOT NULL,
  `CANTIDAD` int unsigned NOT NULL,
  `FECHA` date DEFAULT NULL,
  `OBSERVACIONES` varchar(100) DEFAULT NULL,
  `ID_MATERIAL` int NOT NULL,
  PRIMARY KEY (`ID_MOVIMIENTO`),
  KEY `FK_ALMACENAMIENTO_ANTERIOR` (`ID_ALMACENAMIENTO_ANTERIOR`),
  KEY `FK_ALMACENAMIENTO_NUEVO` (`ID_ALMACENAMIENTO_NUEVO`),
  KEY `FK_MATERIAL_MOVIMIENTO` (`ID_MATERIAL`),
  CONSTRAINT `FK_ALMACENAMIENTO_ANTERIOR` FOREIGN KEY (`ID_ALMACENAMIENTO_ANTERIOR`) REFERENCES `material_almacenamiento` (`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_ALMACENAMIENTO_NUEVO` FOREIGN KEY (`ID_ALMACENAMIENTO_NUEVO`) REFERENCES `material_almacenamiento` (`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_MATERIAL_MOVIMIENTO` FOREIGN KEY (`ID_MATERIAL`) REFERENCES `material_almacenamiento` (`ID_MATERIAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento`
--

LOCK TABLES `movimiento` WRITE;
/*!40000 ALTER TABLE `movimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pc`
--

DROP TABLE IF EXISTS `pc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pc` (
  `ID_PC` int NOT NULL AUTO_INCREMENT,
  `ID_SALA` int NOT NULL,
  `NOMBRE` varchar(30) NOT NULL,
  `ID_PLACA` int DEFAULT NULL,
  `ID_PROCESADOR` int DEFAULT NULL,
  `ID_RAM0` int DEFAULT NULL,
  `ID_RAM1` int DEFAULT NULL,
  `ID_RAM2` int DEFAULT NULL,
  `ID_RAM3` int DEFAULT NULL,
  `ID_DISCO0` int DEFAULT NULL,
  `ID_FUENTE` int DEFAULT NULL,
  `ID_GABINETE` int DEFAULT NULL,
  `ID_TECLADO` int DEFAULT NULL,
  `ID_MONITOR` int DEFAULT NULL,
  `ID_EXPANSION0` int DEFAULT NULL,
  `ID_EXPANSION1` int DEFAULT NULL,
  `ID_MOUSE` int DEFAULT NULL,
  PRIMARY KEY (`ID_PC`),
  KEY `FK_SALA_PC_idx` (`ID_SALA`),
  KEY `FK_PLACA_idx` (`ID_PLACA`,`ID_PROCESADOR`,`ID_RAM0`,`ID_RAM1`,`ID_RAM2`,`ID_RAM3`,`ID_DISCO0`,`ID_FUENTE`,`ID_GABINETE`,`ID_TECLADO`,`ID_MONITOR`,`ID_EXPANSION0`,`ID_EXPANSION1`),
  KEY `FK_PROCESADOR_idx` (`ID_PROCESADOR`),
  KEY `FK_RAM1_idx` (`ID_RAM1`),
  KEY `FK_RAM0_idx` (`ID_RAM0`),
  KEY `FK_RAM2_idx` (`ID_RAM2`),
  KEY `FK_RAM3_idx` (`ID_RAM3`),
  KEY `FK_DISCO_idx` (`ID_DISCO0`),
  KEY `FK_FUENTE_idx` (`ID_FUENTE`),
  KEY `FK_GABINETE_idx` (`ID_GABINETE`),
  KEY `FK_TECLADO_idx` (`ID_TECLADO`),
  KEY `FK_EXPANSION0_idx` (`ID_EXPANSION0`),
  KEY `FK_EXPANSIO1_idx` (`ID_EXPANSION1`),
  KEY `FK_MONITOR_idx` (`ID_MONITOR`),
  KEY `FK_MOUSE_idx` (`ID_MOUSE`),
  CONSTRAINT `FK_DISCO0` FOREIGN KEY (`ID_DISCO0`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_EXPANSION0` FOREIGN KEY (`ID_EXPANSION0`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_EXPANSION1` FOREIGN KEY (`ID_EXPANSION1`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_FUENTE` FOREIGN KEY (`ID_FUENTE`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_GABINETE` FOREIGN KEY (`ID_GABINETE`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_MONITOR` FOREIGN KEY (`ID_MONITOR`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_MOUSE` FOREIGN KEY (`ID_MOUSE`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_PLACA` FOREIGN KEY (`ID_PLACA`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_PROCESADOR` FOREIGN KEY (`ID_PROCESADOR`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_RAM0` FOREIGN KEY (`ID_RAM0`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_RAM1` FOREIGN KEY (`ID_RAM1`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_RAM2` FOREIGN KEY (`ID_RAM2`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_RAM3` FOREIGN KEY (`ID_RAM3`) REFERENCES `material` (`ID_MATERIAL`),
  CONSTRAINT `FK_SALA` FOREIGN KEY (`ID_SALA`) REFERENCES `sala` (`ID_SALA`),
  CONSTRAINT `FK_TECLADO` FOREIGN KEY (`ID_TECLADO`) REFERENCES `material` (`ID_MATERIAL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pc`
--

LOCK TABLES `pc` WRITE;
/*!40000 ALTER TABLE `pc` DISABLE KEYS */;
/*!40000 ALTER TABLE `pc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `ID_SALA` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(45) NOT NULL,
  `ID_REFERENTE` int NOT NULL,
  PRIMARY KEY (`ID_SALA`),
  KEY `FK_REFERENTE_idx` (`ID_REFERENTE`),
  CONSTRAINT `FK_REFERENTE` FOREIGN KEY (`ID_REFERENTE`) REFERENCES `usuario` (`ID_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,'Sala Norte',1),(2,'Sala Este',2),(3,'Sum',3),(4,'Sala Virgi',3);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `ID_USUARIO` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(30) NOT NULL,
  `CONTRASENA` varchar(30) NOT NULL,
  `AUTORIDAD` varchar(30) NOT NULL DEFAULT 'USUARIO',
  PRIMARY KEY (`ID_USUARIO`),
  UNIQUE KEY `NOMBRE_UNIQUE` (`NOMBRE`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Daniela Isaia','Danilamejor','REFERENTE'),(2,'Diego Gareis','Hugo','REFERENTE'),(3,'Virginia Villalba','Virgy','REFERENTE'),(4,'Fabricio Oggier','fafa18','USUARIO');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-08-08  9:33:17
