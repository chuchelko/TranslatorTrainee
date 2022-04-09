using TranslatorTrainee.Forms;

namespace TranslatorTrainee;

public partial class LauncherForm : Form
{
    public LauncherForm()
    {
        InitializeComponent();
        DoubleBuffered = true;
        //FormBorderStyle = FormBorderStyle.None;
    }


    private void button1_Click(object sender, EventArgs e)
    {
        // Вызов формы с блицом
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void speakingBtn_Click(object sender, EventArgs e)
    {
        SpeakingForm form  = new SpeakingForm();
        form.ShowDialog();
    }

    private void trainBtn_Click(object sender, EventArgs e)
    {
        //Вызов формы с тренировками
        Forms.TrainingForm trainingForm = new Forms.TrainingForm();
        trainingForm.ShowDialog();

    }
}