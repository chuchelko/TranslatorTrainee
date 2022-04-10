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
        private TextBox textBox;

        private float timeLeft;
        private int qCount;
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

            comboBox1.SelectedIndex = 2;

            painter = new Data.TaskPanelsPainter(QuestionPanel.CreateGraphics(), AnswerPanel.CreateGraphics());
            painter.QuestionHandler();
            painter.AnswerHandler(0, EventArgs.Empty);

            scoreBtn.Visible = false;
        }

        private async void BlitzForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await cloader.WriteCategoriesAsync();
        }

        private void startstopBtn_Click(object sender, EventArgs e)
        {
            startstopBtn.Visible = false;

            TPC = new Data.TaskPanelConstructor(QuestionPanel, AnswerPanel, cloader?._categories[categoriesBox.SelectedIndex]);
            TPC.AnswBtnClick += TPC_AnswBtnClick;

            if (textBox is not null) textBox.Visible = false;

            scoreBtn.Visible = true;
            scoreBtn.Text = 0.ToString();

            timeTextBox.Visible = true;
            var time = comboBox1.SelectedItem.ToString();
            var split = time?.Split(" ");

            float.TryParse(split[0], out timeLeft);
            comboBox1.Visible = false;
            timer1.Start();
            timeTextBox.Text = timeLeft.ToString() + "c.";

            panel1.BackColor = Color.PaleTurquoise;
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

            qCount += 1;

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
            timeLeft -= 1F;
            timeTextBox.Text = Math.Round(timeLeft, 4).ToString() + "с.";

            if(timeLeft == 0)
            {
                timer1.Stop();
                TPC.AnswBtnClick -= TPC_AnswBtnClick;

                textBox = new TextBox();
                textBox.Size = new Size(panel1.Width / 2, panel1.Height / 2);
                textBox.Location = new Point(0 + panel1.Width / 4, 0 + panel1.Height /4 ); ;
                textBox.Multiline = true;
                textBox.ReadOnly = true;
                textBox.TextAlign = HorizontalAlignment.Center;

                var text = new StringBuilder();
                text.Append("Количество вопросов \r\n" + qCount + "\r\nКоличество правильных ответов \r\n"
                    + score);
                textBox.Text = text.ToString();

                panel1.Controls.Remove(QuestionPanel);
                panel1.Controls.Remove(AnswerPanel);
                panel1.Controls.Add(textBox);

                startstopBtn.Visible = true;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
