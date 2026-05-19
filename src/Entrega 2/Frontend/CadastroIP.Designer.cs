namespace LuminaLearning
{
    partial class CadastroIP
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
            btnCadastrar = new Button();
            lblCadastro = new Label();
            panelIPs = new Panel();
            abaMenu1 = new AbaMenu();
            abaProfile1 = new abaProfile();
            abaSair1 = new abaSair();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BackColor = Color.FromArgb(91, 182, 188);
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1370, 90);
            header1.TabIndex = 0;
            header1.OnMenuClick += header1_OnMenuClick;
            header1.OnbtnProfile += header1_OnbtnProfile;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(144, 96, 196);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 52, 102);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 52, 102);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(574, 603);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(222, 58);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.BackColor = Color.FromArgb(144, 96, 196);
            lblCadastro.FlatStyle = FlatStyle.Flat;
            lblCadastro.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.ForeColor = Color.White;
            lblCadastro.Location = new Point(398, 168);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(575, 86);
            lblCadastro.TabIndex = 9;
            lblCadastro.Text = "Cadastro Empresa";
            // 
            // panelIPs
            // 
            panelIPs.AutoScroll = true;
            panelIPs.Location = new Point(398, 286);
            panelIPs.Name = "panelIPs";
            panelIPs.Size = new Size(575, 298);
            panelIPs.TabIndex = 15;
            // 
            // abaMenu1
            // 
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 16;
            abaMenu1.Visible = false;
            abaMenu1.OnbtnHomeClick += abaMenu1_OnbtnHomeClick;
            abaMenu1.OnbtnJogosClick += abaMenu1_OnbtnJogosClick;
            abaMenu1.OnbtnSairClick += abaMenu1_OnbtnSairClick;
            abaMenu1.OnbtnRelatoriosClick += abaMenu1_OnbtnRelatoriosClick;
            abaMenu1.OnbtnMonitoramentoClick += abaMenu1_OnbtnMonitoramentoClick;
            abaMenu1.OnbtnIPsClick += abaMenu1_OnbtnIPsClick;
            // 
            // abaProfile1
            // 
            abaProfile1.BackColor = Color.FromArgb(146, 153, 188);
            abaProfile1.Location = new Point(800, 90);
            abaProfile1.Name = "abaProfile1";
            abaProfile1.Size = new Size(570, 200);
            abaProfile1.TabIndex = 17;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick_1;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(146, 153, 188);
            abaSair1.Location = new Point(531, 301);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 18;
            abaSair1.Visible = false;
            // 
            // CadastroIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(abaMenu1);
            Controls.Add(panelIPs);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCadastro);
            Controls.Add(header1);
            Name = "CadastroIP";
            Text = "CadastroIP";
            FormClosing += CadastroIP_FormClosing;
            Load += CadastroIP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Header header1;
        private Button btnCadastrar;
        private Label lblCadastro;
        private Panel panelIPs;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
    }
}