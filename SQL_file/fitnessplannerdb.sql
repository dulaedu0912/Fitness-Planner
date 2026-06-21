-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 21, 2026 at 06:00 PM
-- Server version: 8.4.7
-- PHP Version: 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fitnessplannerdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `meals`
--

DROP TABLE IF EXISTS `meals`;
CREATE TABLE IF NOT EXISTS `meals` (
  `meal_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `calories` int NOT NULL,
  `protein_g` decimal(5,2) DEFAULT NULL,
  `carbs_g` decimal(5,2) DEFAULT NULL,
  `fat_g` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`meal_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `meals`
--

INSERT INTO `meals` (`meal_id`, `name`, `calories`, `protein_g`, `carbs_g`, `fat_g`) VALUES
(1, 'Grilled Chicken and Rice', 550, 40.00, 65.00, 12.00),
(2, 'Oatmeal with Peanut Butter & Banana', 420, 14.00, 60.00, 15.00),
(3, 'Baked Salmon with Quinoa', 610, 45.00, 48.00, 22.00),
(4, 'Greek Yogurt Berry Parfait', 280, 23.00, 35.00, 4.00),
(5, ' Protein Shake & Almonds', 350, 30.00, 15.00, 18.00),
(6, 'Lean Beef Stir Fry', 520, 38.00, 50.00, 14.00),
(7, 'Avocado Egg Toast', 390, 16.00, 32.00, 22.00);

-- --------------------------------------------------------

--
-- Table structure for table `usermealplans`
--

DROP TABLE IF EXISTS `usermealplans`;
CREATE TABLE IF NOT EXISTS `usermealplans` (
  `plan_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `plan_date` date NOT NULL,
  `meal_id` int NOT NULL,
  `meal_type` enum('Breakfast','Lunch','Dinner','Snack') COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`plan_id`),
  UNIQUE KEY `user_id` (`user_id`,`plan_date`,`meal_id`,`meal_type`),
  KEY `meal_id` (`meal_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `userprogress`
--

DROP TABLE IF EXISTS `userprogress`;
CREATE TABLE IF NOT EXISTS `userprogress` (
  `progress_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `log_date` date NOT NULL,
  `metric_type` enum('Weight','CaloriesIn','CaloriesOut','WorkoutCompleted') COLLATE utf8mb4_unicode_ci NOT NULL,
  `metric_value` decimal(10,2) NOT NULL,
  PRIMARY KEY (`progress_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password_hash` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `full_name` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `creation_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `full_name`, `creation_date`) VALUES
(1, 'dulara', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'dulara', '2026-06-21 23:22:23');

-- --------------------------------------------------------

--
-- Table structure for table `userworkoutplans`
--

DROP TABLE IF EXISTS `userworkoutplans`;
CREATE TABLE IF NOT EXISTS `userworkoutplans` (
  `plan_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `plan_date` date NOT NULL,
  `workout_id` int NOT NULL,
  `sets` int DEFAULT '3',
  `reps` int DEFAULT '10',
  PRIMARY KEY (`plan_id`),
  UNIQUE KEY `user_id` (`user_id`,`plan_date`,`workout_id`),
  KEY `workout_id` (`workout_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `workouts`
--

DROP TABLE IF EXISTS `workouts`;
CREATE TABLE IF NOT EXISTS `workouts` (
  `workout_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `target_muscle` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `approx_calories_burned` int DEFAULT NULL,
  PRIMARY KEY (`workout_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
