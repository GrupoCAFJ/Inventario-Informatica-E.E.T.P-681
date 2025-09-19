-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: inventario
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
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenamiento`
--

LOCK TABLES `almacenamiento` WRITE;
/*!40000 ALTER TABLE `almacenamiento` DISABLE KEYS */;
INSERT INTO `almacenamiento` VALUES (1,'Armario 1 N',1),(2,'Armario 2 N',1),(3,'Caja de herramientas V',4),(4,'Suelto V',4),(5,'Caja A',3),(6,'Caja B',3),(7,'Caja C',3),(8,'Armario sum',3),(9,'Caja 1',3),(10,'Caja 2',3),(11,'Caja 3',3),(12,'Caja 4',3),(13,'Caja 5',3),(14,'Caja 6',3),(15,'Caja 7',3),(16,'Caja 8',3),(17,'Caja 9',3),(18,'Caja 13',3),(19,'Caja 14',3),(20,'Caja 15',3),(21,'Caja 16',3),(22,'Tupper 1',3),(23,'Tupper 2',3),(24,'Caja 1 sum',3),(25,'Caja 2 sum',3);
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
) ENGINE=InnoDB AUTO_INCREMENT=252 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
INSERT INTO `material` VALUES (1,'Herramienta','Destornillador phillips',NULL,NULL,''),(2,'Herramienta','Destornillador plano',NULL,NULL,''),(3,'Herramienta','Destornillodor torx',NULL,NULL,NULL),(4,'Herramienta','Pincel',NULL,NULL,NULL),(5,'Herramienta','Trincheta',NULL,NULL,NULL),(6,'Herramienta','Guantes de latex',NULL,NULL,NULL),(7,'Herramienta','Pinza universal',NULL,NULL,NULL),(8,'Herramienta','Alicate',NULL,NULL,NULL),(9,'Herramienta','Kit de destornilladores',NULL,NULL,NULL),(10,'Herramienta','Pinza punta pato',NULL,NULL,NULL),(11,'Herramienta','Kit de puntas de destornillador',NULL,NULL,NULL),(12,'Herramienta','Crimpeadora',NULL,NULL,NULL),(13,'Herramienta','Soldador',NULL,NULL,NULL),(14,'Herramienta','Tester de red',NULL,NULL,NULL),(15,'Herramienta','Multímetro',NULL,NULL,NULL),(16,'Herramienta','Lector de código de barra',NULL,NULL,NULL),(17,'Herramienta','Pinza pico loro',NULL,NULL,NULL),(18,'Herramienta','Minipinza curva',NULL,NULL,NULL),(19,'Herramienta','Pinza universal',NULL,NULL,NULL),(20,'Herramienta','Tester de fuente',NULL,NULL,NULL),(21,'Herramienta','Linterna de cabeza',NULL,NULL,NULL),(22,'Herramienta','Pulsera antiestática',NULL,NULL,NULL),(23,'Herramienta','Papel de lija',NULL,NULL,NULL),(24,'Herramienta','Destornillador de cabezal intercambiable',NULL,NULL,NULL),(34,'Herramienta','Espátula',NULL,NULL,NULL),(35,'Herramienta','Martillo',NULL,NULL,NULL),(36,'Herramienta','Llave inglesa',NULL,NULL,NULL),(37,'Herramienta','Pela cable',NULL,NULL,NULL),(38,'Herramienta','Pinza RJ45',NULL,NULL,NULL),(39,'Herramienta','Calibrador',NULL,NULL,NULL),(40,'Herramienta','Lupa',NULL,NULL,NULL),(41,'Herramienta','Cinta métrica',NULL,NULL,NULL),(42,'Herramienta','Guantes de nitrilo',NULL,NULL,NULL),(43,'Insumo','Tornillos',NULL,NULL,NULL),(44,'Insumo','Cinta aislante',NULL,NULL,NULL),(45,'Insumo','Pegamento POXI-RAN',NULL,NULL,NULL),(46,'Insumo','Pegamento UNIPOX',NULL,NULL,NULL),(47,'Insumo','Pegamento Amor',NULL,NULL,NULL),(48,'Insumo','Cinta teflon',NULL,NULL,NULL),(49,'Insumo','Cinta Stiko',NULL,NULL,NULL),(50,'Insumo','Tinta',NULL,NULL,NULL),(51,'Insumo','WD-40',NULL,NULL,NULL),(52,'Insumo','Alcohol isopropílico',NULL,NULL,NULL),(53,'Insumo','Desinfectante',NULL,NULL,NULL),(54,'Insumo','Pasta térmica',NULL,NULL,NULL),(55,'Insumo','Silicona',NULL,NULL,NULL),(56,'Insumo','Pila A23',NULL,NULL,NULL),(57,'Insumo','Pila 2023',NULL,NULL,NULL),(58,'Insumo','Precintos',NULL,NULL,NULL),(59,'Insumo','Hisopos',NULL,NULL,NULL),(60,'Insumo','Tanza',NULL,NULL,NULL),(61,'Insumo','Estaño',NULL,NULL,NULL),(62,'Insumo','Fichas RJ45',NULL,NULL,NULL),(63,'Arduino','SHIELD ETHERNET',NULL,NULL,NULL),(64,'Arduino','MÓDULO RFID RC522',NULL,NULL,NULL),(65,'Arduino','SERVO TOWER PRO MG 90',NULL,NULL,NULL),(66,'Arduino','SERVO TOWER PRO SG90',NULL,NULL,NULL),(67,'Arduino','TECLADO MATRICIAL 4X4',NULL,NULL,NULL),(68,'Arduino','BOMBAS SUMERGIBLES',NULL,NULL,NULL),(69,'Arduino','RUEDA AUTO',NULL,NULL,NULL),(70,'Arduino','PORTA PILAS 6X1,5V',NULL,NULL,NULL),(71,'Arduino','CABLE ADAPTADOR BATERÍA',NULL,NULL,NULL),(72,'Arduino','CABLE ADAPTADOR BATERÍA C/JACK',NULL,NULL,NULL),(73,'Arduino','LCD 16*2 S/12C',NULL,NULL,NULL),(74,'Arduino','LCD 16*2 C/12C',NULL,NULL,NULL),(75,'Arduino','LCD 20*4 12C',NULL,NULL,NULL),(76,'Arduino','LCD AZUL 128*64',NULL,NULL,NULL),(77,'Arduino','MÓDULO RELOJ RTC DS 3231',NULL,NULL,NULL),(78,'Arduino','MÓDULO BLUETOOTH HC05',NULL,NULL,NULL),(79,'Arduino','MÓDULO WIFI SERIAL ESP 8266',NULL,NULL,NULL),(80,'Arduino','SENSOR NIVEL DE AGUA',NULL,NULL,NULL),(81,'Arduino','SENSOR ULTRASÓNICO HC-SR04',NULL,NULL,NULL),(82,'Arduino','MÓDULO DETECTOR DE MOVIMIENTO',NULL,NULL,NULL),(83,'Arduino','RECEPTOR IR (INFRAROJOS)',NULL,NULL,NULL),(84,'Arduino','MÓDULO JOYSTICK C/PULSADOR',NULL,NULL,NULL),(85,'Arduino','SENSOR TEMP Y HUMEDAD DHT 11',NULL,NULL,NULL),(86,'Arduino','SENSOR HUMEDAD DE SUELO',NULL,NULL,NULL),(87,'Arduino','MÓDULO 4 LED EXTERIOR 1,44W',NULL,NULL,NULL),(88,'Arduino','POTENCIÓMETRO',NULL,NULL,NULL),(89,'Arduino','BUZZER',NULL,NULL,NULL),(90,'Arduino','RELÉ 2 MÓDULO',NULL,NULL,NULL),(91,'Arduino','SENSOR TEMP INFRARROJO S/CONTACTO',NULL,NULL,NULL),(119,'Arduino','CONTROL REMOTO',NULL,NULL,NULL),(120,'Arduino','RELÉ 1 MÓDULO',NULL,NULL,NULL),(121,'Arduino','Módulo matriz led 8x8',NULL,NULL,NULL),(122,'Arduino','Display 7 segmentos 1 dígito',NULL,NULL,NULL),(123,'Arduino','Display 7 segmentos 4 dígito',NULL,NULL,NULL),(124,'Arduino','Motor paso a paso 28byt-48',NULL,NULL,NULL),(125,'Arduino','Motor reductor DC',NULL,NULL,NULL),(126,'Arduino','Kit sensores y elementos varios',NULL,NULL,NULL),(127,'Arduino','Celda de carga 10 kg + ampl',NULL,NULL,NULL),(128,'Arduino','Servos MG99GR',NULL,NULL,NULL),(129,'Arduino','Sensor huella digital',NULL,NULL,NULL),(130,'Arduino','Puente H Motor Shield L293d',NULL,NULL,NULL),(131,'Arduino','Protoboard x400 ptos',NULL,NULL,NULL),(132,'Arduino','Protoboard x800 ptos',NULL,NULL,NULL),(133,'Arduino','Arduino Mega',NULL,NULL,NULL),(134,'Arduino','Arduino Uno',NULL,NULL,NULL),(135,'Arduino','Arduino Nano',NULL,NULL,NULL),(136,'Arduino','Arduino Fundino',NULL,NULL,NULL),(137,'Arduino','Cables USB',NULL,NULL,NULL),(138,'Arduino','Celda de carga 10 kg + ampl',NULL,NULL,NULL),(139,'Arduino','Servos MG99GR',NULL,NULL,NULL),(140,'Arduino','Sensor huella digital',NULL,NULL,NULL),(141,'Arduino','Puente H Motor Shield L293d',NULL,NULL,NULL),(142,'Arduino','Led 5mm V-A-R-B',NULL,NULL,NULL),(143,'Arduino','Led 3mm V-A-R-B',NULL,NULL,NULL),(144,'Arduino','Resistencias carbón varios valores',NULL,NULL,NULL),(145,'Arduino','Resistencias metal varios valores',NULL,NULL,NULL),(146,'Arduino','Resistencias',NULL,NULL,NULL),(147,'Arduino','Led roja',NULL,NULL,NULL),(148,'Arduino','led blanca',NULL,NULL,NULL),(149,'Arduino','led amarilla',NULL,NULL,NULL),(150,'Arduino','led verde',NULL,NULL,NULL),(151,'Arduino','Adaptador',NULL,NULL,NULL),(152,'Arduino','Relay 4 módulos',NULL,NULL,NULL),(153,'Arduino','Relay 2 módulos',NULL,NULL,NULL),(154,'Arduino','tarjeta magnética',NULL,NULL,NULL),(155,'Arduino','speaker',NULL,NULL,NULL),(156,'Dispositivos','Impresora',NULL,NULL,NULL),(157,'	Dispositivos','Proyector',NULL,NULL,NULL),(158,'Dispositivos','Estabilizador',NULL,NULL,NULL),(159,'Disco','Disco externo 1TB',NULL,NULL,NULL),(160,'Disco','Disco externo 500GB',NULL,NULL,NULL),(161,'Dispositivos','Router',NULL,NULL,NULL),(162,'Dispositivos','Lector de CD',NULL,NULL,NULL),(163,'Dispositivos','Estación de sodura',NULL,NULL,NULL),(164,'Dispositivos','Cámara',NULL,NULL,NULL),(165,'Cable','Cable Ethernet',NULL,NULL,NULL),(166,'Cable','Cable VGA',NULL,NULL,NULL),(167,'Cable','Cable HDMI',NULL,NULL,NULL),(168,'Cable','Cable Fuente',NULL,NULL,NULL),(169,'Cable','Cable USB - USB C',NULL,NULL,NULL),(170,'Cable','Cable UTP cat 5e',NULL,NULL,NULL),(171,'Cable','Prolongación',NULL,NULL,NULL),(172,'Cable','Cable VGA-HDMI',NULL,NULL,NULL),(173,'Cable','Cable Display Port',NULL,NULL,NULL),(174,'Cable','Adaptador de disco',NULL,NULL,NULL),(175,'Cable','Cable SATA',NULL,NULL,NULL),(176,'Cable','Cable macho - macho',NULL,NULL,NULL),(177,'Cable','Cable macho - hembra',NULL,NULL,NULL),(178,'Cable','Cable hembra - hembra',NULL,NULL,NULL),(179,'Cable','Cable USB A - USB B',NULL,NULL,NULL),(188,'Placa madre','GIGABYTE A520M KUV2',NULL,NULL,NULL),(189,'Placa madre','MSI A320M PRO SLASH UVH',NULL,NULL,NULL),(190,'Placa madre','LENOVO IH61M',NULL,NULL,NULL),(191,'Placa madre','GIGABYTE GAB85M SLASH D3H',NULL,NULL,NULL),(192,'Placa madre','MSI A320M SLASH A PRO',NULL,NULL,NULL),(193,'Placa madre','ASUS A668HM SLASH PLUS',NULL,NULL,NULL),(194,'Placa madre','ASUS H81M SLASH A',NULL,NULL,NULL),(195,'Placa madre','MSI-A320',NULL,NULL,NULL),(196,'Placa madre','GIGABYTE TECHNOLOGY D85M-B3H',NULL,NULL,NULL),(197,'Procesador','AMD R5 4600G 6G READON 3,7',NULL,NULL,NULL),(198,'Procesador','AMD A8-9600  REDEON R7 3,10 GHZ',NULL,NULL,NULL),(199,'Procesador','INTEL CORE I3-2120 3,30 GHZ',NULL,NULL,NULL),(200,'Procesador','INTEL CORE I3-4130 3,40GHZ',NULL,NULL,NULL),(201,'Procesador','INTEL CORE I3 4130',NULL,NULL,NULL),(202,'Procesador','AMD A4-6300 RADEON 3,7 GHZ',NULL,NULL,NULL),(203,'Procesador','AMD A6-7400K RADEON R5 3,5 GHZ',NULL,NULL,NULL),(204,'Procesador','INTEL PENTIUM G63260 3,3 GHZ',NULL,NULL,NULL),(205,'Procesador','ATHLON 320G',NULL,NULL,NULL),(206,'Procesador','INTEL CORE I3 2100',NULL,NULL,NULL),(207,'Procesador','AMD A8-9600 RADEON R7',NULL,NULL,NULL),(208,'Procesador','INTEL i7 6700k 4gb',NULL,NULL,NULL),(209,'Procesador','INTEL CORE I5 4460',NULL,NULL,NULL),(210,'Procesador','RYZEN 5 4600g',NULL,NULL,NULL),(211,'RAM','DDR4 8GB',NULL,NULL,NULL),(212,'RAM','DDR4 16GB',NULL,NULL,NULL),(213,'RAM','DDR4 4GB ',NULL,NULL,NULL),(214,'RAM','DDR3 8GB',NULL,NULL,NULL),(215,'RAM','DDR3 16GB ',NULL,NULL,NULL),(221,'Disco','HDD 1TB',NULL,NULL,NULL),(222,'Disco','HDD 500GB',NULL,NULL,NULL),(223,'Disco','M.2 480GB ',NULL,NULL,NULL),(224,'Disco','SSD 224GB',NULL,NULL,NULL),(225,'Disco','SSD 480GB',NULL,NULL,NULL),(226,'Fuente','Fuente 180W',NULL,NULL,NULL),(227,'Fuente','Fuente 200W',NULL,NULL,NULL),(228,'Fuente','Fuente 250W',NULL,NULL,NULL),(229,'Fuente','Fuente 500W',NULL,NULL,NULL),(230,'Fuente','Fuente 550W',NULL,NULL,NULL),(231,'Fuente','Fuente 600W',NULL,NULL,NULL),(232,'Fuente','Fuente 650W',NULL,NULL,NULL),(233,'Monitor','Monitor',NULL,NULL,NULL),(234,'Mouse','Mouse',NULL,NULL,NULL),(235,'Teclado','Teclado',NULL,NULL,NULL),(236,'Dispositivo','Adaptador de TP Link ',NULL,NULL,NULL),(237,'Dispositivo','Zapatilla',NULL,NULL,NULL),(238,'Cable ','Cable de instalación elécctrica',NULL,NULL,NULL),(239,'Dispositivo','Parlante',NULL,NULL,NULL),(240,'Disco','CD',NULL,NULL,NULL),(241,'Disco','Disquete',NULL,NULL,NULL),(242,'Disco','Targeta de memoria',NULL,NULL,NULL),(243,'Cable','Cable USB - USB',NULL,NULL,NULL),(244,'Disco','Disco SSD 240GB',NULL,NULL,NULL),(245,'Arduino','PULSADOR REDONDO C/RET VERDE',NULL,NULL,NULL),(246,'Arduino','PULSADOR REDONDO C/RET ROJO',NULL,NULL,NULL),(247,'Arduino','PULSADOR CHICO',NULL,NULL,NULL),(248,'Arduino','PULSADOR GRANDE',NULL,NULL,NULL),(249,'Arduino','PORTA LED',NULL,NULL,NULL),(250,'Arduino','PLACAS PUERTO USB',NULL,NULL,NULL),(251,'Arduino','INTERRUPTOR',NULL,NULL,NULL);
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
INSERT INTO `material_almacenamiento` VALUES (1,2,3),(1,3,10),(1,6,14),(2,2,9),(2,3,6),(2,6,7),(3,3,7),(4,2,2),(4,3,7),(5,3,2),(6,1,40),(6,2,2),(6,3,2),(7,3,2),(8,3,4),(8,5,10),(8,25,1),(9,2,4),(9,23,1),(10,3,1),(11,2,1),(11,3,2),(12,1,1),(12,2,2),(12,3,2),(12,4,1),(12,25,9),(13,2,2),(13,3,2),(13,23,1),(14,1,2),(14,4,2),(14,25,1),(15,1,2),(15,2,5),(15,4,1),(16,1,1),(16,24,3),(17,5,5),(18,5,3),(19,5,2),(20,23,1),(21,2,6),(21,23,4),(23,1,1),(24,1,2),(24,2,1),(34,2,1),(35,2,1),(36,2,1),(37,2,2),(38,2,2),(39,2,1),(40,2,1),(41,2,1),(42,2,1),(43,1,1),(43,4,1),(44,2,6),(44,4,2),(45,1,1),(46,1,1),(47,1,1),(48,1,1),(49,1,1),(50,1,8),(51,1,1),(52,1,1),(52,8,1),(53,1,1),(54,2,1),(54,23,1),(55,2,1),(56,2,1),(57,2,4),(58,2,1),(59,2,1),(60,2,1),(61,2,2),(63,9,5),(64,9,3),(65,10,4),(66,10,18),(67,11,5),(68,11,1),(69,11,1),(70,11,1),(71,11,5),(72,11,1),(73,12,3),(74,12,7),(75,12,2),(76,12,2),(77,13,1),(78,13,5),(79,13,7),(80,13,1),(81,13,3),(82,13,3),(83,14,1),(84,14,4),(85,14,3),(86,14,1),(87,14,1),(88,14,2),(89,14,7),(90,14,1),(91,14,1),(119,14,2),(120,14,1),(121,16,3),(122,16,2),(123,16,1),(124,16,3),(125,16,5),(126,17,36),(131,19,3),(132,19,5),(133,19,3),(134,19,8),(135,19,1),(136,19,1),(137,19,1),(138,18,1),(139,18,4),(140,18,1),(141,18,2),(142,20,1),(143,20,1),(144,20,1),(145,20,1),(159,1,4),(160,1,1),(161,1,1),(162,1,1),(166,1,2),(166,2,1),(166,4,1),(167,2,2),(167,4,1),(167,8,1),(168,1,2),(168,2,1),(169,1,2),(170,1,2),(170,4,1),(170,25,1),(171,1,1),(172,2,1),(173,2,1),(174,2,2),(175,1,4),(176,8,1),(177,8,1),(178,8,1),(213,23,2),(228,1,1),(229,2,4),(230,2,5),(231,2,3),(233,2,4),(234,1,4),(234,2,13),(234,4,4),(235,4,7),(236,4,1),(237,4,1),(238,1,3),(239,1,1),(239,2,1),(240,1,58),(241,1,3),(242,2,1),(243,1,4),(244,2,6),(245,15,2),(246,15,2),(247,15,14),(248,15,6),(249,15,3),(250,15,1),(251,15,2);
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
  `ID_MATERIAL` int NOT NULL,
  `ID_ALMACENAMIENTO_ANTERIOR` int NOT NULL,
  `ID_ALMACENAMIENTO_NUEVO` int NOT NULL,
  `CANTIDAD` int unsigned NOT NULL,
  `FECHA` date DEFAULT NULL,
  `OBSERVACIONES` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_MOVIMIENTO`),
  KEY `FK_ALMACENAMIENTO_ANTERIOR` (`ID_MATERIAL`,`ID_ALMACENAMIENTO_ANTERIOR`),
  KEY `FK_ALMACENAMIENTO_NUEVO` (`ID_MATERIAL`,`ID_ALMACENAMIENTO_NUEVO`),
  CONSTRAINT `FK_ALMACENAMIENTO_ANTERIOR` FOREIGN KEY (`ID_MATERIAL`,`ID_ALMACENAMIENTO_ANTERIOR`) 
      REFERENCES `material_almacenamiento` (`ID_MATERIAL`,`ID_ALMACENAMIENTO`),
  CONSTRAINT `FK_ALMACENAMIENTO_NUEVO` FOREIGN KEY (`ID_MATERIAL`,`ID_ALMACENAMIENTO_NUEVO`) 
      REFERENCES `material_almacenamiento` (`ID_MATERIAL`,`ID_ALMACENAMIENTO`)
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

-- Dump completed on 2025-09-12 13:53:06
