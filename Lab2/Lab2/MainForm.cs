using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {

        private SingleLinkedList _list1;
        private SingleLinkedList _list2;

        public MainForm()
        {
            InitializeComponent();


            _list1 = new SingleLinkedList();
            _list2 = new SingleLinkedList();


            SetupGrid(dataGridView1);
            SetupGrid(dataGridView2);

            RefreshGrids();
        }

        private void SetupGrid(DataGridView grid)
        {
            grid.ColumnCount = 2;
            grid.Columns[0].Name = "colIndex";
            grid.Columns[0].HeaderText = "№";
            grid.Columns[0].Width = 50;

            grid.Columns[1].Name = "colValue";
            grid.Columns[1].HeaderText = "Значение";
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersVisible = false; 
        }


        private void RefreshGrids()
        {
            RefreshSingleGrid(dataGridView1, _list1);
            RefreshSingleGrid(dataGridView2, _list2);
        }

        private void RefreshSingleGrid(DataGridView grid, SingleLinkedList list)
        {
            grid.Rows.Clear();

            int[] arr = list.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {

                grid.Rows.Add(i + 1, arr[i]);
            }
        }

        private void menuAddFirst_Click(object sender, EventArgs e) => OpenEdit("Добавление", "В начало");
        private void menuAddLast_Click(object sender, EventArgs e) => OpenEdit("Добавление", "В конец");
        private void menuAddIndex_Click(object sender, EventArgs e) => OpenEdit("Добавление", "По номеру");

        private void menuDeleteFirst_Click(object sender, EventArgs e) => OpenEdit("Удаление", "В начале");
        private void menuDeleteLast_Click(object sender, EventArgs e) => OpenEdit("Удаление", "В конце");
        private void menuDeleteIndex_Click(object sender, EventArgs e) => OpenEdit("Удаление", "По номеру");

        private void OpenEdit(string action, string position)
        {
            using var frm = new EditForm(action, position);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                SingleLinkedList target = (frm.ListNumber == 1) ? _list1 : _list2;
                bool success = false;

                if (action == "Добавление")
                {
                    if (position == "В начало") target.InsertFirst(frm.Value);
                    else if (position == "В конец") target.InsertLast(frm.Value);
                    else target.InsertAtPosition(frm.Value, frm.PositionIndex);
                    success = true;
                }
                else
                {
                    if (position == "В начале") success = target.DeleteFirst();
                    else if (position == "В конце") success = target.DeleteLast();
                    else success = target.DeleteAtPosition(frm.PositionIndex);
                }

                if (!success)
                    MessageBox.Show("Операция не выполнена. Проверьте ввод или пустоту списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                RefreshGrids();
            }
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            var settingsForm = new ExitForm();
            settingsForm.ShowDialog();
        }

        private void menuCreate_Click(object sender, EventArgs e)
        {
            using (var createFrm = new CreateForm())
            {
                if (createFrm.ShowDialog(this) == DialogResult.OK)
                {
                    if (createFrm.TargetListIndex == 1)
                        _list1 = createFrm.CreatedList;
                    else
                        _list2 = createFrm.CreatedList;

                    RefreshGrids();
                }
            }
        }
        private void menuDestroy_Click(object sender, EventArgs e)
        {
            _list1.Clear(); 
            _list2.Clear();
            RefreshGrids();
            MessageBox.Show("Списки очищены", "Инфо");
        }

        private void menuProcess_Click(object sender, EventArgs e)
        {
            if (_list1.IsEmpty() || _list2.IsEmpty())
            {
                MessageBox.Show(
                    "Сначала создайте ОБА списка в пункте 'Создание списка'!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (var processFrm = new ProcessForm(_list1, _list2))
            {
                if (processFrm.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshGrids();
                }
            }
        }



        private void MenuAbout_Click(object sender, EventArgs e)
        {
            var settingsForm = new AboutForm();
            settingsForm.ShowDialog();
        }
    }
}