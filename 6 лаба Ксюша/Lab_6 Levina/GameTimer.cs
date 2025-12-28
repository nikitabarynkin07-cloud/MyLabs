// GameTimer.cs
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public class GameTimer
    {
        private System.Windows.Forms.Timer _timer;

        public event EventHandler Tick;

        public GameTimer(int intervalMs)
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = intervalMs;
            _timer.Tick += (s, e) => Tick?.Invoke(this, EventArgs.Empty);
        }

        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
        public void SetInterval(int intervalMs) => _timer.Interval = intervalMs;
    }
}