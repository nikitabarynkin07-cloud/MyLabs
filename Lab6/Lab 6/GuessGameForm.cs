using Lab_6;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class GuessGameForm : Form
    {
        private double correctAnswer;
        private int totalAttempts;
        private int currentAttempt = 0;

        private CancellationTokenSource gameTimerCts;
        private bool isGameActive = false;

        public GuessGameForm()
        {
            InitializeComponent();
            lblStatus.Text = "Введите значение 'a' и количество попыток";
            txtAttempts.Text = "";
            txtInputA.Text = "";
        }

        /// <summary>
        /// Запуск игры и таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnStart_Click(object sender, EventArgs e)
        {
            // Проверка ввода
            if (!double.TryParse(txtInputA.Text, out double a))
            {
                MessageBox.Show("Введите корректное число для 'a'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAttempts.Text, out totalAttempts) || totalAttempts <= 0)
            {
                MessageBox.Show("Количество попыток должно быть > 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вычисляем правильный ответ
            correctAnswer = FunctionCalculator.Calculate(a);

            // Настройка состояния
            currentAttempt = 0;
            isGameActive = true;
            txtGuess.Enabled = true;
            btnStart.Enabled = false; // Блокируем повторный запуск
            lblStatus.Text = $"Попытка 1 из {totalAttempts}. У вас 30 сек!";
            lblTimer.Text = "Время: 30 сек";

            // Отменяем старый таймер (если был)
            gameTimerCts?.Cancel();
            gameTimerCts = new CancellationTokenSource();

            // Запускаем 30-секундный таймер на игру
            _ = RunGameTimerAsync(30);

            // Фокус на поле ввода
            txtGuess.Focus();
            txtGuess.SelectAll();
        }

        /// <summary>
        /// Запуск таймера
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        private async Task RunGameTimerAsync(int seconds)
        {
            int remaining = seconds;
            try
            {
                while (remaining > 0 && !gameTimerCts.Token.IsCancellationRequested)
                {
                    lblTimer.Text = $"Время: {remaining} сек";
                    await Task.Delay(1000, gameTimerCts.Token);
                    remaining--;
                }

                if (remaining == 0 && !gameTimerCts.Token.IsCancellationRequested)
                {
                    lblTimer.Text = "Время вышло!";
                    EndGame(false, "Время вышло! Правильный ответ: ");
                }
            }
            catch (OperationCanceledException)
            {
                // Игра завершена досрочно (победа или поражение)
            }
        }

        /// <summary>
        /// Обработка ввода при нажатии  Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isGameActive)
            {
                // Проверка ввода
                if (!int.TryParse(txtGuess.Text, out int userAnswer))
                {
                    MessageBox.Show("Неверный формат! Попытка сгорела.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProcessAttempt(false, 0);
                    return;
                }

                ProcessAttempt(true, userAnswer);
            }
        }

        // --- ОБРАБОТКА ПОПЫТКИ ---
        private void ProcessAttempt(bool validInput, int userAnswer)
        {
            currentAttempt++;

            if (validInput && userAnswer == correctAnswer)
            {
                EndGame(true, "✅ ПОБЕДА! Ответ: ");
                return;
            }

            if (currentAttempt >= totalAttempts)
            {
                EndGame(false, "❌ Попытки закончились. Правильный ответ: ");
            }
            else
            {
                lblStatus.Text = $"Попытка {currentAttempt} неудачна. Осталось: {totalAttempts - currentAttempt}";
                txtGuess.Clear();
                txtGuess.Focus();
            }
        }

        // --- ЗАВЕРШЕНИЕ ИГРЫ ---
        private void EndGame(bool isWin, string messagePrefix)
        {
            isGameActive = false;
            txtGuess.Enabled = false;
            gameTimerCts?.Cancel(); // Останавливаем таймер

            lblStatus.Text = $"{messagePrefix}{correctAnswer}";
            lblTimer.Text = "Игра окончена";

            // Разблокируем кнопку "Начать игру" для новой игры
            btnStart.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtInputA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}