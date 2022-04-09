﻿using TranslatorTrainee.Data;
using static TranslatorTrainee.Data.TaskPanelsPainter;

namespace TranslatorTrainee.Forms;

public partial class TrainingForm : Form
{
	public event EventHandler QuestionChanged;
	public event EventHandler AnswerChanged;

	private Panel origQ, origA;

	private int qstCh;



	public int QuestionChoice
	{
		get { return Math.Abs(qstCh); }
		set
		{
			qstCh = value;
			qstCh %= 2;
			QuestionChanged?.Invoke(QuestionChoice, EventArgs.Empty);
		}
	}

	private int ansCh;
	public int AnswerChoice
	{
		get { return Math.Abs(ansCh); }
		set
		{
			ansCh = value;
			ansCh %= 3; 
			AnswerChanged?.Invoke(AnswerChoice, EventArgs.Empty);
		}
	}

	private Data.CategoryLoader cloader;
	private Data.TaskPanelsPainter painter;
	private Data.TaskPanelConstructor TPC;

	public TrainingForm()
	{
		InitializeComponent();
	}

	public void startRecordingButton_Click(object sender, EventArgs e)
	{
		 
	}

	private async void TrainingForm_Load(object sender, EventArgs e)
	{
		cloader = new Data.CategoryLoader(Directory.GetCurrentDirectory() + "\\json\\data1.json");

		try
		{
			await cloader.LoadCategoriesAsync();
		}catch (Exception ex) { }

		comboBox1.Items.Clear();
		comboBox1.Items.AddRange(cloader._categories?.ToArray());

		painter = new Data.TaskPanelsPainter(QuestionPanel.CreateGraphics(), AnswerPanel.CreateGraphics());
		QuestionChanged += painter.QuestionHandler;
		AnswerChanged += painter.AnswerHandler;

		origQ = QuestionPanel;
		origA = AnswerPanel;
	}

	private void testBtn_Click(object sender, EventArgs e)
	{

	}

	private void tstBtn2_Click(object sender, EventArgs e)
	{

	}

	private async void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		await cloader.WriteCategoriesAsync();
	}

	#region Buttons
	private void qstnBtnRight_Click(object sender, EventArgs e)
	{
		QuestionChoice += 1;
	}

	private void answBtnRight_Click(object sender, EventArgs e)
	{
		AnswerChoice += 1;
	}

	private void qstnBtnLeft_Click(object sender, EventArgs e)
	{
		QuestionChoice -= 1;
	}

	private void answBtnLeft_Click(object sender, EventArgs e)
	{
		AnswerChoice -= 1;
	}


	#endregion

	private void TrainingStart_Click(object sender, EventArgs e)
	{

		qstnBtnLeft.Enabled = qstnBtnLeft.Visible = false;
		qstnBtnRight.Enabled = qstnBtnRight.Visible =false;
		answBtnLeft.Enabled = answBtnLeft.Visible = false;
		answBtnRight.Enabled = answBtnRight.Visible = false;

		TPC = new Data.TaskPanelConstructor((QuestionPeek)QuestionChoice, (AnswerPeek)AnswerChoice, QuestionPanel, AnswerPanel, cloader?._categories[comboBox1.SelectedIndex]);
		TPC.AnswBtnClick += TrainingStart_Click;

		ScoreButton.Text = $"Score: {TaskPanelConstructor.score}";

		TaskPanel.Controls.Remove(QuestionPanel);
		QuestionPanel = TPC.QuestionPanelCreate();
		TaskPanel.Controls.Add(QuestionPanel);
		
		TaskPanel.Controls.Remove(AnswerPanel);
		AnswerPanel = TPC.AnswerPanelCreate();
		TaskPanel.Controls.Add(AnswerPanel);
		TaskPanel.Refresh();

		TaskPanel.BackColor = Color.White;

		TrainingStart.Text = "Next";
		StopButton.Visible = true;
	}

	private void StopButton_Click(object sender, EventArgs e)
	{
		
		TrainingStart.Enabled = false;
		ScoreButton.BackColor = Color.LightSeaGreen;

		TaskPanel.Refresh();
	}
}