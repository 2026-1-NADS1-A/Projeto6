using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LuminaLearning
{
    public partial class abaProfile : UserControl
    {
        public event EventHandler OnbtnSairClick;
        public abaProfile()
        {
            InitializeComponent();
        }

        private void abaProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            OnbtnSairClick?.Invoke(this, e);
        }
    }
}
