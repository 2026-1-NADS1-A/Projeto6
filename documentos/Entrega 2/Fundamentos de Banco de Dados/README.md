# Banco de Dados

## Modelo Físico

```sql
/* Modelo_Fisico_BD: */

CREATE TABLE ESCOLA (
    id_escola NUMBER(3) PRIMARY KEY,
    CNPJ VARCHAR2(14),
    senha VARCHAR2(16),
    nome VARCHAR2(100),
    status BOOLEAN,
    fk_PACOTE_id_pacote NUMBER(1)
);

CREATE TABLE PACOTE (
    id_pacote NUMBER(1) PRIMARY KEY,
    limite_acesso_mes NUMBER(5),
    preco_mensal NUMBER(10,2),
    nome VARCHAR2(50),
    status BOOLEAN
);

CREATE TABLE IP_AUTORIZADO (
    id_ip NUMBER(10) PRIMARY KEY,
    endereco_ip  VARCHAR2(45),
    fk_ESCOLA_id_escola NUMBER(3)
);

CREATE TABLE JOGO (
    id_jogo NUMBER(4) PRIMARY KEY,
    nome VARCHAR2(50),
    descricao VARCHAR2(255),
    disciplina VARCHAR2(50),
    faixa_etaria VARCHAR2(15),
    status BOOLEAN
);

CREATE TABLE define (
    fk_PACOTE_id_pacote NUMBER(1),
    fk_JOGO_id_jogo NUMBER(4)
);
 
ALTER TABLE ESCOLA ADD CONSTRAINT FK_ESCOLA_PACOTE
    FOREIGN KEY (fk_PACOTE_id_pacote)
    REFERENCES PACOTE (id_pacote);

ALTER TABLE IP_AUTORIZADO ADD CONSTRAINT FK_IP_AUTORIZADO_ESCOLA
    FOREIGN KEY (fk_ESCOLA_id_escola)
    REFERENCES ESCOLA (id_escola);

ALTER TABLE define ADD CONSTRAINT FK_define_1
    FOREIGN KEY (fk_PACOTE_id_pacote)
    REFERENCES PACOTE (id_pacote)
    ON DELETE RESTRICT;
 
ALTER TABLE define ADD CONSTRAINT FK_define_2
    FOREIGN KEY (fk_JOGO_id_jogo)
    REFERENCES JOGO (id_jogo)
    ON DELETE RESTRICT;

