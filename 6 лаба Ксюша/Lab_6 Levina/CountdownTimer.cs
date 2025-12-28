// CountdownTimer.cs
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    /// <summary>
    /// Класс для управления обратным отсчетом времени.
    /// </summary>
    public class CountdownTimer
    {
        private System.Windows.Forms.Timer _timer;
        private int _secondsLeft;
        private bool _isRunning;

        /// <summary>
        /// Событие, вызываемое при каждом тике таймера.
        /// </summary>
        public event EventHandler Tick;

        /// <summary>
        /// Событие, вызываемое по истечении времени.
        /// </summary>
        public event EventHandler TimeExpired;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="totalSeconds">Общее время в секундах.</param>
        public CountdownTimer(int totalSeconds)
        {
            _secondsLeft = totalSeconds;
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; // 1 секунда
            _timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Запуск таймера.
        /// </summary>
        public void Start()
        {
            if (_isRunning) return;
            _isRunning = true;
            _timer.Start();
        }

        /// <summary>
        /// Остановка таймера.
        /// </summary>
        public void Stop()
        {
            _timer.Stop();
            _isRunning = false;
        }

        /// <summary>
        /// Сброс таймера на начальное значение.
        /// </summary>
        /// <param name="totalSeconds">Новое общее время.</param>
        public void Reset(int totalSeconds)
        {
            Stop();
            _secondsLeft = totalSeconds;
        }

        /// <summary>
        /// Получение оставшегося времени в секундах.
        /// </summary>
        /// <returns>Оставшееся время.</returns>
        public int GetRemainingSeconds()
        {
            return _secondsLeft;
        }

        /// <summary>
        /// Обработчик тика таймера.
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
            OnTick();

            if (_secondsLeft <= 0)
            {
                Stop();
                OnTimeExpired();
            }
        }

        /// <summary>
        /// Вызов события Tick.
        /// </summary>
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Вызов события TimeExpired.
        /// </summary>
        protected virtual void OnTimeExpired()
        {
            TimeExpired?.Invoke(this, EventArgs.Empty);
        }
    }
}