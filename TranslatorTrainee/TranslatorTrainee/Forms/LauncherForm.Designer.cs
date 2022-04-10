namespace TranslatorTrainee;

partial class LauncherForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.blitzBtn = new TranslatorTrainee.CustomButton();
            this.speakingBtn = new TranslatorTrainee.CustomButton();
            this.trainBtn = new TranslatorTrainee.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(232, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 260);
            this.panel2.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(252, 233);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 20);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Регистрация";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 233);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вход";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // blitzBtn
            // 
            this.blitzBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blitzBtn.BackColor = System.Drawing.Color.Turquoise;
            this.blitzBtn.BackgroundColor = System.Drawing.Color.Turquoise;
            this.blitzBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.blitzBtn.BorderRadius = 20;
            this.blitzBtn.BorderSize = 0;
            this.blitzBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blitzBtn.Font = new System.Drawing.Font("Raleway ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blitzBtn.ForeColor = System.Drawing.Color.White;
            this.blitzBtn.Location = new System.Drawing.Point(233, 218);
            this.blitzBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.blitzBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.blitzBtn.Name = "blitzBtn";
            this.blitzBtn.Size = new System.Drawing.Size(346, 62);
            this.blitzBtn.TabIndex = 0;
            this.blitzBtn.Text = "Блиц";
            this.blitzBtn.TextColor = System.Drawing.Color.White;
            this.blitzBtn.UseVisualStyleBackColor = false;
            this.blitzBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // speakingBtn
            // 
            this.speakingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speakingBtn.BackColor = System.Drawing.Color.Turquoise;
            this.speakingBtn.BackgroundColor = System.Drawing.Color.Turquoise;
            this.speakingBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.speakingBtn.BorderRadius = 20;
            this.speakingBtn.BorderSize = 0;
            this.speakingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakingBtn.Font = new System.Drawing.Font("Raleway ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speakingBtn.ForeColor = System.Drawing.Color.White;
            this.speakingBtn.Location = new System.Drawing.Point(234, 302);
            this.speakingBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.speakingBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.speakingBtn.Name = "speakingBtn";
            this.speakingBtn.Size = new System.Drawing.Size(346, 62);
            this.speakingBtn.TabIndex = 1;
            this.speakingBtn.Text = "Готовый текст";
            this.speakingBtn.TextColor = System.Drawing.Color.White;
            this.speakingBtn.UseVisualStyleBackColor = false;
            this.speakingBtn.Click += new System.EventHandler(this.speakingBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainBtn.BackColor = System.Drawing.Color.Turquoise;
            this.trainBtn.BackgroundColor = System.Drawing.Color.Turquoise;
            this.trainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.trainBtn.BorderRadius = 20;
            this.trainBtn.BorderSize = 0;
            this.trainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainBtn.Font = new System.Drawing.Font("Raleway ExtraBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trainBtn.ForeColor = System.Drawing.Color.White;
            this.trainBtn.Location = new System.Drawing.Point(234, 386);
            this.trainBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.trainBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(346, 62);
            this.trainBtn.TabIndex = 2;
            this.trainBtn.Text = "Тренировка";
            this.trainBtn.TextColor = System.Drawing.Color.White;
            this.trainBtn.UseVisualStyleBackColor = false;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.trainBtn);
            this.panel1.Controls.Add(this.speakingBtn);
            this.panel1.Controls.Add(this.blitzBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(812, 518);
            this.panel1.MinimumSize = new System.Drawing.Size(812, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 518);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 565);
            this.MinimumSize = new System.Drawing.Size(830, 565);
            this.Name = "LauncherForm";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel2;
    private LinkLabel linkLabel2;
    private LinkLabel linkLabel1;
    private CustomButton blitzBtn;
    private CustomButton speakingBtn;
    private CustomButton trainBtn;
    private Panel panel1;
}
