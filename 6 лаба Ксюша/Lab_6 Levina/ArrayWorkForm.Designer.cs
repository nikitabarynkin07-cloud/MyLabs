namespace Lab_6_Levina
{
    partial class ArrayWorkForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCreateCustom = new System.Windows.Forms.Button();
            this.btnCreateDefault = new System.Windows.Forms.Button();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSortShell = new System.Windows.Forms.Button();
            this.btnSortGnome = new System.Windows.Forms.Button();
            this.dgvShellResult = new System.Windows.Forms.DataGridView();
            this.dgvGnomeResult = new System.Windows.Forms.DataGridView();
            this.btnShowStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShellResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGnomeResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Работа с массивами";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(20, 50);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(96, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Размер (1–50):";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(122, 47);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 1;
            this.txtSize.Text = "10";
            // 
            // btnCreateCustom
            // 
            this.btnCreateCustom.Location = new System.Drawing.Point(180, 45);
            this.btnCreateCustom.Name = "btnCreateCustom";
            this.btnCreateCustom.Size = new System.Drawing.Size(100, 23);
            this.btnCreateCustom.TabIndex = 2;
            this.btnCreateCustom.Text = "Создать";
            this.btnCreateCustom.UseVisualStyleBackColor = true;
            this.btnCreateCustom.Click += new System.EventHandler(this.btnCreateCustom_Click);
            // 
            // btnCreateDefault
            // 
            this.btnCreateDefault.Location = new System.Drawing.Point(290, 45);
            this.btnCreateDefault.Name = "btnCreateDefault";
            this.btnCreateDefault.Size = new System.Drawing.Size(150, 23);
            this.btnCreateDefault.TabIndex = 3;
            this.btnCreateDefault.Text = "По умолчанию (10)";
            this.btnCreateDefault.UseVisualStyleBackColor = true;
            this.btnCreateDefault.Click += new System.EventHandler(this.btnCreateDefault_Click);
            // 
            // dgvArray
            // 
            this.dgvArray.AllowUserToAddRows = false;
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArray.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dgvArray.Location = new System.Drawing.Point(20, 90);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.RowHeadersVisible = false;
            this.dgvArray.Size = new System.Drawing.Size(600, 50);
            this.dgvArray.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // btnSortShell
            // 
            this.btnSortShell.Location = new System.Drawing.Point(20, 150);
            this.btnSortShell.Name = "btnSortShell";
            this.btnSortShell.Size = new System.Drawing.Size(120, 23);
            this.btnSortShell.TabIndex = 5;
            this.btnSortShell.Text = "Сортировка Шелла";
            this.btnSortShell.UseVisualStyleBackColor = true;
            this.btnSortShell.Click += new System.EventHandler(this.btnSortShell_Click);
            // 
            // btnSortGnome
            // 
            this.btnSortGnome.Location = new System.Drawing.Point(150, 150);
            this.btnSortGnome.Name = "btnSortGnome";
            this.btnSortGnome.Size = new System.Drawing.Size(120, 23);
            this.btnSortGnome.TabIndex = 6;
            this.btnSortGnome.Text = "Сортировка Гномья";
            this.btnSortGnome.UseVisualStyleBackColor = true;
            this.btnSortGnome.Click += new System.EventHandler(this.btnSortGnome_Click);
            // 
            // dgvShellResult
            // 
            this.dgvShellResult.AllowUserToAddRows = false;
            this.dgvShellResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShellResult.Location = new System.Drawing.Point(20, 180);
            this.dgvShellResult.Name = "dgvShellResult";
            this.dgvShellResult.RowHeadersVisible = false;
            this.dgvShellResult.Size = new System.Drawing.Size(600, 50);
            this.dgvShellResult.TabIndex = 7;
            // 
            // dgvGnomeResult
            // 
            this.dgvGnomeResult.AllowUserToAddRows = false;
            this.dgvGnomeResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGnomeResult.Location = new System.Drawing.Point(20, 240);
            this.dgvGnomeResult.Name = "dgvGnomeResult";
            this.dgvGnomeResult.RowHeadersVisible = false;
            this.dgvGnomeResult.Size = new System.Drawing.Size(600, 50);
            this.dgvGnomeResult.TabIndex = 8;
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(20, 300);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(120, 25);
            this.btnShowStats.TabIndex = 9;
            this.btnShowStats.Text = "Статистика";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // ArrayWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.dgvGnomeResult);
            this.Controls.Add(this.dgvShellResult);
            this.Controls.Add(this.btnSortGnome);
            this.Controls.Add(this.btnSortShell);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvArray);
            this.Controls.Add(this.btnCreateDefault);
            this.Controls.Add(this.btnCreateCustom);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ArrayWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с массивами";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShellResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGnomeResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCreateCustom;
        private System.Windows.Forms.Button btnCreateDefault;
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSortShell;
        private System.Windows.Forms.Button btnSortGnome;
        private System.Windows.Forms.DataGridView dgvShellResult;
        private System.Windows.Forms.DataGridView dgvGnomeResult;
        private System.Windows.Forms.Button btnShowStats;
    }
}