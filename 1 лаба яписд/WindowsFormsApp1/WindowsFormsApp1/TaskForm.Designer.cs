namespace Lab1
{
    partial class TaskForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonFindMax = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelInstruction.Location = new System.Drawing.Point(20, 30);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(261, 17);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Введите целое положительное число:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumber.Location = new System.Drawing.Point(20, 60);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(200, 23);
            this.textBoxNumber.TabIndex = 1;
            // 
            // buttonFindMax
            // 
            this.buttonFindMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonFindMax.Location = new System.Drawing.Point(20, 100);
            this.buttonFindMax.Name = "buttonFindMax";
            this.buttonFindMax.Size = new System.Drawing.Size(200, 35);
            this.buttonFindMax.TabIndex = 2;
            this.buttonFindMax.Text = "Найти максимальную цифру";
            this.buttonFindMax.UseVisualStyleBackColor = true;
            this.buttonFindMax.Click += new System.EventHandler(this.ButtonFindMax_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelResult.Location = new System.Drawing.Point(20, 160);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(90, 17);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат:";
            // 
            // labelResultValue
            // 
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelResultValue.ForeColor = System.Drawing.Color.Blue;
            this.labelResultValue.Location = new System.Drawing.Point(20, 190);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(0, 20);
            this.labelResultValue.TabIndex = 4;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonFindMax);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание - Найти максимальную цифру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonFindMax;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResultValue;
    }
}