/*
Meu grupo: Arthur Lacerda, Thiago Militão, Vitor Lima, Leandro Santana e Guilherme Saltão.
*/

create database if not exists db_locadora;
use db_locadora;

create table if not exists tb_estado (
	cd_estado int not null auto_increment,
    nm_estado varchar(50) not null,
    sg_estado char(2) not null unique,
    
    constraint pk_estado primary key (cd_estado)
);

create table if not exists tb_cidade (
	cd_cidade int not null auto_increment,
    nm_cidade varchar(70) not null,
    cd_estadoCidade int not null,
    
    constraint pk_cidade primary key (cd_cidade),
    constraint fk_estadoCidade foreign key (cd_estadoCidade) references tb_estado (cd_estado)
);

create table if not exists tb_cliente (
	cd_cliente int not null auto_increment,
    nm_cliente varchar(50) not null,
    cd_cpfCliente char(11) not null unique,
    sg_sexoCliente char(1) not null,
    qt_idadeCliente int not null,
    nmr_telefoneCliente char(11) unique not null,
    cd_emailCliente varchar(100) unique not null,
    nmr_habilitacaoCliente char(10) not null unique,
    ed_enderecoCliente varchar(200) not null,
	cd_cidadeCliente int not null,
    
    constraint pk_cliente primary key (cd_cliente),
    constraint check(sg_sexoCliente in('M', 'F', '-')),
    constraint check(qt_idadeCliente >= 18 and qt_idadeCliente <= 130),
    constraint fk_cidadeCliente foreign key (cd_cidadeCliente) references tb_cidade (cd_cidade)
);

create table if not exists tb_fabricante (
    cd_fabricante int not null auto_increment,
    nm_fabricante varchar(50) not null,
    
    constraint pk_fabricante primary key (cd_fabricante)
);

create table if not exists tb_modelo (
    cd_modelo int not null auto_increment,
    nm_modelo varchar(50) not null,
    cd_fabricanteModelo int not null,
    
    constraint pk_modelo primary key (cd_modelo),
    constraint fk_fabricanteModelo foreign key (cd_fabricanteModelo) references tb_fabricante (cd_fabricante)
);

create table if not exists tb_carro (
	cd_carro int not null auto_increment,
    id_placaCarro char(8) not null unique,
    id_chassiCarro char(17) not null unique,
    ano_fabricacaoCarro int,
    nm_corCarro varchar(50) not null,
    cd_modeloCarro int not null,
    cd_fabricanteCarro int not null,
    cd_situacao char(1) not null,
    qt_precoDiaria decimal(10, 2) not null,
    
    constraint pk_carro primary key (cd_carro),
    constraint ck_situacao check(cd_situacao in('A', 'D')),
    constraint fk_modelo foreign key (cd_modeloCarro) references tb_modelo (cd_modelo),
    constraint fk_fabricanteCarro foreign key (cd_fabricanteCarro) references tb_fabricante (cd_fabricante)
);

/*
create table if not exists tb_precoDiaria (
	cd_precoDiaria int not null auto_increment,
    cd_carro int not null,
    id_chassiCarro char(17) not null,
    qt_precoDiaria decimal(10, 2) not null,
    
    constraint fk_precoDiaria primary key (cd_precoDiaria),
    constraint fk_carro foreign key (cd_carro) references tb_carro (cd_carro),
    constraint fk_chassiCarro foreign key (id_chassiCarro) references tb_carro (id_chassiCarro)
);
*/

create table if not exists tb_locacao (
    cd_locacao int not null auto_increment,
    cd_cliente int not null,
    cd_carro int not null,
    dt_inicioLocacao date not null,
    dt_fimLocacao date not null,
    prc_valorAluguel decimal(10, 2) not null,
    dt_devolucaoFinal date,
    qt_diasExcedidos int,
    prc_valorMulta decimal(10, 2),
    prc_valorFinal decimal(10, 2),
    
    constraint pk_locacao primary key (cd_locacao),
    constraint fk_cliente foreign key (cd_cliente) references tb_cliente (cd_cliente),
	constraint fk_carroLocacao foreign key (cd_carro) references tb_carro (cd_carro)
);

INSERT INTO tb_fabricante (nm_fabricante) VALUES
('Toyota'),
('Ford'),
('Volkswagen'),
('Honda'),
('Chevrolet'),
('Nissan'),
('BMW'),
('Mercedes-Benz'),
('Audi'),
('Hyundai'),
('Mazda'),
('Volvo');

INSERT INTO tb_modelo (nm_modelo, cd_fabricanteModelo) VALUES
('Corolla', 1),
('Camry', 1), 
('Rav4', 1),
('F-150', 2),
('Mustang', 2),
('Explorer', 2),
('Golf', 3),
('Jetta', 3),
('Passat', 3),
('Civic', 4),
('Accord', 4),
('CR-V', 4),
('Camaro', 5),
('Malibu', 5),
('Equinox', 5),
('Altima', 6),
('Maxima', 6),
('Rogue', 6),
('3 Series', 7),
('5 Series', 7),
('X3', 7),
('C-Class', 8),
('E-Class', 8),
('S-Class', 8),
('A4', 9),
('A6', 9),
('Q5', 9),
('Elantra', 10),
('Tucson', 10),
('Kona', 10),
('Mazda3', 11),
('Mazda6', 11),
('CX-5', 11),
('S60', 12),
('XC40', 12),
('XC90', 12);

INSERT INTO tb_estado (nm_estado, sg_estado) VALUES
('Acre', 'AC'),
('Alagoas', 'AL'),
('Amapá', 'AP'),
('Amazonas', 'AM'),
('Bahia', 'BA'),
('Ceará', 'CE'),
('Distrito Federal', 'DF'),
('Espírito Santo', 'ES'),
('Goiás', 'GO'),
('Maranhão', 'MA'),
('Mato Grosso', 'MT'),
('Mato Grosso do Sul', 'MS'),
('Minas Gerais', 'MG'),
('Pará', 'PA'),
('Paraíba', 'PB'),
('Paraná', 'PR'),
('Pernambuco', 'PE'),
('Piauí', 'PI'),
('Rio de Janeiro', 'RJ'),
('Rio Grande do Norte', 'RN'),
('Rio Grande do Sul', 'RS'),
('Rondônia', 'RO'),
('Roraima', 'RR'),
('Santa Catarina', 'SC'),
('São Paulo', 'SP'),
('Sergipe', 'SE'),
('Tocantins', 'TO');

INSERT INTO tb_cidade (nm_cidade, cd_estadoCidade) VALUES
('Santos', 25),
('São Vicente', 25),
('Praia Grande', 25),
('Guarujá', 25),
('Cubatão', 25),
('Bertioga', 25),
('Peruíbe', 25),
('Mongaguá', 25),
('Itanhaém', 25);

INSERT INTO tb_cliente (
    nm_cliente,
    cd_cpfCliente,
    sg_sexoCliente,
    qt_idadeCliente,
    nmr_telefoneCliente,
    cd_emailCliente,
    nmr_habilitacaoCliente,
    ed_enderecoCliente,
    cd_cidadeCliente
) VALUES 
    ('João Silva', '12345678901', 'M', 30, '987654321', 'joao.silva@gmail.com', 'ABC123456', 'Rua das Flores, 123', 1),
    ('Maria Oliveira', '98765432109', 'F', 28, '123456789', 'maria.oliveira@hotmail.com', 'XYZ789012', 'Avenida Principal, 456', 2),
    ('Carlos Santos', '56789012345', 'M', 35, '567890123', 'carlos.santos@outlook.com', 'DEF678901', 'Praça Central, 789', 3),
    ('Ana Souza', '34567890123', 'F', 22, '345678901', 'ana.souza@gmail.com', 'GHI789012', 'Alameda dos Sonhos, 567', 1),
    ('Felipe Pereira', '23456789012', 'M', 40, '234567890', 'felipe.pereira@gmail.com', 'JKL890123', 'Avenida da Paz, 890', 4),
    ('Bianca Lima', '87654321098', 'F', 26, '876543210', 'bianca.lima@gmail.com', 'MNO901234', 'Rua da Liberdade, 1234', 5),
    ('Rafaela Oliveira', '65432109876', 'F', 32, '654321098', 'rafaela.oliveira@gmail.com', 'PQR012345', 'Travessa das Flores, 5678', 3);

INSERT INTO tb_carro (id_placaCarro, id_chassiCarro, ano_fabricacaoCarro, nm_corCarro, cd_modeloCarro, cd_fabricanteCarro, cd_situacao, qt_precoDiaria)
VALUES
('ABC1234', '12345678901234567', 2022, 'Azul', 1, 1, 'A', 150.00),
('XYZ5678', '98765432109876543', 2021, 'Preto', 4, 2, 'A', 180.00),
('DEF9012', '56789012345678901', 2020, 'Branco', 7, 3, 'A', 200.00),
('CGF9867', '56789012345678', 2018, 'Vermelho', 8, 4, 'D', 250.00),
('JKL3456', '34567890123456789', 2019, 'Prata', 3, 2, 'D', 190.00),
('MNO7890', '01234567890123456', 2023, 'Verde', 5, 3, 'D', 220.00),
('PQR1234', '89012345678901234', 2017, 'Amarelo', 2, 1, 'D', 170.00),
('STU5678', '67890123456789012', 2022, 'Cinza', 6, 4, 'D', 210.00),
('VWX9012', '45678901234567890', 2016, 'Roxo', 9, 5, 'D', 280.00);

INSERT INTO tb_locacao (cd_cliente, cd_carro, dt_inicioLocacao, dt_fimLocacao, prc_ValorAluguel)
VALUES
(1, 1, '2023-01-01', '2023-01-05', 600.00),
(2, 2, '2023-02-01', '2023-02-10', 1620.00),
(3, 3, '2023-03-01', '2023-03-03', 400.00);

/*
INSERT INTO tb_precoDiaria (cd_carro, id_chassiCarro, qt_precoDiaria)
VALUES
(1, '12345678901234567', 150.00),
(2, '98765432109876543', 180.00),
(3, '56789012345678901', 200.00);
*/

/*
select * from tb_fabricante;
select * from tb_estado;
select * from tb_cidade;
select * from tb_cliente;
select * from tb_modelo;
select * from tb_carro;
SELECT tb_modelo.nm_modelo, tb_fabricante.nm_fabricante FROM tb_modelo INNER JOIN tb_fabricante ON (tb_modelo.cd_fabricanteModelo = tb_fabricante.cd_fabricante);
SELECT tb_cliente.nm_cliente, tb_cliente.cd_cpfCliente, tb_cliente.sg_sexoCliente, tb_cliente.qt_idadeCliente, tb_cliente.nmr_telefoneCliente, tb_cliente.cd_emailCliente, tb_cliente.nmr_habilitacaoCliente, tb_cliente.ed_enderecoCliente, tb_cidade.nm_cidade FROM tb_cliente INNER JOIN tb_cidade ON (tb_cliente.cd_cidadeCliente = tb_cidade.cd_cidade) ORDER BY cd_cidadeCliente;
SELECT tb_cidade.nm_cidade, tb_estado.sg_estado FROM tb_cidade INNER JOIN tb_estado on (tb_estado.cd_estado = tb_cidade.cd_estadoCidade);
SELECT tb_carro.id_placaCarro, tb_carro.id_chassiCarro, tb_carro.ano_fabricacaoCarro, tb_carro.nm_corCarro, tb_modelo.nm_modelo, tb_fabricante.nm_fabricante FROM tb_carro INNER JOIN tb_modelo ON tb_carro.cd_modeloCarro = tb_modelo.cd_modelo INNER JOIN tb_fabricante ON tb_carro.cd_fabricanteCarro = tb_fabricante.cd_fabricante;
select * from tb_carro;
select * from tb_locacao;
SELECT
    tb_cliente.nm_cliente,
    tb_carro.id_placaCarro,
    tb_locacao.dt_inicioLocacao,
    tb_locacao.dt_fimLocacao
FROM
    tb_locacao
    INNER JOIN tb_cliente ON tb_locacao.cd_cliente = tb_cliente.cd_cliente
    INNER JOIN tb_carro ON tb_locacao.cd_carro = tb_carro.cd_carro;
SELECT cd_locacao, prc_valorTotal, dt_devolucaoFinal, qt_diasExcedidos, prc_valorMulta FROM tb_devolucao;
SELECT tb_cliente.nm_cliente, tb_carro.id_placaCarro, tb_locacao.dt_inicioLocacao, tb_locacao.dt_fimLocacao, tb_locacao.prc_valorAluguel FROM tb_locacao INNER JOIN tb_cliente ON tb_locacao.cd_cliente = tb_cliente.cd_cliente INNER JOIN tb_carro ON tb_locacao.cd_carro = tb_carro.cd_carro;
UPDATE tb_carro SET cd_situacao = 'A' WHERE cd_carro IN (SELECT cd_carro FROM tb_locacao);
SELECT cd_locacao, prc_valorFinal, dt_devolucaoFinal, qt_diasExcedidos, prc_valorMulta FROM tb_locacao;
SELECT tb_carro.id_placaCarro FROM tb_carro INNER JOIN tb_locacao ON tb_locacao.cd_carro = tb_carro.cd_carro;
SELECT tb_cliente.nm_cliente FROM tb_cliente INNER JOIN tb_locacao ON tb_cliente.cd_cliente = tb_locacao.cd_cliente;
UPDATE tb_locacao SET prc_valorFinal = '400', dt_devolucaoFinal = '2004/12/20', qt_diasExcedidos = '1', prc_valorMulta = '666.00' WHERE cd_cliente = 2;
SELECT c.nm_cliente, car.id_placaCarro, l.prc_valorFinal, l.dt_devolucaoFinal, l.qt_diasExcedidos, l.prc_valorMulta FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro;
SELECT c.nm_cliente FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro WHERE l.dt_devolucaoFinal IS NULL;
SELECT car.id_placaCarro FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro WHERE l.dt_devolucaoFinal IS NULL;
*/