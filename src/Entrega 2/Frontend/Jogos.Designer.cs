namespace LuminaLearning
{
    partial class Jogos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelAbaLateral = new Panel();
            lblSeuPacote = new Label();
            panel4 = new Panel();
            pictureBoxPrata = new PictureBox();
            panel5 = new Panel();
            tableLayoutPanelPrata = new TableLayoutPanel();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            lblExtras = new Label();
            lblPrata = new Label();
            panelPrincipal = new Panel();
            abaSair1 = new abaSair();
            abaProfile1 = new abaProfile();
            abaMenu1 = new AbaMenu();
            lblTitle3 = new Label();
            lblTitle2 = new Label();
            lblTitle1 = new Label();
            btnJogo12 = new Button();
            btnJogo11 = new Button();
            btnJogo10 = new Button();
            btnJogo9 = new Button();
            btnJogo8 = new Button();
            btnJogo7 = new Button();
            btnJogo6 = new Button();
            btnJogo5 = new Button();
            btnJogo4 = new Button();
            btnJogo3 = new Button();
            btnJogo2 = new Button();
            btnJogo1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelAbaLateral.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrata).BeginInit();
            panel5.SuspendLayout();
            tableLayoutPanelPrata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            panelPrincipal.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(panelAbaLateral, 0, 0);
            tableLayoutPanel1.Controls.Add(panelPrincipal, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1370, 659);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelAbaLateral
            // 
            panelAbaLateral.AutoScroll = true;
            panelAbaLateral.BackColor = Color.FromArgb(224, 224, 224);
            panelAbaLateral.Controls.Add(lblSeuPacote);
            panelAbaLateral.Controls.Add(panel4);
            panelAbaLateral.Dock = DockStyle.Fill;
            panelAbaLateral.Location = new Point(0, 0);
            panelAbaLateral.Margin = new Padding(0);
            panelAbaLateral.Name = "panelAbaLateral";
            panelAbaLateral.Size = new Size(274, 659);
            panelAbaLateral.TabIndex = 0;
            // 
            // lblSeuPacote
            // 
            lblSeuPacote.AutoSize = true;
            lblSeuPacote.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeuPacote.Location = new Point(55, 109);
            lblSeuPacote.Name = "lblSeuPacote";
            lblSeuPacote.Size = new Size(165, 32);
            lblSeuPacote.TabIndex = 3;
            lblSeuPacote.Text = "Seu Pacote é:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(216, 191, 126);
            panel4.Controls.Add(pictureBoxPrata);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(lblPrata);
            panel4.Location = new Point(9, 161);
            panel4.Margin = new Padding(0, 0, 10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 337);
            panel4.TabIndex = 2;
            // 
            // pictureBoxPrata
            // 
            pictureBoxPrata.BackgroundImage = Properties.Resources.cristal;
            pictureBoxPrata.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPrata.Location = new Point(21, 10);
            pictureBoxPrata.Name = "pictureBoxPrata";
            pictureBoxPrata.Size = new Size(60, 46);
            pictureBoxPrata.TabIndex = 8;
            pictureBoxPrata.TabStop = false;
            pictureBoxPrata.Click += pictureBoxPrata_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(146, 153, 188);
            panel5.Controls.Add(tableLayoutPanelPrata);
            panel5.Controls.Add(lblExtras);
            panel5.Location = new Point(12, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 264);
            panel5.TabIndex = 5;
            // 
            // tableLayoutPanelPrata
            // 
            tableLayoutPanelPrata.ColumnCount = 2;
            tableLayoutPanelPrata.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelPrata.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanelPrata.Controls.Add(pictureBox10, 0, 0);
            tableLayoutPanelPrata.Controls.Add(pictureBox11, 0, 1);
            tableLayoutPanelPrata.Controls.Add(pictureBox12, 0, 2);
            tableLayoutPanelPrata.Controls.Add(pictureBox13, 0, 3);
            tableLayoutPanelPrata.Controls.Add(pictureBox14, 0, 4);
            tableLayoutPanelPrata.Controls.Add(pictureBox15, 0, 5);
            tableLayoutPanelPrata.Controls.Add(pictureBox16, 0, 6);
            tableLayoutPanelPrata.Controls.Add(pictureBox17, 0, 7);
            tableLayoutPanelPrata.Location = new Point(8, 36);
            tableLayoutPanelPrata.Name = "tableLayoutPanelPrata";
            tableLayoutPanelPrata.RowCount = 8;
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelPrata.Size = new Size(214, 217);
            tableLayoutPanelPrata.TabIndex = 2;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources.check_solid;
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Location = new Point(3, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(26, 21);
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = Properties.Resources.check_solid;
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Dock = DockStyle.Fill;
            pictureBox11.Location = new Point(3, 30);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(26, 21);
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources.check_solid;
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Dock = DockStyle.Fill;
            pictureBox12.Location = new Point(3, 57);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(26, 21);
            pictureBox12.TabIndex = 2;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.check_solid;
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Dock = DockStyle.Fill;
            pictureBox13.Location = new Point(3, 84);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(26, 21);
            pictureBox13.TabIndex = 3;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.check_solid;
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Dock = DockStyle.Fill;
            pictureBox14.Location = new Point(3, 111);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(26, 21);
            pictureBox14.TabIndex = 4;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImage = Properties.Resources.xmark_solid;
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Dock = DockStyle.Fill;
            pictureBox15.Location = new Point(3, 138);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(26, 21);
            pictureBox15.TabIndex = 5;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = Properties.Resources.xmark_solid;
            pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox16.Dock = DockStyle.Fill;
            pictureBox16.Location = new Point(3, 165);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(26, 21);
            pictureBox16.TabIndex = 6;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = Properties.Resources.xmark_solid;
            pictureBox17.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox17.Dock = DockStyle.Fill;
            pictureBox17.Location = new Point(3, 192);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(26, 22);
            pictureBox17.TabIndex = 7;
            pictureBox17.TabStop = false;
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtras.Location = new Point(65, 10);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new Size(127, 21);
            lblExtras.TabIndex = 1;
            lblExtras.Text = "Recursos Extras";
            // 
            // lblPrata
            // 
            lblPrata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrata.AutoSize = true;
            lblPrata.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrata.Location = new Point(87, 17);
            lblPrata.Name = "lblPrata";
            lblPrata.Size = new Size(102, 37);
            lblPrata.TabIndex = 4;
            lblPrata.Text = "PRATA";
            lblPrata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(abaSair1);
            panelPrincipal.Controls.Add(abaProfile1);
            panelPrincipal.Controls.Add(abaMenu1);
            panelPrincipal.Controls.Add(lblTitle3);
            panelPrincipal.Controls.Add(lblTitle2);
            panelPrincipal.Controls.Add(lblTitle1);
            panelPrincipal.Controls.Add(btnJogo12);
            panelPrincipal.Controls.Add(btnJogo11);
            panelPrincipal.Controls.Add(btnJogo10);
            panelPrincipal.Controls.Add(btnJogo9);
            panelPrincipal.Controls.Add(btnJogo8);
            panelPrincipal.Controls.Add(btnJogo7);
            panelPrincipal.Controls.Add(btnJogo6);
            panelPrincipal.Controls.Add(btnJogo5);
            panelPrincipal.Controls.Add(btnJogo4);
            panelPrincipal.Controls.Add(btnJogo3);
            panelPrincipal.Controls.Add(btnJogo2);
            panelPrincipal.Controls.Add(btnJogo1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(274, 0);
            panelPrincipal.Margin = new Padding(0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1096, 659);
            panelPrincipal.TabIndex = 1;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(146, 153, 188);
            abaSair1.Location = new Point(391, 253);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 21;
            abaSair1.Visible = false;
            // 
            // abaProfile1
            // 
            abaProfile1.BackColor = Color.FromArgb(146, 153, 188);
            abaProfile1.Location = new Point(527, -3);
            abaProfile1.Name = "abaProfile1";
            abaProfile1.Size = new Size(570, 200);
            abaProfile1.TabIndex = 20;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick_1;
            // 
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(805, -3);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 19;
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
            // lblTitle3
            // 
            lblTitle3.AutoSize = true;
            lblTitle3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle3.Location = new Point(18, 440);
            lblTitle3.Name = "lblTitle3";
            lblTitle3.Size = new Size(253, 32);
            lblTitle3.TabIndex = 18;
            lblTitle3.Text = "Jogos (Tipo dos jogos)";
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.Location = new Point(18, 234);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(253, 32);
            lblTitle2.TabIndex = 17;
            lblTitle2.Text = "Jogos (Tipo dos jogos)";
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle1.Location = new Point(18, 24);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(253, 32);
            lblTitle1.TabIndex = 16;
            lblTitle1.Text = "Jogos (Tipo dos jogos)";
            // 
            // btnJogo12
            // 
            btnJogo12.Anchor = AnchorStyles.Bottom;
            btnJogo12.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo12.FlatAppearance.BorderColor = Color.FromArgb(216, 191, 126);
            btnJogo12.FlatAppearance.BorderSize = 8;
            btnJogo12.FlatStyle = FlatStyle.Flat;
            btnJogo12.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo12.Location = new Point(821, 495);
            btnJogo12.Name = "btnJogo12";
            btnJogo12.Size = new Size(237, 124);
            btnJogo12.TabIndex = 15;
            btnJogo12.Text = "JOGO 12";
            btnJogo12.UseVisualStyleBackColor = false;
            // 
            // btnJogo11
            // 
            btnJogo11.Anchor = AnchorStyles.Bottom;
            btnJogo11.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo11.FlatAppearance.BorderColor = Color.FromArgb(216, 191, 126);
            btnJogo11.FlatAppearance.BorderSize = 8;
            btnJogo11.FlatStyle = FlatStyle.Flat;
            btnJogo11.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo11.Location = new Point(553, 495);
            btnJogo11.Name = "btnJogo11";
            btnJogo11.Size = new Size(237, 124);
            btnJogo11.TabIndex = 14;
            btnJogo11.Text = "JOGO 11";
            btnJogo11.UseVisualStyleBackColor = false;
            // 
            // btnJogo10
            // 
            btnJogo10.Anchor = AnchorStyles.Bottom;
            btnJogo10.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo10.FlatAppearance.BorderColor = Color.FromArgb(216, 191, 126);
            btnJogo10.FlatAppearance.BorderSize = 8;
            btnJogo10.FlatStyle = FlatStyle.Flat;
            btnJogo10.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo10.Location = new Point(291, 495);
            btnJogo10.Name = "btnJogo10";
            btnJogo10.Size = new Size(237, 124);
            btnJogo10.TabIndex = 13;
            btnJogo10.Text = "JOGO 10";
            btnJogo10.UseVisualStyleBackColor = false;
            // 
            // btnJogo9
            // 
            btnJogo9.Anchor = AnchorStyles.Bottom;
            btnJogo9.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo9.FlatAppearance.BorderColor = Color.FromArgb(216, 191, 126);
            btnJogo9.FlatAppearance.BorderSize = 8;
            btnJogo9.FlatStyle = FlatStyle.Flat;
            btnJogo9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo9.Location = new Point(23, 495);
            btnJogo9.Name = "btnJogo9";
            btnJogo9.Size = new Size(237, 124);
            btnJogo9.TabIndex = 12;
            btnJogo9.Text = "JOGO 9";
            btnJogo9.UseVisualStyleBackColor = false;
            // 
            // btnJogo8
            // 
            btnJogo8.Anchor = AnchorStyles.Bottom;
            btnJogo8.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo8.FlatAppearance.BorderColor = Color.FromArgb(144, 96, 196);
            btnJogo8.FlatAppearance.BorderSize = 8;
            btnJogo8.FlatStyle = FlatStyle.Flat;
            btnJogo8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo8.Location = new Point(821, 288);
            btnJogo8.Name = "btnJogo8";
            btnJogo8.Size = new Size(237, 124);
            btnJogo8.TabIndex = 11;
            btnJogo8.Text = "JOGO 8";
            btnJogo8.UseVisualStyleBackColor = false;
            // 
            // btnJogo7
            // 
            btnJogo7.Anchor = AnchorStyles.Bottom;
            btnJogo7.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo7.FlatAppearance.BorderColor = Color.FromArgb(144, 96, 196);
            btnJogo7.FlatAppearance.BorderSize = 8;
            btnJogo7.FlatStyle = FlatStyle.Flat;
            btnJogo7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo7.Location = new Point(553, 288);
            btnJogo7.Name = "btnJogo7";
            btnJogo7.Size = new Size(237, 124);
            btnJogo7.TabIndex = 10;
            btnJogo7.Text = "JOGO 7";
            btnJogo7.UseVisualStyleBackColor = false;
            // 
            // btnJogo6
            // 
            btnJogo6.Anchor = AnchorStyles.Bottom;
            btnJogo6.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo6.FlatAppearance.BorderColor = Color.FromArgb(144, 96, 196);
            btnJogo6.FlatAppearance.BorderSize = 8;
            btnJogo6.FlatStyle = FlatStyle.Flat;
            btnJogo6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo6.Location = new Point(291, 288);
            btnJogo6.Name = "btnJogo6";
            btnJogo6.Size = new Size(237, 124);
            btnJogo6.TabIndex = 9;
            btnJogo6.Text = "JOGO 6";
            btnJogo6.UseVisualStyleBackColor = false;
            // 
            // btnJogo5
            // 
            btnJogo5.Anchor = AnchorStyles.Bottom;
            btnJogo5.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo5.FlatAppearance.BorderColor = Color.FromArgb(144, 96, 196);
            btnJogo5.FlatAppearance.BorderSize = 8;
            btnJogo5.FlatStyle = FlatStyle.Flat;
            btnJogo5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo5.Location = new Point(23, 288);
            btnJogo5.Name = "btnJogo5";
            btnJogo5.Size = new Size(237, 124);
            btnJogo5.TabIndex = 8;
            btnJogo5.Text = "JOGO 5";
            btnJogo5.UseVisualStyleBackColor = false;
            // 
            // btnJogo4
            // 
            btnJogo4.Anchor = AnchorStyles.Bottom;
            btnJogo4.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo4.FlatAppearance.BorderColor = Color.FromArgb(124, 185, 144);
            btnJogo4.FlatAppearance.BorderSize = 8;
            btnJogo4.FlatStyle = FlatStyle.Flat;
            btnJogo4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo4.Location = new Point(821, 77);
            btnJogo4.Name = "btnJogo4";
            btnJogo4.Size = new Size(237, 124);
            btnJogo4.TabIndex = 7;
            btnJogo4.Text = "JOGO 4";
            btnJogo4.UseVisualStyleBackColor = false;
            // 
            // btnJogo3
            // 
            btnJogo3.Anchor = AnchorStyles.Bottom;
            btnJogo3.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo3.FlatAppearance.BorderColor = Color.FromArgb(124, 185, 144);
            btnJogo3.FlatAppearance.BorderSize = 8;
            btnJogo3.FlatStyle = FlatStyle.Flat;
            btnJogo3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo3.Location = new Point(553, 77);
            btnJogo3.Name = "btnJogo3";
            btnJogo3.Size = new Size(237, 124);
            btnJogo3.TabIndex = 6;
            btnJogo3.Text = "JOGO 3";
            btnJogo3.UseVisualStyleBackColor = false;
            // 
            // btnJogo2
            // 
            btnJogo2.Anchor = AnchorStyles.Bottom;
            btnJogo2.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo2.FlatAppearance.BorderColor = Color.FromArgb(124, 185, 144);
            btnJogo2.FlatAppearance.BorderSize = 8;
            btnJogo2.FlatStyle = FlatStyle.Flat;
            btnJogo2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo2.Location = new Point(291, 77);
            btnJogo2.Name = "btnJogo2";
            btnJogo2.Size = new Size(237, 124);
            btnJogo2.TabIndex = 5;
            btnJogo2.Text = "JOGO 2";
            btnJogo2.UseVisualStyleBackColor = false;
            // 
            // btnJogo1
            // 
            btnJogo1.Anchor = AnchorStyles.Bottom;
            btnJogo1.BackColor = Color.FromArgb(146, 153, 188);
            btnJogo1.FlatAppearance.BorderColor = Color.FromArgb(124, 185, 144);
            btnJogo1.FlatAppearance.BorderSize = 8;
            btnJogo1.FlatStyle = FlatStyle.Flat;
            btnJogo1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogo1.Location = new Point(23, 77);
            btnJogo1.Name = "btnJogo1";
            btnJogo1.Size = new Size(237, 124);
            btnJogo1.TabIndex = 4;
            btnJogo1.Text = "JOGO 1";
            btnJogo1.UseVisualStyleBackColor = false;
            // 
            // Jogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1370, 749);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(header1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Jogos";
            Text = "Jogos";
            FormClosing += Jogos_FormClosing;
            Load += Jogos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelAbaLateral.ResumeLayout(false);
            panelAbaLateral.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrata).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanelPrata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Header header1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAbaLateral;
        private Panel panelPrincipal;
        private Label lblTitle1;
        private Button btnJogo12;
        private Button btnJogo11;
        private Button btnJogo10;
        private Button btnJogo9;
        private Button btnJogo8;
        private Button btnJogo7;
        private Button btnJogo6;
        private Button btnJogo5;
        private Button btnJogo4;
        private Button btnJogo3;
        private Button btnJogo2;
        private Button btnJogo1;
        private Label lblTitle3;
        private Label lblTitle2;
        private AbaMenu abaMenu1;
        private Panel panel4;
        private PictureBox pictureBoxPrata;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanelPrata;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private Label lblExtras;
        private Label lblPrata;
        private Label lblSeuPacote;
        private abaSair abaSair1;
        private abaProfile abaProfile1;
    }
}