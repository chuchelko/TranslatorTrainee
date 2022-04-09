using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TranslatorTrainee.Data;

namespace TranslatorTrainee.Forms;
public partial class SpeakingForm : Form
{
    List<TrackInfo> trackInfos = new List<TrackInfo>();
    public SpeakingForm()
    {
        InitializeComponent();
        Text = "Speaking";
        listView.View = View.Tile;
        listView.LabelEdit = false;
        listView.GridLines = true;
        listView.ShowItemToolTips = true;
        listView.Items.Clear();
        string[] filesWithInfo = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Tracks");
        foreach(string path in filesWithInfo)
        {
            string directory = Directory.GetFiles(path, "*Information.txt")[0];
            string information = File.ReadAllText(directory);
            string name = information.Substring(information.IndexOf(' '), information.IndexOf('\n')-10);
            string time = information.Split('\n')[3].Split(' ')[1];
            trackInfos.Add(new TrackInfo() { Label = name, Tooltip = information, Time = time, Path = path });
            RefreshListView(trackInfos);
        }
    }

    private void listView_SelectedIndexChanged(object sender, EventArgs e)
    {
         
    }

    private void RefreshListView(List<TrackInfo> infos)
    {
        listView.Items.Clear();
        foreach (var info in infos)
        {
            var item = listView.Items.Add(info.Label + " (" + info.Time + ')');
            item.Tag = info.Path;
            item.ToolTipText = info.Tooltip;
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string text = (sender as TextBox)!.Text;
        if(text == "")
        {
            RefreshListView(trackInfos);
        }
        else
        {
            List<TrackInfo> resultInfos = new List<TrackInfo>();
            foreach(var info in trackInfos)
            {
                if (info.Label.ToLower().Contains(text.ToLower()))
                    resultInfos.Add(info);
            }
            RefreshListView(resultInfos);
        }
    }

    private void listView_MouseClick(object sender, MouseEventArgs e)
    {
        
    }

    private void listView_DoubleClick(object sender, EventArgs e)
    {
    }

    private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if(listView.SelectedItems.Count > 0 && e.Button == MouseButtons.Left)
        {
            var item = listView.SelectedItems[0];
            if(item.Bounds.Contains(e.Location))
            {
                TrackRunForm form = new TrackRunForm() { path = item.Tag.ToString(), name = item.Text };
                form.ShowDialog();
            }
        }
    }
}
