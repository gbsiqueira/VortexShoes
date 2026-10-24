-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19/10/2026 às 13:27
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `vortexshoes`
--
CREATE DATABASE IF NOT EXISTS `vortexshoes` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `vortexshoes`;

-- --------------------------------------------------------

--
-- Estrutura para tabela `cargo`
--

CREATE TABLE `cargo` (
  `id_cargo` int(2) NOT NULL,
  `nome` varchar(40) NOT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `nome`, `observacao`, `status`, `data_cadastro`) VALUES
(1, 'administrador', 'Cargo para o funcionário administrador', b'1', '2026-10-18 17:15:32'),
(2, 'vendedor', '', b'1', '2026-10-18 17:15:33'),
(3, 'T.I', '', b'1', '2026-10-18 17:21:18'),
(4, 'Limpeza', '', b'1', '2026-10-18 17:28:29'),
(5, 'Atendente', '', b'1', '2026-10-18 17:28:44'),
(6, 'Administrativo', '', b'1', '2026-10-18 17:29:17'),
(7, 'Operacional', '', b'1', '2026-10-18 17:29:24'),
(8, 'Financeiro', '', b'1', '2026-10-18 17:29:31'),
(9, 'Juridico', '', b'1', '2026-10-18 17:29:37'),
(10, 'RH', '', b'1', '2026-10-18 17:29:45');

-- --------------------------------------------------------

--
-- Estrutura para tabela `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria` int(2) NOT NULL,
  `nome_categoria` varchar(40) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status_categoria` bit(1) NOT NULL,
  `observacao` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `nome_categoria`, `data_cadastro`, `status_categoria`, `observacao`) VALUES
(1, 'Corrida', '2026-10-18 17:24:10', b'1', ''),
(2, 'Confort', '2026-10-18 17:24:17', b'1', ''),
(3, 'Masculino', '2026-10-18 17:24:44', b'1', ''),
(4, 'Feminino', '2026-10-18 17:24:48', b'1', ''),
(5, 'Cano alto', '2026-10-18 17:26:35', b'1', ''),
(6, 'Tênis Casual', '2026-10-18 17:26:49', b'1', ''),
(7, 'Tenis Esportivo', '2026-10-18 17:26:55', b'1', '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(60) NOT NULL,
  `nome_social` varchar(60) DEFAULT NULL,
  `cpf_cliente` char(14) NOT NULL,
  `sexo_cliente` char(1) NOT NULL,
  `data_nascimento_cliente` date NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status_cliente` bit(1) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telefone_cliente` char(14) NOT NULL,
  `telefone_cliente2` char(14) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome_cliente`, `nome_social`, `cpf_cliente`, `sexo_cliente`, `data_nascimento_cliente`, `data_cadastro`, `status_cliente`, `email`, `telefone_cliente`, `telefone_cliente2`) VALUES
(1, 'Gabriel Siqueira', '', '334.543.234-25', 'm', '2000-01-01', '2026-10-18 17:30:36', b'1', 'gabrielsiqueira@gmail.com', '(43)53425-3425', ''),
(2, 'João Marcelo', '', '432.534.253-42', 'm', '2000-01-01', '2026-10-18 17:31:07', b'1', 'joao@gmail.,com', '(13)24132-4132', ''),
(3, 'Julia Souza', '', '553.523.453-24', 'f', '2000-01-05', '2026-10-18 17:31:45', b'1', 'julia@gmail.com', '(53)43245-3242', '(45)23452-3452'),
(4, 'Rafael Monieli', '', '234.523.452-25', 'm', '2000-01-05', '2026-10-18 17:32:53', b'1', 'rafael@gmail.com', '(53)42523-4534', '(41)32432-4132'),
(5, 'Paulo Menezes', '', '434.534.253-45', 'm', '2000-01-05', '2026-10-18 17:33:37', b'1', 'paulo@gmail.com', '(34)53425-3425', ''),
(6, 'Murilo Figato', '', '432.453.253-42', 'm', '2000-01-05', '2026-10-18 17:34:20', b'1', 'murilo@gmail.com', '(43)52345-2345', ''),
(7, 'Renata Gomes', '', '534.253.425-34', 'm', '2000-01-05', '2026-10-18 17:34:42', b'1', 'renata@gmail,com', '(52)34534-2523', ''),
(8, 'Henrique Gustavo', '', '523.453.425-34', 'm', '2000-01-05', '2026-10-18 17:35:25', b'1', 'Henrique@gmail.com', '(34)25342-5342', ''),
(9, 'Maria Romena', '', '432.413.243-23', 'f', '2000-01-05', '2026-10-18 17:36:06', b'1', 'maria@gmail.com', '(34)25342-5234', ''),
(10, 'Matheus Henrique', '', '332.534.252-34', 'm', '2000-01-22', '2026-10-18 17:36:51', b'1', 'MHenque@gmail.com', '(54)35234-5342', ''),
(11, 'gabriel', 'gabriel', '453.425.435-34', 'm', '2000-01-01', '2026-10-19 08:23:38', b'1', 'gabriel@gmail', '(43)53452-3453', '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `endereco`
--

CREATE TABLE `endereco` (
  `id_endereco` int(11) NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `bairro` varchar(30) NOT NULL,
  `numero` int(4) NOT NULL,
  `estado` char(2) NOT NULL,
  `rua` varchar(70) NOT NULL,
  `complemento` varchar(40) DEFAULT NULL,
  `cidade` varchar(40) NOT NULL,
  `cep` char(9) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `endereco`
--

INSERT INTO `endereco` (`id_endereco`, `id_cliente`, `bairro`, `numero`, `estado`, `rua`, `complemento`, `cidade`, `cep`, `status`, `data_cadastro`) VALUES
(1, 1, 'Nossa Senhora das Graças', 122, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:30:37'),
(2, 2, 'Nossa Senhora das Graças', 122, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:31:07'),
(3, 3, 'Nossa Senhora das Graças', 1222, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:31:45'),
(4, 4, 'Nossa Senhora das Graças', 444, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:32:53'),
(5, 5, 'Nossa Senhora das Graças', 646, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:33:37'),
(6, 6, 'Nossa Senhora das Graças', 845, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:34:20'),
(7, 7, 'Nossa Senhora das Graças', 7945, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:34:42'),
(8, 8, 'Nossa Senhora das Graças', 98, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:35:25'),
(9, 9, 'Nossa Senhora das Graças', 344, 'BA', 'Rua Via Coletora B4', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:36:07'),
(10, 10, 'Nossa Senhora das Graças', 555, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-18 17:36:51'),
(11, 11, 'Nossa Senhora das Graças', 222, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '44444-444', b'1', '2026-10-19 08:23:38'),
(12, 11, 'Nossa Senhora das Graças', 22, 'BA', 'Rua Via Coletora B', '', 'Santo Antônio de Jesus', '43523-545', b'1', '2026-10-19 08:23:38');

-- --------------------------------------------------------

--
-- Estrutura para tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `id_fornecedor` int(2) NOT NULL,
  `nome_fornecedor` varchar(60) NOT NULL,
  `status_fornecedor` bit(1) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `cnpj` varchar(18) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `fornecedor`
--

INSERT INTO `fornecedor` (`id_fornecedor`, `nome_fornecedor`, `status_fornecedor`, `data_cadastro`, `observacao`, `email`, `cnpj`) VALUES
(1, 'Nike', b'1', '2026-10-18 17:22:03', '', 'Nike@gmail.com', '12.234.132/4513-24'),
(2, 'Adidas', b'1', '2026-10-18 17:22:16', '', 'Adidas@gmail.com', '43.253.425/3425-34'),
(3, 'Asics', b'1', '2026-10-18 17:22:29', '', 'Asics@gmail.com', '53.245.342/5342-53'),
(4, 'New Balance', b'1', '2026-10-18 17:22:53', '', 'NewBalance@gmail.com', '53.425.342/5342-53'),
(5, 'Rider', b'1', '2026-10-18 17:23:14', '', 'Rider@gmail.com', '43.534.253/4253-42');

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id_funcionario` int(4) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `nome_social` varchar(60) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` varchar(20) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `salario` decimal(7,2) DEFAULT NULL,
  `endereco` varchar(70) NOT NULL,
  `numero` int(4) NOT NULL,
  `complemento` varchar(40) DEFAULT NULL,
  `bairro` varchar(30) NOT NULL,
  `cidade` varchar(40) NOT NULL,
  `estado` char(2) NOT NULL,
  `cep` char(9) NOT NULL,
  `telefone_residencial` char(13) DEFAULT NULL,
  `telefone_celular` char(14) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `usuario` varchar(15) NOT NULL,
  `senha` varchar(10) NOT NULL,
  `tipo_acesso` bit(1) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `id_cargo` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`id_funcionario`, `nome`, `nome_social`, `foto`, `data_nascimento`, `sexo`, `estado_civil`, `cpf`, `rg`, `salario`, `endereco`, `numero`, `complemento`, `bairro`, `cidade`, `estado`, `cep`, `telefone_residencial`, `telefone_celular`, `email`, `usuario`, `senha`, `tipo_acesso`, `status`, `data_cadastro`, `id_cargo`) VALUES
(1, 'administrador', '', '', '1900-01-01', 'n', '', '000.000.000-00', '', 0.00, 'Rua Santa Cruz', 1000, '', 'Centro', 'Piracicaba', 'SP', '13419-030', '', '', 'admin@gmail.com', 'admin', 'admin', b'1', b'1', '2026-10-18 17:15:33', 1),
(2, 'Ana Silva', NULL, NULL, '1990-05-12', 'F', 'Solteiro', '123.456.789-01', '12.345.678-9', 3500.00, 'Rua das Flores', 101, 'Apt 12', 'Centro', 'São Paulo', 'SP', '01001-000', '(11)3333-4444', '(11)98888-7777', 'ana.silva@email.com', 'anasilva', 'senha123', b'0', b'1', '2026-10-18 17:42:46', 2),
(3, 'Bruno Oliveira', NULL, NULL, '1985-11-23', 'M', 'Casado', '234.567.890-12', '23.456.789-0', 4200.50, 'Avenida Brasil', 500, NULL, 'Jardins', 'Campinas', 'SP', '13010-000', NULL, '(19)97777-6666', 'bruno.o@email.com', 'brunooliveira', 'pass456', b'0', b'1', '2026-10-18 17:42:46', 3),
(4, 'Carla Mendes', 'Carla', NULL, '1995-02-14', 'F', 'Solteiro', '345.678.901-23', '34.567.890-1', 2800.00, 'Rua Augusta', 1230, 'Bloco B', 'Consolação', 'São Paulo', 'SP', '01304-001', NULL, '(11)96666-5555', 'carla.mendes@email.com', 'carlam', 'c123456', b'0', b'1', '2026-10-18 17:42:46', 4),
(5, 'Daniel Rocha', NULL, NULL, '1992-08-30', 'M', 'Divorciado', '456.789.012-34', '45.678.901-2', 3100.00, 'Rua do Porto', 45, NULL, 'Vila Nova', 'Piracicaba', 'SP', '13400-000', '(19)3434-5555', '(19)95555-4444', 'daniel.rocha@email.com', 'drocha', 'd987654', b'0', b'1', '2026-10-18 17:42:46', 5),
(6, 'Eduarda Lima', NULL, NULL, '1988-12-05', 'F', 'Casado', '567.890.123-45', '56.789.012-3', 5500.00, 'Rua XV de Novembro', 890, 'Sala 3', 'Centro', 'Curitiba', 'PR', '80020-000', NULL, '(41)94444-3333', 'eduarda.lima@email.com', 'elima', 'ed1234', b'0', b'1', '2026-10-18 17:42:46', 6),
(7, 'Felipe Santos', NULL, NULL, '1997-04-18', 'M', 'Solteiro', '678.901.234-56', '67.890.123-4', 2200.00, 'Avenida Central', 210, NULL, 'Alvorada', 'Belo Horizonte', 'MG', '30110-000', NULL, '(31)93333-2222', 'felipe.santos@email.com', 'fsantos', 'fel1234', b'0', b'1', '2026-10-18 17:42:46', 7),
(8, 'Gabriela Costa', NULL, NULL, '1993-09-25', 'F', 'Solteiro', '789.012.345-67', '78.901.234-5', 4800.00, 'Rua das Palmeiras', 77, 'Apt 402', 'Bela Vista', 'Porto Alegre', 'RS', '90010-000', '(51)3222-1111', '(51)92222-1111', 'gabi.costa@email.com', 'gcosta', 'gabi998', b'0', b'1', '2026-10-18 17:42:46', 8),
(9, 'Heitor Almeida', NULL, NULL, '1982-01-15', 'M', 'Casado', '890.123.456-78', '89.012.345-6', 6200.00, 'Rua das Acácias', 305, NULL, 'Planalto', 'Brasília', 'DF', '70000-000', NULL, '(61)91111-0000', 'heitor.almeida@email.com', 'halmeida', 'hpass12', b'0', b'1', '2026-10-18 17:42:46', 9),
(10, 'Isabela Souza', NULL, NULL, '1999-07-08', 'F', 'Solteiro', '901.234.567-89', '90.123.456-7', 3900.00, 'Rua Bahia', 612, NULL, 'Funcionários', 'Belo Horizonte', 'MG', '30140-000', NULL, '(31)98765-4321', 'isabela.souza@email.com', 'isouza', 'isa1234', b'0', b'1', '2026-10-18 17:42:46', 10),
(11, 'João Pedro Alves', 'JP', NULL, '1991-03-30', 'M', 'Casado', '012.345.678-90', '01.234.567-8', 3400.00, 'Rua Amazonas', 150, 'Casa', 'Independência', 'Ribeirão Preto', 'SP', '14010-000', '(16)3636-2020', '(16)97654-3210', 'joao.alves@email.com', 'jpalves', 'jp2026x', b'0', b'1', '2026-10-18 17:42:46', 2),
(12, 'Karen Ribeiro', NULL, NULL, '1994-10-10', 'F', 'Solteiro', '111.222.333-44', '11.222.333-4', 4100.00, 'Rua Ceará', 88, NULL, 'Savassi', 'Belo Horizonte', 'MG', '30130-000', NULL, '(31)96543-2109', 'karen.ribeiro@email.com', 'kribeiro', 'kar1234', b'0', b'1', '2026-10-18 17:42:46', 3),
(13, 'Lucas Martins', NULL, NULL, '1989-06-21', 'M', 'Divorciado', '222.333.444-55', '22.333.444-5', 2500.00, 'Rua Goiás', 432, 'Apt 101', 'Centro', 'Goiânia', 'GO', '74000-000', NULL, '(62)95432-1098', 'lucas.martins@email.com', 'lmartins', 'luc9876', b'0', b'1', '2026-10-18 17:42:46', 4),
(14, 'Mariana Ferreira', NULL, NULL, '1996-12-19', 'F', 'Solteiro', '333.444.555-66', '33.444.555-6', 2900.00, 'Rua Paraná', 901, NULL, 'Cabral', 'Curitiba', 'PR', '80030-000', '(41)3352-1234', '(41)94321-0987', 'mariana.f@email.com', 'mferreira', 'mar3210', b'0', b'1', '2026-10-18 17:42:46', 5),
(15, 'Nicolas Barbosa', NULL, NULL, '1998-02-28', 'M', 'Solteiro', '444.555.666-77', '44.555.666-7', 3700.00, 'Rua São Paulo', 12, 'Bloco A', 'Centro', 'Campinas', 'SP', '13015-000', NULL, '(19)93210-9876', 'nicolas.b@email.com', 'nbarbosa', 'nic4567', b'0', b'1', '2026-10-18 17:42:46', 6),
(16, 'Olivia Ramos', NULL, NULL, '1987-09-03', 'F', 'Casado', '555.666.777-88', '55.666.777-8', 2100.00, 'Avenida Rio Branco', 1500, 'Sala 12', 'Centro', 'Rio de Janeiro', 'RJ', '20040-002', '(21)2509-0000', '(21)92109-8765', 'olivia.ramos@email.com', 'oramos', 'oli7890', b'0', b'1', '2026-10-18 17:42:46', 7),
(17, 'Paulo Henrique', 'Paulo', NULL, '1990-11-11', 'M', 'Casado', '666.777.888-99', '66.777.888-9', 5100.00, 'Rua Piauí', 340, NULL, 'Santa Paula', 'São Caetano', 'SP', '09541-000', NULL, '(11)91098-7654', 'paulo.h@email.com', 'phenrique', 'p1a2u3l', b'0', b'1', '2026-10-18 17:42:46', 8),
(18, 'Quintino Bocaiuva', NULL, NULL, '1980-04-01', 'M', 'Viúvo', '777.888.999-00', '77.888.999-0', 7000.00, 'Rua Pernambuco', 789, 'Casa', 'Boa Viagem', 'Recife', 'PE', '51020-000', '(81)3465-0000', '(81)90987-6543', 'quintino.b@email.com', 'qbocaiuva', 'quin123', b'0', b'1', '2026-10-18 17:42:46', 9),
(19, 'Rafaela Castro', NULL, NULL, '1993-08-17', 'F', 'Solteiro', '888.999.000-11', '88.999.000-1', 4300.00, 'Rua Sergipe', 55, 'Apt 22', 'Consolação', 'São Paulo', 'SP', '01303-000', NULL, '(11)99876-5432', 'rafaela.castro@email.com', 'rcastro', 'raf4561', b'0', b'1', '2026-10-18 17:42:46', 10),
(20, 'Samuel Nunes', NULL, NULL, '1991-10-29', 'M', 'Solteiro', '999.000.111-22', '99.000.111-2', 3300.00, 'Rua Alagoas', 98, NULL, 'Higienópolis', 'São Paulo', 'SP', '01242-000', NULL, '(11)98765-1234', 'samuel.nunes@email.com', 'snunes', 'sam7890', b'0', b'1', '2026-10-18 17:42:46', 2),
(21, 'Tatiane Farias', NULL, NULL, '1996-01-05', 'F', 'Casado', '123.123.123-12', '12.123.123-1', 4000.00, 'Rua Maranhão', 654, 'Fundos', 'Mooca', 'São Paulo', 'SP', '03102-000', '(11)2291-0000', '(11)97654-1234', 'tatiane.f@email.com', 'tfarias', 'tat1234', b'0', b'1', '2026-10-18 17:42:46', 3),
(22, 'Ubirajara Silva', NULL, NULL, '1984-05-19', 'M', 'Casado', '234.234.234-23', '23.234.234-2', 2600.00, 'Rua Matto Grosso', 321, NULL, 'Barra Funda', 'São Paulo', 'SP', '01140-000', NULL, '(11)96543-1234', 'ubirajara.s@email.com', 'usilva', 'ubi9876', b'0', b'1', '2026-10-18 17:42:46', 4),
(23, 'Vanessa Cruz', NULL, NULL, '1992-03-12', 'F', 'Solteiro', '345.345.345-34', '34.345.345-3', 2950.00, 'Rua Tocantins', 87, 'Apt 12', 'Ipiranga', 'São Paulo', 'SP', '04201-000', NULL, '(11)95432-1234', 'vanessa.cruz@email.com', 'vcruz', 'van4567', b'0', b'1', '2026-10-18 17:42:46', 5),
(24, 'Wagner Lopes', NULL, NULL, '1986-07-22', 'M', 'Divorciado', '456.456.456-45', '45.456.456-4', 3800.00, 'Rua Acre', 111, NULL, 'Tatuapé', 'São Paulo', 'SP', '03304-000', '(11)2092-1111', '(11)94321-1234', 'wagner.lopes@email.com', 'wlopes', 'wag1234', b'0', b'1', '2026-10-18 17:42:46', 6),
(25, 'Xavier Machado', NULL, NULL, '1995-11-30', 'M', 'Solteiro', '567.567.567-56', '56.567.567-5', 2300.00, 'Rua Amapá', 43, NULL, 'Pinheiros', 'São Paulo', 'SP', '05401-000', NULL, '(11)93210-1234', 'xavier.m@email.com', 'xmachado', 'xav9876', b'0', b'1', '2026-10-18 17:42:46', 7),
(26, 'Yasmin Cardoso', 'Yasmin', NULL, '1997-09-14', 'F', 'Solteiro', '678.678.678-67', '67.678.678-6', 4900.00, 'Rua Roraima', 876, 'Apt 91', 'Santana', 'São Paulo', 'SP', '02011-000', NULL, '(11)92109-1234', 'yasmin.c@email.com', 'ycardoso', 'yas4561', b'0', b'1', '2026-10-18 17:42:46', 8),
(27, 'Zackary Lima', NULL, NULL, '1993-12-01', 'M', 'Solteiro', '789.789.789-78', '78.789.789-7', 6100.00, 'Rua Pará', 234, NULL, 'Perdizes', 'São Paulo', 'SP', '05011-000', '(11)3862-0000', '(11)91098-1234', 'zack.lima@email.com', 'zlima', 'zac1234', b'0', b'1', '2026-10-18 17:42:46', 9),
(28, 'Amanda Duarte', NULL, NULL, '1990-02-15', 'F', 'Casado', '890.890.890-89', '89.890.890-8', 4200.00, 'Rua Santa Catarina', 567, 'Bloco C', 'Moema', 'São Paulo', 'SP', '04511-000', NULL, '(11)98765-4322', 'amanda.d@email.com', 'aduarte', 'ama7890', b'0', b'1', '2026-10-18 17:42:46', 10),
(29, 'Bernardo Vieira', NULL, NULL, '1988-08-08', 'M', 'Casado', '901.901.901-90', '90.901.901-9', 3600.00, 'Rua Rio Grande do Sul', 89, NULL, 'Jardim Paulista', 'São Paulo', 'SP', '01423-000', NULL, '(11)97654-4322', 'bernardo.v@email.com', 'bvieira', 'ber1234', b'0', b'1', '2026-10-18 17:42:46', 2),
(30, 'Camila Guimarães', 'Camila', NULL, '1994-04-20', 'F', 'Solteiro', '012.012.012-01', '01.012.012-0', 4400.00, 'Rua Espirito Santo', 765, 'Apt 33', 'Vila Mariana', 'São Paulo', 'SP', '04011-000', '(11)5571-0000', '(11)96543-4322', 'camila.g@email.com', 'cguimaraes', 'cam9876', b'0', b'1', '2026-10-18 17:42:46', 3),
(31, 'Diego Teixeira', NULL, NULL, '1991-06-11', 'M', 'Solteiro', '123.321.123-99', '12.321.123-9', 2750.00, 'Rua Rio Grande do Norte', 432, NULL, 'Lapa', 'São Paulo', 'SP', '05071-000', NULL, '(11)95432-4322', 'diego.t@email.com', 'dteixeira', 'die4567', b'0', b'1', '2026-10-18 17:42:46', 4);

-- --------------------------------------------------------

--
-- Estrutura para tabela `itens_venda`
--

CREATE TABLE `itens_venda` (
  `id_item_venda` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_pedido` int(11) NOT NULL,
  `quantidade` int(4) NOT NULL,
  `valor_total_item` decimal(9,2) NOT NULL,
  `valor_item` decimal(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `itens_venda`
--

INSERT INTO `itens_venda` (`id_item_venda`, `id_produto`, `id_pedido`, `quantidade`, `valor_total_item`, `valor_item`) VALUES
(1, 2, 1, 10, 15840.00, 1584.00),
(2, 2, 2, 1, 1584.00, 1584.00),
(3, 2, 3, 5, 7920.00, 1584.00),
(4, 3, 3, 3, 3900.00, 1300.00),
(5, 6, 4, 1, 650.00, 650.00),
(6, 5, 4, 1, 520.00, 520.00),
(7, 6, 5, 1, 650.00, 650.00),
(8, 6, 6, 1, 650.00, 650.00),
(9, 6, 7, 1, 650.00, 650.00),
(10, 6, 8, 1, 650.00, 650.00),
(11, 5, 10, 1, 520.00, 520.00),
(12, 6, 11, 1, 650.00, 650.00);

-- --------------------------------------------------------

--
-- Estrutura para tabela `marca`
--

CREATE TABLE `marca` (
  `id_marca` int(2) NOT NULL,
  `status_marca` bit(1) NOT NULL,
  `nome_marca` varchar(50) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `marca`
--

INSERT INTO `marca` (`id_marca`, `status_marca`, `nome_marca`, `data_cadastro`, `observacao`) VALUES
(1, b'1', 'Nike', '2026-10-18 17:23:23', ''),
(2, b'1', 'Asics', '2026-10-18 17:23:28', ''),
(3, b'1', 'Adidas', '2026-10-18 17:23:35', ''),
(4, b'1', 'New Balance', '2026-10-18 17:23:43', ''),
(5, b'1', 'Rider', '2026-10-18 17:23:47', '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `id_produto` int(11) NOT NULL,
  `id_marca` int(2) DEFAULT NULL,
  `id_categoria` int(2) DEFAULT NULL,
  `id_fornecedor` int(2) DEFAULT NULL,
  `nome_produto` varchar(50) DEFAULT NULL,
  `produto_foto1` varchar(50) NOT NULL,
  `produto_foto2` varchar(50) DEFAULT NULL,
  `produto_foto3` varchar(50) DEFAULT NULL,
  `produto_foto4` varchar(50) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `tamanho` varchar(10) NOT NULL,
  `preco_custo` decimal(6,2) NOT NULL,
  `lucro` decimal(7,2) DEFAULT NULL,
  `preco_venda` decimal(7,2) NOT NULL,
  `promocao` bit(1) DEFAULT NULL,
  `desconto` decimal(5,2) DEFAULT NULL,
  `preco_desconto` decimal(7,2) DEFAULT NULL,
  `status_produto` bit(1) NOT NULL,
  `cor` varchar(15) NOT NULL,
  `descricao` varchar(1000) DEFAULT NULL,
  `status_destaque` bit(1) NOT NULL,
  `estoque` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `produto`
--

INSERT INTO `produto` (`id_produto`, `id_marca`, `id_categoria`, `id_fornecedor`, `nome_produto`, `produto_foto1`, `produto_foto2`, `produto_foto3`, `produto_foto4`, `data_cadastro`, `tamanho`, `preco_custo`, `lucro`, `preco_venda`, `promocao`, `desconto`, `preco_desconto`, `status_produto`, `cor`, `descricao`, `status_destaque`, `estoque`) VALUES
(1, 1, 7, 1, 'Air max dn', 'airmaxdn.jfif', 'airmaxdn.jfif', '', '', '2026-10-18 17:53:41', '40', 1000.00, 10.00, 1100.00, b'1', 3.00, 1067.00, b'1', 'Branco', 'Nike Air Max Dn Branco\r\n\r\nO Air Max Dn marca uma nova geração na cultura dos sneakers. Com uma estética fluida e moderna, destaca-se pelo seu topo em malha respirável com textura tátil e pelo sistema de amortecimento de última geração.\r\n\r\nDestaques do Produto:\r\n\r\nTecnologia Dynamic Air: Sistema de tubos de câmara dupla que reage à pressão dos teus passos para um conforto em movimento contínuo.\r\n\r\nTopo Respirável: Material leve e estruturado para um ajuste confortável e duradouro.\r\n\r\nDesign Versátil: A tonalidade em branco puro facilita a combinação com qualquer estilo, do desportivo ao casual.\r\n\r\nSola de Borracha: Excelente tração e aderência para o uso diário.', b'1', 30),
(2, 1, 7, 1, 'Air Max 95 ', 'airmax95.png', '', '', '', '2026-10-18 17:57:39', '40', 1440.00, 10.00, 1584.00, b'0', 0.00, 0.00, b'1', 'Preto', 'Tênis Nike Air Max 95\n\nEleve o seu visual urbano com o imponente Nike Air Max 95. Conhecido pelo seu design ondulado em camadas e pelas duplas câmaras de ar visíveis (no calcanhar e no antepé), ele garante um conforto inacreditável para o uso diário com um visual chunky autêntico.\n\nEstilo e Camadas: Combinação de materiais de alta durabilidade e textura única.\n\nAmortecimento Air Max: Absorção de impacto superior a cada passo.\n\nDesign Anatômico: Ajuste firme e suporte ideal para o dia a dia.', b'0', 34),
(3, 1, 7, 1, 'Air Max 95', 'airmax95cinxa.jpg', '', '', '', '2026-10-18 17:59:49', '41', 1000.00, 30.00, 1300.00, b'0', 0.00, 0.00, b'1', 'Cinza', 'Tênis Nike Air Max 95\r\n\r\nEleve o seu visual urbano com o imponente Nike Air Max 95. Conhecido pelo seu design ondulado em camadas e pelas duplas câmaras de ar visíveis (no calcanhar e no antepé), ele garante um conforto inacreditável para o uso diário com um visual chunky autêntico.\r\n\r\nEstilo e Camadas: Combinação de materiais de alta durabilidade e textura única.\r\n\r\nAmortecimento Air Max: Absorção de impacto superior a cada passo.\r\n\r\nDesign Anatômico: Ajuste firme e suporte ideal para o dia a dia.', b'0', 37),
(4, 3, 6, 2, 'Adidas Campus 00s', 'adidascampuspreto.jpeg', '', '', '', '2026-10-18 18:09:39', '40', 400.00, 38.00, 552.00, b'0', 0.00, 0.00, b'1', 'Preto', 'Tênis adidas Campus 00s Preto – O Ícone dos Anos 2000 Amplificado\n\nInspirado na herança do skate e na nostalgia dos anos 2000, o adidas Campus 00s renova a clássica silhueta Campus com proporções mais ousadas e robustas. Com cabedal em suede preto de altíssima qualidade, lingueta acolchoada e as emblemáticas Três Listras contrastantes em destaque, este modelo é a escolha definitiva para quem busca presença e autenticidade no visual streetwear.', b'0', 10),
(5, 3, 6, 2, 'Adidas Campus 00s', 'adidascampusverde.webp', '', '', '', '2026-10-18 18:14:04', '40', 400.00, 30.00, 520.00, b'0', 0.00, 0.00, b'1', 'Verde', 'Tênis adidas Campus 00s Verde– O Ícone dos Anos 2000 Amplificado\r\n\r\nInspirado na herança do skate e na nostalgia dos anos 2000, o adidas Campus 00s renova a clássica silhueta Campus com proporções mais ousadas e robustas. Com cabedal em suede verde de altíssima qualidade, lingueta acolchoada e as emblemáticas Três Listras contrastantes em destaque, este modelo é a escolha definitiva para quem busca presença e autenticidade no visual streetwear.', b'0', 38),
(6, 2, 7, 3, 'Asics Gel NYC', 'asicscinza.webp', '', '', '', '2026-10-18 18:15:42', '41', 500.00, 30.00, 650.00, b'0', 0.00, 0.00, b'1', 'Cinza', 'Tênis ASICS GEL – O Máximo em Conforto e Performance\r\n\r\nDesenvolvido para quem busca amortecimento de elite e absorção de impacto superior, este modelo da ASICS combina tecnologia de ponta com um ajuste impecável. Equipado com o renomado amortecimento GEL e entressola leve e responsiva, ele garante passadas mais suaves e menos fadiga a cada treino ou caminhada. A escolha perfeita para superar os teus limites no desporto e no dia a dia.\r\n\r\nDestaques do Produto:\r\n\r\nTecnologia GEL™: Absorção de impacto máxima em pontos estratégicos para proteger as articulações.\r\n\r\nCabedal Respirável: Malha leve que proporciona excelente ventilação e ajuste anatómico.\r\n\r\nEntressola Leve: Proporciona um retorno de energia eficiente e passada macia.\r\n\r\nSolado AHAR™: Borracha de alta durabilidade e resistência ao desgaste.', b'0', 34),
(7, 4, 2, 4, 'New Balance', 'new balance.webp', '', '', '', '2026-10-18 18:19:06', '40', 700.00, 10.00, 770.00, b'0', 0.00, 0.00, b'1', 'Cinza', 'Tênis New Balance – O Encontro Perfeito Entre Tradição e Estilo Urbano\r\n\r\nCelebrando a herança de qualidade e design icónico da marca, este modelo da New Balance traz o equilíbrio perfeito entre retro e moderno. Com um cabedal construído em materiais de primeira linha e entressola focada em amortecimento macio, ele é a escolha ideal para quem não abre mão de conforto absoluto e de um visual clean, versátil e cheio de atitude para o dia a dia.\r\n\r\nDestaques do Produto:\r\n\r\nConforto Superior: Entressola projetada para absorção de impacto e suporte contínuo.\r\n\r\nMateriais Premium: Combinação de camurça, couro e malha de alta durabilidade.\r\n\r\nDesign Versátil: Silhueta atemporal que combina facilmente com jeans, calças jogger ou calções.\r\n\r\nSola de Borracha: Tração e durabilidade garantidas em diferentes superfícies.', b'0', 30),
(8, 4, 2, 4, 'New Balance 9060', 'new balance9060.webp', '', '', '', '2026-10-18 18:21:52', '40', 800.00, 20.00, 960.00, b'0', 0.00, 0.00, b'1', 'Bege', 'Tênis New Balance – O Encontro Perfeito Entre Tradição e Estilo Urbano\r\n\r\nCelebrando a herança de qualidade e design icónico da marca, este modelo da New Balance traz o equilíbrio perfeito entre retro e moderno. Com um cabedal construído em materiais de primeira linha e entressola focada em amortecimento macio, ele é a escolha ideal para quem não abre mão de conforto absoluto e de um visual clean, versátil e cheio de atitude para o dia a dia.\r\n\r\nDestaques do Produto:\r\n\r\nConforto Superior: Entressola projetada para absorção de impacto e suporte contínuo.\r\n\r\nMateriais Premium: Combinação de camurça, couro e malha de alta durabilidade.\r\n\r\nDesign Versátil: Silhueta atemporal que combina facilmente com jeans, calças jogger ou calções.\r\n\r\nSola de Borracha: Tração e durabilidade garantidas em diferentes superfícies.', b'0', 40),
(9, 1, 7, 1, 'Air Max TN', 'airmaxtn.jfif', '', '', '', '2026-10-18 18:24:47', '40', 1300.00, 10.00, 1430.00, b'0', 0.00, 0.00, b'1', 'Branco', 'Uma lenda dos anos 90 que continua a redefinir o estilo urbano. O Air Max TN combina uma estética arrojada com o que há de melhor em engenharia de conforto da Nike.\r\n\r\nDestaques do Produto:\r\n\r\nAmortecimento Max Air: Unidades visíveis no calcanhar e antepé para leveza e absorção de impacto contínua.\r\n\r\nEstrutura de Suporte: As linhas inspiradas nas folhas de palmeira e no oceano dão suporte estrutural e um visual único.\r\n\r\nSolado: Borracha de alta aderência com ranhuras flexíveis.\r\n\r\nDetalhes Refletivos: Elementos que garantem destaque mesmo em ambientes com pouca luz.', b'0', 30),
(10, 1, 7, 1, 'Air Max TN', 'airmaxtnlaranja.webp', '', '', '', '2026-10-18 18:26:13', '39', 1300.00, 10.00, 1430.00, b'0', 0.00, 0.00, b'1', 'Laranja', 'Uma lenda dos anos 90 que continua a redefinir o estilo urbano. O Air Max TN combina uma estética arrojada com o que há de melhor em engenharia de conforto da Nike.\r\n\r\nDestaques do Produto:\r\n\r\nAmortecimento Max Air: Unidades visíveis no calcanhar e antepé para leveza e absorção de impacto contínua.\r\n\r\nEstrutura de Suporte: As linhas inspiradas nas folhas de palmeira e no oceano dão suporte estrutural e um visual único.\r\n\r\nSolado: Borracha de alta aderência com ranhuras flexíveis.\r\n\r\nDetalhes Refletivos: Elementos que garantem destaque mesmo em ambientes com pouca luz.', b'0', 50),
(11, 1, 7, 1, 'Air Max TN ', 'airmaxtnpretoo.jfif', '', '', '', '2026-10-18 18:27:11', '40', 1300.00, 15.00, 1495.00, b'0', 0.00, 0.00, b'1', 'Preto', 'Uma lenda dos anos 90 que continua a redefinir o estilo urbano. O Air Max TN combina uma estética arrojada com o que há de melhor em engenharia de conforto da Nike.\r\n\r\nDestaques do Produto:\r\n\r\nAmortecimento Max Air: Unidades visíveis no calcanhar e antepé para leveza e absorção de impacto contínua.\r\n\r\nEstrutura de Suporte: As linhas inspiradas nas folhas de palmeira e no oceano dão suporte estrutural e um visual único.\r\n\r\nSolado: Borracha de alta aderência com ranhuras flexíveis.\r\n\r\nDetalhes Refletivos: Elementos que garantem destaque mesmo em ambientes com pouca luz.', b'0', 50),
(12, 1, 7, 1, 'Air Max DN ', 'air max dn roxo.webp', '', '', '', '2026-10-18 18:32:35', '39', 1000.00, 39.00, 1390.00, b'0', 0.00, 1390.00, b'1', 'Roxo', 'Nike Air Max Dn – O Próximo Nível do Amortecimento\r\n\r\nEntra no futuro do conforto com o Nike Air Max Dn. Equipado com a revolucionária tecnologia Dynamic Air — com tubos de câmara dupla que reagem a cada passo —, este modelo oferece uma sensação de transição suave e responsiva como nunca viste. O seu design futurista e limpo combina perfeitamente com qualquer outfit urbano, garantindo que te destacas com estilo e máximo conforto o dia todo.', b'0', 50),
(13, 1, 7, 1, 'Air Max DN ', 'airmaxdnpret.jfif', '', '', '', '2026-10-18 18:34:17', '40', 900.00, 49.00, 1341.00, b'0', 0.00, 0.00, b'1', 'Preto', 'Nike Air Max Dn – O Próximo Nível do Amortecimento\r\n\r\nEntra no futuro do conforto com o Nike Air Max Dn. Equipado com a revolucionária tecnologia Dynamic Air — com tubos de câmara dupla que reagem a cada passo —, este modelo oferece uma sensação de transição suave e responsiva como nunca viste. O seu design futurista e limpo combina perfeitamente com qualquer outfit urbano, garantindo que te destacas com estilo e máximo conforto o dia todo.', b'0', 50),
(14, 1, 7, 1, 'Air Max DN', 'air max dnvermelho.webp', '', '', '', '2026-10-18 18:36:51', '40', 1000.00, 40.00, 1400.00, b'0', 0.00, 0.00, b'1', 'Vermelho', 'Nike Air Max Dn – O Próximo Nível do Amortecimento\r\n\r\nEntra no futuro do conforto com o Nike Air Max Dn. Equipado com a revolucionária tecnologia Dynamic Air — com tubos de câmara dupla que reagem a cada passo —, este modelo oferece uma sensação de transição suave e responsiva como nunca viste. O seu design futurista e limpo combina perfeitamente com qualquer outfit urbano, garantindo que te destacas com estilo e máximo conforto o dia todo.', b'0', 60),
(15, 1, 7, 1, 'Air Max DN', 'air max dn.png', '', '', '', '2026-10-18 18:38:00', '40', 400.00, 140.00, 960.00, b'0', 0.00, 0.00, b'1', 'Branco', 'Nike Air Max Dn – O Próximo Nível do Amortecimento\n\nEntra no futuro do conforto com o Nike Air Max Dn. Equipado com a revolucionária tecnologia Dynamic Air — com tubos de câmara dupla que reagem a cada passo —, este modelo oferece uma sensação de transição suave e responsiva como nunca viste. O seu design futurista e limpo combina perfeitamente com qualquer outfit urbano, garantindo que te destacas com estilo e máximo conforto o dia todo.', b'0', 50),
(16, 2, 2, 3, 'Asics Gel NYC', 'asics nyc.webp', '', '', '', '2026-10-18 18:41:01', '40', 500.00, 100.00, 1000.00, b'0', 0.00, 0.00, b'1', 'Preto', 'Tênis New Balance – O Encontro Perfeito Entre Tradição e Estilo Urbano\r\n\r\nCelebrando a herança de qualidade e design icónico da marca, este modelo da New Balance traz o equilíbrio perfeito entre retro e moderno. Com um cabedal construído em materiais de primeira linha e entressola focada em amortecimento macio, ele é a escolha ideal para quem não abre mão de conforto absoluto e de um visual clean, versátil e cheio de atitude para o dia a dia.\r\n\r\nDestaques do Produto:\r\n\r\nConforto Superior: Entressola projetada para absorção de impacto e suporte contínuo.\r\n\r\nMateriais Premium: Combinação de camurça, couro e malha de alta durabilidade.\r\n\r\nDesign Versátil: Silhueta atemporal que combina facilmente com jeans, calças jogger ou calções.\r\n\r\nSola de Borracha: Tração e durabilidade garantidas em diferentes superfícies.', b'0', 100);

-- --------------------------------------------------------

--
-- Estrutura para tabela `venda`
--

CREATE TABLE `venda` (
  `id_pedido` int(11) NOT NULL,
  `id_funcionario` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `data_pedido` date NOT NULL,
  `valor_total` decimal(8,2) NOT NULL,
  `desconto` decimal(5,2) NOT NULL,
  `tipo_pagamento` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `venda`
--

INSERT INTO `venda` (`id_pedido`, `id_funcionario`, `id_cliente`, `data_pedido`, `valor_total`, `desconto`, `tipo_pagamento`) VALUES
(1, 29, 8, '2026-10-19', 15840.00, 10.00, 'Pix'),
(2, 29, 8, '2026-10-19', 1584.00, 0.00, 'Cartão de Débito'),
(3, 29, 2, '2026-10-19', 11820.00, 0.00, 'Cartão de Débito'),
(4, 29, 1, '2026-10-19', 1170.00, 10.00, 'Cartão de Crédito'),
(5, 2, 8, '2026-10-19', 650.00, 0.00, 'Cartão de Crédito'),
(6, 11, 1, '2026-10-19', 650.00, 0.00, 'Cartão de Débito'),
(7, 2, 11, '2026-10-19', 650.00, 0.00, 'Cartão de Crédito'),
(8, 29, 8, '2026-10-19', 650.00, 0.00, 'Cartão de Débito'),
(9, 11, 1, '2026-10-19', 0.00, 0.00, 'Cartão de Crédito'),
(10, 11, 1, '2026-10-19', 520.00, 0.00, 'Cartão de Crédito'),
(11, 29, 1, '2026-10-19', 650.00, 0.00, 'Cartão de Débito');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`id_cargo`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD UNIQUE KEY `nome_categoria` (`nome_categoria`);

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf_cliente` (`cpf_cliente`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices de tabela `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`id_endereco`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- Índices de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`id_fornecedor`);

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `usuario` (`usuario`),
  ADD KEY `id_cargo` (`id_cargo`);

--
-- Índices de tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD PRIMARY KEY (`id_item_venda`),
  ADD KEY `id_produto` (`id_produto`),
  ADD KEY `id_pedido` (`id_pedido`);

--
-- Índices de tabela `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`),
  ADD UNIQUE KEY `nome_marca` (`nome_marca`);

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `id_marca` (`id_marca`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_fornecedor` (`id_fornecedor`);

--
-- Índices de tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id_pedido`),
  ADD KEY `id_funcionario` (`id_funcionario`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargo`
--
ALTER TABLE `cargo`
  MODIFY `id_cargo` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id_endereco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `id_fornecedor` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id_funcionario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT de tabela `itens_venda`
--
ALTER TABLE `itens_venda`
  MODIFY `id_item_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `endereco`
--
ALTER TABLE `endereco`
  ADD CONSTRAINT `endereco_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`);

--
-- Restrições para tabelas `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`id_cargo`) REFERENCES `cargo` (`id_cargo`);

--
-- Restrições para tabelas `itens_venda`
--
ALTER TABLE `itens_venda`
  ADD CONSTRAINT `itens_venda_ibfk_1` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`),
  ADD CONSTRAINT `itens_venda_ibfk_2` FOREIGN KEY (`id_pedido`) REFERENCES `venda` (`id_pedido`);

--
-- Restrições para tabelas `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`),
  ADD CONSTRAINT `produto_ibfk_3` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`);

--
-- Restrições para tabelas `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
