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
        }
        public enum AnswerPeek
        {
            ChoicesAnsw,
            TextAnsw,
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
                            new Pen(Color.White, 2),
                            Rectangle.Ceiling(textRect));
                        taskG?.DrawString(
                            "Текстовый вопрос",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.White),
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
                        
                        answG?.FillRectangle(
                            new SolidBrush(Color.DimGray),
                            answRect);
                        answG?.DrawRectangle(
                            new Pen(Color.Black, 2),
                            answRect);
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
                            new Pen(Color.White, 2),
                            Rectangle.Ceiling(textRect));
                        answG?.DrawString(
                            "Текстовый ответ",
                            new Font("Robotica", 12, FontStyle.Regular),
                            new SolidBrush(Color.White),
                            new Point(answRect.Width / 10 * 3 - 10, answRect.Height / 2 - 15));
                        break;
                   
                }
                answerPeek = ap;
            }
        }

        public void QuestionHandler()
        {
            taskG?.Clear(Color.DimGray);
            Paint(QuestionPeek.TextQuestion);
        }

        public void AnswerHandler(object? sender, EventArgs e)
        {
            var peek = sender as int?;
            answG?.Clear(Color.DimGray);
            switch (peek)
            {
                case 0:
                    Paint(AnswerPeek.ChoicesAnsw);
                    break;
                case 1:
                    Paint(AnswerPeek.TextAnsw);
                    break;
            }
        }


    }
}
