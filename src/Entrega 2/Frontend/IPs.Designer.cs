namespace LuminaLearning
{
    partial class IPs
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
            abaMenu1 = new AbaMenu();
            abaProfile1 = new abaProfile();
            abaSair1 = new abaSair();
            panel2 = new Panel();
            panelLAB02 = new Panel();
            lblLAB02 = new Label();
            panel1 = new Panel();
            panelLAB01 = new Panel();
            lblLAB01 = new Label();
            panel3 = new Panel();
            panelLAB03 = new Panel();
            lblLAB03 = new Label();
            lblIPs01 = new Label();
            lblIPs02 = new Label();
            lblIPs03 = new Label();
            panel2.SuspendLayout();
            panelLAB02.SuspendLayout();
            panel1.SuspendLayout();
            panelLAB01.SuspendLayout();
            panel3.SuspendLayout();
            panelLAB03.SuspendLayout();
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
            // abaMenu1
            // 
            abaMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            abaMenu1.Location = new Point(1070, 90);
            abaMenu1.Name = "abaMenu1";
            abaMenu1.Size = new Size(300, 600);
            abaMenu1.TabIndex = 1;
            abaMenu1.Visible = false;
            abaMenu1.OnbtnHomeClick += abaMenu1_OnbtnHomeClick;
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
            abaProfile1.TabIndex = 2;
            abaProfile1.Visible = false;
            abaProfile1.OnbtnSairClick += abaProfile1_OnbtnSairClick_1;
            // 
            // abaSair1
            // 
            abaSair1.BackColor = Color.FromArgb(146, 153, 188);
            abaSair1.Location = new Point(531, 301);
            abaSair1.Name = "abaSair1";
            abaSair1.Size = new Size(309, 146);
            abaSair1.TabIndex = 3;
            abaSair1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(146, 153, 188);
            panel2.Controls.Add(lblIPs02);
            panel2.Controls.Add(panelLAB02);
            panel2.Location = new Point(526, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 444);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panelLAB02
            // 
            panelLAB02.BackColor = SystemColors.ActiveBorder;
            panelLAB02.Controls.Add(lblLAB02);
            panelLAB02.Location = new Point(0, 0);
            panelLAB02.Name = "panelLAB02";
            panelLAB02.Size = new Size(318, 74);
            panelLAB02.TabIndex = 1;
            // 
            // lblLAB02
            // 
            lblLAB02.AutoSize = true;
            lblLAB02.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLAB02.Location = new Point(109, 19);
            lblLAB02.Name = "lblLAB02";
            lblLAB02.Size = new Size(100, 37);
            lblLAB02.TabIndex = 1;
            lblLAB02.Text = "LAB02";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(146, 153, 188);
            panel1.Controls.Add(lblIPs01);
            panel1.Controls.Add(panelLAB01);
            panel1.Location = new Point(147, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 444);
            panel1.TabIndex = 5;
            // 
            // panelLAB01
            // 
            panelLAB01.BackColor = SystemColors.ActiveBorder;
            panelLAB01.Controls.Add(lblLAB01);
            panelLAB01.Location = new Point(0, 0);
            panelLAB01.Name = "panelLAB01";
            panelLAB01.Size = new Size(318, 74);
            panelLAB01.TabIndex = 0;
            // 
            // lblLAB01
            // 
            lblLAB01.AutoSize = true;
            lblLAB01.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLAB01.Location = new Point(109, 19);
            lblLAB01.Name = "lblLAB01";
            lblLAB01.Size = new Size(100, 37);
            lblLAB01.TabIndex = 0;
            lblLAB01.Text = "LAB01";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(146, 153, 188);
            panel3.Controls.Add(lblIPs03);
            panel3.Controls.Add(panelLAB03);
            panel3.Location = new Point(903, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 444);
            panel3.TabIndex = 5;
            // 
            // panelLAB03
            // 
            panelLAB03.BackColor = SystemColors.ActiveBorder;
            panelLAB03.Controls.Add(lblLAB03);
            panelLAB03.Location = new Point(0, 0);
            panelLAB03.Name = "panelLAB03";
            panelLAB03.Size = new Size(318, 74);
            panelLAB03.TabIndex = 1;
            // 
            // lblLAB03
            // 
            lblLAB03.AutoSize = true;
            lblLAB03.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLAB03.Location = new Point(109, 19);
            lblLAB03.Name = "lblLAB03";
            lblLAB03.Size = new Size(100, 37);
            lblLAB03.TabIndex = 6;
            lblLAB03.Text = "LAB03";
            // 
            // lblIPs01
            // 
            lblIPs01.AutoSize = true;
            lblIPs01.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIPs01.Location = new Point(93, 94);
            lblIPs01.Name = "lblIPs01";
            lblIPs01.Size = new Size(133, 256);
            lblIPs01.TabIndex = 1;
            lblIPs01.Text = "192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1";
            // 
            // lblIPs02
            // 
            lblIPs02.AutoSize = true;
            lblIPs02.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIPs02.Location = new Point(93, 94);
            lblIPs02.Name = "lblIPs02";
            lblIPs02.Size = new Size(133, 256);
            lblIPs02.TabIndex = 2;
            lblIPs02.Text = "192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1";
            // 
            // lblIPs03
            // 
            lblIPs03.AutoSize = true;
            lblIPs03.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIPs03.Location = new Point(93, 94);
            lblIPs03.Name = "lblIPs03";
            lblIPs03.Size = new Size(133, 256);
            lblIPs03.TabIndex = 6;
            lblIPs03.Text = "192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1\r\n192.168.2.1";
            // 
            // IPs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(abaSair1);
            Controls.Add(abaProfile1);
            Controls.Add(abaMenu1);
            Controls.Add(panel1);
            Controls.Add(header1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IPs";
            Text = "IPs";
            FormClosing += IPs_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelLAB02.ResumeLayout(false);
            panelLAB02.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLAB01.ResumeLayout(false);
            panelLAB01.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelLAB03.ResumeLayout(false);
            panelLAB03.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Header header1;
        private AbaMenu abaMenu1;
        private abaProfile abaProfile1;
        private abaSair abaSair1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panelLAB02;
        private Label lblLAB02;
        private Panel panelLAB01;
        private Label lblLAB01;
        private Panel panelLAB03;
        private Label lblLAB03;
        private Label lblIPs02;
        private Label lblIPs01;
        private Label lblIPs03;
    }
}