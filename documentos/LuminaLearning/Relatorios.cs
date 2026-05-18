using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();

            panelGrafico.Paint += new PaintEventHandler(DesenharGraficoNoPainel);

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panelGrafico, new object[] { true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPs tela = new IPs();
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

        private void abaMenu1_OnbtnHomeClick(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
        }

        private void abaMenu1_OnbtnIPsClick(object sender, EventArgs e)
        {
            IPs tela = new IPs();
            tela.Show();
        }

        private void abaMenu1_OnbtnJogosClick(object sender, EventArgs e)
        {
            Jogos tela = new Jogos();
            tela.Show();
        }

        private void abaMenu1_OnbtnMonitoramentoClick(object sender, EventArgs e)
        {
            Monitoramento tela = new Monitoramento();
            tela.Show();
        }

        private void abaMenu1_OnbtnRelatoriosClick(object sender, EventArgs e)
        {
            Relatorios tela = new Relatorios();
            tela.Show();
        }

        private void abaMenu1_OnbtnSairClick(object sender, EventArgs e)
        {
            abaSair1.Visible = !abaSair1.Visible;

            if (abaSair1.Visible)
            {
                abaSair1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            abaTodas1.Visible = !abaTodas1.Visible;

            if (abaTodas1.Visible)
            {
                abaTodas1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void DesenharGraficoNoPainel(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Cor única azul-escura idêntica para todas as barras
            Color corBarraAzul = Color.FromArgb(92, 98, 127); // #5C627F

            // Dados do gráfico
            string[] jogos = { "Tabuada Fun", "Desafios Frações", "Quiz Numérico" };
            int[] valores = { 92, 81, 66 };

            // Configurações dimensionais baseadas no seu layout físico
            int xInicialBarra = 120;
            int yInicial = 40;
            int alturaBarra = 38;
            int espacamento = 14;
            int larguraMaximaPixels = panelGrafico.Width - xInicialBarra - 25;

            // Altura total da grade de fundo
            int alturaTotalGrafico = (jogos.Length * (alturaBarra + espacamento)) - espacamento;

            // 1. DESENHAR AS LINHAS DE GRADE VERTICAIS (Fundo do gráfico)
            using (Pen canetaGrade = new Pen(Color.FromArgb(235, 235, 235), 1)) // Cinza bem clarinho
            {
                for (int pct = 0; pct <= 100; pct += 20)
                {
                    int xPct = xInicialBarra + (pct * larguraMaximaPixels / 100);
                    // Desenha a linha vertical de cima até embaixo, antes das barras
                    g.DrawLine(canetaGrade, xPct, yInicial, xPct, yInicial + alturaTotalGrafico);
                }
            }

            // 2. TÍTULO CENTRALIZADO (Preto)
            Font fonteTitulo = new Font("Arial", 11, FontStyle.Bold);
            string tituloText = "Média de Acertos por Jogo";
            SizeF tamanhoTitulo = g.MeasureString(tituloText, fonteTitulo);
            float xTitulo = (panelGrafico.Width - tamanhoTitulo.Width) / 2;
            g.DrawString(tituloText, fonteTitulo, Brushes.Black, new PointF(xTitulo, 10));

            // 3. NOMES DOS JOGOS E BARRAS COM A COR CORRETA
            Font fonteTexto = new Font("Arial", 7.5f, FontStyle.Bold);

            for (int i = 0; i < jogos.Length; i++)
            {
                int yAtual = yInicial + (i * (alturaBarra + espacamento));
                int larguraCalculada = (valores[i] * larguraMaximaPixels) / 100;

                // Texto do jogo à esquerda
                g.DrawString(jogos[i], fonteTexto, Brushes.Black, new PointF(15, yAtual + 12));

                // Construção do retângulo da barra
                Rectangle retangulo = new Rectangle(xInicialBarra, yAtual, larguraCalculada, alturaBarra);

                using (Brush pincel = new SolidBrush(corBarraAzul))
                {
                    // Curvatura idêntica apenas na ponta direita da barra
                    DesenharRetanguloArredondadoDireita(g, pincel, retangulo, 12);
                }
            }

            // 4. RÉGUA INFERIOR DE 0% A 100%
            int yRegua = yInicial + alturaTotalGrafico + 8;
            Font fonteRegua = new Font("Arial", 7, FontStyle.Bold);

            for (int pct = 0; pct <= 100; pct += 20)
            {
                int xPct = xInicialBarra + (pct * larguraMaximaPixels / 100);
                g.DrawString(pct + "%", fonteRegua, Brushes.Black, new PointF(xPct - 10, yRegua));
            }
        }

        // Nova função auxiliar para arredondar apenas o lado direito da barra, mantendo a esquerda reta no eixo
        private void DesenharRetanguloArredondadoDireita(Graphics g, Brush pincel, Rectangle bounds, int radius)
        {
            if (bounds.Width <= radius) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                // Lado esquerdo reto (conectado ao início do gráfico)
                path.AddLine(bounds.X, bounds.Y + bounds.Height, bounds.X, bounds.Y);
                path.AddLine(bounds.X, bounds.Y, bounds.X + bounds.Width - radius, bounds.Y);

                // Cantos da direita arredondados
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);

                path.AddLine(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height, bounds.X, bounds.Y + bounds.Height);
                path.CloseAllFigures();
                g.FillPath(pincel, path);
            }
        }

        private void DesenharRetanguloArredondado(Graphics g, Brush pincel, Rectangle bounds, int radius)
        {
            if (bounds.Width <= radius) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                g.FillPath(pincel, path);
            }
        }
    }
}
