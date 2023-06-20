using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Conversor_de_arquivos
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void btnSelecArq_Click(object sender, EventArgs e)
        {
            OpenFileDialog inserirArquivo = new OpenFileDialog();
            inserirArquivo.Filter = "Arquivos de texto |.txt";
            inserirArquivo.Title = "Abrir arquivo de texto";
            inserirArquivo.ShowDialog();
            

            if (inserirArquivo.CheckFileExists)
            {
                txtArquivo.Text = inserirArquivo.FileName;
            }
            else 
            {
                MessageBox.Show("Nenhum arquivo foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArquivo.Text)) 
            {
                MessageBox.Show("Insira um arquivo primeiro!", "Erro ao tentar converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listaFormatos.CheckedIndices == null || listaFormatos.CheckedItems == null) 
            {
                MessageBox.Show("Selecione um formato primeiro!", "Erro ao tentar converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            if (listaFormatos.CheckedIndices.Contains(0)) 
            {
                try
                {
                    //Diálogo de salvar.
                    SaveFileDialog salvar = new SaveFileDialog();
                    salvar.Title = "Salvar arquivo pdf";
                    salvar.Filter = "Arquivos pdf (.pdf) | .pdf";
                    var arqsalv = salvar.ShowDialog();

                    if (arqsalv == DialogResult.OK) //Se o usuário tiver pressionado "Salvar".
                    {
                        var doc = new Document();//Instância da classe document na variável doc.
                        using (FileStream ArquivoPDF = new FileStream(salvar.FileName, FileMode.Create, FileAccess.Write)) 
                        {
                            PdfWriter.GetInstance(doc, ArquivoPDF); //Obtém os parâmetros de doc e ArquivoPDF
                            doc.Open(); //Abre o documento pdf.
                            string conteudoArquivoInserido = File.ReadAllText(txtArquivo.Text); //Variável que obtem os textos do arquivo inserido.
                            Paragraph texto = new Paragraph(conteudoArquivoInserido); //Adiciona o texto do arquivo inserido no pdf.
                            doc.Add(texto); //Adiciona o texto do arquivo inserido no pdf.
                            doc.Close();//Fecha o documento pdf.
                            MessageBox.Show("Conversão feita com sucesso!"); //Mensagem informando que a conversão foi feita.
                        }
                    }
                }
                catch (Exception ex) //Caso ocorra algum erro mostrar a mensagem.
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (listaFormatos.CheckedIndices.Contains(1)) 
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Title = "Salvar arquivo docx";
                salvar.Filter = "Arquivos word (.docx) | .docx";
                var salvArq = salvar.ShowDialog();

                if (salvArq == DialogResult.OK) 
                {
                    try
                    {
                        MessageBox.Show("Ainda não é possível converter para este formato, tente novamente no futuro.", "Não é possível converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (listaFormatos.CheckedIndices.Contains(2))
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Title = "Salvar arquivo xlsx";
                salvar.Filter = "Arquivos excel (.xlsx) | .xlsx";
                var salvArq = salvar.ShowDialog();

                if (salvArq == DialogResult.OK)
                {
                    try
                    {
                        MessageBox.Show("Ainda não é possível converter para este formato, tente novamente no futuro.", "Não é possível converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void app_Load(object sender, EventArgs e)
        {

        }
    }
}
