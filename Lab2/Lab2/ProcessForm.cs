using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ProcessForm : Form
    {
        private readonly SingleLinkedList _list1;
        private readonly SingleLinkedList _list2;

        public ProcessForm(SingleLinkedList list1, SingleLinkedList list2)
        {
            InitializeComponent();

            _list1 = list1;
            _list2 = list2;


            SetupGrid(dgvInit1);
            SetupGrid(dgvInit2);
            SetupGrid(dgvFinal);

            FillGrid(dgvInit1, _list1);
            FillGrid(dgvInit2, _list2);


            if (!_list1.IsSorted() || !_list2.IsSorted())
            {
                MessageBox.Show(
                    "Ошибка! Списки должны быть упорядочены по возрастанию.\n" +
                    "Отредактируйте данные перед обработкой.",
                    "Ошибка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }


            _list1.MergeSorted(_list2);


            FillGrid(dgvFinal, _list1);

            MessageBox.Show(
                "Слияние выполнено успешно!\n\n" +
                $"Начальное состояние показано в верхних таблицах.\n" +
                $"Конечное состояние (результат) — в нижней таблице.\n\n" +
                $"Список 2 теперь пуст.",
                "Обработка завершена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.ColumnCount = 2;

            dgv.Columns[0].Name = "colIndex";
            dgv.Columns[0].HeaderText = "№";
            dgv.Columns[0].Width = 40;

            dgv.Columns[1].Name = "colValue";
            dgv.Columns[1].HeaderText = "Значение";
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
        }

        private void FillGrid(DataGridView dgv, SingleLinkedList list)
        {
            dgv.Rows.Clear();
            int[] arr = list.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                dgv.Rows.Add(i + 1, arr[i]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}