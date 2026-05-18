using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class QuantidadeIP : Form
    {
        public QuantidadeIP()
        {
            InitializeComponent();
        }

        private void QuantidadeIP_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int quantidade;

            bool numeroValido = int.TryParse(txtQuantidade.Text, out quantidade);

            if (numeroValido && quantidade > 0)
            {
                CadastroIP tela = new CadastroIP(quantidade);

                tela.Show();
            }
            else
            {
                MessageBox.Show("Digite uma quantidade válida.");
            }
        }
    }
}
