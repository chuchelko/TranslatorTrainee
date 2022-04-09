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

        private TaskPanelsPainter.QuestionPeek QP;
        private TaskPanelsPainter.AnswerPeek AP;
        private Panel origQ, origA;
        private Question question;
        private QuestionLoader questionLoader;

        public static int score = 0;
        public TaskPanelConstructor(TaskPanelsPainter.QuestionPeek qp, TaskPanelsPainter.AnswerPeek ap, Panel origQ, Panel origA, Category category)
        {
            QP = qp;
            AP = ap;
            this.origQ = origQ;
            this.origA = origA;
            questionLoader = new QuestionLoader(category);
            question = questionLoader.GetRandomQuestion();

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
                case TaskPanelsPainter.QuestionPeek.VoiceQuestion:
                    var btn = new Button();
                    btn.Text = "Play question";
                    btn.Size = panel.Size / 4;
                    btn.Location = new Point(panel.Width / 2 - btn.Width, panel.Height / 2);
                    btn.Click += Btn_Click;
                    panel.Controls.Add(btn);
                    break;
            }

            return panel;
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
                case TaskPanelsPainter.AnswerPeek.VoiceAnsw:
                    break;
            }

            return panel;

        }

        private void FillChoicePanelByTextBox(ref Panel panel)
        {
            var textBox = new TextBox();
            textBox.Location = new Point(panel.Width / 8 - 20, panel.Height / 2 - 10);
            textBox.PlaceholderText = "Введите ответ";
            textBox.Multiline = true;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Size = new Size(panel.Width - panel.Width / 8, panel.Height / 4);
            textBox.KeyDown += TextBox_KeyDown;
            panel.Controls.Add(textBox);
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var textbx = sender as TextBox;
                var text = textbx?.Text;
                if(text.ToLower() == question.RightAnswer.ToLower())
                {
                    origQ.BackColor = Color.LightGreen;
                    score += 1;
                }
                else
                {
                    origQ.BackColor = Color.LightPink;
                }

                textbx?.Dispose();
            }

        }

        private void FillChoicePanelByBtns(ref Panel panel)
        {
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
                answ_btn.Click += Answ_btn_Click;
                ind_list.RemoveAt(rnd_tmp);
                panel.Controls.Add(answ_btn);
                if (i >= 1) j = 1;
            }   

        }

        private void Answ_btn_Click(object? sender, EventArgs e)
        {
           var answer_btn = sender as Button; 
           if(answer_btn.Text == question.RightAnswer)
            {
                score+=1;
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
