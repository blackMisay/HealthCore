-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               11.4.3-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for healthcore
CREATE DATABASE IF NOT EXISTS `healthcore` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `healthcore`;

-- Dumping structure for table healthcore.allergies
CREATE TABLE IF NOT EXISTS `allergies` (
  `allergies_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`allergies_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.employee
CREATE TABLE IF NOT EXISTS `employee` (
  `employee_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `position_id` int(11) NOT NULL,
  `address` text NOT NULL,
  `mobile_number` varchar(18) NOT NULL,
  `phone_number` varchar(18) DEFAULT NULL,
  `email` varchar(30) NOT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.illness
CREATE TABLE IF NOT EXISTS `illness` (
  `illness_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`illness_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.immunization
CREATE TABLE IF NOT EXISTS `immunization` (
  `immunization_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`immunization_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.laboratories
CREATE TABLE IF NOT EXISTS `laboratories` (
  `laboratories_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`laboratories_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.medical_questions
CREATE TABLE IF NOT EXISTS `medical_questions` (
  `medical_question_id` int(11) NOT NULL AUTO_INCREMENT,
  `question_tag_id` int(11) NOT NULL,
  `question` text NOT NULL,
  PRIMARY KEY (`medical_question_id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.patients
CREATE TABLE IF NOT EXISTS `patients` (
  `patient_id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) NOT NULL,
  `birth_date` date NOT NULL,
  `age` smallint(6) NOT NULL,
  `gender` varchar(30) NOT NULL,
  `civil_status` varchar(30) DEFAULT NULL,
  `mobile_number` varchar(18) DEFAULT NULL,
  `address` text DEFAULT NULL,
  `guardian_name` varchar(100) DEFAULT NULL,
  `guardian_occupation` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.patient_medical_history
CREATE TABLE IF NOT EXISTS `patient_medical_history` (
  `patient_medical_history_id` int(11) NOT NULL,
  `allergies` varchar(100) NOT NULL,
  `illness` varchar(100) NOT NULL,
  `surgeries` varchar(100) NOT NULL,
  `immunization` varchar(100) NOT NULL,
  `physical_exam` varchar(100) NOT NULL,
  `laboratories` varchar(100) NOT NULL,
  PRIMARY KEY (`patient_medical_history_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.patient_medical_questions
CREATE TABLE IF NOT EXISTS `patient_medical_questions` (
  `patient_medical_question_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_id` int(11) NOT NULL,
  `medical_question_id` int(11) NOT NULL,
  `response` enum('Yes','No') NOT NULL,
  `remarks` text NOT NULL,
  PRIMARY KEY (`patient_medical_question_id`),
  KEY `fk_patients` (`patient_id`),
  KEY `fk_medical_questions` (`medical_question_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.physical_exam
CREATE TABLE IF NOT EXISTS `physical_exam` (
  `physical_exam_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`physical_exam_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.position
CREATE TABLE IF NOT EXISTS `position` (
  `position_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  `specialization` varchar(100) NOT NULL,
  PRIMARY KEY (`position_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.question_tags
CREATE TABLE IF NOT EXISTS `question_tags` (
  `question_tag_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`question_tag_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

-- Dumping structure for table healthcore.surgeries
CREATE TABLE IF NOT EXISTS `surgeries` (
  `surgeries_id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  PRIMARY KEY (`surgeries_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
