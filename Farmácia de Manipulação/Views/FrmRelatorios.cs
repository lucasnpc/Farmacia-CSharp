using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Farmácia_de_Manipulação.Controladores;
using Farmácia_de_Manipulação.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;

namespace Farmácia_de_Manipulação.Views
{
    public partial class FrmRelatorios : Form
    {
        List<Venda> vendas = new List<Venda>();

        public FrmRelatorios()
        {
            InitializeComponent();

            /*Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();

            string caminho = @"C:\Users\Lucas\Documents\teste.pdf";

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminho, FileMode.Create));

            document.Open();
            string dados = "Código Venda Código Produto Código Cliente Código Funcionário Quantidade Valor Venda\n";
            if (controle.Equals("1"))
            {
                Paragraph paragraph = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12));
                paragraph.Alignment = Element.ALIGN_JUSTIFIED;
                foreach (Venda v in vendas)
                {
                    paragraph.Add(v.cod_venda + "     " + v.cod_produto + "      " + v.cod_cliente + "      " + v.cod_funcionario + "      " +
                        v.quantidade + "      " + v.valor_venda+"\n");
                }
                document.Add(paragraph);
                document.Close();
            }*/
        }

        private void bRelatorioVenda_Click(object sender, EventArgs e)
        {
            vendas = new VendaDAO().GetVendas();

            DataTable dt = new DataTable();
            dt.Columns.Add("Código Venda", typeof(string));
            dt.Columns.Add("Código Produto", typeof(string));
            dt.Columns.Add("Código Cliente", typeof(string));
            dt.Columns.Add("Código Funcionário", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Valor Venda", typeof(string));

            foreach (Venda v in vendas)
            {
                DataRow dr = dt.NewRow();
                dr["Código Venda"] = v.cod_venda;
                dr["Código Produto"] = v.cod_produto;
                dr["Código Cliente"] = v.cod_cliente;
                dr["Código Funcionário"] = v.cod_funcionario;
                dr["Quantidade"] = v.quantidade.ToString();
                dr["Valor Venda"] = v.valor_venda.ToString();

                dt.Rows.Add(dr);
            }
            dataGridRelatorios.DataSource = dt;
            dataGridRelatorios.Update();
            exportarPdf.Enabled = true;
        }

        private void exportarPdf_Click(object sender, EventArgs e)
        {
            if (dataGridRelatorios.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = @"C:\Users\Lucas\Documents\teste.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridRelatorios.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridRelatorios.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (Venda v in vendas)
                            {
                                pdfTable.AddCell(v.cod_venda);
                                pdfTable.AddCell(v.cod_produto);
                                pdfTable.AddCell(v.cod_cliente);
                                pdfTable.AddCell(v.cod_funcionario);
                                pdfTable.AddCell(v.quantidade.ToString());
                                pdfTable.AddCell(v.valor_venda.ToString());
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dados Exportados com sucesso !!!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro :" + ex.Message);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Sem registros para exportar !!!");
        }
    }
}
