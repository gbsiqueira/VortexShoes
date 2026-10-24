    -- Gera��o de Modelo f�sico
    -- Sql ANSI 2003 - brModelo.

    CREATE DATABASE vortexshoes;

    USE vortexshoes;


    CREATE TABLE cliente (
    id_cliente INT(11) AUTO_INCREMENT PRIMARY KEY,
    nome_cliente VARCHAR(60) NOT NULL,
    nome_social VARCHAR(60),
    cpf_cliente CHAR(14) NOT NULL UNIQUE,
    sexo_cliente CHAR(1) NOT NULL,
    data_nascimento_cliente DATE NOT NULL,
    data_cadastro DATETIME NOT NULL,
    status_cliente BIT NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone_cliente CHAR(14) NOT NULL,
    telefone_cliente2 CHAR(14)
    );

    CREATE TABLE endereco (
    id_endereco INT(11) AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT(11),
    bairro VARCHAR(30) NOT NULL,
    numero INTEGER(04) NOT NULL,
    estado CHAR(2) NOT NULL,
    rua VARCHAR(70) NOT NULL,
    complemento VARCHAR(40),
    cidade VARCHAR(40) NOT NULL,
    cep CHAR(9) NOT NULL,
    status BIT NOT NULL,
    data_cadastro DATETIME NOT NULL,
    FOREIGN KEY(id_cliente) REFERENCES cliente (id_cliente)
    );

    CREATE TABLE cargo
    (
        id_cargo INT(02) AUTO_INCREMENT PRIMARY KEY,
        nome VARCHAR(40) UNIQUE NOT NULL,
        observacao VARCHAR(100),
        status BIT NOT NULL,
        data_cadastro DATETIME NOT NULL
    );

    CREATE TABLE funcionario
    (
        id_funcionario INT(04) AUTO_INCREMENT PRIMARY KEY,
        nome VARCHAR(60) NOT NULL,
        nome_social VARCHAR(60),
        foto VARCHAR(255),
        data_nascimento DATE NOT NULL,
        sexo CHAR(01) NOT NULL,
        estado_civil VARCHAR(20),
        cpf CHAR(14) UNIQUE NOT NULL,
        rg VARCHAR(12),
        salario DECIMAL(7,2),
        endereco VARCHAR(70) NOT NULL,
        numero INT(04) NOT NULL,
        complemento VARCHAR(40),
        bairro VARCHAR(30) NOT NULL,
        cidade VARCHAR(40) NOT NULL,
        estado CHAR(02) NOT NULL,
        cep CHAR(09) NOT NULL,
        telefone_residencial CHAR(13),
        telefone_celular CHAR(14),
        email VARCHAR(50) NOT NULL,
        usuario VARCHAR(15) UNIQUE NOT NULL,
        senha VARCHAR(10) NOT NULL,
        tipo_acesso BIT NOT NULL,
        status BIT NOT NULL,
        data_cadastro DATETIME NOT NULL,
        id_cargo INT(02),
        FOREIGN KEY(id_cargo) REFERENCES cargo (id_cargo)
    );

    CREATE TABLE venda (
    id_pedido INT(11) AUTO_INCREMENT PRIMARY KEY,
    id_funcionario INT(11),
    id_cliente INT(11),
    data_pedido DATE NOT NULL,
    valor_total DECIMAL(8,2) NOT NULL,
    desconto DECIMAL(5,2) NOT NULL,
    tipo_pagamento VARCHAR(20) NOT NULL,
    FOREIGN KEY(id_funcionario) REFERENCES funcionario (id_funcionario),
    FOREIGN KEY(id_cliente) REFERENCES cliente (id_cliente)
    );

    CREATE TABLE categoria (
    id_categoria INT(02) AUTO_INCREMENT PRIMARY KEY,
    nome_categoria VARCHAR(40) NOT NULL UNIQUE,
    data_cadastro DATETIME NOT NULL,
    status_categoria BIT NOT NULL,
    observacao VARCHAR(100)
    );

    CREATE TABLE fornecedor (
    id_fornecedor INT(02) AUTO_INCREMENT PRIMARY KEY,
    nome_fornecedor VARCHAR(60) NOT NULL,
    status_fornecedor BIT,
    data_cadastro DATETIME NOT NULL,
    observacao VARCHAR(100),
    email VARCHAR(50) NOT NULL,
    cnpj VARCHAR(18)
    );

    CREATE TABLE marca (
    id_marca INT(02) AUTO_INCREMENT PRIMARY KEY,
    status_marca BIT NOT NULL,
    nome_marca VARCHAR(50) NOT NULL UNIQUE,
    data_cadastro DATETIME NOT NULL,
    observacao VARCHAR(100)
    );

    CREATE TABLE produto (
    id_produto INT(11) AUTO_INCREMENT PRIMARY KEY,
    id_marca INT(02),
    id_categoria INT(02),
    id_fornecedor INT(02),
    nome_produto VARCHAR(50),
    produto_foto1 VARCHAR(50) NOT NULL,
    produto_foto2 VARCHAR(50),
    produto_foto3 VARCHAR(50),
    produto_foto4 VARCHAR(50),
    data_cadastro DATETIME NOT NULL,
    tamanho VARCHAR(10) NOT NULL,
    preco_custo DECIMAL(6,2) NOT NULL,
    lucro DECIMAL(7,2),
    preco_venda DECIMAL(7,2) NOT NULL,
    promocao BIT,
    desconto DECIMAL(5,2),  
    preco_desconto DECIMAL(7,2),
    status_produto BIT NOT NULL,
    cor VARCHAR(15) NOT NULL,
    descricao VARCHAR(1000),
    status_destaque BIT NOT NULL,
    estoque INT(5) NOT NULL,
    FOREIGN KEY(id_marca) REFERENCES marca (id_marca),
    FOREIGN KEY(id_categoria) REFERENCES categoria (id_categoria),
    FOREIGN KEY(id_fornecedor) REFERENCES fornecedor (id_fornecedor)
    );

    CREATE TABLE itens_venda (
    id_item_venda INT(11) PRIMARY KEY AUTO_INCREMENT,
    id_produto INT(11) NOT NULL,
    id_pedido INT(11) NOT NULL,
    quantidade INT(4) NOT NULL,
    valor_total_item DECIMAL(9,2) NOT NULL,
    valor_item DECIMAL(6,2) NOT NULL,
    FOREIGN KEY(id_produto) REFERENCES produto (id_produto),
    FOREIGN KEY(id_pedido) REFERENCES venda (id_pedido)
    );

    INSERT INTO cargo VALUES(0, 'administrador', 'Cargo para o funcionário administrador', 1, NOW());

    INSERT INTO cargo VALUES(0, 'vendedor', '', 1, NOW());

    INSERT INTO funcionario VALUES(0, 'administrador', '', '', '1900-01-01', 'n', '', '000.000.000-00', '', 0, 'Rua Santa Cruz', 1000, '', 'Centro', 'Piracicaba', 'SP', '13419-030', '', '', 'admin@gmail.com', 'admin', 'admin', 1, 1, NOW(), 1);

    