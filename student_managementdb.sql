-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 16, 2024 at 01:55 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

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
(1, 'Introduction to CS', 'Basic programming concepts in Python', 3, 0),
(2, 'Data Structures', 'Linked lists, trees, and algorithms', 3, 0),
(3, 'Calculus I', 'Limits, derivatives, and integrals', 4, 0),
(4, 'English Literature', 'Analysis of literary works from various periods', 3, 1),
(5, 'Calculus 2', 'Next part', 0, 1),
(9, 'Test Course 1', 'Info1', 1, 1),
(10, 'Test Course 4', 'ss', 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbgrade`
--

CREATE TABLE `tbgrade` (
  `StudentId` int(11) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `Grade` char(2) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbgrade`
--

INSERT INTO `tbgrade` (`StudentId`, `CourseId`, `Grade`, `created_at`) VALUES
(205555, 9, NULL, '2024-03-15 16:10:29'),
(215052011, 9, 'D', '2024-03-15 14:22:17'),
(215052011, 10, NULL, '2024-03-15 14:45:05'),
(215052012, 9, NULL, '2024-03-15 14:44:37'),
(215052012, 10, NULL, '2024-03-15 14:45:12'),
(215052013, 9, 'B+', '2024-03-16 00:28:37');

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
(1, 'A', '2024-03-11', 'A', '2024-03-11 01:27:59'),
(2, 'ABCD', '2024-03-11', 'abc', '2024-03-11 02:29:02'),
(3, 'abcde', '2024-03-12', 'dsss', '2024-03-12 03:12:30'),
(123, 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa', '2024-03-11', 'email@emai', '2024-03-12 13:22:12'),
(1011, 'John Smith', '2024-03-11', '', '2024-03-11 14:57:16'),
(1012, 'Pablo Escobar', '2024-03-11', '', '2024-03-11 14:57:35'),
(1013, 'Andrea', '2024-03-11', '', '2024-03-11 14:57:46'),
(1014, 'John Dele', '2024-03-11', '', '2024-03-11 14:57:55'),
(1015, 'Pablo Santos', '2024-03-11', '', '2024-03-11 14:58:07'),
(1016, 'Pablo Doe', '2024-03-11', '', '2024-03-11 14:58:22'),
(198888, 'NKDsdsss', '2024-03-14', 'duynk@211', '2024-03-15 10:09:13'),
(205555, 'NKDsdsss', '2024-03-14', 'duynk@21', '2024-03-15 10:09:06'),
(215052011, 'Nguyen Van A', '2024-03-14', 'duynk@21', '2024-03-15 10:08:43'),
(215052012, 'Nguyen Van A', '2024-03-14', 'duynk@21', '2024-03-15 10:08:46'),
(215052013, 'Nguyen Van C', '2024-03-14', 'duynk@21', '2024-03-15 10:08:48'),
(215052066, 'Nguyễn Khánh Duy', '2003-11-22', 'duynk21@uef.edu.vn', '2024-03-10 09:49:34');

--
-- Indexes for dumped tables
--

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
  ADD PRIMARY KEY (`StudentId`,`CourseId`),
  ADD KEY `CourseId` (`CourseId`);

--
-- Indexes for table `tbstudent`
--
ALTER TABLE `tbstudent`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbcourse`
--
ALTER TABLE `tbcourse`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbgrade`
--
ALTER TABLE `tbgrade`
  ADD CONSTRAINT `tbgrade_ibfk_1` FOREIGN KEY (`StudentId`) REFERENCES `tbstudent` (`id`),
  ADD CONSTRAINT `tbgrade_ibfk_2` FOREIGN KEY (`CourseId`) REFERENCES `tbcourse` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
