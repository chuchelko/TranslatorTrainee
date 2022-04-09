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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.tstBtn2 = new System.Windows.Forms.Button();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.answBtnRight = new System.Windows.Forms.Button();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.answBtnLeft = new System.Windows.Forms.Button();
            this.qstnBtnRight = new System.Windows.Forms.Button();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.qstnBtnLeft = new System.Windows.Forms.Button();
            this.TrainingStart = new System.Windows.Forms.Button();
            this.TaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(386, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(241, 409);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(94, 29);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "button1";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // tstBtn2
            // 
            this.tstBtn2.Location = new System.Drawing.Point(444, 409);
            this.tstBtn2.Name = "tstBtn2";
            this.tstBtn2.Size = new System.Drawing.Size(94, 29);
            this.tstBtn2.TabIndex = 2;
            this.tstBtn2.Text = "button1";
            this.tstBtn2.UseVisualStyleBackColor = true;
            this.tstBtn2.Click += new System.EventHandler(this.tstBtn2_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.Controls.Add(this.answBtnRight);
            this.TaskPanel.Controls.Add(this.AnswerPanel);
            this.TaskPanel.Controls.Add(this.answBtnLeft);
            this.TaskPanel.Controls.Add(this.qstnBtnRight);
            this.TaskPanel.Controls.Add(this.QuestionPanel);
            this.TaskPanel.Controls.Add(this.qstnBtnLeft);
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
            this.AnswerPanel.BackColor = System.Drawing.Color.White;
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
            // qstnBtnRight
            // 
            this.qstnBtnRight.Location = new System.Drawing.Point(359, 3);
            this.qstnBtnRight.Name = "qstnBtnRight";
            this.qstnBtnRight.Size = new System.Drawing.Size(23, 88);
            this.qstnBtnRight.TabIndex = 2;
            this.qstnBtnRight.Text = ">";
            this.qstnBtnRight.UseVisualStyleBackColor = true;
            this.qstnBtnRight.Click += new System.EventHandler(this.qstnBtnRight_Click);
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.Color.White;
            this.QuestionPanel.Location = new System.Drawing.Point(32, 3);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(321, 88);
            this.QuestionPanel.TabIndex = 1;
            // 
            // qstnBtnLeft
            // 
            this.qstnBtnLeft.Location = new System.Drawing.Point(3, 3);
            this.qstnBtnLeft.Name = "qstnBtnLeft";
            this.qstnBtnLeft.Size = new System.Drawing.Size(23, 88);
            this.qstnBtnLeft.TabIndex = 0;
            this.qstnBtnLeft.Text = "<";
            this.qstnBtnLeft.UseVisualStyleBackColor = true;
            this.qstnBtnLeft.Click += new System.EventHandler(this.qstnBtnLeft_Click);
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
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrainingStart);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.tstBtn2);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "TrainingForm";
            this.Text = "TrainingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainingForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.TaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

	}

    #endregion

    private ComboBox comboBox1;
    private Button testBtn;
    private Button tstBtn2;
    private Panel TaskPanel;
    private Button answBtnRight;
    private Panel AnswerPanel;
    private Button answBtnLeft;
    private Button qstnBtnRight;
    private Panel QuestionPanel;
    private Button qstnBtnLeft;
    private Button TrainingStart;
}