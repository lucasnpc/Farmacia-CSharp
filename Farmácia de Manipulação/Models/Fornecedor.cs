namespace Farmácia_de_Manipulação.Models
{
    class Fornecedor
    {
       public string cnpj;
       public string nome;
       public string rua;
       public string numero;
       public string bairro;
       public string cidade;
       public string tel1;
       public string tel2;
       public string email;
       public string cpf_funcionario;


        public Fornecedor(string _cnpj, string _nome, string _rua, string _numero, string _bairro, string _cidade,
            string _tel1, string _tel2, string _email, string _cpf_funcionario)
        {
            cnpj = _cnpj;
            nome = _nome;
            rua = _rua;
            numero = _numero;
            bairro = _bairro;
            cidade = _cidade;
            tel1 = _tel1;
            tel2 = _tel2;
            email = _email;
            cpf_funcionario = _cpf_funcionario;
        }
    }
}
