namespace LuminaLearning
{
    partial class Monitoramento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header1 = new Header();
            abaMenu1 = new AbaMenu();
            abaProfile1 = new abaProfile();
            abaSair1 = new abaSair();
            panelMonitoramentoGeral = new Panel();
            lblMonitoramentoGeral = new Label();
            panel1 = new Panel();
            txtAtualizacao = new TextBox();
            lblAtualizacao = new Label();
            lblStatus = new Label();
            txtPacote = new TextBox();
            lblPacote = new Label();
            lblEscola = new Label();
            txtEscola = new TextBox();
            panelConsumo = new Panel();
            lblConsumo = new Label();
            panelIPsMonitorados = new Panel();
            lblIPsMonitorados = new Label();
            panelAlertas = new Panel();
            lblAlertas = new Label();
            panelMonitoramentoGeral.SuspendLayout();
            panel1.SuspendLayout();
            panelConsumo.SuspendLayout();
            panelIPsMonitorados.SuspendLayout();
            panelAlertas.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1370, 90);
            header1.TabIndex = 0;
            header1.OnMenuClick += header1_OnMenuClick;
            header1.OnbtnProfile += header1_OnbtnProfile;
            // 
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 1;
            abaMenu1.Visible = false;
            abaMenu1.OnbtnHomeClick += abaMenu1_OnbtnHomeClick;
            abaMenu1.OnbtnCadastroClick += abaMenu1_OnbtnCadastroClick;
            abaMenu1.OnbtnLoginClick += abaMenu1_OnbtnLoginClick;
            abaMenu1.OnbtnPacotesClick += abaMenu1_OnbtnPacotesClick;
            abaMenu1.OnbtnJogosClick += abaMenu1_OnbtnJogosClick;
            abaMenu1.OnbtnSairClick += abaMenu1_OnbtnSairClick;
            abaMenu1.OnbtnRelatoriosClick += abaMenu1_OnbtnRelatoriosClick;
            abaMenu1.OnbtnMonitoramentoClick += abaMenu1_OnbtnMonitoramentoClick;
            abaMenu1.OnbtnIPsClick += abaMenu1_OnbtnIPsClick;
            // 
            // abaProfile1
            // 
            abaProfile1.BackColor = Color.FromArgb(224, 224, 224);
            abaProfile1.Location = new Point(800, 90);
            abaProfile1.Name = "abaProfile1";
            abaProfile1.Size = new Size(570, 200);
            abaProfile1.TabIndex = 2;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(224, 224, 224);
            abaSair1.Location = new Point(531, 301);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 3;
            abaSair1.Visible = false;
            // 
            // panelMonitoramentoGeral
            // 
            panelMonitoramentoGeral.BackColor = Color.Gray;
            panelMonitoramentoGeral.Controls.Add(lblMonitoramentoGeral);
            panelMonitoramentoGeral.Location = new Point(59, 96);
            panelMonitoramentoGeral.Name = "panelMonitoramentoGeral";
            panelMonitoramentoGeral.Size = new Size(1253, 105);
            panelMonitoramentoGeral.TabIndex = 4;
            // 
            // lblMonitoramentoGeral
            // 
            lblMonitoramentoGeral.AutoSize = true;
            lblMonitoramentoGeral.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonitoramentoGeral.Location = new Point(375, 20);
            lblMonitoramentoGeral.Name = "lblMonitoramentoGeral";
            lblMonitoramentoGeral.Size = new Size(502, 65);
            lblMonitoramentoGeral.TabIndex = 0;
            lblMonitoramentoGeral.Text = "Monitoramento Geral";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(txtAtualizacao);
            panel1.Controls.Add(lblAtualizacao);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(txtPacote);
            panel1.Controls.Add(lblPacote);
            panel1.Controls.Add(lblEscola);
            panel1.Controls.Add(txtEscola);
            panel1.Location = new Point(59, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 143);
            panel1.TabIndex = 5;
            // 
            // txtAtualizacao
            // 
            txtAtualizacao.Location = new Point(891, 77);
            txtAtualizacao.Name = "txtAtualizacao";
            txtAtualizacao.Size = new Size(158, 23);
            txtAtualizacao.TabIndex = 6;
            // 
            // lblAtualizacao
            // 
            lblAtualizacao.AutoSize = true;
            lblAtualizacao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtualizacao.Location = new Point(669, 68);
            lblAtualizacao.Name = "lblAtualizacao";
            lblAtualizacao.Size = new Size(216, 32);
            lblAtualizacao.TabIndex = 5;
            lblAtualizacao.Text = "Última Atualização:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(669, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(208, 32);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status do Sistema:";
            // 
            // txtPacote
            // 
            txtPacote.Location = new Point(128, 77);
            txtPacote.Name = "txtPacote";
            txtPacote.Size = new Size(363, 23);
            txtPacote.TabIndex = 3;
            // 
            // lblPacote
            // 
            lblPacote.AutoSize = true;
            lblPacote.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacote.Location = new Point(38, 68);
            lblPacote.Name = "lblPacote";
            lblPacote.Size = new Size(89, 32);
            lblPacote.TabIndex = 2;
            lblPacote.Text = "Pacote:";
            // 
            // lblEscola
            // 
            lblEscola.AutoSize = true;
            lblEscola.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEscola.Location = new Point(38, 23);
            lblEscola.Name = "lblEscola";
            lblEscola.Size = new Size(84, 32);
            lblEscola.TabIndex = 1;
            lblEscola.Text = "Escola:";
            // 
            // txtEscola
            // 
            txtEscola.Location = new Point(128, 32);
            txtEscola.Name = "txtEscola";
            txtEscola.Size = new Size(363, 23);
            txtEscola.TabIndex = 0;
            // 
            // panelConsumo
            // 
            panelConsumo.BackColor = Color.Gray;
            panelConsumo.Controls.Add(lblConsumo);
            panelConsumo.Location = new Point(59, 358);
            panelConsumo.Name = "panelConsumo";
            panelConsumo.Size = new Size(421, 264);
            panelConsumo.TabIndex = 6;
            // 
            // lblConsumo
            // 
            lblConsumo.AutoSize = true;
            lblConsumo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsumo.Location = new Point(92, 12);
            lblConsumo.Name = "lblConsumo";
            lblConsumo.Size = new Size(227, 32);
            lblConsumo.TabIndex = 0;
            lblConsumo.Text = "Consumo de Pacote";
            // 
            // panelIPsMonitorados
            // 
            panelIPsMonitorados.BackColor = Color.Gray;
            panelIPsMonitorados.Controls.Add(lblIPsMonitorados);
            panelIPsMonitorados.Location = new Point(486, 358);
            panelIPsMonitorados.Name = "panelIPsMonitorados";
            panelIPsMonitorados.Size = new Size(502, 264);
            panelIPsMonitorados.TabIndex = 7;
            // 
            // lblIPsMonitorados
            // 
            lblIPsMonitorados.AutoSize = true;
            lblIPsMonitorados.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIPsMonitorados.Location = new Point(158, 12);
            lblIPsMonitorados.Name = "lblIPsMonitorados";
            lblIPsMonitorados.Size = new Size(186, 32);
            lblIPsMonitorados.TabIndex = 1;
            lblIPsMonitorados.Text = "IPs Monitorados";
            // 
            // panelAlertas
            // 
            panelAlertas.BackColor = Color.Gray;
            panelAlertas.Controls.Add(lblAlertas);
            panelAlertas.Location = new Point(994, 358);
            panelAlertas.Name = "panelAlertas";
            panelAlertas.Size = new Size(318, 379);
            panelAlertas.TabIndex = 8;
            // 
            // lblAlertas
            // 
            lblAlertas.AutoSize = true;
            lblAlertas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertas.Location = new Point(54, 12);
            lblAlertas.Name = "lblAlertas";
            lblAlertas.Size = new Size(211, 32);
            lblAlertas.TabIndex = 1;
            lblAlertas.Text = "Alertas do Sistema";
            // 
            // Monitoramento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(abaMenu1);
            Controls.Add(panelAlertas);
            Controls.Add(panelIPsMonitorados);
            Controls.Add(panelConsumo);
            Controls.Add(panel1);
            Controls.Add(panelMonitoramentoGeral);
            Controls.Add(header1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Monitoramento";
            Text = "Monitoramento";
            panelMonitoramentoGeral.ResumeLayout(false);
            panelMonitoramentoGeral.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelConsumo.ResumeLayout(false);
            panelConsumo.PerformLayout();
            panelIPsMonitorados.ResumeLayout(false);
            panelIPsMonitorados.PerformLayout();
            panelAlertas.ResumeLayout(false);
            panelAlertas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Header header1;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
        private Panel panelMonitoramentoGeral;
        private Label lblMonitoramentoGeral;
        private Panel panel1;
        private Label lblAtualizacao;
        private Label lblStatus;
        private TextBox txtPacote;
        private Label lblPacote;
        private Label lblEscola;
        private TextBox txtEscola;
        private TextBox txtAtualizacao;
        private Panel panelConsumo;
        private Panel panelIPsMonitorados;
        private Panel panelAlertas;
        private Label lblConsumo;
        private Label lblIPsMonitorados;
        private Label lblAlertas;
    }
}