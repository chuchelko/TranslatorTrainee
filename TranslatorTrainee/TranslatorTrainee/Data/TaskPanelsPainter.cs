using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    internal class TaskPanelsPainter
    {

        public enum QuestionPeek
        {
            TextQuestion,
            VoiceQuestion
        }
        public enum AnswerPeek
        {
            ChoicesAnsw,
            TextAnsw,
            VoiceAnsw
        }

        private Rectangle taskRect;
        private Rectangle answRect;
        private Graphics? taskG;
        private Graphics? answG;

        public QuestionPeek questionPeek;
        public AnswerPeek answerPeek;



        public TaskPanelsPainter(Graphics TaskG, Graphics AnswG)
        {
            taskG = TaskG;
            answG = AnswG;
            taskRect = Rectangle.Ceiling(TaskG.VisibleClipBounds);
            answRect = Rectangle.Ceiling(AnswG.VisibleClipBounds);
        }

        public void Paint(Enum qp, [CallerMemberName]string name = "")
        {
            if(name == "QuestionHandler")
            {
                var qpp = (QuestionPeek)qp;
                switch (qpp)
                {
                    case QuestionPeek.TextQuestion:
                        var textRect = new RectangleF(
                            taskRect.Width / 10,
                            taskRect.Height / 4,
                            taskRect.Width - 2 * taskRect.Width / 10, taskRect.Height / 2
                            );
                        taskG?.DrawRectangle(
                            new Pen(Color.Black, 2),
                            Rectangle.Ceiling(textRect));
                        taskG?.DrawString(
                            "Текстовый вопрос",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.Black),
                            new Point(taskRect.Width / 10 * 3 - 10, taskRect.Height / 2 - 15));
                        break;
                    case QuestionPeek.VoiceQuestion:
                        var textRect1 = new RectangleF(
                            taskRect.Width / 10,
                            taskRect.Height / 4,
                            taskRect.Width - 2 * taskRect.Width / 10, taskRect.Height / 2
                            );
                        taskG?.DrawRectangle(
                            new Pen(Color.Black, 2),
                            Rectangle.Ceiling(textRect1));
                        taskG?.DrawString(
                            "Голосовой вопрос",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.Black),
                            new Point(taskRect.Width / 10 * 3 - 10, taskRect.Height / 2 - 15));
                        break;
                }
                questionPeek = qpp;
            }
            if(name == "AnswerHandler")
            {
                var ap = (AnswerPeek)qp;

                switch (ap)
                {
                    case AnswerPeek.ChoicesAnsw:
                        answG?.DrawLine(
                            new Pen(Color.Black, 2),
                            new Point(answRect.Width / 2, 0),
                            new Point(answRect.Width / 2, answRect.Height));
                        answG?.DrawLine(
                            new Pen(Color.Black, 2),
                            new Point(0, answRect.Height / 2),
                            new Point(answRect.Width, answRect.Height / 2));
                        break;
                    case AnswerPeek.TextAnsw:
                        var textRect = new RectangleF(
                            answRect.Width / 10,
                            answRect.Height / 4,
                            answRect.Width - 2 * answRect.Width / 10, answRect.Height /2
                            );
                        answG?.DrawRectangle(
                            new Pen(Color.Black, 2),
                            Rectangle.Ceiling(textRect));
                        answG?.DrawString(
                            "Текстовый ответ",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.Black),
                            new Point(answRect.Width / 10 * 3 - 10, answRect.Height / 2 - 15));
                        break;
                    case AnswerPeek.VoiceAnsw:
                        var textRect1 = new RectangleF(
                            answRect.Width / 10,
                            answRect.Height / 4,
                            answRect.Width - 2 * answRect.Width / 10, answRect.Height / 2
                            );
                        answG?.DrawRectangle(
                            new Pen(Color.Black, 2),
                            Rectangle.Ceiling(textRect1));
                        answG?.DrawString(
                            "Голосовой ответ",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.Black),
                            new Point(answRect.Width / 10 * 3 - 10, answRect.Height / 2 - 15));
                        break;
                }
                answerPeek = ap;
            }
        }

        public void QuestionHandler(object? sender, EventArgs e)
        {
            var peek = sender as int?;
            taskG?.Clear(Color.White);
            if(peek == 0)
            {
                Paint(QuestionPeek.TextQuestion);
            }
            if(peek == 1)
            {
                Paint(QuestionPeek.VoiceQuestion);
            }
        }

        public void AnswerHandler(object? sender, EventArgs e)
        {
            var peek = sender as int?;
            answG?.Clear(Color.White);
            switch (peek)
            {
                case 0:
                    Paint(AnswerPeek.ChoicesAnsw);
                    break;
                case 1:
                    Paint(AnswerPeek.TextAnsw);
                    break;
                case 2:
                    Paint(AnswerPeek.VoiceAnsw);
                    break;
            }
        }


    }
}
