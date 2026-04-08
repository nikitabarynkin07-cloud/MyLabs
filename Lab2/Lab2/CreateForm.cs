using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class CreateForm : Form
    {

        public SingleLinkedList CreatedList { get; private set; }
        public int TargetListIndex { get; private set; }
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtListIndex.Text, out int listNum) || (listNum != 1 && listNum != 2))
            {
                MessageBox.Show("Введите 1 или 2.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtListIndex.Focus();
                return;
            }
            TargetListIndex = listNum;

            if (!int.TryParse(txtCount.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Количество должно быть целым числом > 0.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCount.Focus();
                return;
            }


            int[] tempData = new int[count];
            for (int i = 0; i < count; i++)
            {
                while (true)
                {
                    string input = Interaction.InputBox(
                        $"Введите значение элемента №{i + 1} из {count}:",
                        $"Создание Списка {listNum}", "");

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        if (MessageBox.Show("Прервать создание списка?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            return;
                        continue;
                    }

                    if (int.TryParse(input, out tempData[i]))
                        break; 

                    MessageBox.Show("Введено не число. Попробуйте снова.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            CreatedList = new SingleLinkedList();
            CreatedList.CreateFromInput(tempData); 

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
