using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmácia_de_Manipulação.Models
{
    class Produto
    {
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string lote { get; set; }
        public string data_fabricacao { get; set; }
        public string data_validade { get; set; }
        public string recomendacoes { get; set; }
        public int quantidade { get; set; }
        public string segmento { get; set; }
        public double valor_custo { get; set; }
        public double valor_venda { get; set; }
        public int estoqueminimo { get; set; }
        public int estoquemaximo { get; set; }
        public string cnpjfornecedor { get; set; }
    }
}
