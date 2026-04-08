using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class EditForm : Form
    {
        public int ListNumber { get; private set; }
        public int Value { get; private set; }
        public int PositionIndex { get; private set; }

        public EditForm(string action, string position)
        {
            InitializeComponent();

            this.btnOK.Click += btnOK_Click;
            this.btnCancel.Click += btnCancel_Click;

            this.Text = $"{action} → {position}";

            bool isDelete = action == "Удаление";
            bool isByIndex = position.Contains("номеру");

            lblValue.Visible = txtValue.Visible = !isDelete;
            lblIndex.Visible = txtIndex.Visible = isByIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtListNum.Text, out int num) || (num != 1 && num != 2))
            {
                MessageBox.Show("Введите 1 или 2.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtListNum.Focus(); return;
            }
            ListNumber = num;

            if (txtValue.Visible)
            {
                if (!int.TryParse(txtValue.Text, out int val))
                {
                    MessageBox.Show("Введите целое число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValue.Focus(); return;
                }
                Value = val;
            }


            if (txtIndex.Visible)
            {
                if (!int.TryParse(txtIndex.Text, out int idx) || idx < 1)
                {
                    MessageBox.Show("Номер узла должен быть ≥ 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIndex.Focus(); return;
                }
                PositionIndex = idx;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}