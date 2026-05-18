namespace LuminaLearning
{
    partial class Cadastro
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
            lblCadastro = new Label();
            header1 = new Header();
            txtNome = new TextBox();
            txtCNPJ = new TextBox();
            txtConfirmar = new TextBox();
            txtCriar = new TextBox();
            btnCadastrar = new Button();
            abaMenu1 = new AbaMenu();
            abaSair1 = new abaSair();
            abaProfile1 = new abaProfile();
            SuspendLayout();
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.BackColor = Color.Gray;
            lblCadastro.FlatStyle = FlatStyle.Flat;
            lblCadastro.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastro.ForeColor = Color.White;
            lblCadastro.Location = new Point(398, 168);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(575, 86);
            lblCadastro.TabIndex = 2;
            lblCadastro.Text = "Cadastro Empresa";
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1370, 90);
            header1.TabIndex = 3;
            header1.OnMenuClick += header1_OnMenuClick;
            header1.OnbtnProfile += header1_OnbtnProfile;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(224, 224, 224);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = SystemColors.ControlText;
            txtNome.Location = new Point(411, 279);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(548, 58);
            txtNome.TabIndex = 4;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.FromArgb(224, 224, 224);
            txtCNPJ.BorderStyle = BorderStyle.FixedSingle;
            txtCNPJ.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.ForeColor = SystemColors.ControlText;
            txtCNPJ.Location = new Point(411, 353);
            txtCNPJ.Multiline = true;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PlaceholderText = "CNPJ";
            txtCNPJ.Size = new Size(548, 58);
            txtCNPJ.TabIndex = 5;
            // 
            // txtConfirmar
            // 
            txtConfirmar.BackColor = Color.FromArgb(224, 224, 224);
            txtConfirmar.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmar.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmar.ForeColor = SystemColors.ControlText;
            txtConfirmar.Location = new Point(411, 525);
            txtConfirmar.Multiline = true;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "Confirmar Senha";
            txtConfirmar.Size = new Size(548, 58);
            txtConfirmar.TabIndex = 6;
            // 
            // txtCriar
            // 
            txtCriar.BackColor = Color.FromArgb(224, 224, 224);
            txtCriar.BorderStyle = BorderStyle.FixedSingle;
            txtCriar.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCriar.ForeColor = SystemColors.ControlText;
            txtCriar.Location = new Point(411, 435);
            txtCriar.Multiline = true;
            txtCriar.Name = "txtCriar";
            txtCriar.PlaceholderText = "Criar Senha";
            txtCriar.Size = new Size(548, 58);
            txtCriar.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(574, 603);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(222, 58);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 10;
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
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(224, 224, 224);
            abaSair1.Location = new Point(56, 216);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 11;
            abaSair1.Visible = false;
            // 
            // abaProfile1
            // 
            abaProfile1.BackColor = Color.FromArgb(224, 224, 224);
            abaProfile1.Location = new Point(800, 90);
            abaProfile1.Name = "abaProfile1";
            abaProfile1.Size = new Size(570, 200);
            abaProfile1.TabIndex = 12;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(abaMenu1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCriar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtCNPJ);
            Controls.Add(txtNome);
            Controls.Add(header1);
            Controls.Add(lblCadastro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCadastro;
        private Header header1;
        private TextBox txtNome;
        private TextBox txtCNPJ;
        private TextBox txtConfirmar;
        private TextBox txtCriar;
        private Button btnCadastrar;
        private AbaMenu abaMenu1;
        private abaSair abaSair1;
        private abaProfile abaProfile1;
    }
}