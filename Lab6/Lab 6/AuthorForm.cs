using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
            lblAuthorInfo.Text = "Группа: 6106-090301D\nБарынкин Никита Викторович";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}