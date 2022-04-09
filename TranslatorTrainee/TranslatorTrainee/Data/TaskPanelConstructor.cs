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
                    label.Text = QuestionLoader.GetRandomQuestion().Text;
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
                    FillChoicePanel(ref panel);
                    break;
                case TaskPanelsPainter.AnswerPeek.TextAnsw:
                    break;
                case TaskPanelsPainter.AnswerPeek.VoiceAnsw:
                    break;
            }

            return panel;

        }

        private void FillChoicePanel(ref Panel panel)
        {
            var btn_list = new List<Button>();
            for(int i = 0; i < 4; i++)
            {
                var btn = new Button();
                
            }   
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
