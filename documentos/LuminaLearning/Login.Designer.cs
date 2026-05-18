namespace LuminaLearning
{
    partial class Login
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
            txtSenha = new TextBox();
            txtID = new TextBox();
            abaMenu1 = new AbaMenu();
            abaProfile1 = new abaProfile();
            abaSair1 = new abaSair();
            lblLogin = new Label();
            btnLogin = new Button();
            txtIP = new TextBox();
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
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(224, 224, 224);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(411, 417);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(548, 58);
            txtSenha.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(411, 273);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Identificador(CNPJ)";
            txtID.Size = new Size(548, 58);
            txtID.TabIndex = 2;
            // 
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 5;
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
            abaProfile1.TabIndex = 6;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(224, 224, 224);
            abaSair1.Location = new Point(531, 329);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 7;
            abaSair1.Visible = false;
            abaSair1.Load += abaSair1_Load;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Gray;
            lblLogin.FlatStyle = FlatStyle.Flat;
            lblLogin.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(446, 168);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(479, 86);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login Empresa";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gray;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(580, 481);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(213, 58);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtIP
            // 
            txtIP.BackColor = Color.FromArgb(224, 224, 224);
            txtIP.BorderStyle = BorderStyle.FixedSingle;
            txtIP.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIP.Location = new Point(411, 345);
            txtIP.Multiline = true;
            txtIP.Name = "txtIP";
            txtIP.PlaceholderText = "IP Origem";
            txtIP.Size = new Size(548, 58);
            txtIP.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(txtIP);
            Controls.Add(abaProfile1);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(abaMenu1);
            Controls.Add(txtID);
            Controls.Add(txtSenha);
            Controls.Add(header1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Header header1;
        private TextBox txtSenha;
        private TextBox txtID;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
        private Label lblLogin;
        private Button btnLogin;
        private TextBox txtIP;
    }
}