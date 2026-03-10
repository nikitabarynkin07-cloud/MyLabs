using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTaskDescription_Click(object sender, EventArgs e)
        {

        }
    }
}