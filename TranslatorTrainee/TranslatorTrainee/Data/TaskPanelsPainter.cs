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
                        taskG?.FillRectangle(
                        new SolidBrush(Color.Red),
                        taskRect);
                        break;
                    case QuestionPeek.VoiceQuestion:
                        taskG?.FillRectangle(
                        new SolidBrush(Color.Blue),
                        taskRect);
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
                        answG?.FillRectangle(
                        new SolidBrush(Color.Blue),
                        answRect);
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
