namespace TranslatorTrainee.Forms;

partial class TrackRunForm
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
            this.button = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.recordedTextBox = new System.Windows.Forms.TextBox();
            this.translationTextBox = new System.Windows.Forms.TextBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(366, 368);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(89, 79);
            this.button.TabIndex = 0;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timerLabel.Location = new System.Drawing.Point(408, 328);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 41);
            this.timerLabel.TabIndex = 1;
            // 
            // recordedTextBox
            // 
            this.recordedTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.recordedTextBox.Location = new System.Drawing.Point(12, 12);
            this.recordedTextBox.Multiline = true;
            this.recordedTextBox.Name = "recordedTextBox";
            this.recordedTextBox.ReadOnly = true;
            this.recordedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recordedTextBox.Size = new System.Drawing.Size(241, 309);
            this.recordedTextBox.TabIndex = 4;
            // 
            // translationTextBox
            // 
            this.translationTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.translationTextBox.Location = new System.Drawing.Point(278, 12);
            this.translationTextBox.Multiline = true;
            this.translationTextBox.Name = "translationTextBox";
            this.translationTextBox.ReadOnly = true;
            this.translationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translationTextBox.Size = new System.Drawing.Size(241, 309);
            this.translationTextBox.TabIndex = 5;
            // 
            // originalTextBox
            // 
            this.originalTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.originalTextBox.Location = new System.Drawing.Point(547, 12);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalTextBox.Size = new System.Drawing.Size(241, 309);
            this.originalTextBox.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(384, 345);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(50, 20);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "label1";
            this.timeLabel.Visible = false;
            // 
            // TrackRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.translationTextBox);
            this.Controls.Add(this.recordedTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TrackRunForm";
            this.Text = "TrackRunForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrackRunForm_FormClosed);
            this.Load += new System.EventHandler(this.TrackRunForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button button;
    private Label timerLabel;
    private TextBox recordedTextBox;
    private TextBox translationTextBox;
    private TextBox originalTextBox;
    private Label timeLabel;
}
