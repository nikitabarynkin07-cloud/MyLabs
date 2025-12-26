namespace Lab_6
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
            this.btnGuessGame = new System.Windows.Forms.Button();
            this.btnArrayOperations = new System.Windows.Forms.Button();
            this.btnSaperGame = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuessGame
            // 
            this.btnGuessGame.Location = new System.Drawing.Point(80, 60);
            this.btnGuessGame.Name = "btnGuessGame";
            this.btnGuessGame.Size = new System.Drawing.Size(150, 30);
            this.btnGuessGame.TabIndex = 0;
            this.btnGuessGame.Text = "Игра 'Угадайка'";
            this.btnGuessGame.UseVisualStyleBackColor = true;
            this.btnGuessGame.Click += new System.EventHandler(this.btnGuessGame_Click);
            // 
            // btnArrayOperations
            // 
            this.btnArrayOperations.Location = new System.Drawing.Point(80, 100);
            this.btnArrayOperations.Name = "btnArrayOperations";
            this.btnArrayOperations.Size = new System.Drawing.Size(150, 30);
            this.btnArrayOperations.TabIndex = 1;
            this.btnArrayOperations.Text = "Работа с массивами";
            this.btnArrayOperations.UseVisualStyleBackColor = true;
            this.btnArrayOperations.Click += new System.EventHandler(this.btnArrayOperations_Click);
            // 
            // btnSaperGame
            // 
            this.btnSaperGame.Location = new System.Drawing.Point(80, 140);
            this.btnSaperGame.Name = "btnSaperGame";
            this.btnSaperGame.Size = new System.Drawing.Size(150, 30);
            this.btnSaperGame.TabIndex = 2;
            this.btnSaperGame.Text = "Игра 'Сапер'";
            this.btnSaperGame.UseVisualStyleBackColor = true;
            this.btnSaperGame.Click += new System.EventHandler(this.btnSaperGame_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(80, 180);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(150, 30);
            this.btnAuthor.TabIndex = 3;
            this.btnAuthor.Text = "Об авторе";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(80, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(70, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Лабораторная №6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnSaperGame);
            this.Controls.Add(this.btnArrayOperations);
            this.Controls.Add(this.btnGuessGame);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuessGame;
        private System.Windows.Forms.Button btnArrayOperations;
        private System.Windows.Forms.Button btnSaperGame;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}