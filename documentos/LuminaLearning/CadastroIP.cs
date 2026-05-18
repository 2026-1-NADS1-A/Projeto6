using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class CadastroIP : Form
    {
        // guarda a quantidade de IPs
        private int quantidadeIPs;

        // construtor
        public CadastroIP(int quantidade)
        {
            InitializeComponent();

            quantidadeIPs = quantidade;
        }

        // quando a tela carregar
        private void CadastroIP_Load(object sender, EventArgs e)
        {
            GerarCamposIPs();
        }

        // gera os campos dinamicamente
        private void GerarCamposIPs()
        {
            panelIPs.Controls.Clear();

            // distância das laterais
            int margemLateral = 20;

            // distância vertical entre os campos
            int espacamento = 15;

            // posição inicial
            int posY = 20;

            // largura automática
            int larguraCampo = panelIPs.Width - (margemLateral * 2);

            for (int i = 0; i < quantidadeIPs; i++)
            {
                TextBox txtIP = new TextBox();

                txtIP.Name = "txtIP" + i;

                // multiline permite aumentar altura
                txtIP.Multiline = true;

                // tamanho do campo
                txtIP.Size = new Size(larguraCampo, 48);

                // posição
                txtIP.Location = new Point(margemLateral, posY);

                // visual
                txtIP.BackColor = Color.FromArgb(146, 152, 194);

                txtIP.ForeColor = Color.White;

                txtIP.BorderStyle = BorderStyle.None;

                txtIP.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                // placeholder
                txtIP.PlaceholderText = $"digite o {i + 1}º IP:";

                // adiciona no panel
                panelIPs.Controls.Add(txtIP);

                // próxima posição
                posY += 48 + espacamento;
            }
        }

        // evento do botão
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pacotes tela = new Pacotes();
            tela.Show();
        }

        private void CadastroIP_Load_1(object sender, EventArgs e)
        {

        }
    }
}
