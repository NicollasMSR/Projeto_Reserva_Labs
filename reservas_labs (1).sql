-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24/11/2024 às 01:58
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
  `id` int(11) NOT NULL,
  `local_reserva` varchar(50) DEFAULT NULL,
  `data_reserva` varchar(10) DEFAULT NULL,
  `dia_semana` varchar(50) DEFAULT NULL,
  `horario_inicial` varchar(5) DEFAULT NULL,
  `horario_final` varchar(5) DEFAULT NULL,
  `curso` varchar(50) DEFAULT NULL,
  `ano` varchar(20) DEFAULT NULL,
  `prof_resp` varchar(100) DEFAULT NULL,
  `reserva_fixa` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `reserva`
--

INSERT INTO `reserva` (`id`, `local_reserva`, `data_reserva`, `dia_semana`, `horario_inicial`, `horario_final`, `curso`, `ano`, `prof_resp`, `reserva_fixa`) VALUES
(1, 'LABORATÓRIO 1 (Aquário)', '25/11/2024', '', '07:00', '08:40', 'MEIO AMBIENTE', '2° SEGUNDO', 'XXXXXX XXXXXX', 'NÃO'),
(2, 'LABORATÓRIO 2', '  /  /', 'TODA TERÇA-FEIRA', '08:40', '12:20', 'DESENVOLVIMENTO DE SISTEMAS ', '3° TERCEIRO', 'XXXXXX XXXXXXX', 'SIM'),
(3, 'LABORATÓRIO 3 ', '  /  /', 'TODA SEGUNDA-FEIRA', '09:50', '12:20', 'SECRETARIADO', '2° SEGUNDO', 'ZZZZZZZZ ZZZZZZ', 'SIM'),
(4, 'LABORATÓRIO DE QUÍMICA ', '28/11/2024', '', '13:20', '15:00', 'DESENVOLVIMENTO DE SISTEMAS ', '2° SEGUNDO', 'ZZZZZZZ ZZZZZZZ', 'NÃO'),
(5, 'SALA MAKER', '27/11/2024', '', '11:30', '12:20', 'SECRETARIADO', '1° PRIMEIRO ', 'YYYYYYY YYYYYY', 'NÃO'),
(6, 'SIBÉRIA', '  /  /', 'TODA QUARTA-FEIRA', '15:00', '15:50', 'DESIGN DE INTERIORES', '1° PRIMEIRO ', 'YYYYYYY YYYYYY', 'SIM'),
(7, 'AUDITÓRIO', '26/11/2024', '', '09:50', '12:20', 'HOSPEDAGEM', '3° TERCEIRO', 'AAAAAA  AAAAAA', 'NÃO');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
