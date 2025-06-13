CREATE DATABASE  IF NOT EXISTS `proyectoprogramacion` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyectoprogramacion`;
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
  `ID_LISTADO` int NOT NULL,
  `TIPO` varchar(15) NOT NULL,
  `FECHA` date DEFAULT NULL,
  `PRECIO` decimal(11,2) DEFAULT '0.00',
  `NOMBRE_VENDEDOR` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_ADICION`),
  UNIQUE KEY `ID_LISTADO_UNIQUE` (`ID_LISTADO`),
  CONSTRAINT `FK_LISTADO_ADICION` FOREIGN KEY (`ID_LISTADO`) REFERENCES `listado` (`ID_LISTADO`)
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
  `ID_LISTADO` int NOT NULL,
  PRIMARY KEY (`ID_ALMACENAMIENTO`),
  KEY `FK_SALAS` (`ID_SALAS`),
  KEY `FK_LISTADO` (`ID_LISTADO`),
  CONSTRAINT `FK_LISTADO` FOREIGN KEY (`ID_LISTADO`) REFERENCES `listado` (`ID_LISTADO`),
  CONSTRAINT `FK_SALAS` FOREIGN KEY (`ID_SALAS`) REFERENCES `salas` (`ID_SALAS`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenamiento`
--

LOCK TABLES `almacenamiento` WRITE;
/*!40000 ALTER TABLE `almacenamiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacenamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `listado`
--

DROP TABLE IF EXISTS `listado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `listado` (
  `ID_LISTADO` int NOT NULL AUTO_INCREMENT,
  `MATERIAL` varchar(45) DEFAULT NULL,
  `CANTIDAD` int NOT NULL,
  `ID_MATERIALES` int NOT NULL,
  PRIMARY KEY (`ID_LISTADO`),
  KEY `FK_MATERIALES` (`ID_MATERIALES`),
  CONSTRAINT `FK_MATERIALES` FOREIGN KEY (`ID_MATERIALES`) REFERENCES `materiales` (`ID_MATERIALES`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listado`
--

LOCK TABLES `listado` WRITE;
/*!40000 ALTER TABLE `listado` DISABLE KEYS */;
/*!40000 ALTER TABLE `listado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiales`
--

DROP TABLE IF EXISTS `materiales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiales` (
  `ID_MATERIALES` int NOT NULL AUTO_INCREMENT,
  `TIPO` varchar(45) NOT NULL,
  `NOMBRE` varchar(45) NOT NULL,
  `CODIGO_BARRA` int DEFAULT NULL,
  `IMAGEN` blob,
  `CARACTERISTICAS` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID_MATERIALES`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiales`
--

LOCK TABLES `materiales` WRITE;
/*!40000 ALTER TABLE `materiales` DISABLE KEYS */;
/*!40000 ALTER TABLE `materiales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento` (
  `ID_MOVIMIENTO` int NOT NULL AUTO_INCREMENT,
  `ID_LISTADO_ANTERIOR` int NOT NULL,
  `ID_LISTADO_NUEVO` int NOT NULL,
  `CANTIDAD` int DEFAULT NULL,
  `FECHA` date DEFAULT NULL,
  `OBSERVACIONES` varchar(100) DEFAULT NULL,
  `ID_MATERIALES` int NOT NULL,
  PRIMARY KEY (`ID_MOVIMIENTO`),
  KEY `FK_LISTADO_NUEVO` (`ID_LISTADO_NUEVO`),
  KEY `FK_LISTADO_ANTERIOR` (`ID_LISTADO_ANTERIOR`),
  KEY `FK_MATERIALES_MOVIMIENTO` (`ID_MATERIALES`),
  CONSTRAINT `FK_LISTADO_ANTERIOR` FOREIGN KEY (`ID_LISTADO_ANTERIOR`) REFERENCES `listado` (`ID_LISTADO`),
  CONSTRAINT `FK_LISTADO_NUEVO` FOREIGN KEY (`ID_LISTADO_NUEVO`) REFERENCES `listado` (`ID_LISTADO`),
  CONSTRAINT `FK_MATERIALES_MOVIMIENTO` FOREIGN KEY (`ID_MATERIALES`) REFERENCES `materiales` (`ID_MATERIALES`)
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
  `NOMBRE` varchar(45) NOT NULL,
  `ID_LISTADO` int NOT NULL,
  `ID_SALAS` int NOT NULL,
  PRIMARY KEY (`ID_PC`),
  UNIQUE KEY `ID_LISTADO_UNIQUE` (`ID_LISTADO`),
  KEY `FK_SALASPC` (`ID_SALAS`),
  CONSTRAINT `FK_LISTADOPC` FOREIGN KEY (`ID_LISTADO`) REFERENCES `listado` (`ID_LISTADO`),
  CONSTRAINT `FK_SALASPC` FOREIGN KEY (`ID_SALAS`) REFERENCES `salas` (`ID_SALAS`)
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
-- Table structure for table `salas`
--

DROP TABLE IF EXISTS `salas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salas` (
  `ID_SALAS` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(45) NOT NULL,
  `ID_REFERENTE` int NOT NULL,
  PRIMARY KEY (`ID_SALAS`),
  UNIQUE KEY `REFERENTE_UNIQUE` (`ID_REFERENTE`),
  CONSTRAINT `FK_REFERENTE` FOREIGN KEY (`ID_REFERENTE`) REFERENCES `usuarios` (`ID_USUARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salas`
--

LOCK TABLES `salas` WRITE;
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `ID_USUARIO` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(30) NOT NULL,
  `CONTRASEÑA` varchar(30) NOT NULL,
  `AUTORIDAD` varchar(30) NOT NULL,
  PRIMARY KEY (`ID_USUARIO`),
  UNIQUE KEY `NOMBRE_UNIQUE` (`NOMBRE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-13  9:34:06
