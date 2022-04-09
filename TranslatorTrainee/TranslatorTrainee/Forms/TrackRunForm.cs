﻿using NAudio.Wave;
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
//using VisioForge.Shared.NAudio.Wave;

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
        if(timer.Enabled == false)
        {
            progress = new Progress<string>(s => timerLabel.Text = s);
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            button.Visible = false;
            timerLabel.Text = "3";
        }
    }

    TimeOnly time = new TimeOnly();
    IProgress<string> progress;
    WaveFileReader soundPlayer;
    WaveOut waveOut;
    TimeOnly duration;
    System.Timers.Timer soundDurationTimer = new(1000);
    SpeechToText speechToText = new SpeechToText();
    
    private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        progress.Report((3-time.Second).ToString());
        if(time.Second == 3)
        {
            progress.Report("");
            soundPlayer = new WaveFileReader(Directory.GetFiles(path, "*.wav")[0]);
            duration = new TimeOnly(soundPlayer.TotalTime.Hours, soundPlayer.TotalTime.Minutes, soundPlayer.TotalTime.Seconds);
            waveOut = new WaveOut();
            waveOut.Init(soundPlayer);
            waveOut.Play();
            time = new TimeOnly();
            soundDurationTimer.Elapsed += SoundDurationTimer_Elapsed;
            soundDurationTimer.Start();
            speechToText.StartRecordingAudio(this);
            timer.Elapsed -= Timer_Elapsed;
            timer.Stop();
        }
        time = time.Add(new TimeSpan(0, 0, 1));
    }

    private void SoundDurationTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        timeLabel.Invoke(delegate () { timeLabel.Visible = true; });
        timeLabel.Invoke(delegate () { timeLabel.Text = $"{time.Minute}:{time.Second}/{duration.Minute}:{duration.Second}"; });
        if(time.Second == 5)
        {
            speechToText.StopRecordingAudio();
            label1.Invoke(delegate () { label1.Text = speechToText.GetTextFromSpeech(); });
        }
        time = time.Add(new TimeSpan(0, 0, 1));

    }

    private void TrackRunForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        soundDurationTimer.Stop();
        if(waveOut != null)
        {
            waveOut.Stop();
            waveOut.Dispose();
        }
        if(soundPlayer != null)
        {
            soundPlayer.Close();
            soundPlayer.Dispose();

        }
    }
}
