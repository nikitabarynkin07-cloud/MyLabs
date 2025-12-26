namespace Lab_6
{
    partial class SaperGameForm
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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameBoard.Location = new System.Drawing.Point(20, 20);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(200, 200);
            this.pnlGameBoard.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(20, 230);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(200, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Новая игра";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // SaperGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pnlGameBoard);
            this.Name = "SaperGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Игра 'Сапер'";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btnRestart;
    }
}