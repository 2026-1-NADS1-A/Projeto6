namespace LuminaLearning
{
    partial class QuantidadeIP
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
            lblCadastro = new Label();
            lblPergunta = new Label();
            txtQuantidade = new TextBox();
            btnCadastrar = new Button();
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
            lblCadastro.TabIndex = 3;
            lblCadastro.Text = "Cadastro Empresa";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(464, 374);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(442, 45);
            lblPergunta.TabIndex = 4;
            lblPergunta.Text = "Quantos IPs deseja cadastrar?";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(146, 153, 188);
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.ForeColor = SystemColors.ControlText;
            txtQuantidade.Location = new Point(411, 422);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade de IPs";
            txtQuantidade.Size = new Size(548, 58);
            txtQuantidade.TabIndex = 5;
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
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // abaMenu1
            // 
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 11;
            abaMenu1.Visible = false;
            abaMenu1.OnbtnHomeClick += abaMenu1_OnbtnHomeClick;
            abaMenu1.OnbtnCadastroClick += abaMenu1_OnbtnCadastroClick;
            abaMenu1.OnbtnLoginClick += abaMenu1_OnbtnLoginClick;
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
            abaProfile1.TabIndex = 12;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick_1;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(146, 153, 188);
            abaSair1.Location = new Point(531, 301);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 13;
            abaSair1.Visible = false;
            // 
            // QuantidadeIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(abaMenu1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtQuantidade);
            Controls.Add(lblPergunta);
            Controls.Add(lblCadastro);
            Controls.Add(header1);
            Name = "QuantidadeIP";
            Text = "QuantidadeIP";
            FormClosing += QuantidadeIP_FormClosing;
            Load += QuantidadeIP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Header header1;
        private Label lblCadastro;
        private Label lblPergunta;
        private TextBox txtQuantidade;
        private Button btnCadastrar;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
    }
}