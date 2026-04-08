namespace Lab2
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpInit = new GroupBox();
            label2 = new Label();
            lblInit1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvInit2 = new DataGridView();
            dgvInit1 = new DataGridView();
            grpFinal = new GroupBox();
            lblFinal = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvFinal = new DataGridView();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInit1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinal).BeginInit();
            SuspendLayout();
            // 
            // grpInit
            // 
            grpInit.Location = new Point(287, 190);
            grpInit.Name = "grpInit";
            grpInit.Size = new Size(200, 20);
            grpInit.TabIndex = 0;
            grpInit.TabStop = false;
            grpInit.Text = "Начальное состояние";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(57, 93);
            label2.TabIndex = 1;
            label2.Text = "Список 2";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInit1
            // 
            lblInit1.AutoSize = true;
            lblInit1.Dock = DockStyle.Left;
            lblInit1.Location = new Point(3, 0);
            lblInit1.Name = "lblInit1";
            lblInit1.Size = new Size(57, 93);
            lblInit1.TabIndex = 0;
            lblInit1.Text = "Список 1";
            lblInit1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5107918F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.48921F));
            tableLayoutPanel1.Controls.Add(dgvInit2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblInit1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvInit1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(556, 186);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvInit2
            // 
            dgvInit2.AllowUserToAddRows = false;
            dgvInit2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInit2.ColumnHeadersVisible = false;
            dgvInit2.Dock = DockStyle.Fill;
            dgvInit2.Location = new Point(67, 96);
            dgvInit2.Name = "dgvInit2";
            dgvInit2.ReadOnly = true;
            dgvInit2.RowHeadersVisible = false;
            dgvInit2.Size = new Size(486, 87);
            dgvInit2.TabIndex = 3;
            // 
            // dgvInit1
            // 
            dgvInit1.AllowUserToAddRows = false;
            dgvInit1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInit1.ColumnHeadersVisible = false;
            dgvInit1.Dock = DockStyle.Fill;
            dgvInit1.Location = new Point(67, 3);
            dgvInit1.Name = "dgvInit1";
            dgvInit1.ReadOnly = true;
            dgvInit1.RowHeadersVisible = false;
            dgvInit1.Size = new Size(486, 87);
            dgvInit1.TabIndex = 2;
            // 
            // grpFinal
            // 
            grpFinal.Location = new Point(3, 214);
            grpFinal.Name = "grpFinal";
            grpFinal.Size = new Size(550, 24);
            grpFinal.TabIndex = 2;
            grpFinal.TabStop = false;
            grpFinal.Text = "Конечное состояние";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Dock = DockStyle.Top;
            lblFinal.Location = new Point(0, 0);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(125, 15);
            lblFinal.TabIndex = 3;
            lblFinal.Text = "Начально состояние:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 92);
            label1.TabIndex = 4;
            label1.Text = "Результат слияния:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 478F));
            tableLayoutPanel2.Controls.Add(dgvFinal, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 236);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(544, 92);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // dgvFinal
            // 
            dgvFinal.AllowUserToAddRows = false;
            dgvFinal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinal.ColumnHeadersVisible = false;
            dgvFinal.Dock = DockStyle.Fill;
            dgvFinal.Location = new Point(69, 3);
            dgvFinal.Name = "dgvFinal";
            dgvFinal.ReadOnly = true;
            dgvFinal.RowHeadersVisible = false;
            dgvFinal.Size = new Size(472, 86);
            dgvFinal.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(235, 374);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 7;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(btnClose);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblFinal);
            Controls.Add(grpFinal);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(grpInit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcessForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Обработка списков (вариант 16)";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInit1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInit;
        private Label label2;
        private Label lblInit1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvInit1;
        private DataGridView dgvInit2;
        private GroupBox grpFinal;
        private Label lblFinal;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvFinal;
        private Button btnClose;
    }
}