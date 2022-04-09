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
            this.TrainingStart = new System.Windows.Forms.Button();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
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
            this.TrainingStart.Location = new System.Drawing.Point(338, 341);
            this.TrainingStart.Name = "TrainingStart";
            this.TrainingStart.Size = new System.Drawing.Size(94, 29);
            this.TrainingStart.TabIndex = 4;
            this.TrainingStart.Text = "Start";
            this.TrainingStart.UseVisualStyleBackColor = true;
            this.TrainingStart.Click += new System.EventHandler(this.TrainingStart_Click);
            // 
            // ScoreButton
            // 
            this.ScoreButton.Enabled = false;
            this.ScoreButton.Location = new System.Drawing.Point(660, 209);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(94, 29);
            this.ScoreButton.TabIndex = 0;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(338, 376);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    private Button TrainingStart;
    private Button ScoreButton;
    private Button StopButton;
}