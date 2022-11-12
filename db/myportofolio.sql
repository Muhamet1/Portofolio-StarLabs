-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2022 at 10:13 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `myportofolio`
--

-- --------------------------------------------------------

--
-- Table structure for table `contacts`
--

CREATE TABLE `contacts` (
  `contactId` int(11) NOT NULL,
  `contactName` longtext NOT NULL,
  `contactEmail` longtext NOT NULL,
  `contactMessage` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`contactId`, `contactName`, `contactEmail`, `contactMessage`) VALUES
(11, 'test', 'test@test.com', 'test message');

-- --------------------------------------------------------

--
-- Table structure for table `photos`
--

CREATE TABLE `photos` (
  `Id` varchar(255) NOT NULL,
  `Url` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `projectId` int(11) NOT NULL,
  `projectTitle` longtext NOT NULL,
  `projectSubTitle` longtext NOT NULL,
  `projectDescription` longtext NOT NULL,
  `projectLink` longtext NOT NULL,
  `PhotoNum` longtext NOT NULL,
  `PhotoUrl` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`projectId`, `projectTitle`, `projectSubTitle`, `projectDescription`, `projectLink`, `PhotoNum`, `PhotoUrl`) VALUES
(9, 'Ecommerce', '.NET MVC & MSSQL', 'Full Stack Website with .NET MVC Framework. Add to cart functionality, Role based authentication and Authorization, Admin Dashboard, Filter Products by(Category, Price), Checkout, Image Upload-Cloudinary API, Ajax Jquery(Live Search).', 'https://github.com/Muhamet1/MVCProject', 'd0qjk3ivzrolgyabcctg', 'https://res.cloudinary.com/du95cvqb3/image/upload/v1668171079/d0qjk3ivzrolgyabcctg.jpg'),
(10, 'TechEcommerce', '.NET & React & TypeScript & MSSQL', 'E-Commerce-Full Stack Website with .NET 6.0 and React Js. RESTful APIs using Mediator and CQRS Pattern. Role based authentication and authorization, MobX for state management, Axios.', 'https://github.com/agon-ademaj/techecommerce', 'wypavesb7dmphsfvkku3', 'https://res.cloudinary.com/du95cvqb3/image/upload/v1668171158/wypavesb7dmphsfvkku3.png'),
(11, 'Techshop', 'PHP & JavaScript & MYSQL', 'E-Commerce-Full Stack Website with PHP and JavaScript. Backend part with PHP and Frontend JavaScript,HTML ,CSS.', 'https://github.com/mk51086/techshop', 'rumfynw3swaw3r1dah9m', 'https://res.cloudinary.com/du95cvqb3/image/upload/v1668171219/rumfynw3swaw3r1dah9m.jpg'),
(12, 'MyPortofolio', 'React & TailwindCss', 'MyPortofolio-Front EndWebsite using React and TailwindCss framework for styling.', 'https://muhamet1.github.io/MyPortofolio/', 'mxfsuqt0ybxwnjayidyg', 'https://res.cloudinary.com/du95cvqb3/image/upload/v1668171275/mxfsuqt0ybxwnjayidyg.png');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20221110112701_InitialCreate', '6.0.7');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`contactId`);

--
-- Indexes for table `photos`
--
ALTER TABLE `photos`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`projectId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `contactId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `projects`
--
ALTER TABLE `projects`
  MODIFY `projectId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
