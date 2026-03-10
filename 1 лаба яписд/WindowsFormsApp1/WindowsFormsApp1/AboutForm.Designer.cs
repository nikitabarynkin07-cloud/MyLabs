namespace Lab1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(263, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Лабораторная работа №1";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelTask.Location = new System.Drawing.Point(20, 55);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(202, 18);
            this.labelTask.TabIndex = 1;
            this.labelTask.Text = "Рекурсивные алгоритмы";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTaskDescription.Location = new System.Drawing.Point(21, 82);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(521, 60);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = resources.GetString("labelTaskDescription.Text");
            this.labelTaskDescription.Click += new System.EventHandler(this.labelTaskDescription_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(21, 184);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(208, 34);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Разработчик:\nБарынкин Никита Викторович";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGroup.Location = new System.Drawing.Point(20, 230);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(158, 17);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Группа: 6106-090301D";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(150, 280);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 324);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonClose;
    }
}