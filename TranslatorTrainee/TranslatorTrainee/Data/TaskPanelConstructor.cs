using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    internal class TaskPanelConstructor
    {
        private TaskPanelsPainter.QuestionPeek QP;
        private TaskPanelsPainter.AnswerPeek AP;
        private Panel origQ, origA;
        private Question question;
        public TaskPanelConstructor(TaskPanelsPainter.QuestionPeek qp, TaskPanelsPainter.AnswerPeek ap, Panel origQ, Panel origA, Question question)
        {
            QP = qp;
            AP = ap;
            this.origQ = origQ;
            this.origA = origA;
            this.question = question;
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
                    //label.Text = QuestionLoader.GetRandomQuestion().Text;
                    label.Location = new Point(panel.Width / 2 - label.Width, panel.Height / 2);
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
            textBox.Location = new Point(panel.Width / 4, panel.Height / 2 - 10);
            textBox.Multiline = true;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Size = panel.Size / 4;
            textBox.KeyDown += TextBox_KeyDown;
            panel.Controls.Add(textBox);

        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var textbx = sender as TextBox;
                var text = textbx?.Text;
                textbx?.Dispose();

            }

        }

        private void FillChoicePanelByBtns(ref Panel panel)
        {
            var rnd = new Random();
            List<int> ind_list = new(){ 0, 1, 2, 3 };
            for(int i = 0; i < 4; i++)
            {
                var answ_btn = new Button();
                answ_btn.Margin = Padding.Empty;
                answ_btn.Size = panel.Size / 4;
                answ_btn.Location = new Point(panel.Width / 2 * (i % 2), panel.Height / 2 * (i % 2));
                var rnd_tmp = rnd.Next(0, ind_list.Count);
                answ_btn.Text = question.Answers[ind_list[rnd_tmp]];
                answ_btn.Click += Answ_btn_Click;
                ind_list.RemoveAt(rnd_tmp);
                panel.Controls.Add(answ_btn);
            }   

        }

        private void Answ_btn_Click(object? sender, EventArgs e)
        {
            var answer_btn = sender as Button; 
           //жду коммит Эмиля
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
