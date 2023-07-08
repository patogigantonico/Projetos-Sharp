using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CRUID_com_Datagridview
{
    public partial class Form1 : Form
    {
        //Instância da classe datagridview no objeto dt.
        DataTable dt = new DataTable();
        int id = 1; //Variável que recebe o valor do id. 

        //Sessão de métodos//

        private void CarregarTabela() //Este método faz com que as colunas sejam criadas no datagridview.
        {
            dt.Columns.Add("id", typeof(Int32)); //A coluna id do tipo inteiro 32 é adicionada.
            dt.Columns["id"].AutoIncrement = true; //A coluna id é definida como autoincremento, ou seja seu valor é adicionado automaticamente.
            dt.Columns["id"].AutoIncrementSeed = 1; //A coluna id recebe um incremento de +1  a cada vez que for adicionado.

            dt.Columns.Add("nome", typeof(string));//A nome id do tipo string é adicionada.
            dt.Columns.Add("e-mail", typeof(string));//A coluna e-mail do tipo string é adicionada.
            dt.Columns.Add("Classificação", typeof(string));//A coluna Classificação do tipo string é adicionada.

            dgv.DataSource = dt; //O datagridview recebe todas as colunas que foram definidas na instância dt.
        }

        private void RemoverLinha()
        {
            //Se a conta de linhas for 0, ou seja se não houver nenhuma linha no datagrid, mostrar a mensagem
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Não há nenhum dado na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Se nenhuma linha estiver selecionada, mostrar a mensagem.
            else if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha inteira primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv.SelectedRows.Count > 0) // Se houver pelo menos uma linha selecionada (mas não mais do que uma), remover a linha selecionada.
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    dgv.Rows.RemoveAt(row.Index);
                }
            }
            else //Se as linhas selecionadas forem maior que 0, ou seja se houver linhas selecionadas.
            {
                var row = dgv.SelectedRows[0].Cells[0].RowIndex; //A variável row recebe as linhas selecionadas e as celulas.
                dgv.Rows.RemoveAt(row); //Método que remove as linhas com base nos parâmetros da variável row.
            }
        }

        private void AdicionarLinha() //Adiciona uma nova linha à tabela.
        {
            //Se as caixas de texto estiverem vazias, retornar uma mensagem.
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Ainda há campos a serem preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else  //Se não, adicionar a linha e limpar as caixas de texto.
            {
                dt.Rows.Add(id++, txtNome.Text, txtEmail.Text); //Adiciona a linha com os dados inseridos nas caixas de texto.
                //Limpa as caixas de texto.
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
        }

        private void atualizarLinha() //Atualiza uma linha selecionada já existente na tabela.
        {
            if (dgv.SelectedRows.Count > 0) //Se houver linhas selecionadas
            {
                try //Tenta executar o que está abaixo.
                {
                    //Para cada linha em dgv.SelectedRows, faça.
                    foreach (DataGridViewRow row in dgv.SelectedRows) //Atualiza cada linha selecionada com o que foi digitado pelo user.
                    {
                        //Acrescenta os dados digitados às colunas correspondentes
                        row.Cells["e-mail"].Value = txtEmail.Text; 
                        row.Cells["nome"].Value = txtNome.Text;

                        //Limpa as caixas de texto ao atualizar.
                        txtEmail.Text = string.Empty;
                        txtNome.Text = string.Empty;
                    }
                }
                catch (Exception ex) //Captura a exceção e retorna em uma mensagem de erro.
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dgv.SelectedRows.Count == 0) //Se nenhuma linha for selecionada, mostrar a mensagem.
            {
                MessageBox.Show("Selecione uma linha primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Fim da sessão de métodos//

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTabela(); //Chama o método que faz o datagridview criar as colunas toda vez que o programa é iniciado.
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarLinha(); //Chama o método que adiciona as linhas.
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverLinha(); //Chama o método que remove as linhas.
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarLinha(); //Chama o método que atualiza as linhas selecionadas.
        }
    }
}
