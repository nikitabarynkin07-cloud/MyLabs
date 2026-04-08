namespace Lab2
{
    partial class MainForm
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
            menu = new MenuStrip();
            menuTask = new ToolStripMenuItem();
            menuCreate = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuAdd = new ToolStripMenuItem();
            menuAddFirst = new ToolStripMenuItem();
            menuAddLast = new ToolStripMenuItem();
            menuAddIndex = new ToolStripMenuItem();
            menuDelete = new ToolStripMenuItem();
            menuDeleteFirst = new ToolStripMenuItem();
            menuDeleteLast = new ToolStripMenuItem();
            menuDeleteIndex = new ToolStripMenuItem();
            menuProcess = new ToolStripMenuItem();
            menuDestroy = new ToolStripMenuItem();
            MenuAbout = new ToolStripMenuItem();
            MenuExit = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuTask, MenuAbout, MenuExit });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuTask
            // 
            menuTask.BackColor = SystemColors.Window;
            menuTask.DropDownItems.AddRange(new ToolStripItem[] { menuCreate, menuEdit, menuProcess, menuDestroy });
            menuTask.Name = "menuTask";
            menuTask.Size = new Size(76, 20);
            menuTask.Text = "1. Задание";
            // 
            // menuCreate
            // 
            menuCreate.Name = "menuCreate";
            menuCreate.Size = new Size(204, 22);
            menuCreate.Text = "Создание списка";
            menuCreate.Click += menuCreate_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuAdd, menuDelete });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(204, 22);
            menuEdit.Text = "Редактирование списка";
            // 
            // menuAdd
            // 
            menuAdd.DropDownItems.AddRange(new ToolStripItem[] { menuAddFirst, menuAddLast, menuAddIndex });
            menuAdd.Name = "menuAdd";
            menuAdd.Size = new Size(141, 22);
            menuAdd.Text = "Добавление";
            // 
            // menuAddFirst
            // 
            menuAddFirst.Name = "menuAddFirst";
            menuAddFirst.Size = new Size(135, 22);
            menuAddFirst.Text = "В начало";
            menuAddFirst.Click += menuAddFirst_Click;
            // 
            // menuAddLast
            // 
            menuAddLast.Name = "menuAddLast";
            menuAddLast.Size = new Size(135, 22);
            menuAddLast.Text = "В конец";
            menuAddLast.Click += menuAddLast_Click;
            // 
            // menuAddIndex
            // 
            menuAddIndex.Name = "menuAddIndex";
            menuAddIndex.Size = new Size(135, 22);
            menuAddIndex.Text = "По номеру";
            menuAddIndex.Click += menuAddIndex_Click;
            // 
            // menuDelete
            // 
            menuDelete.DropDownItems.AddRange(new ToolStripItem[] { menuDeleteFirst, menuDeleteLast, menuDeleteIndex });
            menuDelete.Name = "menuDelete";
            menuDelete.Size = new Size(141, 22);
            menuDelete.Text = "Удаление";
            // 
            // menuDeleteFirst
            // 
            menuDeleteFirst.Name = "menuDeleteFirst";
            menuDeleteFirst.Size = new Size(135, 22);
            menuDeleteFirst.Text = "В начале";
            menuDeleteFirst.Click += menuDeleteFirst_Click;
            // 
            // menuDeleteLast
            // 
            menuDeleteLast.Name = "menuDeleteLast";
            menuDeleteLast.Size = new Size(135, 22);
            menuDeleteLast.Text = "В конце";
            menuDeleteLast.Click += menuDeleteLast_Click;
            // 
            // menuDeleteIndex
            // 
            menuDeleteIndex.Name = "menuDeleteIndex";
            menuDeleteIndex.Size = new Size(135, 22);
            menuDeleteIndex.Text = "По номеру";
            menuDeleteIndex.Click += menuDeleteIndex_Click;
            // 
            // menuProcess
            // 
            menuProcess.Name = "menuProcess";
            menuProcess.Size = new Size(204, 22);
            menuProcess.Text = "Обработка списков";
            menuProcess.Click += menuProcess_Click;
            // 
            // menuDestroy
            // 
            menuDestroy.Name = "menuDestroy";
            menuDestroy.Size = new Size(204, 22);
            menuDestroy.Text = "Разрушение списков";
            menuDestroy.Click += menuDestroy_Click;
            // 
            // MenuAbout
            // 
            MenuAbout.BackColor = SystemColors.Window;
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Size = new Size(106, 20);
            MenuAbout.Text = "2. О программе";
            MenuAbout.Click += MenuAbout_Click;
            // 
            // MenuExit
            // 
            MenuExit.BackColor = SystemColors.Window;
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(65, 20);
            MenuExit.Text = "3. Выход";
            MenuExit.Click += menuExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 426);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(5, 5);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список 1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(384, 379);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ScrollBar;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(384, 15);
            label1.TabIndex = 0;
            label1.Text = "№ | Значение";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(405, 5);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Список 2";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(384, 379);
            dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ScrollBar;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(384, 15);
            label2.TabIndex = 1;
            label2.Text = "№ | Значение";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menu);
            Name = "MainForm";
            Text = "Лабораторная работа №2";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menuTask;
        private ToolStripMenuItem menuCreate;
        private ToolStripMenuItem menuEdit;
        private ToolStripMenuItem menuProcess;
        private ToolStripMenuItem menuDestroy;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private ToolStripMenuItem MenuExit;
        private ToolStripMenuItem menuAdd;
        private ToolStripMenuItem menuAddFirst;
        private ToolStripMenuItem menuAddLast;
        private ToolStripMenuItem menuAddIndex;
        private ToolStripMenuItem menuDelete;
        private ToolStripMenuItem menuDeleteFirst;
        private ToolStripMenuItem menuDeleteLast;
        private ToolStripMenuItem menuDeleteIndex;
        private ToolStripMenuItem MenuAbout;
    }
}