using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    /// <summary>
    /// Класс для отслеживания времени ввода с таймаутом
    /// </summary>
    public static class InputTimer
    {
        /// <summary>
        /// Ожидает ввод в течение указанного времени (в секундах)
        /// </summary>
        /// <param name="timeLimitSeconds">Лимит времени в секундах</param>
        /// <param name="inputBox">TextBox, из которого читается ввод</param>
        /// <param name="form">Форма, на которой находится поле ввода</param>
        /// <returns>True, если ввод был сделан вовремя; False — если время вышло</returns>
        public static async Task<bool> WaitForInput(int timeLimitSeconds, TextBox inputBox, Form form)
        {
            var tcs = new TaskCompletionSource<bool>();
            CancellationTokenSource cts = new CancellationTokenSource();

            // Ждем нажатия Enter
            KeyEventHandler onEnter = null;
            onEnter = (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cts.Cancel();
                    tcs.SetResult(true);
                    inputBox.KeyDown -= onEnter;
                }
            };
            inputBox.KeyDown += onEnter;

            // Запускаем таймер
            var delayTask = Task.Delay(timeLimitSeconds * 1000, cts.Token);
            var completedTask = await Task.WhenAny(delayTask, tcs.Task);

            inputBox.KeyDown -= onEnter;

            if (completedTask == tcs.Task)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Время на ввод истекло ({timeLimitSeconds} сек)!", "Время вышло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}