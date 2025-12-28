// AuthorInfoForm.cs
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public partial class AuthorInfoForm : Form
    {
        public AuthorInfoForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}