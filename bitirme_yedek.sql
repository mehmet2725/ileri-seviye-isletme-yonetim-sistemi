-- MySQL dump 10.13  Distrib 8.0.39, for Win64 (x86_64)
--
-- Host: localhost    Database: bitirme_projesi
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `calisanlar`
--

DROP TABLE IF EXISTS `calisanlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calisanlar` (
  `calisan_id` int NOT NULL AUTO_INCREMENT,
  `kullanici_id` int NOT NULL,
  `vardiya_baslangic_zamani` time DEFAULT NULL,
  `vardiya_bitis_zamani` time DEFAULT NULL,
  `izin_durumu` tinyint(1) DEFAULT '0',
  `gorev` varchar(255) DEFAULT NULL,
  `calisma_durumu` enum('Aktif','Pasif') DEFAULT 'Aktif',
  `yetki_seviyesi` int DEFAULT NULL,
  PRIMARY KEY (`calisan_id`),
  KEY `kullanici_id` (`kullanici_id`),
  CONSTRAINT `calisanlar_ibfk_1` FOREIGN KEY (`kullanici_id`) REFERENCES `kullanicilar` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calisanlar`
--

LOCK TABLES `calisanlar` WRITE;
/*!40000 ALTER TABLE `calisanlar` DISABLE KEYS */;
INSERT INTO `calisanlar` VALUES (1,1000,NULL,NULL,0,'Görev 1','Aktif',1),(2,1001,NULL,NULL,0,'Görev 2','Aktif',1),(3,3501,NULL,NULL,0,'Görev 3','Aktif',2),(4,3502,NULL,NULL,0,'Görev 4','Aktif',2),(5,4501,NULL,NULL,0,'Görev 5','Aktif',3),(6,4502,NULL,NULL,0,'Görev 6','Aktif',3);
/*!40000 ALTER TABLE `calisanlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feedback` (
  `id` int NOT NULL AUTO_INCREMENT,
  `musteri_id` int NOT NULL,
  `geri_bildirim` text NOT NULL,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `musteri_id` (`musteri_id`),
  CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`musteri_id`) REFERENCES `musteriler` (`musteri_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
INSERT INTO `feedback` VALUES (9,2,'deneme deneme','2025-01-05 04:17:58'),(10,4,'merhaba saat 04.41','2025-01-05 04:41:21');
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kullanicilar`
--

DROP TABLE IF EXISTS `kullanicilar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanicilar` (
  `kullanici_id` int NOT NULL AUTO_INCREMENT,
  `ad_soyad` varchar(255) NOT NULL,
  `eposta` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `rol` enum('Yonetici','Calisan','Musteri') NOT NULL,
  `kayit_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  `erisim_siparis` tinyint(1) DEFAULT '0' COMMENT 'Sipariş bilgilerine erişim izni',
  `erisim_stok` tinyint(1) DEFAULT '0' COMMENT 'Stok bilgilerine erişim izni',
  `ilgili_tablo_id` int DEFAULT NULL,
  PRIMARY KEY (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5004 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanicilar`
--

LOCK TABLES `kullanicilar` WRITE;
/*!40000 ALTER TABLE `kullanicilar` DISABLE KEYS */;
INSERT INTO `kullanicilar` VALUES (1,'Yönetici Bir','yonetici1@example.com','dene','Yonetici','2025-01-03 12:44:20',0,0,NULL),(2,'Yönetici İki','yonetici2@example.com','sifre123','Yonetici','2025-01-03 12:44:20',0,0,NULL),(1000,'Çalışan Bir','calisan1@example.com','password123','Calisan','2025-01-03 12:44:28',0,0,NULL),(1001,'Çalışan İki','calisan2@example.com','password123','Calisan','2025-01-03 12:44:28',0,0,NULL),(3501,'Çalışan Seviye 2 Bir','calisan2seviye@example.com','password123','Calisan','2025-01-03 12:44:37',0,0,NULL),(3502,'Çalışan Seviye 2 İki','calisan2seviye2@example.com','password123','Calisan','2025-01-03 12:44:37',0,0,NULL),(4501,'Çalışan Seviye 3 Bir','calisan3seviye@example.com','password123','Calisan','2025-01-03 12:44:41',0,0,NULL),(4502,'Çalışan Seviye 3 İki','calisan3seviye2@example.com','password123','Calisan','2025-01-03 12:44:41',0,0,NULL),(5001,'Müşteri Bir','merhaba@example.com','sifre123','Musteri','2025-01-03 12:44:46',0,0,NULL),(5002,'Müşteri İki','musteri2@example.com','sifre123','Musteri','2025-01-03 12:44:46',0,0,NULL),(5003,'mehmet s','mehmet@example.com','d','Musteri','2025-01-05 04:40:28',0,0,NULL);
/*!40000 ALTER TABLE `kullanicilar` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_kullanici_ekleme` AFTER INSERT ON `kullanicilar` FOR EACH ROW begin
insert into loglar(kullanici_id, tablo_adi, islem_tipi, detaylar)
values (
new.kullanici_id,
'kullanicilar',
'Ekleme',
concat('Yeni kullanıcı eklendi: ',new.ad_soyad, ' (rol: ',new.rol, ')')
);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_kullanici_guncelleme` AFTER UPDATE ON `kullanicilar` FOR EACH ROW BEGIN
    INSERT INTO loglar (kullanici_id, tablo_adi, islem_tipi, detaylar)
    VALUES (
        NEW.kullanici_id,
        'kullanicilar',
        'Güncelleme',
        CONCAT('Kullanıcı bilgileri güncellendi: ', NEW.ad_soyad)
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_kullanici_silme` AFTER DELETE ON `kullanicilar` FOR EACH ROW BEGIN
    INSERT INTO loglar (kullanici_id, tablo_adi, islem_tipi, detaylar)
    VALUES (
        OLD.kullanici_id,
        'kullanicilar',
        'Silme',
        CONCAT('Kullanıcı silindi: ', OLD.ad_soyad)
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `loglar`
--

DROP TABLE IF EXISTS `loglar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loglar` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `kullanici_id` int NOT NULL,
  `islem_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  `tablo_adi` varchar(255) DEFAULT NULL,
  `islem_tipi` varchar(100) DEFAULT NULL,
  `detaylar` text,
  PRIMARY KEY (`log_id`),
  KEY `kullanici_id` (`kullanici_id`),
  CONSTRAINT `loglar_ibfk_1` FOREIGN KEY (`kullanici_id`) REFERENCES `kullanicilar` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=473 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loglar`
--

LOCK TABLES `loglar` WRITE;
/*!40000 ALTER TABLE `loglar` DISABLE KEYS */;
INSERT INTO `loglar` VALUES (1,1,'2024-12-17 02:14:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici Bir (rol: Yonetici)'),(2,2,'2024-12-17 02:14:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici İki (rol: Yonetici)'),(5,5001,'2024-12-17 02:14:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri Bir (rol: Musteri)'),(6,5002,'2024-12-17 02:14:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri İki (rol: Musteri)'),(7,5001,'2024-12-17 02:17:33',NULL,'Veri Çekme','Müşteri bilgileri görüntülendi.'),(8,5002,'2024-12-17 02:18:10',NULL,'Veri Çekme','Müşteri bilgileri görüntülendi.'),(9,5001,'2024-12-17 02:24:09',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(11,1,'2024-12-17 02:25:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(12,5008,'2024-12-17 03:21:35','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Ahmet Yılmaz (rol: Musteri)'),(13,5008,'2024-12-17 03:22:36','siparisler','Ekleme','Yeni sipariş eklendi (id: 1) - toplam tutar: 2700.00'),(14,5008,'2024-12-17 03:22:36','siparisler','Ekleme','Yeni sipariş eklendi (id: 2) - toplam tutar: 13500.00'),(16,5008,'2024-12-17 03:34:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(17,5008,'2024-12-17 03:38:59',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(18,5001,'2024-12-17 19:32:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(19,5002,'2024-12-17 19:46:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(20,5008,'2024-12-17 20:08:47',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(21,5008,'2024-12-18 21:29:26',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(22,5008,'2024-12-18 21:52:41',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(23,5008,'2024-12-18 21:56:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(24,5008,'2024-12-18 21:58:49',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(25,5008,'2024-12-18 21:59:05','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(26,5008,'2024-12-18 21:59:22','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(27,5008,'2024-12-18 22:04:40',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(28,5008,'2024-12-18 22:04:52','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(29,5008,'2024-12-18 22:04:53','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(30,5008,'2024-12-18 22:23:44',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(31,5008,'2024-12-18 22:24:01','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(32,5008,'2024-12-18 22:24:02','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(33,5008,'2024-12-18 22:25:11','siparisler','Ekleme','Yeni sipariş eklendi (id: 3) - toplam tutar: 7500.00'),(34,5008,'2024-12-18 22:26:39',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(35,5008,'2024-12-18 22:27:00','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(36,5008,'2024-12-18 22:27:00','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(37,5008,'2024-12-18 22:28:39',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(38,5008,'2024-12-18 22:28:45','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(39,5008,'2024-12-18 22:28:46','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(40,5008,'2024-12-19 09:55:42',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(41,5008,'2024-12-19 09:55:44','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(42,5008,'2024-12-19 09:55:45','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(43,5008,'2024-12-20 16:23:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(44,5008,'2024-12-20 16:23:55','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(45,5008,'2024-12-20 16:23:57','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(46,5008,'2024-12-20 16:38:05',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(47,5008,'2024-12-20 16:38:08','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(48,5008,'2024-12-20 16:40:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(49,5008,'2024-12-20 16:40:54','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(50,5008,'2024-12-20 16:41:05','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(51,5008,'2024-12-20 16:42:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(52,5008,'2024-12-20 16:42:14','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(53,5008,'2024-12-20 16:42:15','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(54,5008,'2024-12-20 16:53:33',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(55,5008,'2024-12-20 16:53:37','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(56,5008,'2024-12-20 16:53:38','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(57,5008,'2024-12-20 17:09:05',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(58,5008,'2024-12-20 17:09:07','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(59,5008,'2024-12-20 17:09:08','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(60,5008,'2024-12-20 17:13:37','musteriler','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(61,5008,'2024-12-20 18:27:21',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(62,5008,'2024-12-20 18:28:23','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(63,5008,'2024-12-20 18:28:24','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(64,5008,'2024-12-20 18:31:49',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(65,5008,'2024-12-20 18:31:51','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(66,5008,'2024-12-20 18:32:15',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(67,5008,'2024-12-20 18:32:45','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(68,5008,'2024-12-20 18:37:47',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(69,5008,'2024-12-20 18:37:51','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(70,5008,'2024-12-20 18:37:52','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(71,5008,'2024-12-20 18:39:10',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(72,5008,'2024-12-20 18:46:27',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(73,5008,'2024-12-20 18:46:54','musteriler','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(74,5008,'2024-12-20 18:47:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(75,5008,'2024-12-20 18:51:35',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(76,5008,'2024-12-20 18:52:10','musteriler','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(77,5008,'2024-12-20 19:00:46',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(78,5008,'2024-12-20 19:01:07','musteriler','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(79,5008,'2024-12-20 19:04:00',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(80,5008,'2024-12-20 19:04:37','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Ahmet Yılmaz'),(81,5008,'2024-12-20 19:04:40','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(82,5008,'2024-12-20 19:05:57',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(83,5008,'2024-12-20 19:07:44',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(84,5008,'2024-12-20 19:15:37',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(85,5008,'2024-12-20 19:17:02','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Ahmet Yılmaz'),(86,5008,'2024-12-20 19:17:02','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(87,5008,'2024-12-20 19:17:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(88,5008,'2024-12-20 19:26:08',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(89,5008,'2024-12-22 00:25:25',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(90,5008,'2024-12-22 00:25:27','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(91,5008,'2024-12-22 00:25:28','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(92,5008,'2024-12-23 17:44:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(93,5008,'2024-12-23 17:44:55','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(94,5008,'2024-12-23 17:44:58','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(95,5008,'2024-12-23 20:32:27',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(96,5008,'2024-12-23 20:33:08','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Ahmet Yılmaz'),(97,5008,'2024-12-23 20:33:08','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(98,5008,'2024-12-23 20:33:42',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(101,1001,'2024-12-23 23:39:54','kullanicilar','Silme','Kullanıcı silindi: Çalışan Bir'),(102,1002,'2024-12-23 23:39:54','kullanicilar','Silme','Kullanıcı silindi: Çalışan İki'),(103,1001,'2024-12-23 23:53:32','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 1 (rol: Calisan)'),(104,3501,'2024-12-23 23:53:32','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 2 (rol: Calisan)'),(105,4500,'2024-12-23 23:53:32','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 3 (rol: Calisan)'),(106,1001,'2024-12-23 23:54:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(107,1001,'2024-12-23 23:54:44','calisanlar','Veri Çekme','Vardiya bilgileri görüntülendi.'),(108,1001,'2024-12-23 23:59:50',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(109,1001,'2024-12-24 00:07:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(110,1001,'2024-12-24 00:08:20',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(111,1001,'2024-12-24 00:11:51',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(112,1001,'2024-12-25 13:23:08',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(113,1001,'2024-12-25 13:29:51',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(114,1001,'2024-12-25 13:37:28',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(115,1001,'2024-12-25 13:45:23',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(116,1001,'2024-12-25 14:32:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(117,4500,'2024-12-25 14:36:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(118,1001,'2024-12-25 14:46:41',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(119,3501,'2024-12-25 14:47:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(120,3501,'2024-12-25 14:47:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(121,4500,'2024-12-25 14:47:54',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(122,1001,'2024-12-25 15:12:50',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(123,3501,'2024-12-25 15:13:09',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(124,4500,'2024-12-25 15:13:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(125,1001,'2024-12-25 15:22:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(126,3501,'2024-12-25 15:25:39',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(127,4500,'2024-12-25 15:26:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(128,4501,'2024-12-25 15:30:37','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Seviye 3'),(129,4501,'2024-12-25 15:31:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(130,1001,'2024-12-25 15:31:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(131,1001,'2024-12-25 18:34:45',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(132,3501,'2024-12-25 18:35:07',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(133,4501,'2024-12-25 18:35:30',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(134,1001,'2024-12-25 18:45:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(135,1001,'2024-12-25 18:46:52',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(136,1001,'2024-12-25 18:47:44',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(137,1001,'2024-12-25 18:50:17',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(138,1001,'2024-12-25 18:50:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(139,1001,'2024-12-25 18:52:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(140,1001,'2024-12-25 18:55:01',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(141,3501,'2024-12-25 18:55:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(142,4501,'2024-12-25 18:55:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(143,1001,'2024-12-25 19:07:04',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(144,3501,'2024-12-25 19:07:34',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(145,1001,'2024-12-25 19:09:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(146,3501,'2024-12-25 19:09:40',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(147,1001,'2024-12-25 19:19:09',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(148,1001,'2024-12-25 19:20:26',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(149,1001,'2024-12-25 19:21:27',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(150,3501,'2024-12-25 19:23:55',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(151,3501,'2024-12-25 19:24:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(152,4501,'2024-12-25 19:24:32',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(153,1001,'2024-12-25 19:31:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(154,3501,'2024-12-25 19:31:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(155,4501,'2024-12-25 19:31:57',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(156,3501,'2024-12-25 19:33:20',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(157,3501,'2024-12-25 19:43:24',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(158,3501,'2024-12-25 19:49:32',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(159,3501,'2024-12-25 19:53:03',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(160,3501,'2024-12-25 20:02:00',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(161,4501,'2024-12-25 20:02:27',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(162,1001,'2024-12-26 18:46:42',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(163,3501,'2024-12-26 18:47:06',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(164,4501,'2024-12-26 18:49:48',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(165,3501,'2024-12-26 18:56:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(166,3501,'2024-12-26 19:03:46',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(167,3501,'2024-12-26 19:13:37',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(168,3501,'2024-12-26 19:21:40',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(169,3501,'2024-12-26 19:27:04',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(170,3501,'2024-12-26 19:56:34',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(171,3501,'2024-12-26 19:57:07',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(172,3501,'2024-12-26 19:58:58',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(173,5008,'2024-12-26 20:08:27','siparisler','Ekleme','Yeni sipariş eklendi (id: 4) - toplam tutar: 2700.00'),(174,5008,'2024-12-26 20:08:27','siparisler','Ekleme','Yeni sipariş eklendi (id: 5) - toplam tutar: 13500.00'),(175,5008,'2024-12-26 20:08:27','siparisler','Ekleme','Yeni sipariş eklendi (id: 6) - toplam tutar: 7500.00'),(176,3501,'2024-12-26 20:08:54',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(177,3501,'2024-12-26 20:12:37',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(178,3501,'2024-12-26 20:12:46',NULL,'Sipariş İptal Edildi','Sipariş 4 durumu Sipariş İptal Edildi olarak güncellendi.'),(179,5002,'2024-12-26 20:18:13','siparisler','Ekleme','Yeni sipariş eklendi (id: 9) - toplam tutar: 250.50'),(180,3501,'2024-12-26 20:19:06',NULL,'Sipariş Onaylandı','Sipariş 9 durumu Sipariş Onaylandı olarak güncellendi.'),(181,3501,'2024-12-26 20:19:25',NULL,'Sipariş İptal Edildi','Sipariş 9 durumu Sipariş İptal Edildi olarak güncellendi.'),(182,3501,'2024-12-26 20:21:41',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(183,3501,'2024-12-27 14:09:05',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(184,3501,'2024-12-27 14:09:12',NULL,'Sipariş İptal Edildi','Sipariş 4 durumu Sipariş İptal Edildi olarak güncellendi.'),(185,3501,'2024-12-27 14:16:26',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(186,4501,'2024-12-27 14:17:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(187,4501,'2024-12-27 14:20:12',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(188,3501,'2024-12-27 14:20:40',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(189,1001,'2024-12-27 14:21:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(190,4501,'2024-12-27 14:23:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(191,4501,'2024-12-27 14:53:51',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(192,4501,'2024-12-27 14:56:08',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(193,4501,'2024-12-27 16:30:59',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(194,4501,'2024-12-27 16:42:23',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(195,4501,'2024-12-27 16:43:08',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(196,4501,'2024-12-27 16:43:52',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(197,4501,'2024-12-27 16:53:01',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(198,4501,'2024-12-27 17:24:18',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(199,3501,'2024-12-27 17:28:21',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(200,1001,'2024-12-27 17:28:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(201,3501,'2024-12-27 18:29:06',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(202,4501,'2024-12-27 18:29:21',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(203,4501,'2024-12-27 18:30:27',NULL,'Düzenleme','Sipariş 4 düzenlendi.'),(204,3501,'2024-12-27 18:36:17',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(205,4501,'2024-12-27 23:26:06',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(206,3501,'2024-12-28 00:48:33',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(207,4501,'2024-12-28 00:48:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(208,4501,'2024-12-28 00:51:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(209,4501,'2024-12-28 00:52:28',NULL,'Güncelleme','Müşteri bilgileri güncellendi.'),(210,4501,'2024-12-28 00:56:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(211,4501,'2024-12-28 00:57:16',NULL,'Güncelleme','Müşteri: merhabalar deneme bilgileri güncellendi.'),(212,4501,'2024-12-30 17:59:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(213,4501,'2024-12-30 18:00:05',NULL,'Düzenleme','Sipariş 1 düzenlendi.'),(214,4501,'2024-12-30 18:02:21',NULL,'Güncelleme','Müşteri: Müşteri Bir bilgileri güncellendi.'),(215,4501,'2024-12-30 18:52:55',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(216,4501,'2024-12-30 18:53:23',NULL,'Düzenleme','Sipariş 6 düzenlendi.'),(217,4501,'2024-12-30 18:53:33','siparisler','Durum Güncelleme','Sipariş ID: 6, Yeni Durum: Tamamlandi'),(218,4501,'2024-12-30 18:54:18',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(219,4501,'2024-12-30 19:35:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(220,4501,'2024-12-30 19:48:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(221,4501,'2024-12-30 19:48:15',NULL,'Veri Görüntüleme','Stok bilgileri görüntülendi.'),(222,4501,'2024-12-30 19:48:49',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(223,4501,'2024-12-30 19:48:49',NULL,'Veri Görüntüleme','Stok bilgileri görüntülendi.'),(224,4501,'2024-12-30 19:49:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(225,4501,'2024-12-30 19:49:13',NULL,'Veri Görüntüleme','Stok bilgileri görüntülendi.'),(226,4501,'2024-12-30 19:55:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(227,4501,'2024-12-30 19:55:25',NULL,'Veri Görüntüleme','Stok bilgileri görüntülendi.'),(228,4501,'2024-12-30 19:56:06',NULL,'Veri Görüntüleme','Stok bilgileri görüntülendi.'),(229,4501,'2024-12-30 20:14:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(230,4501,'2024-12-30 20:16:23',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(231,4501,'2024-12-30 20:16:58',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(232,1001,'2024-12-30 20:25:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(233,3501,'2024-12-30 20:25:55',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(234,4501,'2024-12-30 20:26:25',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(235,4501,'2024-12-30 20:27:10',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 2'),(236,4501,'2024-12-30 20:28:45',NULL,'Stok Düzenleme','Ürün ID: 3, Yeni Stok: 10, Yeni Fiyat: 1000'),(237,4501,'2024-12-30 20:43:48',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(238,4501,'2024-12-30 20:44:23',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(239,4501,'2024-12-30 20:47:30',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(240,4501,'2024-12-30 20:47:39',NULL,'Düzenleme','Sipariş 9 düzenlendi.'),(241,4501,'2024-12-30 20:47:47','siparisler','Durum Güncelleme','Sipariş ID: 9, Yeni Durum: Tamamlandi'),(242,4501,'2024-12-30 20:47:57',NULL,'Düzenleme','Sipariş 9 düzenlendi.'),(243,5008,'2024-12-31 01:16:15',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(244,5008,'2024-12-31 01:16:16','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(245,5008,'2024-12-31 01:16:17','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(246,1001,'2024-12-31 03:04:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(247,1001,'2024-12-31 03:12:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(248,4501,'2024-12-31 03:13:06',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(249,4501,'2024-12-31 03:17:38',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(250,5008,'2024-12-31 03:18:09','siparisler','Ekleme','Yeni sipariş eklendi (id: 10) - toplam tutar: 2700.00'),(251,4501,'2024-12-31 03:18:09','siparisler','Ekleme','Yeni sipariş eklendi.'),(252,4501,'2024-12-31 03:23:24',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(253,5008,'2024-12-31 03:23:46','siparisler','Ekleme','Yeni sipariş eklendi (id: 11) - toplam tutar: 27000.00'),(254,4501,'2024-12-31 03:23:46','siparisler','Ekleme','Yeni sipariş eklendi.'),(255,4501,'2024-12-31 03:45:59',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(256,4501,'2024-12-31 03:47:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(257,4501,'2024-12-31 03:48:23','urunler','Güncelleme','Ürün ID: 4, Yeni Ad: Mouse, Yeni Stok: 15, Yeni Fiyat: 500'),(258,4501,'2024-12-31 04:02:57',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(259,4501,'2024-12-31 04:03:45',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(260,1001,'2024-12-31 04:29:59',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(261,1001,'2024-12-31 04:34:45',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(262,4501,'2024-12-31 04:35:05',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(263,4501,'2024-12-31 04:35:17','siparisler','Durum Güncelleme','Sipariş ID: 10, Yeni Durum: Iptal'),(264,4501,'2024-12-31 04:35:36',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 5008'),(265,4501,'2024-12-31 04:36:14',NULL,'Güncelleme','Ürün Güncellendi: Klavye'),(266,4501,'2024-12-31 04:37:29',NULL,'Ekleme','Yeni Ürün Eklendi: ürünid sıkıntı çıkarırsa naneyi yeriz'),(267,4501,'2024-12-31 04:38:12',NULL,'Ekleme','Yeni Ürün Eklendi: çalışıyoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo'),(268,4501,'2024-12-31 04:38:54',NULL,'Ekleme','Yeni Ürün Eklendi: bravo bana lan amq'),(269,4501,'2024-12-31 04:39:11',NULL,'Ekleme','Yeni Ürün Eklendi: saat 5 oluyo amq'),(270,1001,'2024-12-31 08:15:12',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(271,4501,'2024-12-31 08:15:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(272,4501,'2024-12-31 08:16:43','siparisler','Durum Güncelleme','Sipariş ID: 11, Yeni Durum: Tamamlandi'),(273,4501,'2024-12-31 08:17:49',NULL,'Güncelleme','Ürün Güncellendi: Gaming Monitor'),(274,1,'2025-01-01 00:05:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(275,1,'2025-01-01 00:06:18',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(276,1,'2025-01-01 00:06:35',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(277,1,'2025-01-01 00:06:59',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(278,1,'2025-01-01 00:21:01',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(279,1,'2025-01-01 00:24:34',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(280,1,'2025-01-01 00:42:58',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(281,1,'2025-01-01 00:43:02','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(282,1,'2025-01-01 00:43:04','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(283,1,'2025-01-01 00:43:39',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(284,1,'2025-01-01 00:43:39','musteriler','Düzenleme','Müşteri ID: 1 düzenlendi.'),(285,1,'2025-01-01 00:43:43','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(286,1,'2025-01-01 00:44:06',NULL,'Düzenleme','Sipariş 1 düzenlendi.'),(287,1,'2025-01-01 00:44:06','siparisler','Düzenleme','Sipariş ID: 1 düzenlendi.'),(288,1,'2025-01-01 00:44:08','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(289,1,'2025-01-01 19:12:21',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(290,1,'2025-01-01 19:21:48',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(291,1,'2025-01-01 19:28:45',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(292,1001,'2025-01-01 19:29:13','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışşköle'),(293,1,'2025-01-01 19:29:29','calisanlar','İptal','Çalışan düzenleme işlemi iptal edildi.'),(294,1,'2025-01-01 19:39:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(295,1,'2025-01-01 19:46:07',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(296,1,'2025-01-01 19:46:29',NULL,'Güncelleme','Ürün Güncellendi: saat 5 oluyo amq'),(297,1,'2025-01-01 19:46:48',NULL,'Güncelleme','Ürün Güncellendi: saat 5 oluyo amq'),(298,1,'2025-01-01 19:47:47','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(299,1,'2025-01-01 19:47:51','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(300,1,'2025-01-01 19:48:02','calisanlar','İptal','Çalışan düzenleme işlemi iptal edildi.'),(301,1,'2025-01-01 20:12:28',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(302,1,'2025-01-01 20:17:51',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(303,1,'2025-01-01 20:48:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(304,1,'2025-01-01 20:51:09',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(305,1,'2025-01-01 20:57:30',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(306,5009,'2025-01-01 20:58:09','kullanicilar','Ekleme','Yeni kullanıcı eklendi: deneme (rol: Calisan)'),(307,1,'2025-01-02 10:47:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(308,1,'2025-01-02 11:02:05',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(309,1,'2025-01-02 11:02:26',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(310,1,'2025-01-02 11:08:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(311,1,'2025-01-02 11:11:35',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(312,1,'2025-01-02 11:26:55',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(313,2,'2025-01-02 13:37:57',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(314,1,'2025-01-02 14:36:34',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(315,1,'2025-01-02 14:45:04',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(316,1001,'2025-01-02 14:50:48',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(317,1,'2025-01-02 14:51:06',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(318,1,'2025-01-02 14:54:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(319,1,'2025-01-02 16:51:24',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(320,1000,'2025-01-02 16:53:46','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Test Çalışan (rol: Calisan)'),(321,1,'2025-01-02 16:55:53',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(322,1,'2025-01-02 17:39:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(323,1,'2025-01-02 17:59:36',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(324,1,'2025-01-03 01:33:43',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(325,5008,'2025-01-03 01:34:50',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(326,5008,'2025-01-03 01:34:51','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(327,5008,'2025-01-03 01:47:12',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(328,5008,'2025-01-03 01:47:14','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(329,4501,'2025-01-03 01:47:31',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(330,1,'2025-01-03 01:48:13',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(331,1,'2025-01-03 01:51:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(332,1,'2025-01-03 01:54:57',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(333,1,'2025-01-03 01:56:19',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(334,1,'2025-01-03 02:01:11',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(335,1,'2025-01-03 02:02:22',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(336,1,'2025-01-03 02:03:15',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(337,5003,'2025-01-03 02:04:47','kullanicilar','Ekleme','Yeni kullanıcı eklendi: merhabalarr (rol: Musteri)'),(338,1,'2025-01-03 02:05:02','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(339,1,'2025-01-03 02:05:34','musteriler','Düzenleme','Müşteri ID: 5010 düzenlendi.'),(340,5003,'2025-01-03 02:05:44',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(341,5003,'2025-01-03 02:05:45','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(342,4501,'2025-01-03 02:07:28',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(343,1,'2025-01-03 02:10:23',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(344,1,'2025-01-03 02:10:36','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(345,1,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Yönetici Bir'),(346,2,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Yönetici İki'),(347,1000,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Test Çalışan'),(348,1001,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Çalışşköle'),(349,3501,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 2'),(350,4501,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 3'),(351,5001,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Müşteri Bir'),(352,5002,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Müşteri İki'),(353,5003,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: merhabalarr'),(354,5008,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: Ahmet Yılmaz'),(355,5009,'2025-01-03 12:28:28','kullanicilar','Silme','Kullanıcı silindi: deneme'),(356,1,'2025-01-03 12:33:38','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici Bir (rol: Yonetici)'),(357,2,'2025-01-03 12:33:38','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici İki (rol: Yonetici)'),(358,3,'2025-01-03 12:33:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Bir (rol: Calisan)'),(359,4,'2025-01-03 12:33:44','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan İki (rol: Calisan)'),(360,5,'2025-01-03 12:33:51','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 2 Bir (rol: Calisan)'),(361,6,'2025-01-03 12:33:51','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 2 İki (rol: Calisan)'),(362,7,'2025-01-03 12:33:57','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 3 Bir (rol: Calisan)'),(363,8,'2025-01-03 12:33:57','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 3 İki (rol: Calisan)'),(364,9,'2025-01-03 12:34:07','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri Bir (rol: Musteri)'),(365,10,'2025-01-03 12:34:07','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri İki (rol: Musteri)'),(366,1,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Yönetici Bir'),(367,2,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Yönetici İki'),(368,3,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan Bir'),(369,4,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan İki'),(370,5,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 2 Bir'),(371,6,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 2 İki'),(372,7,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 3 Bir'),(373,8,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Çalışan Seviye 3 İki'),(374,9,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Müşteri Bir'),(375,10,'2025-01-03 12:40:42','kullanicilar','Silme','Kullanıcı silindi: Müşteri İki'),(376,11,'2025-01-03 12:44:20','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici Bir (rol: Yonetici)'),(377,12,'2025-01-03 12:44:20','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Yönetici İki (rol: Yonetici)'),(378,13,'2025-01-03 12:44:28','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Bir (rol: Calisan)'),(379,14,'2025-01-03 12:44:28','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan İki (rol: Calisan)'),(380,15,'2025-01-03 12:44:37','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 2 Bir (rol: Calisan)'),(381,16,'2025-01-03 12:44:37','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 2 İki (rol: Calisan)'),(382,17,'2025-01-03 12:44:41','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 3 Bir (rol: Calisan)'),(383,18,'2025-01-03 12:44:41','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Çalışan Seviye 3 İki (rol: Calisan)'),(384,19,'2025-01-03 12:44:46','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri Bir (rol: Musteri)'),(385,20,'2025-01-03 12:44:46','kullanicilar','Ekleme','Yeni kullanıcı eklendi: Müşteri İki (rol: Musteri)'),(386,11,'2025-01-03 12:48:27',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(387,11,'2025-01-03 12:49:04','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(388,11,'2025-01-03 12:49:06','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(389,11,'2025-01-03 12:54:16',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(390,21,'2025-01-03 12:55:11','kullanicilar','Ekleme','Yeni kullanıcı eklendi: deneme (rol: Yonetici)'),(391,21,'2025-01-03 12:57:10',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(392,5000,'2025-01-03 12:58:04','kullanicilar','Ekleme','Yeni kullanıcı eklendi: denemeğğ (rol: Musteri)'),(393,5000,'2025-01-03 13:00:03',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(394,5000,'2025-01-03 13:00:05','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(395,5000,'2025-01-03 13:00:05','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(396,19,'2025-01-03 13:11:15',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(397,21,'2025-01-03 13:11:39',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(398,21,'2025-01-03 13:33:52',NULL,'Giriş','Kullanıcı başarıyla giriş yaptı.'),(399,19,'2025-01-03 14:17:28','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(400,1,'2025-01-03 15:54:54','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Yönetici Bir'),(401,2,'2025-01-03 15:54:54','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Yönetici İki'),(402,21,'2025-01-03 15:57:29','kullanicilar','Silme','Kullanıcı silindi: deneme'),(403,1000,'2025-01-03 16:07:47','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Bir'),(404,1001,'2025-01-03 16:08:05','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan İki'),(405,3501,'2025-01-03 16:08:14','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Seviye 2 Bir'),(406,3502,'2025-01-03 16:08:21','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Seviye 2 İki'),(407,4501,'2025-01-03 16:08:26','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Seviye 3 Bir'),(408,4502,'2025-01-03 16:08:32','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Çalışan Seviye 3 İki'),(409,5001,'2025-01-03 16:14:13','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Müşteri Bir'),(410,5002,'2025-01-03 16:14:20','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Müşteri İki'),(411,1,'2025-01-03 16:18:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(412,1,'2025-01-03 16:18:46','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(413,1,'2025-01-03 16:18:55',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(414,1,'2025-01-03 16:18:55','musteriler','Düzenleme','Müşteri ID: 1 düzenlendi.'),(415,1,'2025-01-03 16:18:57','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(416,5001,'2025-01-03 16:20:44','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(417,5001,'2025-01-03 16:20:44','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(418,5000,'2025-01-03 16:35:24','kullanicilar','Silme','Kullanıcı silindi: denemeğğ'),(419,3502,'2025-01-03 17:35:13',NULL,'Ekleme','Yeni Ürün Eklendi: deneme'),(420,3502,'2025-01-03 17:38:43','siparisler','Durum Güncelleme','Sipariş ID: 1, Yeni Durum: Tamamlandi'),(421,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 1)'),(422,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 2)'),(423,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 3)'),(424,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 4)'),(425,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 5)'),(426,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 6)'),(427,5002,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 9)'),(428,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 10)'),(429,5008,'2025-01-05 02:16:35','siparisler','Silme','Sipariş silindi (id: 11)'),(430,4502,'2025-01-05 02:43:25',NULL,'Güncelleme','Ürün Güncellendi: çalışıyoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo'),(431,4502,'2025-01-05 02:50:39',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(432,4502,'2025-01-05 02:50:41',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 2'),(433,5001,'2025-01-05 03:17:18','siparisler','Ekleme','Yeni sipariş eklendi (id: 17) - toplam tutar: 100.00'),(434,4502,'2025-01-05 03:18:03','siparisler','Durum Güncelleme','Sipariş ID: 17, Yeni Durum: Tamamlandi'),(435,5002,'2025-01-05 03:28:45','siparisler','Ekleme','Yeni sipariş eklendi (id: 18) - toplam tutar: 14.00'),(436,5001,'2025-01-05 03:50:26','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(437,5001,'2025-01-05 03:50:28','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(438,5001,'2025-01-05 03:51:17','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Müşteri Bir'),(439,5001,'2025-01-05 03:51:17','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(440,5001,'2025-01-05 03:51:21','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(441,5001,'2025-01-05 03:51:22','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(442,5001,'2025-01-05 03:51:22','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(443,5001,'2025-01-05 04:00:20','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(444,5001,'2025-01-05 04:00:21','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(445,5001,'2025-01-05 04:11:32','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(446,5001,'2025-01-05 04:12:15','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Müşteri Bir'),(447,5001,'2025-01-05 04:12:15','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(448,5001,'2025-01-05 04:15:51','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Müşteri Bir'),(449,5001,'2025-01-05 04:15:51','musteriler ve kullanicilar','Güncelleme','Telefon ve e-posta bilgileri güncellendi.'),(450,5002,'2025-01-05 04:17:44','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(451,5002,'2025-01-05 04:17:45','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(452,4502,'2025-01-05 04:38:08',NULL,'Düzenleme','Sipariş 17 düzenlendi.'),(453,4502,'2025-01-05 04:38:32',NULL,'Düzenleme','Müşteri bilgileri düzenlendi: Müşteri ID 1'),(454,4502,'2025-01-05 04:38:46',NULL,'Ekleme','Yeni Ürün Eklendi: deneme'),(455,1,'2025-01-05 04:39:30','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(456,1,'2025-01-05 04:39:31','siparisler','Veri Çekme','Sipariş bilgileri çekildi.'),(457,5003,'2025-01-05 04:40:28','kullanicilar','Ekleme','Yeni kullanıcı eklendi: mehmet s (rol: Musteri)'),(458,1,'2025-01-05 04:40:41','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(459,1,'2025-01-05 04:40:44','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(460,1,'2025-01-05 04:40:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(461,1,'2025-01-05 04:40:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(462,1,'2025-01-05 04:40:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(463,1,'2025-01-05 04:40:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(464,1,'2025-01-05 04:40:45','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(465,1,'2025-01-05 04:40:47','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(466,1,'2025-01-05 04:40:47','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(467,1,'2025-01-05 04:40:47','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(468,1,'2025-01-05 04:40:48','musteriler','Veri Çekme','Müşteri bilgileri çekildi.'),(469,5003,'2025-01-05 04:41:05','siparisler','Veri Çekme','Sipariş bilgileri görüntülendi.'),(470,5003,'2025-01-05 04:41:06','musteriler','Veri Çekme','Müşteri bilgileri görüntülendi.'),(471,1,'2025-01-05 04:42:13','calisanlar','İptal','Çalışan düzenleme işlemi iptal edildi.'),(472,1,'2025-01-05 05:09:08','kullanicilar','Güncelleme','Kullanıcı bilgileri güncellendi: Yönetici Bir');
/*!40000 ALTER TABLE `loglar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musteriler`
--

DROP TABLE IF EXISTS `musteriler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musteriler` (
  `musteri_id` int NOT NULL AUTO_INCREMENT,
  `kullanici_id` int NOT NULL,
  `borc_durumu` decimal(10,2) DEFAULT '0.00',
  `toplam_alacak` decimal(10,2) DEFAULT '0.00',
  `hesap_durumu` tinyint(1) DEFAULT '0',
  `telefon` varchar(15) DEFAULT NULL,
  `eposta` varchar(255) DEFAULT NULL,
  `adres` text,
  `kayit_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`musteri_id`),
  KEY `kullanici_id` (`kullanici_id`),
  CONSTRAINT `musteriler_ibfk_1` FOREIGN KEY (`kullanici_id`) REFERENCES `kullanicilar` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musteriler`
--

LOCK TABLES `musteriler` WRITE;
/*!40000 ALTER TABLE `musteriler` DISABLE KEYS */;
INSERT INTO `musteriler` VALUES (1,5001,100.00,0.00,0,'09876543211','merhaba@example.com','Ad','2025-01-03 12:45:25'),(2,5002,0.00,0.00,0,'5552345678',NULL,'Adres 2','2025-01-03 12:45:25'),(4,5003,0.00,0.00,0,'1234567911','mehmet@example.com','ddd','2025-01-05 04:40:31');
/*!40000 ALTER TABLE `musteriler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siparis_urunler`
--

DROP TABLE IF EXISTS `siparis_urunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siparis_urunler` (
  `siparis_id` int NOT NULL,
  `urun_id` int NOT NULL,
  `miktar` int DEFAULT '1',
  `birim_fiyat` decimal(10,2) DEFAULT '0.00',
  `toplam_fiyat` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`siparis_id`,`urun_id`),
  KEY `urun_id` (`urun_id`),
  CONSTRAINT `siparis_urunler_ibfk_1` FOREIGN KEY (`siparis_id`) REFERENCES `siparisler` (`siparis_id`),
  CONSTRAINT `siparis_urunler_ibfk_2` FOREIGN KEY (`urun_id`) REFERENCES `urunler` (`urun_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparis_urunler`
--

LOCK TABLES `siparis_urunler` WRITE;
/*!40000 ALTER TABLE `siparis_urunler` DISABLE KEYS */;
INSERT INTO `siparis_urunler` VALUES (1,1,2,1350.00,2700.00),(2,2,1,13500.00,13500.00),(3,1,3,2500.00,7500.00);
/*!40000 ALTER TABLE `siparis_urunler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `siparisler`
--

DROP TABLE IF EXISTS `siparisler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `siparisler` (
  `siparis_id` int NOT NULL AUTO_INCREMENT,
  `musteri_id` int NOT NULL,
  `siparis_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  `toplam_tutar` decimal(10,2) DEFAULT '0.00',
  `siparis_durumu` enum('Hazirlaniyor','Tamamlandi','Iptal') DEFAULT 'Hazirlaniyor',
  PRIMARY KEY (`siparis_id`),
  KEY `siparisler_ibfk_1` (`musteri_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparisler`
--

LOCK TABLES `siparisler` WRITE;
/*!40000 ALTER TABLE `siparisler` DISABLE KEYS */;
INSERT INTO `siparisler` VALUES (17,5001,'2025-01-05 03:17:18',150.00,'Hazirlaniyor'),(18,5002,'2025-01-05 03:28:45',14.00,'Hazirlaniyor');
/*!40000 ALTER TABLE `siparisler` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_siparis_ekleme` AFTER INSERT ON `siparisler` FOR EACH ROW BEGIN
    INSERT INTO loglar (kullanici_id, tablo_adi, islem_tipi, detaylar)
    VALUES (
        NEW.musteri_id,
        'siparisler',
        'Ekleme',
        CONCAT('Yeni sipariş eklendi (id: ', NEW.siparis_id, ') - toplam tutar: ', NEW.toplam_tutar)
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `log_siparis_silme` AFTER DELETE ON `siparisler` FOR EACH ROW BEGIN
    INSERT INTO loglar (kullanici_id, tablo_adi, islem_tipi, detaylar)
    VALUES (
        OLD.musteri_id,
        'siparisler',
        'Silme',
        CONCAT('Sipariş silindi (id: ', OLD.siparis_id, ')')
    );
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `urunler`
--

DROP TABLE IF EXISTS `urunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `urunler` (
  `urun_id` int NOT NULL AUTO_INCREMENT,
  `urun_adi` varchar(255) NOT NULL,
  `stok_miktari` int DEFAULT '0',
  `fiyat` decimal(10,2) DEFAULT '0.00',
  `eklenme_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  `guncellenme_tarihi` datetime DEFAULT NULL,
  PRIMARY KEY (`urun_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `urunler`
--

LOCK TABLES `urunler` WRITE;
/*!40000 ALTER TABLE `urunler` DISABLE KEYS */;
INSERT INTO `urunler` VALUES (1,'Laptop',8,1350.00,'2024-12-17 03:24:45','2024-12-17 03:24:45'),(2,'Gaming Monitor',3,7.00,'2024-12-17 03:24:45','2024-12-31 08:17:49'),(3,'Klavye',20,5000.00,'2024-12-17 03:24:45','2024-12-31 04:36:14'),(4,'Mouse',15,500.00,'2024-12-17 03:24:45','2024-12-31 03:48:23'),(5,'ürünid sıkıntı çıkarırsa naneyi yeriz',10,80.00,'2024-12-31 04:37:29',NULL),(6,'çalışıyoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo',2,99.00,'2024-12-31 04:38:12','2025-01-05 02:43:24'),(7,'bravo bana lan amq',3,33.00,'2024-12-31 04:38:54',NULL),(8,'saat 5 oluyo amq',2,38.00,'2024-12-31 04:39:11','2025-01-01 19:46:48'),(9,'deneme',1,1.00,'2025-01-03 17:35:13',NULL),(10,'deneme',2,22.00,'2025-01-05 04:38:46',NULL);
/*!40000 ALTER TABLE `urunler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yoneticiler`
--

DROP TABLE IF EXISTS `yoneticiler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yoneticiler` (
  `yonetici_id` int NOT NULL AUTO_INCREMENT,
  `kullanici_id` int NOT NULL,
  PRIMARY KEY (`yonetici_id`),
  KEY `kullanici_id` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yoneticiler`
--

LOCK TABLES `yoneticiler` WRITE;
/*!40000 ALTER TABLE `yoneticiler` DISABLE KEYS */;
INSERT INTO `yoneticiler` VALUES (1,1),(2,2);
/*!40000 ALTER TABLE `yoneticiler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-05  5:46:02
