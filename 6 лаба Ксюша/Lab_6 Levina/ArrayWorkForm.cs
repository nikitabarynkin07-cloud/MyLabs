// ArrayWorkForm.cs
using Lab_6_Levina;
using System;
using System.Windows.Forms;

namespace Lab_6_Levina
{
    public partial class ArrayWorkForm : Form
    {
        private int[] _originalArray;
        private bool _arrayCreated = false;
        private double? _shellTimeMs;  // Сохраняем для статистики
        private double? _gnomeTimeMs;  // Сохраняем для статистики

        public ArrayWorkForm()
        {
            InitializeComponent();
            dgvArray.ReadOnly = false;
            dgvArray.AllowUserToAddRows = false;
            dgvArray.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvArray.CellValueChanged += DgvArray_CellValueChanged;
        }


        /// <summary>
        /// ручное изменения значений в массиве
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvArray_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_arrayCreated && e.RowIndex == 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    int[] current = GetArrayFromGrid();
                    HighlightMinMax(current);
                }
                catch {}
            }
        }


        /// <summary>
        /// кнопка создания массива по умолчанию 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDefault_Click(object sender, EventArgs e)
        {
            CreateArray(10);
        }


        /// <summary>
        /// кнопка создания пользовательсокго массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCustom_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int size) || size < 1 || size > 50)
            {
                MessageBox.Show("Размер массива должен быть целым числом от 1 до 50.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CreateArray(size);
        }

        /// <summary>
        /// создание массива
        /// </summary>
        /// <param name="size"></param>
        private void CreateArray(int size)
        {
            try
            {
                _originalArray = ArrayProcessor.CreateRandomArray(size);
                DisplayArrayInGrid(_originalArray, dgvArray);
                HighlightMinMax(_originalArray);
                _arrayCreated = true;
                lblStatus.Text = $"Массив создан ({size} элементов). Вы можете редактировать значения.";
                // Сбрасываем времена
                _shellTimeMs = null;
                _gnomeTimeMs = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        /// <summary>
        /// Вывод массива в таблицу формы DataGridView
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dgv"></param>
        private void DisplayArrayInGrid(int[] array, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                dgv.Columns.Add($"Col{i}", $"[{i}]");
                dgv.Columns[i].Width = 55;
            }
            dgv.Rows.Add();
            for (int i = 0; i < array.Length; i++)
            {
                dgv.Rows[0].Cells[i].Value = array[i].ToString();
            }
        }
          

        /// <summary>
        /// Подсветка мин и макс
        /// </summary>
        /// <param name="array"></param>
        private void HighlightMinMax(int[] array)
        {
            if (array.Length == 0) return;
            var stats = ArrayProcessor.GetStatistics(array);
            int min = stats.min, max = stats.max;

            for (int i = 0; i < array.Length; i++)
            {
                var cell = dgvArray.Rows[0].Cells[i];
                cell.Style.BackColor = System.Drawing.Color.White;
                cell.Style.ForeColor = System.Drawing.Color.Black;
                if (array[i] == min)
                {
                    cell.Style.BackColor = System.Drawing.Color.LightCoral;
                    cell.Style.ForeColor = System.Drawing.Color.White;
                }
                else if (array[i] == max)
                {
                    cell.Style.BackColor = System.Drawing.Color.LightGreen;
                    cell.Style.ForeColor = System.Drawing.Color.Black;
                }
            }
        }


        /// <summary>
        /// Перезапись массива из формы в int
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="FormatException"></exception>
        private int[] GetArrayFromGrid()
        {
            if (dgvArray.Columns.Count == 0)
                throw new InvalidOperationException("Массив не создан.");

            int[] arr = new int[dgvArray.Columns.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                var val = dgvArray.Rows[0].Cells[i].Value?.ToString();
                if (!int.TryParse(val, out arr[i]))
                    throw new FormatException($"Некорректное значение в ячейке [{i}].");
            }
            return arr;
        }


        /// <summary>
        /// Кнопка сортировки шелла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortShell_Click(object sender, EventArgs e)
        {
            if (!_arrayCreated)
            {
                MessageBox.Show("Сначала создайте массив.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[] current = GetArrayFromGrid();
                var (sorted, time) = ArrayProcessor.ShellSortWithTime(current);
                DisplayArrayInGrid(sorted, dgvShellResult);
                _shellTimeMs = time; // Сохраняем только для статистики
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сортировки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Кнопка сортировки гнома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortGnome_Click(object sender, EventArgs e)
        {
            if (!_arrayCreated)
            {
                MessageBox.Show("Сначала создайте массив.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[] current = GetArrayFromGrid();
                var (sorted, time) = ArrayProcessor.GnomeSortWithTime(current);
                DisplayArrayInGrid(sorted, dgvGnomeResult);
                _gnomeTimeMs = time; // Сохраняем только для статистики
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сортировки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Отображение статистики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowStats_Click(object sender, EventArgs e)
        {
            if (!_arrayCreated)
            {
                MessageBox.Show("Сначала создайте массив.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[] current = GetArrayFromGrid();
                var stats = ArrayProcessor.GetStatistics(current);

                string shellStr = _shellTimeMs.HasValue
                    ? $"Сортировка Шелла: {_shellTimeMs:F2} мс"
                    : "Сортировка Шелла не выполнялась";

                string gnomeStr = _gnomeTimeMs.HasValue
                    ? $"Гномья сортировка: {_gnomeTimeMs:F2} мс"
                    : "Гномья сортировка не выполнялась";

                string comparison = "Сравнение недоступно";
                if (_shellTimeMs.HasValue && _gnomeTimeMs.HasValue)
                {
                    double diff = Math.Abs(_shellTimeMs.Value - _gnomeTimeMs.Value);
                    if (_gnomeTimeMs < _shellTimeMs)
                        comparison = $"Гномья быстрее на {diff:F2} мс";
                    else if (_shellTimeMs < _gnomeTimeMs)
                        comparison = $"Шелла быстрее на {diff:F2} мс";
                    else
                        comparison = "Время выполнения одинаковое";
                }

                string message = $@"
ВРЕМЯ ВЫПОЛНЕНИЯ:
{shellStr}
{gnomeStr}

СРАВНЕНИЕ:
{comparison}

СТАТИСТИКА МАССИВА:
Минимум: {stats.min}
Максимум: {stats.max}
Среднее арифметическое: {stats.average:F2}
";

                MessageBox.Show(message, "Подробная статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}