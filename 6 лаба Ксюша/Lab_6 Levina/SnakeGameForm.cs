// SnakeGameForm.cs
using Lab_6_Levina;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public partial class SnakeGameForm : Form
    {
        private SnakeGameLogic _game;
        private GameTimer _timer;
        private Panel _gameField;

        public SnakeGameForm()
        {
            InitializeComponent();
            InitializeGameField();
            _game = new SnakeGameLogic();
            _timer = new GameTimer(_game.Speed);
            _timer.Tick += Timer_Tick;
            DrawGame();
            _timer.Start();
        }


        /// <summary>
        /// отрисовка поля
        /// </summary>
        private void InitializeGameField()
        {
            _gameField = new Panel
            {
                Location = new Point(20, 60),
                Size = new Size(
                    SnakeGameLogic.FIELD_SIZE * SnakeGameLogic.CELL_SIZE,
                    SnakeGameLogic.FIELD_SIZE * SnakeGameLogic.CELL_SIZE
                ),
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(_gameField);
        }


        /// <summary>
        /// Таймер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _game.Move();
            if (_game.IsGameOver)
            {
                _timer.Stop();
                MessageBox.Show($"Игра окончена!\nВаш счёт: {_game.Score}", "Змейка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewGame.Visible = true;
            }
            else
            {
                _timer.SetInterval(_game.Speed);
                DrawGame();
            }
        }


        /// <summary>
        /// Отрисовка игры
        /// </summary>
        private void DrawGame()
        {
            _gameField.Controls.Clear();

            // Отрисовка змейки
            for (int i = 0; i < _game.Snake.Count; i++)
            {
                var seg = _game.Snake[i];
                var panel = new Panel
                {
                    Size = new Size(SnakeGameLogic.CELL_SIZE - 2, SnakeGameLogic.CELL_SIZE - 2),
                    Location = new Point(seg.y * SnakeGameLogic.CELL_SIZE + 1, seg.x * SnakeGameLogic.CELL_SIZE + 1),
                    BackColor = i == 0 ? Color.LimeGreen : Color.Green
                };
                _gameField.Controls.Add(panel);
            }

            // Отрисовка еды
            var foodPanel = new Panel
            {
                Size = new Size(SnakeGameLogic.CELL_SIZE - 2, SnakeGameLogic.CELL_SIZE - 2),
                Location = new Point(_game.Food.y * SnakeGameLogic.CELL_SIZE + 1, _game.Food.x * SnakeGameLogic.CELL_SIZE + 1),
                BackColor = Color.Red
            };
            _gameField.Controls.Add(foodPanel);

            // Обновление счёта
            lblScore.Text = $"Счёт: {_game.Score}";
        }


        /// <summary>
        /// Движение по wasd
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (_game.IsGameOver) return base.ProcessCmdKey(ref msg, keyData);

            char newDir = keyData switch
            {
                Keys.W or Keys.Up => 'w',
                Keys.S or Keys.Down => 's',
                Keys.A or Keys.Left => 'a',
                Keys.D or Keys.Right => 'd',
                _ => '\0'
            };

            if (newDir != '\0')
            {
                // Запрет разворота на 180 градусов
                if ((_game.Direction == 'w' && newDir == 's') ||
                    (_game.Direction == 's' && newDir == 'w') ||
                    (_game.Direction == 'a' && newDir == 'd') ||
                    (_game.Direction == 'd' && newDir == 'a'))
                {
                    return true;
                }
                _game.Direction = newDir;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Кнопка новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            _game.Reset();
            _timer.Stop();
            _timer.SetInterval(_game.Speed);
            _timer.Start();
            btnNewGame.Visible = false;
            DrawGame();
        }

        private void SnakeGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer?.Stop();
        }
    }
}