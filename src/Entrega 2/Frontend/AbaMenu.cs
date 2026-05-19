using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class AbaMenu : UserControl
    {
        public event EventHandler OnbtnHomeClick;
        public event EventHandler OnbtnCadastroClick;
        public event EventHandler OnbtnLoginClick;
        public event EventHandler OnbtnPacotesClick;
        public event EventHandler OnbtnJogosClick;
        public event EventHandler OnbtnSairClick;
        public event EventHandler OnbtnRelatoriosClick;
        public event EventHandler OnbtnMonitoramentoClick;
        public event EventHandler OnbtnIPsClick;
        public AbaMenu()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OnbtnHomeClick?.Invoke(this, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            OnbtnCadastroClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnbtnLoginClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            OnbtnPacotesClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            OnbtnJogosClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            OnbtnSairClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            OnbtnRelatoriosClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnMonitoramento_Click(object sender, EventArgs e)
        {
            OnbtnMonitoramentoClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnIPs_Click(object sender, EventArgs e)
        {
            OnbtnIPsClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
