namespace Lab_6
{
    partial class GuessGameForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessGameForm));
            lblInputA = new Label();
            txtInputA = new TextBox();
            lblAttempts = new Label();
            txtAttempts = new TextBox();
            btnStart = new Button();
            lblPrompt = new Label();
            txtGuess = new TextBox();
            lblStatus = new Label();
            lblTimer = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInputA
            // 
            lblInputA.AutoSize = true;
            lblInputA.Location = new Point(14, 17);
            lblInputA.Margin = new Padding(4, 0, 4, 0);
            lblInputA.Name = "lblInputA";
            lblInputA.Size = new Size(116, 15);
            lblInputA.TabIndex = 0;
            lblInputA.Text = "Введите значение a:";
            // 
            // txtInputA
            // 
            txtInputA.Location = new Point(135, 14);
            txtInputA.Margin = new Padding(4, 3, 4, 3);
            txtInputA.Name = "txtInputA";
            txtInputA.Size = new Size(116, 23);
            txtInputA.TabIndex = 1;
            txtInputA.TextChanged += txtInputA_TextChanged;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(14, 52);
            lblAttempts.Margin = new Padding(4, 0, 4, 0);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(126, 15);
            lblAttempts.TabIndex = 2;
            lblAttempts.Text = "Количество попыток:";
            // 
            // txtAttempts
            // 
            txtAttempts.Location = new Point(135, 48);
            txtAttempts.Margin = new Padding(4, 3, 4, 3);
            txtAttempts.Name = "txtAttempts";
            txtAttempts.Size = new Size(58, 23);
            txtAttempts.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(201, 46);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 27);
            btnStart.TabIndex = 4;
            btnStart.Text = "Начать игру";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(14, 92);
            lblPrompt.Margin = new Padding(4, 0, 4, 0);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(111, 15);
            lblPrompt.TabIndex = 5;
            lblPrompt.Text = "Введите ваш ответ:";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(135, 89);
            txtGuess.Margin = new Padding(4, 3, 4, 3);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(193, 23);
            txtGuess.TabIndex = 6;
            txtGuess.KeyDown += txtGuess_KeyDown;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 127);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Готово...";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblTimer.ForeColor = Color.Red;
            lblTimer.Location = new Point(14, 150);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 15);
            lblTimer.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(357, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 59);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GuessGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 185);
            Controls.Add(pictureBox1);
            Controls.Add(lblTimer);
            Controls.Add(lblStatus);
            Controls.Add(txtGuess);
            Controls.Add(lblPrompt);
            Controls.Add(btnStart);
            Controls.Add(txtAttempts);
            Controls.Add(lblAttempts);
            Controls.Add(txtInputA);
            Controls.Add(lblInputA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GuessGameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Игра 'Угадайка'";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInputA;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimer;
        private PictureBox pictureBox1;
    }
}