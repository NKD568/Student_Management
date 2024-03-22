-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2024 at 09:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student_managementdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbaccount`
--

CREATE TABLE `tbaccount` (
  `id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Level` int(11) NOT NULL,
  `isBlocked` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbaccount`
--

INSERT INTO `tbaccount` (`id`, `Username`, `Password`, `Level`, `isBlocked`) VALUES
(1, '215052066', 'E10ADC3949BA59ABBE56E057F20F883E', 2, 0),
(3, '215052001', '202CB962AC59075B964B07152D234B70', 2, 0),
(7, '215052002', 'E10ADC3949BA59ABBE56E057F20F883E', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbcourse`
--

CREATE TABLE `tbcourse` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` text NOT NULL,
  `Credits` int(11) NOT NULL,
  `isOpen` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbcourse`
--

INSERT INTO `tbcourse` (`id`, `Name`, `Description`, `Credits`, `isOpen`) VALUES
(1, 'Introduction To CS', 'Beginner', 1, 0),
(2, 'Data Structures', 'Linked lists, trees, and algorithms', 3, 0),
(4, 'English Literature', 'Analysis of literary works from various periods', 3, 1),
(5, 'Calculus 2', 'Next part', 0, 1),
(9, 'Test Course A', 'Info1', 1, 1),
(10, 'Test Course B', 'ss', 2, 1),
(13, 'Test Course C', '123', 1, 1),
(14, 'Test Course D', '123', 1, 1),
(15, 'Test Course E', '123', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbgrade`
--

CREATE TABLE `tbgrade` (
  `id` int(11) NOT NULL,
  `StudentId` int(11) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `Grade` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbgrade`
--

INSERT INTO `tbgrade` (`id`, `StudentId`, `CourseId`, `Grade`) VALUES
(15, 215052001, 9, NULL),
(16, 215052011, 9, NULL),
(17, 215052012, 9, NULL),
(19, 215052011, 10, NULL),
(20, 215052012, 10, NULL),
(22, 215052011, 13, NULL),
(24, 215052012, 13, NULL),
(31, 215052013, 10, NULL),
(32, 215052013, 13, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tbschedule`
--

CREATE TABLE `tbschedule` (
  `id` int(11) NOT NULL,
  `GradeId` int(11) NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbschedule`
--

INSERT INTO `tbschedule` (`id`, `GradeId`, `Date`) VALUES
(157, 15, '2024-03-21 00:00:00'),
(158, 16, '2024-03-21 00:00:00'),
(159, 17, '2024-03-21 00:00:00'),
(250, 19, '2024-03-26 00:00:00'),
(251, 20, '2024-03-26 00:00:00'),
(252, 31, '2024-03-26 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbstudent`
--

CREATE TABLE `tbstudent` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Birthdate` date NOT NULL,
  `Email` varchar(50) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbstudent`
--

INSERT INTO `tbstudent` (`id`, `Name`, `Birthdate`, `Email`, `created_at`) VALUES
(1011, 'John Smith', '2024-03-11', '', '2024-03-11 14:57:16'),
(1012, 'Pablo Escobar', '2024-03-11', '', '2024-03-11 14:57:35'),
(1013, 'Andrea', '2024-03-11', '', '2024-03-11 14:57:46'),
(1014, 'John Dele', '2024-03-11', '', '2024-03-11 14:57:55'),
(1015, 'Pablo Santos', '2024-03-11', '', '2024-03-11 14:58:07'),
(1016, 'Pablo Doe', '2024-03-11', '', '2024-03-11 14:58:22'),
(215052001, 'Test Student', '2024-03-07', 'teststudent@email.edu.vn', '2024-03-21 06:31:29'),
(215052011, 'Nguyen Van A', '2024-03-14', 'duynk@21', '2024-03-15 10:08:43'),
(215052012, 'Nguyen Van B', '2024-03-14', 'duynk@21', '2024-03-15 10:08:46'),
(215052013, 'Nguyen Van C', '2024-03-14', 'duynk@21', '2024-03-15 10:08:48'),
(215052066, 'Nguyễn Khánh Duy', '2003-11-22', 'duynk21@uef.edu.vn', '2024-03-10 09:49:34');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbaccount`
--
ALTER TABLE `tbaccount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQUE(Username)` (`Username`);

--
-- Indexes for table `tbcourse`
--
ALTER TABLE `tbcourse`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Indexes for table `tbgrade`
--
ALTER TABLE `tbgrade`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_StudentId` (`StudentId`),
  ADD KEY `FK_CourseId` (`CourseId`);

--
-- Indexes for table `tbschedule`
--
ALTER TABLE `tbschedule`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_GradeId` (`GradeId`);

--
-- Indexes for table `tbstudent`
--
ALTER TABLE `tbstudent`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbaccount`
--
ALTER TABLE `tbaccount`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbcourse`
--
ALTER TABLE `tbcourse`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbgrade`
--
ALTER TABLE `tbgrade`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `tbschedule`
--
ALTER TABLE `tbschedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=253;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbgrade`
--
ALTER TABLE `tbgrade`
  ADD CONSTRAINT `FK_CourseId` FOREIGN KEY (`CourseId`) REFERENCES `tbcourse` (`id`),
  ADD CONSTRAINT `FK_StudentId` FOREIGN KEY (`StudentId`) REFERENCES `tbstudent` (`id`),
  ADD CONSTRAINT `tbgrade_ibfk_1` FOREIGN KEY (`StudentId`) REFERENCES `tbstudent` (`id`),
  ADD CONSTRAINT `tbgrade_ibfk_2` FOREIGN KEY (`CourseId`) REFERENCES `tbcourse` (`id`);

--
-- Constraints for table `tbschedule`
--
ALTER TABLE `tbschedule`
  ADD CONSTRAINT `FK_GradeId` FOREIGN KEY (`GradeId`) REFERENCES `tbgrade` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
