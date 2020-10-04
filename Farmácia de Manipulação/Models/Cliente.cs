using Npgsql;
using System;
using System.Collections.Generic;

namespace Farmácia_de_Manipulação.Models
{
    class Cliente
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string data_nascimento { get; set; }
        public string numero_residencia { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string email { get; set; }
        public string cpffunc { get; set; }

        /*public Cliente(string CPF, string name, string data_nasc, string numero, string rua, string bairro,
            string cidade, string tel1, string tel2, string email, string CPFfunc)
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
            this.cpffunc = CPFfunc;
        }    */   
    }
}
