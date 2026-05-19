namespace LuminaLearning
{
    partial class AbaMenu
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
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            btnIPs = new Button();
            btnMonitoramento = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnRelatorios = new Button();
            pictureBoxSair = new PictureBox();
            pictureBoxJogos = new PictureBox();
            pictureBoxHome = new PictureBox();
            btnSair = new Button();
            btnJogos = new Button();
            btnHome = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(146, 153, 188);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnIPs);
            panel1.Controls.Add(btnMonitoramento);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRelatorios);
            panel1.Controls.Add(pictureBoxSair);
            panel1.Controls.Add(pictureBoxJogos);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnJogos);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.user_plus_solid;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(6, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 64);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // btnIPs
            // 
            btnIPs.BackgroundImageLayout = ImageLayout.None;
            btnIPs.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIPs.Location = new Point(85, 317);
            btnIPs.Name = "btnIPs";
            btnIPs.Size = new Size(202, 64);
            btnIPs.TabIndex = 16;
            btnIPs.Text = "IPs Registrados";
            btnIPs.UseVisualStyleBackColor = true;
            btnIPs.Click += btnIPs_Click;
            // 
            // btnMonitoramento
            // 
            btnMonitoramento.BackgroundImageLayout = ImageLayout.None;
            btnMonitoramento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonitoramento.Location = new Point(85, 220);
            btnMonitoramento.Name = "btnMonitoramento";
            btnMonitoramento.Size = new Size(202, 64);
            btnMonitoramento.TabIndex = 15;
            btnMonitoramento.Text = "MONITORAMENTO";
            btnMonitoramento.UseVisualStyleBackColor = true;
            btnMonitoramento.Click += btnMonitoramento_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.eye_solid;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(6, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 64);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.file_solid;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 64);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackgroundImageLayout = ImageLayout.None;
            btnRelatorios.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorios.Location = new Point(85, 117);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(202, 64);
            btnRelatorios.TabIndex = 12;
            btnRelatorios.Text = "RELATÓRIOS";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // pictureBoxSair
            // 
            pictureBoxSair.BackgroundImage = Properties.Resources.arrow_right_from_bracket_solid1;
            pictureBoxSair.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxSair.Location = new Point(6, 515);
            pictureBoxSair.Name = "pictureBoxSair";
            pictureBoxSair.Size = new Size(76, 64);
            pictureBoxSair.TabIndex = 11;
            pictureBoxSair.TabStop = false;
            // 
            // pictureBoxJogos
            // 
            pictureBoxJogos.BackgroundImage = Properties.Resources.gamepad_solid;
            pictureBoxJogos.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxJogos.Location = new Point(6, 413);
            pictureBoxJogos.Name = "pictureBoxJogos";
            pictureBoxJogos.Size = new Size(76, 64);
            pictureBoxJogos.TabIndex = 10;
            pictureBoxJogos.TabStop = false;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.BackgroundImage = Properties.Resources.house_solid;
            pictureBoxHome.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxHome.Location = new Point(6, 20);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(76, 64);
            pictureBoxHome.TabIndex = 6;
            pictureBoxHome.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(85, 515);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(202, 64);
            btnSair.TabIndex = 5;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnJogos
            // 
            btnJogos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogos.Location = new Point(85, 413);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(202, 64);
            btnJogos.TabIndex = 4;
            btnJogos.Text = "JOGOS";
            btnJogos.UseVisualStyleBackColor = true;
            btnJogos.Click += btnJogos_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(85, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 64);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // AbaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AbaMenu";
            Size = new Size(300, 600);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnJogos;
        private Button btnHome;
        private Button btnSair;
        private PictureBox pictureBoxSair;
        private PictureBox pictureBoxJogos;
        private PictureBox pictureBoxHome;
        private Button btnMonitoramento;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnRelatorios;
        private PictureBox pictureBox3;
        private Button btnIPs;
    }
}
