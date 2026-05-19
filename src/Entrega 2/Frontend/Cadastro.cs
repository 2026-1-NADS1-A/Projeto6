using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class Cadastro : Form
    {
        private bool emNavegacao = false;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
        }

        private void header1_OnMenuClick(object sender, EventArgs e)
        {
            abaMenu1.Visible = !abaMenu1.Visible;

            if (abaMenu1.Visible)
            {
                abaMenu1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void abaMenu1_OnbtnCadastroClick(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.Show();
        }

        private void abaMenu1_OnbtnHomeClick(object sender, EventArgs e)
        {
            Home tela = new Home();
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

        private void abaMenu1_OnbtnLoginClick(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
        }

        private void abaMenu1_OnbtnPacotesClick(object sender, EventArgs e)
        {
            Pacotes tela = new Pacotes();
            tela.Show();
        }

        private void header1_OnbtnProfile(object sender, EventArgs e)
        {
            abaProfile1.Visible = !abaProfile1.Visible;

            if (abaProfile1.Visible)
            {
                abaProfile1.BringToFront(); // Garante que ele fique na frente de tudo
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

        private void abaMenu1_OnbtnSairClick(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha tudo e limpa a memória instantaneamente
        }

        private void btnIrLogin_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            QuantidadeIP tela = new QuantidadeIP();
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

        private void abaProfile1_OnbtnSairClick_1(object sender, EventArgs e)
        {
            abaSair1.Visible = !abaSair1.Visible;

            if (abaSair1.Visible)
            {
                abaSair1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se NÃO está em navegação, significa que o usuário clicou no X da janela
            if (!emNavegacao)
            {
                Application.Exit(); // Encerra o app por completo
            }
        }
    }
}
