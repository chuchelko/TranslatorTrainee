namespace TranslatorTrainee.Forms;

public partial class TrainingForm : Form
{
	private Data.CategoryLoader cloader = new("../Jsons/data1.json");
	public TrainingForm()
	{
		InitializeComponent();
	}

	public void startRecordingButton_Click(object sender, EventArgs e)
	{
		 
	}

	private void TrainingForm_Load(object sender, EventArgs e)
	{

	}

    private void testBtn_Click(object sender, EventArgs e)
    {

    }

    private void tstBtn2_Click(object sender, EventArgs e)
    {

    }
}