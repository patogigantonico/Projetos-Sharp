using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gasolina
{
    public partial class Form1 : Form
    {
        Combustível BombaCombustível = new Combustível();

        public Form1()
        {
            InitializeComponent();
        }

        //Evento que impede adicionar letras, sinais de pontuação, simbolos e espaços.
        private void KeyPressTextbox(object sender, KeyPressEventArgs e) 
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        //Botão calcular.
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls) 
            {
                if (controle is TextBox && controle.Text == string.Empty && controle != QtdLitros && controle != QtdeKM)
                {
                    MessageBox.Show("Há campos que necessitam ser preenchidos!");
                    return;
                }
            }

            BombaCombustível.NomeVeiculo = NomeCarro.Text;

            //CalcLitros();
            BombaCombustível.Dinheiro = Convert.ToDouble(Dinheiro.Text);
            BombaCombustível.ValorLitro = Convert.ToDouble(ValorLitro.Text);

            //CalcKM();
            BombaCombustível.KmLitro = Convert.ToDouble(KMLitros.Text);
            BombaCombustível.QtdeLitros = Convert.ToDouble(BombaCombustível.CalcLitros());

            BombaCombustível.tipo = comboBox1.Text; //O tipo recebe o valor inserido na combobox.

            //Mostra os resultados nas txtbox
            QtdeKM.Text = BombaCombustível.CalcKM().ToString();
            QtdLitros.Text = BombaCombustível.CalcLitros().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    ValorLitro.Text = "4,50";
                    break;

                case 1:
                    ValorLitro.Text = "5,90";
                    break;

                case 2:
                    ValorLitro.Text = "8,50";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se as caixas estiverem vazias.
            if (NomeCarro.Text == string.Empty && Dinheiro.Text == string.Empty && ValorLitro.Text == string.Empty && KMLitros.Text == string.Empty && QtdeKM.Text == string.Empty && QtdLitros.Text == string.Empty)
            {
                MessageBox.Show("Os campos já estão limpos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                //Esvazia as caixas de texto.
                NomeCarro.Text = string.Empty;
                Dinheiro.Text = string.Empty;
                ValorLitro.Text = string.Empty;
                KMLitros.Text = string.Empty;
                comboBox1.Text = string.Empty;
                QtdeKM.Text = string.Empty;
                QtdLitros.Text = string.Empty;
            }
        }
    }
}
