-- Database: farmacia

-- DROP DATABASE farmacia;

CREATE DATABASE farmacia
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    T-- Database: farmacia

-- DROP DATABASE farmacia;

CREATE DATABASE farmacia
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;
	
create table funcionario(
	cpf varchar(20) not null,
    nome varchar(50) not null,
    data_nasc date not null,
    numero varchar(10),
    rua varchar(60),
    bairro varchar(50),
    cidade varchar(50),
    telefone1 varchar(20),
    telefone2 varchar(20),
    email varchar(70),
    usuario varchar(25),
    senha varchar(100),
    cargo varchar(20),
    data_admissao date,
    primary key(cpf)
);

insert into funcionario(cpf,nome,data_nasc,usuario,senha,cargo) values(37574358850,'Lucas','1999-04-18','lucas','0211','Proprietário');

create table cliente(
	cpf varchar(20) not null primary key,
    nome varchar(50) not null,
    data_nasc date not null,
    numero varchar(10),
    rua varchar(60),
    bairro varchar(50),
    cidade varchar(50),
    telefone1 varchar(20),
    telefone2 varchar(20),
    email varchar(70),
    fk_funcionario varchar(20),
    foreign key (fk_funcionario) references funcionario(cpf) ON DELETE CASCADE ON UPDATE CASCADE
);

create table medico_afiliado(
	crm varchar(30),
    nome_hopt varchar(50) not null,
    nome_medico varchar(50) not null,
    especialidade varchar(50) not null,
    numero_hopt varchar(10),
    rua_hopt varchar(60),
    bairro_hopt varchar(50),
    cidade varchar(50),
    tel_hopt varchar(20),
    fk_funcionario varchar(20),
    foreign key(fk_funcionario) references funcionario(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key(crm)
);

create table fornecedor(
	cnpj varchar(20) not null,
    nome varchar(50) not null,
    rua varchar(60),
    numero varchar(10),
    bairro varchar(50),
    cidade varchar(50),
    tel1 varchar(20),
    tel2 varchar(20),
    email varchar(60),
    fk_funcionario varchar(20) not null,
    primary key(cnpj),
    foreign key(fk_funcionario) references funcionario(cpf) ON DELETE CASCADE ON UPDATE CASCADE
);

create table produto(
	descricao varchar(50),
    codigo varchar(20),
    lote varchar(30),
    data_fabricacao date not null,
    data_validade date not null,
    recomendacoes text,
    medida varchar(2),
    estoque real,
    segmento varchar(30),
    unidade varchar(50),
    valor_custo real,
    valor_venda real,
    estoqueMin int,
    estoqueMax int,
    statusProduto varchar(20) default 'A Vencer',
    fk_funcionario varchar(20),
    fk_fornecedor varchar(20),
    foreign key (fk_funcionario) references funcionario(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key (fk_fornecedor) references fornecedor(cnpj) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key(codigo)
);

INSERT INTO produto(data_fabricacao,data_validade,codigo,lote) VALUES('2017-05-02','2017-06-25', '1211221221','ADS2W221');

UPDATE produto SET data_validade = '2017-06-24';

create table receita(
	numero_requisicao varchar(20),
    nome_paciente varchar(50),
    nome_medico varchar(50),
    informacoes text,
    fk_cliente varchar(20),
    foreign key (fk_cliente) references cliente(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key(numero_requisicao)
);

create table formula(
	id serial primary key,
    preco real,
    descricao varchar(50)
);

create table receita_formula_produto(
	num_receita varchar(20),
    id_formula int,
    cod_produto varchar(20),
    foreign key(num_receita) references receita(numero_requisicao) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key(id_formula) references formula(id) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key(cod_produto) references produto(codigo) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key(num_receita,id_formula,cod_produto)
);

create table pedido(
	fk_funcionario varchar(20),
    fk_cliente varchar(20),
    fk_receita varchar(20),
    id_pedido serial,
    data_encomenda date,
    data_retirada date,
    pgto_antecipado real,
    preco_total real,
    foreign key(fk_funcionario) references funcionario(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key(fk_cliente) references cliente(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key(fk_receita) references receita(numero_requisicao) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key (id_pedido)
);

create table pedido_cliente(
	fk_pedido int,
    fk_cliente varchar(20),
    foreign key(fk_pedido) references pedido(id_pedido) ON DELETE CASCADE ON UPDATE CASCADE,
    foreign key(fk_cliente) references cliente(cpf) ON DELETE CASCADE ON UPDATE CASCADE,
    primary key (fk_pedido,fk_cliente)
);

/*SELECT codigo,quantidade FROM produto,formula,receita_formula_produto
WHERE formula.id = receita_formula_produto.id_formula AND 
receita_formula_produto.cod_produto = produto.codigo;*/

/*Pega o nome das formulas que estao na receita*/
select DISTINCT descricao from formula,receita_formula_produto,receita where formula.id = receita_formula_produto.id_formula and 
receita_formula_produto.num_receita = '3127';

/*Produto produtos que pertencem a formulas*/
SELECT codigo, descricao, valor_venda as produtoInfo FROM produto, receita_formula_produto
WHERE receita_formula_produto.cod_produto = produto.codigo AND  
receita_formula_produto.id_formula = 55;

/*Pega informacoes dos cliente e pedidos para mostrar na tela principal*/
SELECT cpf,nome,telefone1,data_encomenda,data_retirada,preco_total FROM cliente,pedido,pedido_cliente
				WHERE pedido_cliente.fk_pedido = id_pedido AND pedido_cliente.fk_cliente = cliente.cpf;
    
/*Cria trigger produto vencido

DELIMITER $$
CREATE TRIGGER validadeProduto BEFORE UPDATE
ON produto
FOR EACH ROW
BEGIN
if(data_validade >= now()) THEN
	UPDATE produto SET statusProduto = 'VENCIDO';
ELSE
	UPDATE produto SET statusProduto = 'A Vencer';
END IF;
END$$
delimiter ;


/*Tabelas que nao deram certo*/
/*create table formula_receita(
	id_receita varchar(20),
    id_formula int,
    foreign key(id_receita) references receita(numero_requisicao),
    foreign key(id_formula) references formula(id),
    primary key(id_receita,id_formula)
);

select * from formula_receita

create table produto_formula(
	id_formula int,
    id_produto varchar(20),
    foreign key(id_formula) references formula(id),
    foreign key(id_produto) references produto(codigo),
    primary key(id_formula,id_produto)
);
*/ABLESPACE = pg_default
    CONNECTION LIMIT = -1;