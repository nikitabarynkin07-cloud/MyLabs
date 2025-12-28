namespace Lab_6_Levina
{
    partial class GuessGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessGameForm));
            lblTitle = new Label();
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            btnStart = new Button();
            lblAttempts = new Label();
            lblTimeLeft = new Label();
            lblGuess = new Label();
            txtGuess = new TextBox();
            btnSubmit = new Button();
            lblResult = new Label();
            txtAttempts = new TextBox();
            lblAttemptsLabel = new Label();
            txtTimeLimit = new TextBox();
            lblTimeLimitLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(93, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Игра: Угадай ответ";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(35, 69);
            lblA.Margin = new Padding(4, 0, 4, 0);
            lblA.Name = "lblA";
            lblA.Size = new Size(54, 15);
            lblA.TabIndex = 1;
            lblA.Text = "Число a:";
            // 
            // txtA
            // 
            txtA.Location = new Point(99, 66);
            txtA.Margin = new Padding(4, 3, 4, 3);
            txtA.Name = "txtA";
            txtA.Size = new Size(116, 23);
            txtA.TabIndex = 0;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(35, 104);
            lblB.Margin = new Padding(4, 0, 4, 0);
            lblB.Name = "lblB";
            lblB.Size = new Size(55, 15);
            lblB.TabIndex = 3;
            lblB.Text = "Число b:";
            // 
            // txtB
            // 
            txtB.Location = new Point(99, 100);
            txtB.Margin = new Padding(4, 3, 4, 3);
            txtB.Name = "txtB";
            txtB.Size = new Size(116, 23);
            txtB.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(99, 138);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(117, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Начать игру";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(35, 179);
            lblAttempts.Margin = new Padding(4, 0, 4, 0);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(122, 15);
            lblAttempts.TabIndex = 6;
            lblAttempts.Text = "Попыток осталось: 0";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Location = new Point(35, 208);
            lblTimeLeft.Margin = new Padding(4, 0, 4, 0);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(121, 15);
            lblTimeLeft.TabIndex = 7;
            lblTimeLeft.Text = "Времени осталось: 0";
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(35, 242);
            lblGuess.Margin = new Padding(4, 0, 4, 0);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(134, 15);
            lblGuess.TabIndex = 8;
            lblGuess.Text = "Ваша попытка (целое):";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(196, 239);
            txtGuess.Margin = new Padding(4, 3, 4, 3);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(116, 23);
            txtGuess.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Location = new Point(196, 271);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Проверить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblResult.Location = new Point(35, 323);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 11;
            lblResult.Visible = false;
            // 
            // txtAttempts
            // 
            txtAttempts.Location = new Point(292, 66);
            txtAttempts.Margin = new Padding(4, 3, 4, 3);
            txtAttempts.Name = "txtAttempts";
            txtAttempts.Size = new Size(58, 23);
            txtAttempts.TabIndex = 5;
            txtAttempts.Text = "3";
            // 
            // lblAttemptsLabel
            // 
            lblAttemptsLabel.AutoSize = true;
            lblAttemptsLabel.Location = new Point(222, 69);
            lblAttemptsLabel.Margin = new Padding(4, 0, 4, 0);
            lblAttemptsLabel.Name = "lblAttemptsLabel";
            lblAttemptsLabel.Size = new Size(60, 15);
            lblAttemptsLabel.TabIndex = 14;
            lblAttemptsLabel.Text = "Попыток:";
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(292, 100);
            txtTimeLimit.Margin = new Padding(4, 3, 4, 3);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(58, 23);
            txtTimeLimit.TabIndex = 6;
            txtTimeLimit.Text = "30";
            // 
            // lblTimeLimitLabel
            // 
            lblTimeLimitLabel.AutoSize = true;
            lblTimeLimitLabel.Location = new Point(222, 104);
            lblTimeLimitLabel.Margin = new Padding(4, 0, 4, 0);
            lblTimeLimitLabel.Name = "lblTimeLimitLabel";
            lblTimeLimitLabel.Size = new Size(62, 15);
            lblTimeLimitLabel.TabIndex = 16;
            lblTimeLimitLabel.Text = "Время (с):";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(372, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 74);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // GuessGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 369);
            Controls.Add(pictureBox1);
            Controls.Add(lblTimeLimitLabel);
            Controls.Add(txtTimeLimit);
            Controls.Add(lblAttemptsLabel);
            Controls.Add(txtAttempts);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(txtGuess);
            Controls.Add(lblGuess);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblAttempts);
            Controls.Add(btnStart);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GuessGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Угадай ответ";
            FormClosing += GuessGameForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Label lblAttemptsLabel;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.Label lblTimeLimitLabel;
        private PictureBox pictureBox1;
    }
}