namespace Lab2
{
    partial class CreateForm
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
            lblListIndex = new Label();
            txtListIndex = new TextBox();
            lblCount = new Label();
            txtCount = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblListIndex
            // 
            lblListIndex.Anchor = AnchorStyles.None;
            lblListIndex.AutoSize = true;
            lblListIndex.Location = new Point(83, 40);
            lblListIndex.Name = "lblListIndex";
            lblListIndex.Size = new Size(136, 15);
            lblListIndex.TabIndex = 0;
            lblListIndex.Text = "Номер списка (1 или 2)";
            // 
            // txtListIndex
            // 
            txtListIndex.Anchor = AnchorStyles.None;
            txtListIndex.Location = new Point(93, 68);
            txtListIndex.MaxLength = 1;
            txtListIndex.Name = "txtListIndex";
            txtListIndex.Size = new Size(113, 23);
            txtListIndex.TabIndex = 1;
            txtListIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.None;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(58, 106);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(182, 15);
            lblCount.TabIndex = 2;
            lblCount.Text = "Введите количество элементов:";
            // 
            // txtCount
            // 
            txtCount.Anchor = AnchorStyles.None;
            txtCount.Location = new Point(93, 147);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(113, 23);
            txtCount.TabIndex = 3;
            txtCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.Location = new Point(111, 204);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(76, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(111, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(76, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 309);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtCount);
            Controls.Add(lblCount);
            Controls.Add(txtListIndex);
            Controls.Add(lblListIndex);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создание списка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListIndex;
        private TextBox txtListIndex;
        private Label lblCount;
        private TextBox txtCount;
        private Button btnCreate;
        private Button btnCancel;
    }
}