using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmácia_de_Manipulação.Models
{
    class Produto
    {
        string codigo;
        string descricao;
        string lote;
        string data_fabricacao;
        string data_validade;
        string recomendacoes;
        int quantidade;
        string segmento;
        double valor_custo;
        double valor_venda;
        int estoqueminimo;
        int estoquemaximo;
        string cnpjfornecedor;

        public Produto(string cod, string desc, string lot, string data_fabri, string data_vali, string recomend, int qtd,
            string segment, double vlr_custo, double vlr_venda, int stockmin, int stockmax, string cnpj)
        {
            codigo = cod;
            descricao = desc;
            lote = lot;
            data_fabricacao = data_fabri;
            data_validade = data_vali;
            recomendacoes = recomend;
            quantidade = qtd;
            segmento = segment;
            valor_custo = vlr_custo;
            valor_venda = vlr_venda;
            estoqueminimo = stockmin;
            estoquemaximo = stockmax;
            cnpjfornecedor = cnpj;
        }
    }
}
