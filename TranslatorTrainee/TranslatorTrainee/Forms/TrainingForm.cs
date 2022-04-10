using System.Text;
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

    private int score;
    private int qCount;
    private TextBox textBox;

    public TrainingForm()
    {
        InitializeComponent();
    }

    private async void TrainingForm_Load(object sender, EventArgs e)
    {
        textBox?.Dispose();
        score = qCount =0;


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
        AnswerChanged.Invoke(0, EventArgs.Empty) ;
    }

    private void testBtn_Click(object sender, EventArgs e)
    {
        //speechToText.StartRecordingAudio();
    }

    private void tstBtn2_Click(object sender, EventArgs e)
    {
        //speechToText.StopRecordingAudio();
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
        TPC.AnswBtnClick += TPC_AnswBtnClick;
        TPC.TextBoxEnter += TPC_TextBoxEnter;

        categoriesBox.Enabled = false;
        ScoreButton.Visible = true;
        ScoreButton.Text = $"{score}";

        textBox?.Dispose();

        TaskPanel.Controls.Remove(QuestionPanel);
        QuestionPanel = TPC.QuestionPanelCreate();
        TaskPanel.Controls.Add(QuestionPanel);
        
        TaskPanel.Controls.Remove(AnswerPanel);
        AnswerPanel = TPC.AnswerPanelCreate();
        TaskPanel.Controls.Add(AnswerPanel);
        TaskPanel.Refresh();

        TaskPanel.BackColor = Color.PaleTurquoise;
        StopButton.Visible = true;
        StopButton.Enabled = true;
        TrainingStart.Visible = false;
        nextBtn.Visible = true;
    }

    private void TPC_TextBoxEnter(object? sender, EventArgs e)
    {
        var tb = sender as TextBox;
        score += 1;
        qCount += 1;
        ScoreButton.Text = score.ToString();
        RefreshTaskPanel();

        tb.Dispose();
    }

    private void RefreshTaskPanel()
    {
        TPC.QuestionRefresh();
        TaskPanel.Controls.Remove(QuestionPanel);
        QuestionPanel = TPC.QuestionPanelCreate();
        TaskPanel.Controls.Add(QuestionPanel);

        TaskPanel.Controls.Remove(AnswerPanel);
        AnswerPanel = TPC.AnswerPanelCreate();
        TaskPanel.Controls.Add(AnswerPanel);

        qCount += 1;
    }

    private void TPC_AnswBtnClick(object? sender, EventArgs e)
    {
        var btn = sender as Button;
        var answ = btn.Text;
        if (answ.ToLower() == TPC.question.RightAnswer.ToLower())
        {
            score += 1;
        }

        qCount += 1;

        ScoreButton.Text = score.ToString();

        RefreshTaskPanel();
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        ScoreButton.Visible = false;
        TPC.textBox?.Dispose();

        categoriesBox.Enabled = true;


        textBox = new TextBox();
        textBox.Size = new Size(TaskPanel.Width / 2 + 20, TaskPanel.Height / 2 + 20);
        textBox.Location = new Point(0 + TaskPanel.Width / 4, 0 + TaskPanel.Height / 4); ;
        textBox.Multiline = true;
        textBox.ReadOnly = true;
        textBox.TextAlign = HorizontalAlignment.Center;

        var text = new StringBuilder();
        text.Append("Количество вопросов \r\n" + qCount + "\r\nКоличество правильных ответов \r\n"
            + score);
        textBox.Text = text.ToString();

        TaskPanel.Controls.Remove(QuestionPanel);
        TaskPanel.Controls.Remove(AnswerPanel);
        TaskPanel.Controls.Add(textBox);

        StopButton.Enabled = false;
        StopButton.Visible = false;
        nextBtn.Visible = false;
        TrainingStart.Visible = true;
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
        RefreshTaskPanel();
        
    }

    private void swthBtn_Click(object sender, EventArgs e)
    {
        TrainingForm_Load(null, EventArgs.Empty);
    }
}