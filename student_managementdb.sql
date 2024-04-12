-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 12, 2024 at 04:26 PM
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
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` int(11) NOT NULL,
  `isBlocked` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `username`, `password`, `level`, `isBlocked`) VALUES
(1, '215052066', 'E10ADC3949BA59ABBE56E057F20F883E', 2, 0),
(3, '215052001', '202CB962AC59075B964B07152D234B70', 2, 0),
(7, '215052002', 'E10ADC3949BA59ABBE56E057F20F883E', 0, 0),
(8, '215052011', '202CB962AC59075B964B07152D234B70', 2, 1),
(9, '215052012', '202CB962AC59075B964B07152D234B70', 2, 0),
(10, '215052013', '202CB962AC59075B964B07152D234B70', 2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `capacity` int(11) NOT NULL,
  `state` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id`, `course_id`, `name`, `capacity`, `state`) VALUES
(9, 17, 'Class 2', 10, 'Opened'),
(12, 17, 'Class 3', 50, 'Ongoing'),
(22, 17, 'Class A', 12, 'Opened'),
(23, 10, 'Class B', 12, 'Ongoing'),
(24, 14, 'Class 4', 15, 'Ongoing'),
(25, 16, 'Class 1', 25, 'Ongoing');

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `credits` int(11) NOT NULL,
  `isOpen` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`id`, `name`, `description`, `credits`, `isOpen`) VALUES
(1, 'Introduction To CS', 'Beginner', 1, 0),
(2, 'Data Structures', 'Linked lists, trees, and algorithms', 3, 0),
(4, 'English Literature', 'Analysis of literary works from various periods', 3, 1),
(5, 'Calculus 2', 'Next part', 0, 1),
(10, 'Test Course B', 's', 2, 1),
(13, 'Test Course C', '123', 1, 1),
(14, 'Test Course D', '123', 1, 1),
(15, 'Test Course E', '123', 1, 1),
(16, 'Test Course F', 'Next test', 1, 1),
(17, 'Test Course A', 'Test', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `enrollments`
--

CREATE TABLE `enrollments` (
  `id` int(11) NOT NULL,
  `class_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollments`
--

INSERT INTO `enrollments` (`id`, `class_id`, `student_id`, `created_at`) VALUES
(4, 9, 215052011, '2024-04-10 13:39:48'),
(5, 23, 215052012, '2024-04-10 13:42:26'),
(6, 22, 215052012, '2024-04-10 13:55:21'),
(7, 9, 215052012, '2024-04-10 13:56:31'),
(8, 12, 215052012, '2024-04-12 02:07:12'),
(9, 12, 215052011, '2024-04-12 02:07:28'),
(10, 12, 215052013, '2024-04-12 02:07:36'),
(11, 24, 215052012, '2024-04-12 05:36:07'),
(12, 24, 215052011, '2024-04-12 05:36:10'),
(13, 25, 215052012, '2024-04-12 07:40:42'),
(14, 25, 215052013, '2024-04-12 07:40:45'),
(15, 25, 215052014, '2024-04-12 07:40:49'),
(16, 25, 215052015, '2024-04-12 07:40:53');

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `id` int(11) NOT NULL,
  `enrollment_id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `grade` char(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`id`, `enrollment_id`, `type`, `grade`) VALUES
(1, 5, 'Progress', 'D'),
(2, 5, 'Midterm', 'F'),
(3, 5, 'Final', 'D'),
(4, 5, 'Overall', 'F'),
(5, 4, 'Progress', 'A'),
(6, 4, 'Midterm', 'B+'),
(7, 4, 'Final', 'D'),
(8, 4, 'Overall', 'C'),
(9, 4, 'Progress', 'A'),
(10, 4, 'Midterm', 'B+'),
(11, 4, 'Final', 'D'),
(12, 4, 'Overall', 'C'),
(13, 7, 'Progress', 'B+'),
(14, 7, 'Midterm', 'B'),
(15, 7, 'Final', 'A'),
(16, 7, 'Overall', 'B+'),
(17, 8, 'Progress', 'F'),
(18, 8, 'Midterm', 'A'),
(19, 8, 'Final', 'C'),
(20, 8, 'Overall', 'D'),
(21, 9, 'Progress', 'C+'),
(22, 9, 'Midterm', 'C'),
(23, 9, 'Final', 'B+'),
(24, 9, 'Overall', 'C+'),
(25, 10, 'Progress', 'A'),
(26, 10, 'Midterm', 'A'),
(27, 10, 'Final', 'A'),
(28, 10, 'Overall', 'A'),
(49, 5, 'Progress', 'D'),
(50, 5, 'Midterm', 'F'),
(51, 5, 'Final', 'D'),
(52, 5, 'Overall', 'F');

-- --------------------------------------------------------

--
-- Table structure for table `rechecks`
--

CREATE TABLE `rechecks` (
  `id` int(11) NOT NULL,
  `grade_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `schedules`
--

CREATE TABLE `schedules` (
  `id` int(11) NOT NULL,
  `enrollment_id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedules`
--

INSERT INTO `schedules` (`id`, `enrollment_id`, `type`, `date`) VALUES
(116, 13, 'Exam', '2024-04-17'),
(117, 14, 'Exam', '2024-04-17'),
(118, 15, 'Exam', '2024-04-17'),
(119, 16, 'Exam', '2024-04-17'),
(120, 5, 'Timetable', '2024-04-18'),
(121, 11, 'Exam', '2024-04-25'),
(122, 12, 'Exam', '2024-04-25'),
(123, 8, 'Timetable', '2024-04-27'),
(124, 9, 'Timetable', '2024-04-27'),
(125, 10, 'Timetable', '2024-04-27');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `birthdate` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `name`, `birthdate`, `email`, `created_at`) VALUES
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
(215052014, 'Nguyen Van D', '2024-03-23', 'email@email', '2024-03-24 13:01:57'),
(215052015, 'Nguyen Van E', '2024-03-23', 'email@email', '2024-03-24 13:02:03'),
(215052016, 'Nguyen Van F', '2024-03-23', 'email@email', '2024-03-24 13:02:08'),
(215052017, 'Nguyen Van G', '2024-03-23', 'email@email', '2024-03-24 13:02:15'),
(215052018, 'Nguyen Van H', '2024-03-23', 'email@email', '2024-03-24 13:02:19'),
(215052019, 'Nguyen Van I', '2024-03-23', 'email@email', '2024-03-24 13:02:23'),
(215052020, 'Nguyen Van J', '2024-03-23', 'email@email', '2024-03-24 13:02:30'),
(215052066, 'Nguyễn Khánh Duy', '2003-11-22', 'duynk21@uef.edu.vn', '2024-03-10 09:49:34');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIQUE(Username)` (`username`);

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UNIPE_ClassName` (`name`),
  ADD KEY `FK_course_id` (`course_id`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Name` (`name`);

--
-- Indexes for table `enrollments`
--
ALTER TABLE `enrollments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Enrollment_Class` (`class_id`),
  ADD KEY `FK_Enrollment_Student` (`student_id`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Gradee_Enrollment` (`enrollment_id`);

--
-- Indexes for table `rechecks`
--
ALTER TABLE `rechecks`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Recheck_Grade` (`grade_id`);

--
-- Indexes for table `schedules`
--
ALTER TABLE `schedules`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Schedule_Enrollment` (`enrollment_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `enrollments`
--
ALTER TABLE `enrollments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `grades`
--
ALTER TABLE `grades`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT for table `rechecks`
--
ALTER TABLE `rechecks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `schedules`
--
ALTER TABLE `schedules`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=126;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `FK_CourseId_Classes` FOREIGN KEY (`course_id`) REFERENCES `courses` (`id`),
  ADD CONSTRAINT `FK_course_id` FOREIGN KEY (`course_id`) REFERENCES `courses` (`id`);

--
-- Constraints for table `enrollments`
--
ALTER TABLE `enrollments`
  ADD CONSTRAINT `FK_Enrollment_Class` FOREIGN KEY (`class_id`) REFERENCES `classes` (`id`),
  ADD CONSTRAINT `FK_Enrollment_Student` FOREIGN KEY (`student_id`) REFERENCES `students` (`id`);

--
-- Constraints for table `grades`
--
ALTER TABLE `grades`
  ADD CONSTRAINT `FK_Gradee_Enrollment` FOREIGN KEY (`enrollment_id`) REFERENCES `enrollments` (`id`);

--
-- Constraints for table `rechecks`
--
ALTER TABLE `rechecks`
  ADD CONSTRAINT `FK_Recheck_Grade` FOREIGN KEY (`grade_id`) REFERENCES `grades` (`id`);

--
-- Constraints for table `schedules`
--
ALTER TABLE `schedules`
  ADD CONSTRAINT `FK_Schedule_Enrollment` FOREIGN KEY (`enrollment_id`) REFERENCES `enrollments` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
