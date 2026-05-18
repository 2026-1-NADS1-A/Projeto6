using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class Header : UserControl
    {
        public event EventHandler OnMenuClick;
        public event EventHandler OnbtnProfile;
        public Header()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnMenuClick?.Invoke(this, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OnbtnProfile?.Invoke(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
