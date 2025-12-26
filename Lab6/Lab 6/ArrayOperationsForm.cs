using Lab_6;
using System;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class ArrayOperationsForm : Form
    {
        private MassivSort currentArray;

        public ArrayOperationsForm()
        {
            InitializeComponent();
            dgvArray.CellEndEdit += DgvArray_CellEndEdit;
        }

        /// <summary>
        /// Создание массива с указанным размером
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size = CheckInput.iCheck(txtArraySize);
            if (size <= 0 || size > 50)
            {
                MessageBox.Show("Размер массива должен быть от 1 до 50.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                currentArray = new MassivSort(size);
                UpdateDataGridViewFromMassivSort();
                lblStatus.Text = $"Массив размером {size} создан.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Создание массива по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateDefault_Click(object sender, EventArgs e)
        {
            try
            {
                currentArray = new MassivSort(); // Конструктор без параметров, размер = 10
                UpdateDataGridViewFromMassivSort();
                lblStatus.Text = "Массив по умолчанию (размер 10) создан.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновление DGV
        /// </summary>
        private void UpdateDataGridViewFromMassivSort()
        {
            int[] arr = currentArray.GetArray();
            dgvArray.Rows.Clear();
            dgvArray.Columns.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                dgvArray.Columns.Add($"Col{i}", $"[{i}]");
            }

            dgvArray.Rows.Add();
            for (int i = 0; i < arr.Length; i++)
            {
                dgvArray.Rows[0].Cells[i].Value = arr[i];
            }

            HighlightMinMax();
        }

        /// <summary>
        /// Обработка редактирования ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvArray_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (currentArray == null) return;

            int[] updated = GetArrayFromGrid();
            currentArray.SetArray(updated);
            HighlightMinMax();
        }

        private int[] GetArrayFromGrid()
        {
            int[] arr = new int[dgvArray.ColumnCount];
            for (int i = 0; i < dgvArray.ColumnCount; i++)
            {
                var cell = dgvArray.Rows[0].Cells[i];
                arr[i] = cell.Value != null && int.TryParse(cell.Value.ToString(), out int val) ? val : 0;
            }
            return arr;
        }

        /// <summary>
        /// Подсветка максимума и минимума
        /// </summary>
        private void HighlightMinMax()
        {
            if (currentArray == null) return;

            // Сброс цветов
            foreach (DataGridViewCell cell in dgvArray.Rows[0].Cells)
            {
                cell.Style.BackColor = Color.White;
                cell.Style.ForeColor = Color.Black;
            }

            // Собираем корректные числа из таблицы
            List<int> validValues = new List<int>();
            for (int i = 0; i < dgvArray.ColumnCount; i++)
            {
                var cell = dgvArray.Rows[0].Cells[i];
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int num))
                {
                    validValues.Add(num);
                }
                else
                {
                    // Если значение некорректно — подсвечиваем КРАСНЫМ
                    dgvArray.Rows[0].Cells[i].Style.BackColor = Color.LightPink;
                    dgvArray.Rows[0].Cells[i].Style.ForeColor = Color.DarkRed;
                }
            }

            // Если нет корректных чисел — выходим
            if (validValues.Count == 0) return;

            // Находим максимум и минимум ТОЛЬКО среди корректных чисел
            int max = validValues.Max();
            int min = validValues.Min();

            // Подсвечиваем корректные макс/мин
            for (int i = 0; i < dgvArray.ColumnCount; i++)
            {
                var cell = dgvArray.Rows[0].Cells[i];
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int num))
                {
                    if (num == max)
                    {
                        cell.Style.BackColor = Color.LightGreen;
                        cell.Style.ForeColor = Color.DarkGreen;
                    }
                    else if (num == min)
                    {
                        cell.Style.BackColor = Color.LightCoral;
                        cell.Style.ForeColor = Color.DarkRed;
                    }
                }
            }
        }
        /// <summary>
        /// Обработчик изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            if (currentArray != null)
            {
                int[] updated = GetArrayFromGrid();
                currentArray.SetArray(updated);
                HighlightMinMax();
                lblStatus.Text = "Изменения применены.";
            }
        }
        /// <summary>
        /// Сортировка и операции ---
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortBubble_Click(object sender, EventArgs e)
        {
            if (currentArray == null) { ShowNoArrayMessage(); return; }
            int[] original = currentArray.GetArray();
            int[] sorted = currentArray.BubbleSort((int[])original.Clone());
            currentArray.SetArray(sorted);
            UpdateDataGridViewFromMassivSort();
            lblStatus.Text = "Массив отсортирован методом пузырька.";
        }

        private void btnSortSelection_Click(object sender, EventArgs e)
        {
            if (currentArray == null) { ShowNoArrayMessage(); return; }
            int[] original = currentArray.GetArray();
            int[] sorted = currentArray.ViborSort((int[])original.Clone());
            currentArray.SetArray(sorted);
            UpdateDataGridViewFromMassivSort();
            lblStatus.Text = "Массив отсортирован методом выбора.";
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            if (currentArray == null) { ShowNoArrayMessage(); return; }
            int max = currentArray.FindMax();
            int min = currentArray.FindMin();
            double avg = currentArray.FindAverage();
            string stats = $"Максимум: {max}\nМинимум: {min}\nСреднее арифметическое: {avg:F2}";
            MessageBox.Show(stats, "Статистика массива", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPerformAll_Click(object sender, EventArgs e)
        {
            if (currentArray == null) { ShowNoArrayMessage(); return; }
            string result = currentArray.PerformAllOperations();
            MessageBox.Show(result, "Результаты всех операций", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HighlightMinMax();
        }

        private void ShowNoArrayMessage()
        {
            MessageBox.Show("Сначала создайте массив.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}