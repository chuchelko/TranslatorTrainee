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
	private int qstnChoice = 0;
	private Data.TaskPanelsPainter painter;
	public TrainingForm()
	{
		InitializeComponent();
	}

	public void startRecordingButton_Click(object sender, EventArgs e)
	{
		 
	}

	private async void TrainingForm_Load(object sender, EventArgs e)
	{
		cloader = new Data.CategoryLoader("../../../Jsons/data1.json");

		try
		{
			await cloader.LoadCategoriesAsync();
		}catch (Exception ex) { }

		comboBox1.Items.Clear();
		comboBox1.Items.AddRange(cloader._categories?.ToArray());

		painter = new Data.TaskPanelsPainter(QuestionPanel.CreateGraphics(), AnswerPanel.CreateGraphics());
		QuestionChanged += painter.QuestionHandler;
		AnswerChanged += painter.AnswerHandler;
	}

	private void testBtn_Click(object sender, EventArgs e)
	{

	}

	private void tstBtn2_Click(object sender, EventArgs e)
	{

	}

	private async void TrainingForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		await cloader.LoadCategoriesAsync();
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

	}
}