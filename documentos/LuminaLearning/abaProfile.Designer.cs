namespace LuminaLearning
{
    partial class abaProfile
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxProfile = new PictureBox();
            lblNome = new Label();
            lblPacote = new Label();
            txtBoxNome = new TextBox();
            txtBoxPacote = new TextBox();
            lblCNPJ = new Label();
            txtBoxCNPJ = new TextBox();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxProfile.BackColor = Color.Transparent;
            pictureBoxProfile.BackgroundImage = Properties.Resources.circle_user_regular;
            pictureBoxProfile.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProfile.Location = new Point(16, 16);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(135, 84);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(165, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(102, 40);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblPacote
            // 
            lblPacote.AutoSize = true;
            lblPacote.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacote.Location = new Point(165, 133);
            lblPacote.Name = "lblPacote";
            lblPacote.Size = new Size(108, 40);
            lblPacote.TabIndex = 2;
            lblPacote.Text = "Pacote:";
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(273, 16);
            txtBoxNome.Multiline = true;
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(271, 40);
            txtBoxNome.TabIndex = 3;
            // 
            // txtBoxPacote
            // 
            txtBoxPacote.Location = new Point(273, 133);
            txtBoxPacote.Multiline = true;
            txtBoxPacote.Name = "txtBoxPacote";
            txtBoxPacote.Size = new Size(271, 40);
            txtBoxPacote.TabIndex = 4;
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCNPJ.Location = new Point(165, 79);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(87, 40);
            lblCNPJ.TabIndex = 5;
            lblCNPJ.Text = "CNPJ:";
            // 
            // txtBoxCNPJ
            // 
            txtBoxCNPJ.Location = new Point(273, 79);
            txtBoxCNPJ.Multiline = true;
            txtBoxCNPJ.Name = "txtBoxCNPJ";
            txtBoxCNPJ.Size = new Size(271, 40);
            txtBoxCNPJ.TabIndex = 6;
            // 
            // btnSair
            // 
            btnSair.BackgroundImage = Properties.Resources.arrow_right_from_bracket_solid1;
            btnSair.BackgroundImageLayout = ImageLayout.Zoom;
            btnSair.Location = new Point(34, 125);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(91, 57);
            btnSair.TabIndex = 7;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // abaProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btnSair);
            Controls.Add(txtBoxCNPJ);
            Controls.Add(lblCNPJ);
            Controls.Add(txtBoxPacote);
            Controls.Add(txtBoxNome);
            Controls.Add(lblPacote);
            Controls.Add(lblNome);
            Controls.Add(pictureBoxProfile);
            Name = "abaProfile";
            Size = new Size(570, 200);
            Load += abaProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProfile;
        private Label lblNome;
        private Label lblPacote;
        private TextBox txtBoxNome;
        private TextBox txtBoxPacote;
        private Label lblCNPJ;
        private TextBox txtBoxCNPJ;
        private Button btnSair;
    }
}
