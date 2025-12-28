// AuthorInfoForm.Designer.cs
namespace Lab_6_Levina
{
    partial class AuthorInfoForm
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
            this.lblAuthorInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAuthorInfo
            // 
            this.lblAuthorInfo.AutoSize = true;
            this.lblAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthorInfo.Location = new System.Drawing.Point(50, 50);
            this.lblAuthorInfo.Name = "lblAuthorInfo";
            this.lblAuthorInfo.Size = new System.Drawing.Size(250, 34);
            this.lblAuthorInfo.TabIndex = 0;
            this.lblAuthorInfo.Text = "Группа: 6105-090301D\nЛевина Ксения Андреевна";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AuthorInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAuthorInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Об авторе";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAuthorInfo;
        private System.Windows.Forms.Button btnClose;
    }
}