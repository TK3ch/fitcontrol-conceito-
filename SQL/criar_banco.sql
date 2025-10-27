CREATE DATABASE IF NOT EXISTS sistema_academia;
USE sistema_academia;

CREATE TABLE IF NOT EXISTS Academias (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(200),
    Telefone VARCHAR(20)
);

CREATE TABLE IF NOT EXISTS Alunos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    EstaPagando BOOLEAN NOT NULL,
    AcademiaId INT,
    FOREIGN KEY (AcademiaId) REFERENCES Academias(Id)
);

CREATE TABLE IF NOT EXISTS Materias (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Custo DECIMAL(10,2) NOT NULL,
    AcademiaId INT,
    FOREIGN KEY (AcademiaId) REFERENCES Academias(Id)
);

CREATE TABLE IF NOT EXISTS Pagamentos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AlunoId INT,
    Valor DECIMAL(10,2),
    DataPagamento DATETIME,
    AcademiaId INT,
    FOREIGN KEY (AlunoId) REFERENCES Alunos(Id),
    FOREIGN KEY (AcademiaId) REFERENCES Academias(Id)
);