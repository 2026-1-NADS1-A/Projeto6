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
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
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
            // CadastroIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelIPs);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCadastro);
            Controls.Add(header1);
            Name = "CadastroIP";
            Text = "CadastroIP";
            Load += CadastroIP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Header header1;
        private Button btnCadastrar;
        private Label lblCadastro;
        private Panel panelIPs;
    }
}