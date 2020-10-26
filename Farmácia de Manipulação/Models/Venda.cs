namespace Farmácia_de_Manipulação.Models
{
    class Venda
    {
        public string cod_venda { get; set; }
        public string cod_produto { get; set; }
        public string cod_cliente { get; set; }
        public string cod_funcionario { get; set; }
        public int quantidade { get; set; }
        public double valor_venda { get; set; }
    }
}
