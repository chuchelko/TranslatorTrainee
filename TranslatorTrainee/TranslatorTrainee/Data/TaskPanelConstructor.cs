using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    internal class TaskPanelConstructor
    {
        public event EventHandler AnswBtnClick;
        public event EventHandler TextBoxEnter;

        private TaskPanelsPainter.QuestionPeek QP;
        private TaskPanelsPainter.AnswerPeek AP;
        private Panel origQ, origA, thisQ, thisA;
        public Question question;
        private QuestionLoader questionLoader;

        public TextBox textBox;

        public static int score = 0;
        public TaskPanelConstructor(TaskPanelsPainter.QuestionPeek qp, TaskPanelsPainter.AnswerPeek ap, Panel origQ, Panel origA, Category category)
        {
            QP = 0;
            AP = ap;
            this.origQ = origQ;
            this.origA = origA;
            questionLoader = new QuestionLoader(category);
            question = questionLoader.GetRandomQuestion();
        }

        public TaskPanelConstructor(Panel origQ, Panel origA, Category category)
        {
            this.origQ = origQ;
            this.origA = origA;
            questionLoader = new QuestionLoader(category);
            question = questionLoader.GetRandomQuestion();
        }

        public void QuestionRefresh()
        {
            question = questionLoader.GetRandomQuestion();
        }

        public Panel BlitzQuestionPanelCreate()
        {
            var panel = new Panel();
            panel.Name = origQ.Name;
            panel.Size = origQ.Size;
            panel.Location = origQ.Location;

            var label = new Label();
            label.AutoSize = true;
            label.MaximumSize = panel.Size;
            label.Text = question.Text;
            label.Location = new Point(0, panel.Height / 2);
            panel.Controls.Add(label);

            return panel;
        }

        public Panel QuestionPanelCreate()
        {
            var panel = new Panel();
            panel.Name = origQ.Name;
            panel.Size = origQ.Size;
            panel.Location = origQ.Location;

            switch (QP)
            {
                case TaskPanelsPainter.QuestionPeek.TextQuestion:
                    var label = new Label();
                    label.AutoSize = true;
                    label.MaximumSize = panel.Size;
                    label.Text = question.Text;
                    label.Location = new Point(0, panel.Height / 2);
                    panel.Controls.Add(label);
                    break;
            }

            thisQ = panel;

            return panel;
        }

        public Panel BlitzAnswerPanelCreate()
        {
            var panel = new Panel();
            panel.Name = origA.Name;
            panel.Size = origA.Size;
            panel.Location = origA.Location;

            BlitzFillChoicePanelByBtns(ref panel);

            thisA = panel;
            return panel;
        }

        private void BlitzFillChoicePanelByBtns(ref Panel panel)
        {
            //var rightAnswBtn = new Button();
            var rnd = new Random();
            var answers = question.WrongAnswers;
            answers.Add(question.RightAnswer);
            List<int> ind_list = new() { 0, 1, 2, 3 };
            var j = 0;
            for (int i = 0; i < 4; i++)
            {

                var answ_btn = new Button();
                answ_btn.Margin = Padding.Empty;
                answ_btn.Size = new Size(panel.Width / 2, panel.Height / 2);
                answ_btn.Location = new Point(panel.Width / 2 * (i % 2), panel.Height / 2 * j);
                var rnd_tmp = rnd.Next(0, ind_list.Count);
                answ_btn.Text = answers[ind_list[rnd_tmp]];
                answ_btn.Click += Answ_btn_Click1;
                ind_list.RemoveAt(rnd_tmp);
                panel.Controls.Add(answ_btn);
                if (i >= 1) j = 1;
            }

            thisA = panel;
        }

        private void Answ_btn_Click1(object? sender, EventArgs e)
        {
            AnswBtnClick.Invoke(sender, e);
        }

        public Panel AnswerPanelCreate()
        {
            var panel = new Panel();
            panel.Name = origA.Name;
            panel.Size = origA.Size;
            panel.Location = origA.Location;

            switch (AP)
            {
                case TaskPanelsPainter.AnswerPeek.ChoicesAnsw:
                    FillChoicePanelByBtns(ref panel);
                    break;
                case TaskPanelsPainter.AnswerPeek.TextAnsw:
                    FillChoicePanelByTextBox(ref panel);
                    break;
            }

            thisA = panel;

            return panel;

        }

        private void FillChoicePanelByTextBox(ref Panel panel)
        {
            textBox = new TextBox();
            textBox.Location = new Point(panel.Width / 8 - 20, panel.Height / 2 - 10);
            textBox.PlaceholderText = "Введите ответ";
            textBox.Multiline = false;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Size = new Size(panel.Width - panel.Width / 8, panel.Height / 4);
            textBox.KeyUp += TextBox_KeyDown;
            panel.Controls.Add(textBox);
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var textbx = sender as TextBox;
                var text = textbx?.Text;
                text.TrimEnd('\n', '\r');
                if (text.ToLower() == question.RightAnswer.ToLower())
                {
                    TextBoxEnter.Invoke(textbx, EventArgs.Empty);
                }
                else
                {
                    textbx.Text = string.Empty;
                    thisA.BackColor = Color.LightPink;
                }
            }

        }

        private void FillChoicePanelByBtns(ref Panel panel)
        {
            var rightAnswBtn = new Button();
            var rnd = new Random();
            var answers = question.WrongAnswers;
            answers.Add(question.RightAnswer);
            List<int> ind_list = new(){ 0, 1, 2, 3 };
            var j = 0;
            for (int i = 0; i < 4; i++)
            {
  
                var answ_btn = new Button();
                answ_btn.Margin = Padding.Empty;
                answ_btn.Size = new Size(panel.Width / 2, panel.Height / 2);
                answ_btn.Location = new Point(panel.Width / 2 * (i % 2), panel.Height / 2 * j);
                var rnd_tmp = rnd.Next(0, ind_list.Count);
                answ_btn.Text = answers[ind_list[rnd_tmp]];
                answ_btn.Click += Answ_btn_Click1;
                ind_list.RemoveAt(rnd_tmp);
                panel.Controls.Add(answ_btn);
                if (i >= 1) j = 1;
            }

            thisA = panel;
        }
    }
}
