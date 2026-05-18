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
            SuspendLayout();
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1370, 90);
            header1.TabIndex = 0;
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
            txtQuantidade.BackColor = Color.FromArgb(224, 224, 224);
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
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // QuantidadeIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnCadastrar);
            Controls.Add(txtQuantidade);
            Controls.Add(lblPergunta);
            Controls.Add(lblCadastro);
            Controls.Add(header1);
            Name = "QuantidadeIP";
            Text = "QuantidadeIP";
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
    }
}