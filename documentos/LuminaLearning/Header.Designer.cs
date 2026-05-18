namespace LuminaLearning
{
    partial class Header
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
            pictureBox1 = new PictureBox();
            button2 = new Button();
            btnProfile = new Button();
            btnLogo = new Button();
            btnUser = new Button();
            btnMenu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnLogo);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 90);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Cadastro_Empresa_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(112, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 77);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = Properties.Resources.bars_solid;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1326, 12);
            button2.Name = "button2";
            button2.Size = new Size(65, 54);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.BackgroundImage = Properties.Resources.circle_user_regular;
            btnProfile.BackgroundImageLayout = ImageLayout.Zoom;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(1255, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(65, 54);
            btnProfile.TabIndex = 4;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackgroundImage = Properties.Resources.Lumina_Learning_removebg_preview;
            btnLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(17, 7);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(78, 75);
            btnLogo.TabIndex = 3;
            btnLogo.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUser.BackgroundImage = Properties.Resources.circle_user_regular;
            btnUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(2478, 12);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(65, 54);
            btnUser.TabIndex = 2;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMenu.BackgroundImage = Properties.Resources.bars_solid;
            btnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(2549, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(65, 54);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Header";
            Size = new Size(1424, 90);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogo;
        private Button btnUser;
        private Button btnMenu;
        private Button btnProfile;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
