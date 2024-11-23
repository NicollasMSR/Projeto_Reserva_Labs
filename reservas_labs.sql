-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23/11/2024 às 18:18
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `reservas_labs`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `login`
--

CREATE TABLE `login` (
  `nome` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `senha` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `login`
--

INSERT INTO `login` (`nome`, `email`, `senha`) VALUES
('Nicollas Miguel', 'nicollas.reis@etec.sp.gov.br', '12345');

-- --------------------------------------------------------

--
-- Estrutura para tabela `reserva`
--

CREATE TABLE `reserva` (
  `local_reserva` varchar(30) DEFAULT NULL,
  `data_reserva` varchar(12) DEFAULT NULL,
  `dia_semana` varchar(30) DEFAULT NULL,
  `horario_incial` varchar(5) DEFAULT NULL,
  `horario_final` varchar(5) DEFAULT NULL,
  `curso` varchar(30) DEFAULT NULL,
  `ano` varchar(20) DEFAULT NULL,
  `prof_resp` varchar(100) DEFAULT NULL,
  `reserva_fixa` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `reserva`
--

INSERT INTO `reserva` (`local_reserva`, `data_reserva`, `dia_semana`, `horario_incial`, `horario_final`, `curso`, `ano`, `prof_resp`, `reserva_fixa`) VALUES
('LABORATÓRIO 3 ', '  /  /', 'TODA SEGUNDA-FEIRA', '08:40', '12:20', 'DESENVOLVIMENTO DE SISTEMAS ', '2° SEGUNDO', 'Marcio Ferraz', 'SIM'),
('LABORATÓRIO DE QUÍMICA ', '19/11/2024', '', '13:20', '15:00', 'DESENVOLVIMENTO DE SISTEMAS ', '2° SEGUNDO', 'Claudemir Borgo', 'NÃO'),
('LABORATÓRIO 2', '18/11/2024', '', '07:00', '08:40', 'MEIO AMBIENTE', '2° SEGUNDO', 'Simoni', 'NÃO'),
('LABORATÓRIO 3 ', '20/11/2024', 'TODA SEGUNDA-FEIRA', '07:00', '08:40', 'MEIO AMBIENTE', '1° PRIMEIRO ', 'vccvcv', 'NÃO');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
