namespace LuminaLearning
{
    partial class abaSair
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
            pictureBoxSair = new PictureBox();
            lblSair = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSair
            // 
            pictureBoxSair.BackgroundImage = Properties.Resources.circle_user_regular;
            pictureBoxSair.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxSair.Location = new Point(104, 3);
            pictureBoxSair.Name = "pictureBoxSair";
            pictureBoxSair.Size = new Size(100, 50);
            pictureBoxSair.TabIndex = 0;
            pictureBoxSair.TabStop = false;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSair.Location = new Point(74, 56);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(155, 25);
            lblSair.TabIndex = 1;
            lblSair.Text = "Confirmar saída?";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Red;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(27, 95);
            btnConfirmar.Margin = new Padding(0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 38);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(167, 95);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 38);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // abaSair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 153, 188);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblSair);
            Controls.Add(pictureBoxSair);
            Name = "abaSair";
            Size = new Size(309, 146);
            Load += abaSair_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxSair;
        private Label lblSair;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}
