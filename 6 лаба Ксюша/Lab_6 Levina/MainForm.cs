// MainForm.cs
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public partial class MainForm : Form
    {


        /// <summary>
        /// Отрисовка поля
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Игра угадайка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuessGame_Click(object sender, EventArgs e)
        {
            GuessGameForm guessForm = new GuessGameForm();
            guessForm.ShowDialog();
        }


        /// <summary>
        /// Сортировка массивов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrayWork_Click(object sender, EventArgs e)
        {
            ArrayWorkForm arrayForm = new ArrayWorkForm();
            arrayForm.ShowDialog();
        }


        /// <summary>
        /// Змейка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSnakeGame_Click(object sender, EventArgs e)
        {
            SnakeGameForm snakeForm = new SnakeGameForm();
            snakeForm.ShowDialog();
        }

        /// <summary>
        /// Вывод автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuthorInfo_Click(object sender, EventArgs e)
        {
            AuthorInfoForm authorForm = new AuthorInfoForm();
            authorForm.ShowDialog();
        }


        /// <summary>
        /// Ехит
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}