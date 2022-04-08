﻿namespace TranslatorTrainee;

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
            this.blitzBtn = new System.Windows.Forms.Button();
            this.speakingBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
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
            // 
            // blitzBtn
            // 
            this.blitzBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blitzBtn.Location = new System.Drawing.Point(233, 218);
            this.blitzBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.blitzBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.blitzBtn.Name = "blitzBtn";
            this.blitzBtn.Size = new System.Drawing.Size(346, 62);
            this.blitzBtn.TabIndex = 0;
            this.blitzBtn.Text = "Блиц";
            this.blitzBtn.UseVisualStyleBackColor = true;
            this.blitzBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // speakingBtn
            // 
            this.speakingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speakingBtn.Location = new System.Drawing.Point(234, 302);
            this.speakingBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.speakingBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.speakingBtn.Name = "speakingBtn";
            this.speakingBtn.Size = new System.Drawing.Size(346, 62);
            this.speakingBtn.TabIndex = 1;
            this.speakingBtn.Text = "Готовый текст";
            this.speakingBtn.UseVisualStyleBackColor = true;
            this.speakingBtn.Click += new System.EventHandler(this.speakingBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainBtn.Location = new System.Drawing.Point(234, 386);
            this.trainBtn.MaximumSize = new System.Drawing.Size(346, 62);
            this.trainBtn.MinimumSize = new System.Drawing.Size(346, 62);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(346, 62);
            this.trainBtn.TabIndex = 2;
            this.trainBtn.Text = "Тренировка";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TranslatorTrainee.Properties.Resources.LauncherBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.trainBtn);
            this.panel1.Controls.Add(this.speakingBtn);
            this.panel1.Controls.Add(this.blitzBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
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
            this.Name = "LauncherForm";
            this.Text = "Launcher";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panel2;
    private LinkLabel linkLabel2;
    private LinkLabel linkLabel1;
    private Button blitzBtn;
    private Button speakingBtn;
    private Button trainBtn;
    private Panel panel1;
}