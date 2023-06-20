using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bloco_de_notas_simples
{
    public partial class Editar_fonte : Form
    {
        public Editar_fonte()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caixatamanho.SelectedIndex == 1 && caixafonte.SelectedIndex == 1 && caixaestilo.SelectedIndex == 1) 
            { 

            }
        }
    }
}
