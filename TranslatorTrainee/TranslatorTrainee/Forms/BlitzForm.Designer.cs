namespace TranslatorTrainee.Forms
{
    partial class BlitzForm
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
            this.components = new System.ComponentModel.Container();
            this.categoriesBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.startstopBtn = new System.Windows.Forms.Button();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.Location = new System.Drawing.Point(236, 30);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(328, 28);
            this.categoriesBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnswerPanel);
            this.panel1.Controls.Add(this.QuestionPanel);
            this.panel1.Location = new System.Drawing.Point(236, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 263);
            this.panel1.TabIndex = 1;
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.Location = new System.Drawing.Point(3, 134);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(322, 126);
            this.AnswerPanel.TabIndex = 1;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Location = new System.Drawing.Point(3, 3);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(322, 126);
            this.QuestionPanel.TabIndex = 0;
            // 
            // startstopBtn
            // 
            this.startstopBtn.Location = new System.Drawing.Point(290, 366);
            this.startstopBtn.Name = "startstopBtn";
            this.startstopBtn.Size = new System.Drawing.Size(217, 72);
            this.startstopBtn.TabIndex = 2;
            this.startstopBtn.Text = "Start!";
            this.startstopBtn.UseVisualStyleBackColor = true;
            this.startstopBtn.Click += new System.EventHandler(this.startstopBtn_Click);
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(628, 140);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(118, 42);
            this.scoreBtn.TabIndex = 3;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(628, 281);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(118, 27);
            this.timeTextBox.TabIndex = 4;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeTextBox.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5 c.",
            "10 с.",
            "15 с.",
            "20 с.",
            "25 с.",
            "30 с."});
            this.comboBox1.Location = new System.Drawing.Point(614, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // BlitzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.startstopBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.categoriesBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "BlitzForm";
            this.Text = "BlitzForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlitzForm_FormClosing);
            this.Load += new System.EventHandler(this.BlitzForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox categoriesBox;
        private Panel panel1;
        private Panel AnswerPanel;
        private Panel QuestionPanel;
        private Button startstopBtn;
        private Button scoreBtn;
        private System.Windows.Forms.Timer timer1;
        private TextBox timeTextBox;
        private ComboBox comboBox1;
    }
}