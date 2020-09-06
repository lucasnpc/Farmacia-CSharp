using System;

namespace Farmácia_de_Manipulação.Models
{
    class Funcionario
    {
        public String cpf;
        public String nome;
        public string data_nascimento;
        public String numero_residencia;
        public String rua;
        public String bairro;
        public String cidade;
        public String tel1;
        public String tel2;
        public String email;
        public String usuario;
        public String senha;
        public String cargo;
        public string data_admissao;

        public Funcionario(String CPF, String name, String data_nasc, String numero, String rua, String bairro, String cidade, String tel1, String tel2
            , String email, String usuario, String senha, String cargo, String date)
        {
            this.cpf = CPF;
            this.nome = name;
            this.data_nascimento = data_nasc;
            this.numero_residencia = numero;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.tel1 = tel1;
            this.tel2 = tel2;
            this.email = email;
            this.usuario = usuario;
            this.senha = senha;
            this.cargo = cargo;
            this.data_admissao = date;
        }
    }
}
