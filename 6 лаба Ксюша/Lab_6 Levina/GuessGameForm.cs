// GuessGameForm.cs
using Lab_6_Levina;
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public partial class GuessGameForm : Form
    {
        private GuessGameLogic _game;

        public GuessGameForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка начала игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) ||
                !double.TryParse(txtB.Text, out double b) ||
                !int.TryParse(txtAttempts.Text, out int attempts) ||
                !int.TryParse(txtTimeLimit.Text, out int timeLimit) ||
                attempts <= 0 || timeLimit <= 0)
            {
                MessageBox.Show("Проверьте правильность ввода всех полей.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _game = new GuessGameLogic(a, b, attempts, timeLimit);

            // Подписываемся на события таймера
            _game.Timer.TimeExpired += (s, ev) => EndGame(false);
            _game.Timer.Tick += (s, ev) => UpdateTimeLabel(); // 🔸 Обновление времени каждую секунду

            // Обновляем UI
            lblAttempts.Text = $"Попыток осталось: {_game.TotalAttempts}";
            UpdateTimeLabel(); // Устанавливаем начальное время
            txtGuess.Enabled = true;
            btnSubmit.Enabled = true;
            btnStart.Enabled = false;
            lblResult.Visible = false;
            txtGuess.Focus();

            _game.Start();
        }


        /// <summary>
        /// Кнопка ввода ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_game == null || _game.IsGameOver) return;

            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                MessageBox.Show("Введите целое число.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _game.MakeGuess(guess);

            switch (result)
            {
                case GuessResult.Correct:
                    lblResult.Text = "Верно!";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    EndGame(true);
                    break;
                case GuessResult.Incorrect:
                    lblResult.Text = "Неверно!";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                    lblResult.Visible = true;
                    txtGuess.Clear();
                    txtGuess.Focus();
                    lblAttempts.Text = $"Попыток осталось: {_game._attemptsLeft}";
                    break;
                case GuessResult.GameOver:
                    EndGame(false);
                    break;
            }
        }

        /// <summary>
        /// обновление времени
        /// </summary>
        private void UpdateTimeLabel()
        {
            if (_game != null)
            {
                lblTimeLeft.Text = $"Времени осталось: {_game.Timer.GetRemainingSeconds()} сек";
            }
        }


        /// <summary>
        /// конец игры
        /// </summary>
        /// <param name="won"></param>
        private void EndGame(bool won)
        {
            if (_game == null) return;

            _game.Timer.Stop();
            txtGuess.Enabled = false;
            btnSubmit.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Text = "Начать заново";

            string message;
            if (won)
            {
                message = "Поздравляем! Вы угадали!";
            }
            else
            {
                // 🔸 Показываем правильный ответ при проигрыше
                message = $"Игра окончена!\nПравильный ответ: {(int)Math.Round(_game.CorrectAnswer)}";
            }

            lblResult.Text = message;
            lblResult.ForeColor = won ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            lblResult.Visible = true;
        }


        /// <summary>
        /// окончание таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuessGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _game?.Timer.Stop();
        }
    }
}