-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Gegenereerd op: 10 mrt 2022 om 14:27
-- Serverversie: 8.0.27
-- PHP-versie: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_quiztime`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quiz`
--

CREATE TABLE `quiz` (
  `quiz_id` int NOT NULL,
  `quiz_name` varchar(50) DEFAULT NULL,
  `quiz_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Gegevens worden geëxporteerd voor tabel `quiz`
--

INSERT INTO `quiz` (`quiz_id`, `quiz_name`, `quiz_date`) VALUES
(2, 'star wars', '2022-03-10 09:50:37');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quiz_answers`
--

CREATE TABLE `quiz_answers` (
  `answers_id` int NOT NULL,
  `questions_id` int DEFAULT NULL,
  `answers` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `right_answer` tinyint DEFAULT NULL,
  `answers_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Gegevens worden geëxporteerd voor tabel `quiz_answers`
--

INSERT INTO `quiz_answers` (`answers_id`, `questions_id`, `answers`, `right_answer`, `answers_date`) VALUES
(13, 3, 'Episode 1, the Phantom Mecance', 0, '2022-03-10 10:02:58'),
(14, 3, 'Episode 4, a New hope', 0, '2022-03-10 10:02:58'),
(15, 3, 'Episode 5, the Empire strikes back', 0, '2022-03-10 10:02:58'),
(16, 3, 'Episode 3: Revenge of the Sith', 1, '2022-03-10 10:02:59'),
(17, 4, 'Obi Wan Kenobi', 0, '2022-03-10 10:03:54'),
(18, 4, 'Han Solo', 1, '2022-03-10 10:03:54'),
(19, 4, 'Darth Vader', 0, '2022-03-10 10:03:55'),
(20, 4, 'Luke Skywalker', 0, '2022-03-10 10:03:55'),
(21, 5, 'Anakin Skywalker', 1, '2022-03-10 10:05:22'),
(22, 5, 'Obi Wan Kenobi', 0, '2022-03-10 10:05:22'),
(23, 5, 'Luke Skywalker', 0, '2022-03-10 10:05:22'),
(24, 5, 'Mace Windu', 0, '2022-03-10 10:05:22'),
(25, 6, 'Bib Fortuna', 0, '2022-03-10 10:06:14'),
(26, 6, 'Jabba The Hutt', 1, '2022-03-10 10:06:14'),
(27, 6, 'Jarjar Binks', 0, '2022-03-10 10:06:15'),
(28, 6, 'Jango Fett', 0, '2022-03-10 10:06:15'),
(29, 7, 'Imperial Shuttle', 0, '2022-03-10 10:07:08'),
(30, 7, 'a-wing', 0, '2022-03-10 10:07:08'),
(31, 7, 'Slave I', 1, '2022-03-10 10:07:08'),
(32, 7, 'Millenium Falcon', 0, '2022-03-10 10:07:08');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quiz_questions`
--

CREATE TABLE `quiz_questions` (
  `question_id` int NOT NULL,
  `quiz_id` int DEFAULT NULL,
  `quiz_questions` varchar(255) DEFAULT NULL,
  `question_image` varchar(255) DEFAULT NULL,
  `questions_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Gegevens worden geëxporteerd voor tabel `quiz_questions`
--

INSERT INTO `quiz_questions` (`question_id`, `quiz_id`, `quiz_questions`, `question_image`, `questions_date`) VALUES
(3, 2, 'In welke episode word de Death Star gebouwd?', 'C:\\Users\\Rowan\\Pictures\\quiztime\\deathstar.jpg', '2022-03-10 10:16:24'),
(4, 2, 'Wie vermoordt Greedo in Episode 4, A New Hope?', 'C:\\Users\\Rowan\\Pictures\\quiztime\\Greedo.jpg', '2022-03-10 10:16:41'),
(5, 2, 'Welke Jedi word getransformeerd in Darth Vader?', 'C:\\Users\\Rowan\\Pictures\\quiztime\\darthVader.jpg', '2022-03-10 10:16:51'),
(6, 2, 'wie geeft het startsein bij de podrace in Episode 1, The Phantom Mecance?', 'C:\\Users\\Rowan\\Pictures\\quiztime\\podrace.jpg', '2022-03-10 10:17:00'),
(7, 2, 'Welk schip is van Boba Fett?', 'C:\\Users\\Rowan\\Pictures\\quiztime\\bobafett.jpg', '2022-03-10 10:15:16');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `quiz`
--
ALTER TABLE `quiz`
  ADD PRIMARY KEY (`quiz_id`);

--
-- Indexen voor tabel `quiz_answers`
--
ALTER TABLE `quiz_answers`
  ADD PRIMARY KEY (`answers_id`),
  ADD KEY `questions_id_idx` (`questions_id`);

--
-- Indexen voor tabel `quiz_questions`
--
ALTER TABLE `quiz_questions`
  ADD PRIMARY KEY (`question_id`),
  ADD KEY `quiz_id_idx` (`quiz_id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `quiz`
--
ALTER TABLE `quiz`
  MODIFY `quiz_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT voor een tabel `quiz_answers`
--
ALTER TABLE `quiz_answers`
  MODIFY `answers_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT voor een tabel `quiz_questions`
--
ALTER TABLE `quiz_questions`
  MODIFY `question_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `quiz_answers`
--
ALTER TABLE `quiz_answers`
  ADD CONSTRAINT `questions_id` FOREIGN KEY (`questions_id`) REFERENCES `quiz_questions` (`question_id`);

--
-- Beperkingen voor tabel `quiz_questions`
--
ALTER TABLE `quiz_questions`
  ADD CONSTRAINT `quiz_id` FOREIGN KEY (`quiz_id`) REFERENCES `quiz` (`quiz_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
