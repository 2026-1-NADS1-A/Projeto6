namespace AULA05
{
    partial class Form1
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
            label2 = new Label();
            lblIP = new Label();
            labelIpOrigem = new Label();
            txtIpOrigem = new TextBox();
            btnVerificar = new Button();
            lstLog = new ListBox();
            labelLog = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "IP LOCAL";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.ForeColor = SystemColors.ButtonHighlight;
            lblIP.Location = new Point(112, 98);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(40, 15);
            lblIP.TabIndex = 5;
            lblIP.Text = "0.0.0.0";
            // 
            // labelIpOrigem
            // 
            labelIpOrigem.AutoSize = true;
            labelIpOrigem.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIpOrigem.ForeColor = SystemColors.ButtonHighlight;
            labelIpOrigem.Location = new Point(24, 126);
            labelIpOrigem.Name = "labelIpOrigem";
            labelIpOrigem.Size = new Size(146, 15);
            labelIpOrigem.TabIndex = 6;
            labelIpOrigem.Text = "CONFIRME O SEU IP: ";
            // 
            // txtIpOrigem
            // 
            txtIpOrigem.Location = new Point(175, 119);
            txtIpOrigem.Margin = new Padding(3, 2, 3, 2);
            txtIpOrigem.Name = "txtIpOrigem";
            txtIpOrigem.Size = new Size(311, 23);
            txtIpOrigem.TabIndex = 7;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(501, 119);
            btnVerificar.Margin = new Padding(3, 2, 3, 2);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(96, 22);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(24, 203);
            lstLog.Margin = new Padding(3, 2, 3, 2);
            lstLog.Name = "lstLog";
            lstLog.ScrollAlwaysVisible = true;
            lstLog.Size = new Size(617, 124);
            lstLog.TabIndex = 9;
            lstLog.SelectedIndexChanged += lstLog_SelectedIndexChanged;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLog.ForeColor = SystemColors.ButtonHighlight;
            labelLog.Location = new Point(23, 179);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(145, 15);
            labelLog.TabIndex = 10;
            labelLog.Text = "LOG DE TENTATIVA:";
            labelLog.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2026_04_07_194259;
            pictureBox1.Location = new Point(217, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 50);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(labelLog);
            Controls.Add(lstLog);
            Controls.Add(btnVerificar);
            Controls.Add(txtIpOrigem);
            Controls.Add(labelIpOrigem);
            Controls.Add(lblIP);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "PROJETO GRUPO6";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblIP;
        private Label labelIpOrigem;
        private TextBox txtIpOrigem;
        private Button btnVerificar;
        private ListBox lstLog;
        private Label labelLog;
        private PictureBox pictureBox1;
    }
}
