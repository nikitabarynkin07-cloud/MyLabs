using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGuessGame_Click(object sender, EventArgs e)
        {
            GuessGameForm guessGameForm = new GuessGameForm();
            guessGameForm.ShowDialog(); // Показываем как модальное окно
        }

        private void btnArrayOperations_Click(object sender, EventArgs e)
        {
            ArrayOperationsForm arrayOperationsForm = new ArrayOperationsForm();
            arrayOperationsForm.ShowDialog();
        }

        private void btnSaperGame_Click(object sender, EventArgs e)
        {
            SaperGameForm saperGameForm = new SaperGameForm();
            saperGameForm.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}