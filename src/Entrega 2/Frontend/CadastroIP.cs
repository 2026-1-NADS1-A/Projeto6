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
        private bool emNavegacao = false;

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
            this.emNavegacao = true;
            this.Close();
        }

        private void CadastroIP_Load_1(object sender, EventArgs e)
        {

        }

        private void header1_OnbtnProfile(object sender, EventArgs e)
        {
            abaProfile1.Visible = !abaProfile1.Visible;

            if (abaProfile1.Visible)
            {
                abaProfile1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void header1_OnMenuClick(object sender, EventArgs e)
        {
            abaMenu1.Visible = !abaMenu1.Visible;

            if (abaMenu1.Visible)
            {
                abaMenu1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void abaProfile1_OnbtnSairClick(object sender, EventArgs e)
        {
            abaSair1.Visible = !abaSair1.Visible;

            if (abaSair1.Visible)
            {
                abaSair1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void abaMenu1_OnbtnHomeClick(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
            this.emNavegacao = true;
            this.Close();
        }

        private void abaMenu1_OnbtnIPsClick(object sender, EventArgs e)
        {
            IPs tela = new IPs();
            tela.Show();
            this.emNavegacao = true;
            this.Close();
        }

        private void abaMenu1_OnbtnJogosClick(object sender, EventArgs e)
        {
            Jogos tela = new Jogos();
            tela.Show();
            this.emNavegacao = true;
            this.Close();
        }

        private void abaMenu1_OnbtnMonitoramentoClick(object sender, EventArgs e)
        {
            Monitoramento tela = new Monitoramento();
            tela.Show();
            this.emNavegacao = true;
            this.Close();
        }

        private void abaMenu1_OnbtnRelatoriosClick(object sender, EventArgs e)
        {
            Relatorios tela = new Relatorios();
            tela.Show();
            this.emNavegacao = true;
            this.Close();
        }

        private void abaMenu1_OnbtnSairClick(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha tudo e limpa a memória instantaneamente
        }

        private void abaProfile1_OnbtnSairClick_1(object sender, EventArgs e)
        {
            abaSair1.Visible = !abaSair1.Visible;

            if (abaSair1.Visible)
            {
                abaSair1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void CadastroIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se NÃO está em navegação, significa que o usuário clicou no X da janela
            if (!emNavegacao)
            {
                Application.Exit(); // Encerra o app por completo
            }
        }
    }
}
