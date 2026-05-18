namespace LuminaLearning
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.Show();
        }

        private void lblMessier_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
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

        private void abaMenu1_OnbtnHomeClick(object sender, EventArgs e)
        {
            Home tela = new Home();
            tela.Show();
        }

        private void abaMenu1_OnbtnCadastroClick(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.Show();
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

        private void abaMenu1_OnbtnJogosClick(object sender, EventArgs e)
        {
            Jogos tela = new Jogos();
            tela.Show();
        }

        private void panelSombra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
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
            abaSair1.Visible = !abaSair1.Visible;

            if (abaSair1.Visible)
            {
                abaSair1.BringToFront(); // Garante que ele fique na frente de tudo
            }
        }

        private void abaMenu1_OnbtnIPsClick(object sender, EventArgs e)
        {
            IPs tela = new IPs();
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
    }
}
