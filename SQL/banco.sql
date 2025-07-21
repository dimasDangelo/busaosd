create database busaosd;
use busaosd;

CREATE TABLE tipo_local (
 id INT auto_increment primary KEY,
 nome varchar(20)
);
CREATE TABLE locais (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE,
    id_tipo_local INT,
    FOREIGN KEY (id_tipo_local) REFERENCES tipo_local(id)
);

CREATE TABLE horarios_onibus (
    id INT AUTO_INCREMENT PRIMARY KEY,
    origem_id INT NOT NULL,
    destino_id INT NOT NULL,
    horario TIME NOT NULL,
    seg BOOLEAN DEFAULT FALSE,
    ter BOOLEAN DEFAULT FALSE,
    qua BOOLEAN DEFAULT FALSE,
    qui BOOLEAN DEFAULT FALSE,
    sex BOOLEAN DEFAULT FALSE,
    sab BOOLEAN DEFAULT FALSE,
    dom BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (origem_id) REFERENCES locais(id),
    FOREIGN KEY (destino_id) REFERENCES locais(id)
);

