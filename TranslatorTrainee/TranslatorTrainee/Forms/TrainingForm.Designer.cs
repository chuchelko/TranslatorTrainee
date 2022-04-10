using System.ComponentModel;

namespace TranslatorTrainee.Forms;

partial class TrainingForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null)) {
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
            this.categoriesBox = new System.Windows.Forms.ComboBox();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.answBtnRight = new System.Windows.Forms.Button();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.answBtnLeft = new System.Windows.Forms.Button();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.TrainingStart = new TranslatorTrainee.CustomButton();
            this.ScoreButton = new TranslatorTrainee.CustomButton();
            this.StopButton = new TranslatorTrainee.CustomButton();
            this.nextBtn = new TranslatorTrainee.CustomButton();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.Location = new System.Drawing.Point(199, 35);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(386, 28);
            this.categoriesBox.TabIndex = 0;
            // 
            // TaskPanel
            // 
            this.TaskPanel.Controls.Add(this.answBtnRight);
            this.TaskPanel.Controls.Add(this.AnswerPanel);
            this.TaskPanel.Controls.Add(this.answBtnLeft);
            this.TaskPanel.Controls.Add(this.QuestionPanel);
            this.TaskPanel.Location = new System.Drawing.Point(200, 123);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(385, 202);
            this.TaskPanel.TabIndex = 3;
            // 
            // answBtnRight
            // 
            this.answBtnRight.Location = new System.Drawing.Point(359, 110);
            this.answBtnRight.Name = "answBtnRight";
            this.answBtnRight.Size = new System.Drawing.Size(23, 88);
            this.answBtnRight.TabIndex = 5;
            this.answBtnRight.Text = ">";
            this.answBtnRight.UseVisualStyleBackColor = true;
            this.answBtnRight.Click += new System.EventHandler(this.answBtnRight_Click);
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.BackColor = System.Drawing.Color.DimGray;
            this.AnswerPanel.Location = new System.Drawing.Point(32, 110);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(321, 88);
            this.AnswerPanel.TabIndex = 4;
            // 
            // answBtnLeft
            // 
            this.answBtnLeft.Location = new System.Drawing.Point(3, 110);
            this.answBtnLeft.Name = "answBtnLeft";
            this.answBtnLeft.Size = new System.Drawing.Size(23, 88);
            this.answBtnLeft.TabIndex = 3;
            this.answBtnLeft.Text = "<";
            this.answBtnLeft.UseVisualStyleBackColor = true;
            this.answBtnLeft.Click += new System.EventHandler(this.answBtnLeft_Click);
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.Color.White;
            this.QuestionPanel.Location = new System.Drawing.Point(32, 3);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(321, 88);
            this.QuestionPanel.TabIndex = 1;
            // 
            // TrainingStart
            // 
            this.TrainingStart.BackColor = System.Drawing.Color.Turquoise;
            this.TrainingStart.BackgroundColor = System.Drawing.Color.Turquoise;
            this.TrainingStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TrainingStart.BorderRadius = 10;
            this.TrainingStart.BorderSize = 0;
            this.TrainingStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainingStart.Font = new System.Drawing.Font("Raleway ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrainingStart.ForeColor = System.Drawing.Color.White;
            this.TrainingStart.Location = new System.Drawing.Point(320, 393);
            this.TrainingStart.Name = "TrainingStart";
            this.TrainingStart.Size = new System.Drawing.Size(130, 45);
            this.TrainingStart.TabIndex = 4;
            this.TrainingStart.Text = "Start";
            this.TrainingStart.TextColor = System.Drawing.Color.White;
            this.TrainingStart.UseVisualStyleBackColor = true;
            this.TrainingStart.Click += new System.EventHandler(this.TrainingStart_Click);
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.Turquoise;
            this.ScoreButton.BackgroundColor = System.Drawing.Color.Turquoise;
            this.ScoreButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ScoreButton.BorderRadius = 5;
            this.ScoreButton.BorderSize = 0;
            this.ScoreButton.Enabled = false;
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreButton.ForeColor = System.Drawing.Color.White;
            this.ScoreButton.Location = new System.Drawing.Point(628, 195);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(128, 75);
            this.ScoreButton.TabIndex = 0;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ScoreButton.TextColor = System.Drawing.Color.White;
            this.ScoreButton.UseVisualStyleBackColor = false;
            this.ScoreButton.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Turquoise;
            this.StopButton.BackgroundColor = System.Drawing.Color.Turquoise;
            this.StopButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StopButton.BorderRadius = 10;
            this.StopButton.BorderSize = 0;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Raleway ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopButton.ForeColor = System.Drawing.Color.White;
            this.StopButton.Location = new System.Drawing.Point(320, 393);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(130, 45);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.TextColor = System.Drawing.Color.White;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Turquoise;
            this.nextBtn.BackgroundColor = System.Drawing.Color.Turquoise;
            this.nextBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextBtn.BorderRadius = 10;
            this.nextBtn.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Raleway ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(320, 341);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(130, 46);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.TextColor = System.Drawing.Color.White;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.TrainingStart);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.categoriesBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TrainingForm";
            this.Text = "TrainingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

	}

    #endregion

    private ComboBox categoriesBox;
    private Panel TaskPanel;
    private Button answBtnRight;
    private Panel AnswerPanel;
    private Button answBtnLeft;
    private Panel QuestionPanel;
    private CustomButton TrainingStart;
    private CustomButton StopButton;
    private CustomButton nextBtn;
    private CustomButton ScoreButton;
}