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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "123",
            "12341",
            "123516",
            "213129121"});
            this.comboBox1.Location = new System.Drawing.Point(185, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(386, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(309, 316);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(94, 29);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "button1";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // tstBtn2
            // 
            this.tstBtn2.Location = new System.Drawing.Point(511, 304);
            this.tstBtn2.Name = "tstBtn2";
            this.tstBtn2.Size = new System.Drawing.Size(94, 29);
            this.tstBtn2.TabIndex = 2;
            this.tstBtn2.Text = "button1";
            this.tstBtn2.UseVisualStyleBackColor = true;
            this.tstBtn2.Click += new System.EventHandler(this.tstBtn2_Click);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tstBtn2);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "TrainingForm";
            this.Text = "TrainingForm";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.ResumeLayout(false);

	}

    #endregion

    private ComboBox comboBox1;
    private Button testBtn;
    private Button tstBtn2;
}