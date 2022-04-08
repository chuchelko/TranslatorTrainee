using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorTrainee.Forms;
public partial class SpeakingForm : Form
{
    public SpeakingForm()
    {
        InitializeComponent();
        listView.View = View.Tile;
        listView.LabelEdit = false;
        listView.GridLines = true;
        listView.Items[1]
    }

    private void listView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
