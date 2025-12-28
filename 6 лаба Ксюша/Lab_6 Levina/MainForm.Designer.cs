// MainForm.Designer.cs
namespace Lab_6_Levina
{
    partial class MainForm
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
            btnGuessGame = new Button();
            btnArrayWork = new Button();
            btnSnakeGame = new Button();
            btnAuthorInfo = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuessGame
            // 
            btnGuessGame.Location = new Point(58, 92);
            btnGuessGame.Margin = new Padding(4, 3, 4, 3);
            btnGuessGame.Name = "btnGuessGame";
            btnGuessGame.Size = new Size(233, 46);
            btnGuessGame.TabIndex = 0;
            btnGuessGame.Text = "Игра: Угадай ответ";
            btnGuessGame.UseVisualStyleBackColor = true;
            btnGuessGame.Click += btnGuessGame_Click;
            // 
            // btnArrayWork
            // 
            btnArrayWork.Location = new Point(58, 162);
            btnArrayWork.Margin = new Padding(4, 3, 4, 3);
            btnArrayWork.Name = "btnArrayWork";
            btnArrayWork.Size = new Size(233, 46);
            btnArrayWork.TabIndex = 1;
            btnArrayWork.Text = "Работа с массивами";
            btnArrayWork.UseVisualStyleBackColor = true;
            btnArrayWork.Click += btnArrayWork_Click;
            // 
            // btnSnakeGame
            // 
            btnSnakeGame.Location = new Point(58, 231);
            btnSnakeGame.Margin = new Padding(4, 3, 4, 3);
            btnSnakeGame.Name = "btnSnakeGame";
            btnSnakeGame.Size = new Size(233, 46);
            btnSnakeGame.TabIndex = 2;
            btnSnakeGame.Text = "Игра Змейка";
            btnSnakeGame.UseVisualStyleBackColor = true;
            btnSnakeGame.Click += btnSnakeGame_Click;
            // 
            // btnAuthorInfo
            // 
            btnAuthorInfo.Location = new Point(58, 300);
            btnAuthorInfo.Margin = new Padding(4, 3, 4, 3);
            btnAuthorInfo.Name = "btnAuthorInfo";
            btnAuthorInfo.Size = new Size(233, 46);
            btnAuthorInfo.TabIndex = 3;
            btnAuthorInfo.Text = "Об авторе";
            btnAuthorInfo.UseVisualStyleBackColor = true;
            btnAuthorInfo.Click += btnAuthorInfo_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(58, 369);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(233, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(99, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 5;
            label1.Text = "Главное меню";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 462);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAuthorInfo);
            Controls.Add(btnSnakeGame);
            Controls.Add(btnArrayWork);
            Controls.Add(btnGuessGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа №5";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnGuessGame;
        private System.Windows.Forms.Button btnArrayWork;
        private System.Windows.Forms.Button btnSnakeGame;
        private System.Windows.Forms.Button btnAuthorInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}