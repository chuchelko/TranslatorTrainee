using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslatorTrainee.Forms
{
    public partial class BlitzForm : Form
    {
        private Data.TaskPanelsPainter painter;
        private Data.CategoryLoader cloader;
        private Data.TaskPanelConstructor TPC;

        private float timeLeft;
        private int score;

        public BlitzForm()
        {
            InitializeComponent();
        }

        private async void BlitzForm_Load(object sender, EventArgs e)
        {
            cloader = new Data.CategoryLoader(Directory.GetCurrentDirectory() + "\\json\\data1.json");

            try
            {
                await cloader.LoadCategoriesAsync();
            } catch(Exception ex) { }

            categoriesBox.Items.Clear();
            categoriesBox.Items.AddRange(cloader._categories?.ToArray());
            categoriesBox.SelectedIndex = 0;

            painter = new Data.TaskPanelsPainter(QuestionPanel.CreateGraphics(), AnswerPanel.CreateGraphics());
            painter.QuestionHandler();
            painter.AnswerHandler(0, EventArgs.Empty);

            scoreBtn.Visible = false;

            timeLeft = 30F;
        }

        private async void BlitzForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await cloader.WriteCategoriesAsync();
        }

        private void startstopBtn_Click(object sender, EventArgs e)
        {
            TPC = new Data.TaskPanelConstructor(QuestionPanel, AnswerPanel, cloader?._categories[categoriesBox.SelectedIndex]);
            TPC.AnswBtnClick += TPC_AnswBtnClick;
            scoreBtn.Visible = true;
            scoreBtn.Text = 0.ToString();
            timeTextBox.Visible = true;
            timer1.Start();

            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Remove(QuestionPanel);
            QuestionPanel = TPC.BlitzQuestionPanelCreate();
            panel1.Controls.Add(QuestionPanel);

            panel1.Controls.Remove(AnswerPanel);
            AnswerPanel = TPC.BlitzAnswerPanelCreate();
            panel1.Controls.Add(AnswerPanel);
        }

        private void TPC_AnswBtnClick(object? sender, EventArgs e)
        {
            var btn = sender as Button;
            var answ = btn.Text;
            if(answ.ToLower() == TPC.question.RightAnswer.ToLower())
            {
                score += 1;
            }

            scoreBtn.Text = score.ToString();

            TPC.QuestionRefresh();
            panel1.Controls.Remove(QuestionPanel);
            QuestionPanel = TPC.BlitzQuestionPanelCreate();
            panel1.Controls.Add(QuestionPanel);

            panel1.Controls.Remove(AnswerPanel);
            AnswerPanel = TPC.BlitzAnswerPanelCreate();
            panel1.Controls.Add(AnswerPanel);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 0.1F;
            timeTextBox.Text = Math.Round(timeLeft, 4).ToString() + "с.";
        }
    }
}
