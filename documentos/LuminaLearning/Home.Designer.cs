namespace LuminaLearning
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            btnJogo1 = new Button();
            btnJogo3 = new Button();
            btnJogo2 = new Button();
            btnJogo4 = new Button();
            header1 = new Header();
            abaMenu1 = new AbaMenu();
            abaProfile1 = new abaProfile();
            abaSair1 = new abaSair();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ControlDark;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(308, 263);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(754, 134);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Empresa";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnJogo1
            // 
            btnJogo1.Anchor = AnchorStyles.Bottom;
            btnJogo1.BackColor = Color.Silver;
            btnJogo1.FlatAppearance.BorderColor = Color.FromArgb(216, 191, 126);
            btnJogo1.FlatAppearance.BorderSize = 8;
            btnJogo1.FlatStyle = FlatStyle.Flat;
            btnJogo1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogo1.ForeColor = Color.White;
            btnJogo1.Location = new Point(10, 538);
            btnJogo1.Name = "btnJogo1";
            btnJogo1.Size = new Size(308, 170);
            btnJogo1.TabIndex = 3;
            btnJogo1.Text = "JOGO 1";
            btnJogo1.UseVisualStyleBackColor = false;
            // 
            // btnJogo3
            // 
            btnJogo3.Anchor = AnchorStyles.Bottom;
            btnJogo3.BackColor = Color.Silver;
            btnJogo3.FlatAppearance.BorderColor = Color.DimGray;
            btnJogo3.FlatAppearance.BorderSize = 8;
            btnJogo3.FlatStyle = FlatStyle.Flat;
            btnJogo3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogo3.ForeColor = Color.White;
            btnJogo3.Location = new Point(701, 538);
            btnJogo3.Name = "btnJogo3";
            btnJogo3.Size = new Size(308, 170);
            btnJogo3.TabIndex = 4;
            btnJogo3.Text = "JOGO 3";
            btnJogo3.UseVisualStyleBackColor = false;
            // 
            // btnJogo2
            // 
            btnJogo2.Anchor = AnchorStyles.Bottom;
            btnJogo2.BackColor = Color.Silver;
            btnJogo2.FlatAppearance.BorderColor = Color.DimGray;
            btnJogo2.FlatAppearance.BorderSize = 8;
            btnJogo2.FlatStyle = FlatStyle.Flat;
            btnJogo2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogo2.ForeColor = Color.White;
            btnJogo2.Location = new Point(363, 538);
            btnJogo2.Name = "btnJogo2";
            btnJogo2.Size = new Size(308, 170);
            btnJogo2.TabIndex = 5;
            btnJogo2.Text = "JOGO 2";
            btnJogo2.UseVisualStyleBackColor = false;
            // 
            // btnJogo4
            // 
            btnJogo4.Anchor = AnchorStyles.Bottom;
            btnJogo4.BackColor = Color.Silver;
            btnJogo4.FlatAppearance.BorderColor = Color.DimGray;
            btnJogo4.FlatAppearance.BorderSize = 8;
            btnJogo4.FlatStyle = FlatStyle.Flat;
            btnJogo4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogo4.ForeColor = Color.White;
            btnJogo4.Location = new Point(1049, 538);
            btnJogo4.Name = "btnJogo4";
            btnJogo4.Size = new Size(308, 170);
            btnJogo4.TabIndex = 6;
            btnJogo4.Text = "JOGO 4";
            btnJogo4.UseVisualStyleBackColor = false;
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1370, 90);
            header1.TabIndex = 7;
            header1.OnMenuClick += header1_OnMenuClick;
            header1.OnbtnProfile += header1_OnbtnProfile;
            // 
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 9;
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
            abaProfile1.Location = new Point(804, 90);
            abaProfile1.Name = "abaProfile1";
            abaProfile1.Size = new Size(566, 200);
            abaProfile1.TabIndex = 10;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(224, 224, 224);
            abaSair1.Location = new Point(531, 329);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 11;
            abaSair1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Cadastro_Empresa_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(462, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 169);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(pictureBox1);
            Controls.Add(abaMenu1);
            Controls.Add(header1);
            Controls.Add(btnJogo4);
            Controls.Add(btnJogo2);
            Controls.Add(btnJogo3);
            Controls.Add(btnJogo1);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCadastrar;
        private Button btnJogo1;
        private Button btnJogo3;
        private Button btnJogo2;
        private Button btnJogo4;
        private Header header1;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
        private PictureBox pictureBox1;
    }
}
