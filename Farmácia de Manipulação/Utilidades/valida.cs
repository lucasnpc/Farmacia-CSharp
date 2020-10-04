using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmácia_de_Manipulação
{
    class valida
    {
        public static bool validacpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int resto = 0, soma = 0;
            int I = 0;
            string digito = "";
            int[] numerosCpf = new int[11];
            string valor;
            try
            {
                valor = cpf.Substring(0, 9);

                for (I = 0; I < 9; I++)
                {
                    soma += int.Parse(valor[I].ToString()) * multiplicador1[I];
                }

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();

                valor += digito;
                soma = 0;
                for (I = 0; I < 10; I++)
                    soma += int.Parse(valor[I].ToString()) * multiplicador2[I];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito += resto.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (cpf.EndsWith(digito))
            {
                return true;
            }
            else
                return false;

        }

        public static bool validaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0, resto = 0;
            string digito = "", cnpjPassado = "";

            cnpjPassado = cnpj.Substring(0, 12);

            for(int I = 0; I < 12; I++)
            {
                soma += int.Parse(cnpjPassado[I].ToString()) * multiplicador1[I];
            }
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            cnpjPassado += digito;
            soma = 0;
            resto = 0;
            for (int I = 0; I < 13; I++)
                soma += int.Parse(cnpjPassado[I].ToString()) * multiplicador2[I];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();

            if (cnpj.EndsWith(digito))
                return true;
            else
                return false;
        }
    }
}
