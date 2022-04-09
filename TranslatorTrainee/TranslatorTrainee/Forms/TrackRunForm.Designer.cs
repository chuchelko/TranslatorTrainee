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
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(366, 283);
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
            this.timerLabel.Location = new System.Drawing.Point(366, 186);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 41);
            this.timerLabel.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(384, 260);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.button);
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
    private Label timeLabel;
}
