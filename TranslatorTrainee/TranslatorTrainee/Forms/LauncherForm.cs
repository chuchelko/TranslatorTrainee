using TranslatorTrainee.Data;
using TranslatorTrainee.Forms;

namespace TranslatorTrainee;

public partial class LauncherForm : Form
{
    private Bitmap bmp;
    private Graphics g;
    private SVGParser svgparser;
    public LauncherForm()
    {
        InitializeComponent();
        DoubleBuffered = true;
        //FormBorderStyle = FormBorderStyle.None;
    }


    private void button1_Click(object sender, EventArgs e)
    {
        BlitzForm form = new BlitzForm();
        form.ShowDialog();
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        g.FillEllipse(new SolidBrush(Color.Turquoise),
            blitzBtn.Location.X + 13,
            blitzBtn.Location.Y - 180,
            50,
            150);
        g.DrawImage(bmp, 
            new Point(blitzBtn.Location.X - 20, blitzBtn.Location.Y - 200));
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

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
    }

    private void LauncherForm_Load(object sender, EventArgs e)
    {
        svgparser = new Data.SVGParser(
            new Size(blitzBtn.Size.Width, 200));
        bmp = svgparser.GetBitmapFromSVG("Logo");
        g = panel1.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
    }
}