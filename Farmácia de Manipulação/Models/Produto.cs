using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmácia_de_Manipulação.Models
{
    class Produto
    {
        string codigo { get; set; }
        string descricao { get; set; }
        string lote { get; set; }
        string data_fabricacao { get; set; }
        string data_validade { get; set; }
        string recomendacoes { get; set; }
        int quantidade { get; set; }
        string segmento { get; set; }
        double valor_custo { get; set; }
        double valor_venda { get; set; }
        int estoqueminimo { get; set; }
        int estoquemaximo { get; set; }
        string cnpjfornecedor { get; set; }
    }
}
