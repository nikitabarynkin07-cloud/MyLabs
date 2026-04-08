namespace Lab2
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            labelTitle = new Label();
            labelTask = new Label();
            labelTaskDescription = new Label();
            labelAuthor = new Label();
            labelGroup = new Label();
            buttonClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(23, 23);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(263, 24);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Лабораторная работа №2";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            labelTask.Location = new Point(23, 63);
            labelTask.Margin = new Padding(4, 0, 4, 0);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(337, 18);
            labelTask.TabIndex = 1;
            labelTask.Text = "Динамические структуры данных. Списки\r\n";
            // 
            // labelTaskDescription
            // 
            labelTaskDescription.AutoSize = true;
            labelTaskDescription.Font = new Font("Microsoft Sans Serif", 9F);
            labelTaskDescription.Location = new Point(24, 95);
            labelTaskDescription.Margin = new Padding(4, 0, 4, 0);
            labelTaskDescription.Name = "labelTaskDescription";
            labelTaskDescription.Size = new Size(0, 15);
            labelTaskDescription.TabIndex = 2;
            labelTaskDescription.Click += labelTaskDescription_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Microsoft Sans Serif", 10F);
            labelAuthor.Location = new Point(23, 288);
            labelAuthor.Margin = new Padding(4, 0, 4, 0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(208, 34);
            labelAuthor.TabIndex = 3;
            labelAuthor.Text = "Разработчик:\nБарынкин Никита Викторович";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Microsoft Sans Serif", 10F);
            labelGroup.Location = new Point(24, 331);
            labelGroup.Margin = new Padding(4, 0, 4, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(158, 17);
            labelGroup.TabIndex = 4;
            labelGroup.Text = "Группа: 6106-090301D";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(205, 370);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(117, 35);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(452, 147);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 444);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(labelGroup);
            Controls.Add(labelAuthor);
            Controls.Add(labelTaskDescription);
            Controls.Add(labelTask);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonClose;
        private Label label1;
    }
}