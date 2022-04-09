using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorTrainee.Forms;
public partial class TrackRunForm : Form
{
    public string path;
    public string name;
    private bool playing = false;
    System.Timers.Timer timer = new System.Timers.Timer();
    public TrackRunForm()
    {
        InitializeComponent();
    }

    private void TrackRunForm_Load(object sender, EventArgs e)
    {

        this.Text = name;
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (playing)
            button.Text = "Stop";
        else
            button.Text = "Start";
        playing = !playing;
        if(timer.Enabled == false)
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            button.Visible = false;
            timerLabel.Text = "3";
        }
    }

    int seconds = 0;
    private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        timerLabel.Text = (3 - seconds).ToString();
        if(seconds == 3)
        {
            timerLabel.Dispose();
            button.Visible = true;
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = path;
            soundPlayer.Play();
        }
        seconds += 1;
    }
}
