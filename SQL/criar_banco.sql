
CREATE DATABASE academia;
USE academia;


CREATE TABLE Planos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Nome_plano VARCHAR(80) NOT NULL,
    Valor_plano DECIMAL(10,2) NOT NULL
);


CREATE TABLE Unidades (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Endereco VARCHAR(250) NOT NULL,
    Telefone VARCHAR(20),
    cnpj_unidade VARCHAR(20)
);


CREATE TABLE Alunos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Nome_al VARCHAR(85) NOT NULL,
    CPF_al VARCHAR(11) NOT NULL,
    Idade_al VARCHAR(2),
    Genero_al VARCHAR(15),
    Numero_matricula VARCHAR(25),
    plano_al INT,
    unidade INT,

    FOREIGN KEY (plano_al) REFERENCES Planos(id),
    FOREIGN KEY (unidade) REFERENCES Unidades(id)
);

CREATE TABLE Pagtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_unidade INT NOT NULL,
    Cod_pagto VARCHAR(80),
    data_pagto DATE,
    plano INT,
    aluno_pag INT,

    FOREIGN KEY (id_unidade) REFERENCES Unidades(id),
    FOREIGN KEY (plano) REFERENCES Planos(id),
    FOREIGN KEY (aluno_pag) REFERENCES Alunos(id)
);
