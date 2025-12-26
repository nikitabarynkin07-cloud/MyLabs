using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class SaperGameForm : Form
    {
        // Размеры поля (как в вашем коде)
        private const int ROWS = 5;
        private const int COLS = 5;
        private const int MINE_COUNT = 5;

        // Логика игры
        private char[,] fullField;      // Полное поле с минами и цифрами
        private char[,] userField;      // Поле, видимое игроку
        private bool isGameOver = false;

        // Кнопки для клеток
        private Button[,] buttons;

        public SaperGameForm()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            isGameOver = false;
            // Создаём пустое поле
            userField = CreateEmptyField();
            // Генерируем поле с минами и цифрами
            fullField = FillNumbers(PlaceMines(CreateEmptyField(), MINE_COUNT));

            // Обновляем кнопки
            UpdateButtons();
        }

        // --- ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ (аналоги из вашего класса Game) ---

        private char[,] CreateEmptyField()
        {
            char[,] field = new char[ROWS, COLS];
            for (int i = 0; i < ROWS; i++)
                for (int j = 0; j < COLS; j++)
                    field[i, j] = '#';
            return field;
        }

        private char[,] PlaceMines(char[,] field, int mineCount)
        {
            Random rnd = new Random();
            int placed = 0;
            while (placed < mineCount)
            {
                int r = rnd.Next(ROWS);
                int c = rnd.Next(COLS);
                if (field[r, c] != '*')
                {
                    field[r, c] = '*';
                    placed++;
                }
            }
            return field;
        }

        private char[,] FillNumbers(char[,] field)
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (field[i, j] != '*')
                    {
                        int count = CountMinesAround(field, i, j);
                        field[i, j] = (char)('0' + count);
                    }
                }
            }
            return field;
        }

        private int CountMinesAround(char[,] field, int row, int col)
        {
            int count = 0;
            for (int dr = -1; dr <= 1; dr++)
            {
                for (int dc = -1; dc <= 1; dc++)
                {
                    if (dr == 0 && dc == 0) continue;
                    int r = row + dr;
                    int c = col + dc;
                    if (r >= 0 && r < ROWS && c >= 0 && c < COLS && field[r, c] == '*')
                        count++;
                }
            }
            return count;
        }

        // --- РЕКУРСИВНОЕ ОТКРЫТИЕ ---

        private void RevealCell(int row, int col)
        {
            if (row < 0 || row >= ROWS || col < 0 || col >= COLS) return;
            if (userField[row, col] != '#') return; // Уже открыта

            userField[row, col] = fullField[row, col];

            // Если клетка пустая (0) — открываем соседей
            if (fullField[row, col] == '0')
            {
                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        if (dr == 0 && dc == 0) continue;
                        RevealCell(row + dr, col + dc);
                    }
                }
            }
        }

        // --- ОБРАБОТКА КЛИКА ПО КЛЕТКЕ ---

        private void OnCellClick(object sender, EventArgs e)
        {
            if (isGameOver) return;

            Button btn = sender as Button;
            Point pos = (Point)btn.Tag; // Координаты сохранены в Tag
            int row = pos.X;
            int col = pos.Y;

            // Если мина — проигрыш
            if (fullField[row, col] == '*')
            {
                // Показать всё поле
                for (int i = 0; i < ROWS; i++)
                    for (int j = 0; j < COLS; j++)
                        userField[i, j] = fullField[i, j];

                UpdateButtons();
                MessageBox.Show("Вы взорвались на мине!", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                isGameOver = true;
                return;
            }

            // Открываем клетку (и область, если нужно)
            RevealCell(row, col);
            UpdateButtons();

            // Проверка победы
            if (CheckWin())
            {
                MessageBox.Show("ПОБЕДА!!!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isGameOver = true;
            }
        }

        private bool CheckWin()
        {
            int revealed = 0;
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (userField[i, j] != '#' && userField[i, j] != '*')
                        revealed++;
                }
            }
            return revealed == ROWS * COLS - MINE_COUNT;
        }

        // --- ОБНОВЛЕНИЕ ИНТЕРФЕЙСА ---

        private void UpdateButtons()
        {
            // Создаём кнопки при первом запуске
            if (buttons == null)
            {
                buttons = new Button[ROWS, COLS];
                pnlGameBoard.Controls.Clear();
                pnlGameBoard.Size = new Size(COLS * 40, ROWS * 40);

                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        Button btn = new Button
                        {
                            Width = 40,
                            Height = 40,
                            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                            Location = new Point(j * 40, i * 40),
                            Tag = new Point(i, j) // Сохраняем координаты
                        };
                        btn.Click += OnCellClick;
                        pnlGameBoard.Controls.Add(btn);
                        buttons[i, j] = btn;
                    }
                }
            }

            // Обновляем текст и цвет кнопок
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    char c = userField[i, j];
                    Button btn = buttons[i, j];
                    btn.Text = c == '0' ? "" : c.ToString();
                    btn.Enabled = (c == '#'); // Только закрытые клетки кликабельны

                    if (c == '*')
                        btn.BackColor = Color.Red;
                    else if (c != '#')
                        btn.BackColor = Color.LightGreen;
                    else
                        btn.BackColor = SystemColors.Control;
                }
            }
        }

        // --- ОБРАБОТЧИКИ КНОПОК ---

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void SaperGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Опционально: ничего не нужно, GC всё уберёт
        }
    }
}