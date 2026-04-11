using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Collections.Generic;
using System.Drawing; 

namespace AULA05
{
    public partial class Form1 : Form
    {
        List<string> ipsAutorizados = new List<string>()
        {
            "127.0.0.1",
            "192.168.0.10",
            "192.168.0.11",
            "192.168.0.12",
            "10.1.33.5"
        };

        public Form1()
        {
            InitializeComponent();
            lblIP.Text = ObterIpLocal();
            {



            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.Encoding = System.Text.Encoding.UTF8;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar a página: " + ex.Message);
            }
        }

        private string ObterIpLocal()
        {
            string nomeMaquina = Dns.GetHostName();
            IPHostEntry host = Dns.GetHostEntry(nomeMaquina);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "IP não encontrado";
        }

        private void txtHTML_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtURL_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void lstLog_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string ipInformado = txtIpOrigem.Text.Trim();

            if (ipInformado == "")
            {
                MessageBox.Show("Informe o IP de origem.");
                txtIpOrigem.Focus();
                return;
            }

            if (ipsAutorizados.Contains(ipInformado))
            {
                MessageBox.Show("IP AUTORIZADO");
                lstLog.Items.Add("AUTORIZADO - IP " + ipInformado);
            }
            else
            {
                MessageBox.Show("IP BLOQUEADO");
                lstLog.Items.Add("BLOQUEADO - IP " + ipInformado);
            }
        }

        private void textBoxsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}