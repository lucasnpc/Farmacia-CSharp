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
    }
}
