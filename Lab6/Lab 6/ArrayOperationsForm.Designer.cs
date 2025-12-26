namespace Lab_6
{
    partial class ArrayOperationsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnApplyChanges;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSize = new System.Windows.Forms.Label();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerateDefault = new System.Windows.Forms.Button();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.btnSortBubble = new System.Windows.Forms.Button();
            this.btnSortSelection = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPerformAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            this.SuspendLayout();
            this.dgvArray.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArray_CellEndEdit);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 15);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(93, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Размер массива:";
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(111, 12);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(50, 20);
            this.txtArraySize.TabIndex = 1;
            this.txtArraySize.Text = "10";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(167, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Создать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // prim izm
            // 
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.btnApplyChanges.Location = new System.Drawing.Point(400, 145);
            this.btnApplyChanges.Size = new System.Drawing.Size(100, 23);
            this.btnApplyChanges.Text = "Применить";
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            this.Controls.Add(this.btnApplyChanges);
            //
            // btnGenerateDefault
            //
            this.btnGenerateDefault.Location = new System.Drawing.Point(273, 10);
            this.btnGenerateDefault.Name = "btnGenerateDefault";
            this.btnGenerateDefault.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateDefault.TabIndex = 3;
            this.btnGenerateDefault.Text = "По умолчанию";
            this.btnGenerateDefault.UseVisualStyleBackColor = true;
            this.btnGenerateDefault.Click += new System.EventHandler(this.btnGenerateDefault_Click);
            // 
            // dgvArray
            // 
            this.dgvArray.AllowUserToAddRows = false;
            this.dgvArray.AllowUserToDeleteRows = false;
            this.dgvArray.ReadOnly = false;
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvArray.Location = new System.Drawing.Point(12, 45);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.Size = new System.Drawing.Size(560, 60);
            this.dgvArray.TabIndex = 4;
            // 
            // btnSortBubble
            // 
            this.btnSortBubble.Location = new System.Drawing.Point(12, 115);
            this.btnSortBubble.Name = "btnSortBubble";
            this.btnSortBubble.Size = new System.Drawing.Size(120, 23);
            this.btnSortBubble.TabIndex = 5;
            this.btnSortBubble.Text = "Сортировка (пузырёк)";
            this.btnSortBubble.UseVisualStyleBackColor = true;
            this.btnSortBubble.Click += new System.EventHandler(this.btnSortBubble_Click);
            // 
            // btnSortSelection
            // 
            this.btnSortSelection.Location = new System.Drawing.Point(138, 115);
            this.btnSortSelection.Name = "btnSortSelection";
            this.btnSortSelection.Size = new System.Drawing.Size(120, 23);
            this.btnSortSelection.TabIndex = 6;
            this.btnSortSelection.Text = "Сортировка (выбор)";
            this.btnSortSelection.UseVisualStyleBackColor = true;
            this.btnSortSelection.Click += new System.EventHandler(this.btnSortSelection_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(264, 115);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(130, 23);
            this.btnShowStats.TabIndex = 7;
            this.btnShowStats.Text = "Макс/Мин/Среднее";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Создайте массив...";
            // 
            // btnPerformAll
            // 
            this.btnPerformAll.Location = new System.Drawing.Point(400, 115);
            this.btnPerformAll.Name = "btnPerformAll";
            this.btnPerformAll.Size = new System.Drawing.Size(172, 23);
            this.btnPerformAll.TabIndex = 9;
            this.btnPerformAll.Text = "Выполнить все операции";
            this.btnPerformAll.UseVisualStyleBackColor = true;
            this.btnPerformAll.Click += new System.EventHandler(this.btnPerformAll_Click);
            // 
            // ArrayOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 180);
            this.Controls.Add(this.btnPerformAll);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.btnSortSelection);
            this.Controls.Add(this.btnSortBubble);
            this.Controls.Add(this.dgvArray);
            this.Controls.Add(this.btnGenerateDefault); // ← ДОБАВЛЕНА В ФОРМУ
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.lblSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrayOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с массивами";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGenerateDefault; // ← НОВОЕ ПОЛЕ
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.Button btnSortBubble;
        private System.Windows.Forms.Button btnSortSelection;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnPerformAll;
    }
}