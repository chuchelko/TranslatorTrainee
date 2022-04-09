using TranslatorTrainee.Data;
using static TranslatorTrainee.Data.TaskPanelsPainter;

namespace TranslatorTrainee.Forms;

public partial class TrainingForm : Form
{
	public event EventHandler QuestionChanged;
	public event EventHandler AnswerChanged;

	private int qstCh;
	public int QuestionChoice
	{
		get { return Math.Abs(qstCh); }
		set
		{
			qstCh = value;
			QuestionChanged?.Invoke(QuestionChoice, EventArgs.Empty);
		}
	}

	private int ansCh;

	private SpeechToText speechToText = new();
	
	public int AnswerChoice
	{
		get { return Math.Abs(ansCh); }
		set
		{
			ansCh = value;
			ansCh %= 2; 
			AnswerChanged?.Invoke(AnswerChoice, EventArgs.Empty);
		}
	}

	private CategoryLoader cloader;
	private TaskPanelsPainter painter;
	private TaskPanelConstructor TPC;

	public TrainingForm()
	{
		InitializeComponent();
	}

	private async void TrainingForm_Load(object sender, EventArgs e)
	{
		cloader = new Data.CategoryLoader(Directory.GetCurrentDirectory() + "\\json\\data1.json");

		try
		{
			await cloader.LoadCategoriesAsync();
		}catch (Exception ex) { }

		categoriesBox.Items.Clear();
		categoriesBox.Items.AddRange(cloader._categories?.ToArray());
		categoriesBox.SelectedIndex = 0;

		painter = new Data.TaskPanelsPainter(QuestionPanel.CreateGraphics(), AnswerPanel.CreateGraphics());
		//QuestionChanged += painter.QuestionHandler;
		painter.QuestionHandler();
		AnswerChanged += painter.AnswerHandler;
	}

	private void testBtn_Click(object sender, EventArgs e)
	{
		speechToText.StartRecordingAudio();
	}

	private void tstBtn2_Click(object sender, EventArgs e)
	{
		speechToText.StopRecordingAudio();
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

	}

	private void answBtnLeft_Click(object sender, EventArgs e)
	{
		AnswerChoice -= 1;
	}


	#endregion

	private void TrainingStart_Click(object sender, EventArgs e)
	{
		answBtnLeft.Enabled = answBtnLeft.Visible = false;
		answBtnRight.Enabled = answBtnRight.Visible = false;

		TPC = new Data.TaskPanelConstructor((QuestionPeek)QuestionChoice, (AnswerPeek)AnswerChoice, QuestionPanel, AnswerPanel, cloader?._categories[categoriesBox.SelectedIndex]);

		ScoreButton.Visible = true;
		ScoreButton.Text = $"{TaskPanelConstructor.score}";

		TaskPanel.Controls.Remove(QuestionPanel);
		QuestionPanel = TPC.QuestionPanelCreate();
		TaskPanel.Controls.Add(QuestionPanel);
		
		TaskPanel.Controls.Remove(AnswerPanel);
		AnswerPanel = TPC.BlitzAnswerPanelCreate();
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
		TPC.textBox?.Dispose();

		ScoreButton.Text = $"{TaskPanelConstructor.score}";

		TaskPanel.Refresh();
	}
}