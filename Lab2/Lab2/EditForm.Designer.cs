namespace Lab2
{
    partial class EditForm
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
            lblTitle = new Label();
            lblListNum = new Label();
            txtListNum = new TextBox();
            lblValue = new Label();
            txtValue = new TextBox();
            lblIndex = new Label();
            txtIndex = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(93, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Параметры операции:";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblListNum
            // 
            lblListNum.AutoSize = true;
            lblListNum.Location = new Point(59, 87);
            lblListNum.Name = "lblListNum";
            lblListNum.Size = new Size(139, 15);
            lblListNum.TabIndex = 1;
            lblListNum.Text = "Номер списка (1 или 2):";
            // 
            // txtListNum
            // 
            txtListNum.Location = new Point(254, 87);
            txtListNum.MaxLength = 1;
            txtListNum.Name = "txtListNum";
            txtListNum.Size = new Size(100, 23);
            txtListNum.TabIndex = 2;
            txtListNum.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(59, 137);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(118, 15);
            lblValue.TabIndex = 3;
            lblValue.Text = "Значение элемента:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(254, 137);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(100, 23);
            txtValue.TabIndex = 4;
            txtValue.TextAlign = HorizontalAlignment.Center;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(59, 193);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(123, 15);
            lblIndex.TabIndex = 5;
            lblIndex.Text = "Номер позиции (≥1):";
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(254, 193);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(100, 23);
            txtIndex.TabIndex = 6;
            txtIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(93, 259);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 7;
            btnOK.Text = "Ок";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(240, 259);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = btnCancel;
            ClientSize = new Size(419, 306);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtIndex);
            Controls.Add(lblIndex);
            Controls.Add(txtValue);
            Controls.Add(lblValue);
            Controls.Add(txtListNum);
            Controls.Add(lblListNum);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование списка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblListNum;
        private TextBox txtListNum;
        private Label lblValue;
        private TextBox txtValue;
        private Label lblIndex;
        private TextBox txtIndex;
        private Button btnOK;
        private Button btnCancel;
    }
}