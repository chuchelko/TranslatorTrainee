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
                if(qpp == QuestionPeek.TextQuestion)
                    taskG?.FillRectangle(
                        new SolidBrush(Color.Red),
                        taskRect);
                if (qpp == QuestionPeek.VoiceQuestion)
                    taskG?.FillRectangle(
                        new SolidBrush(Color.Blue),
                        taskRect);

                questionPeek = qpp;
            }
            if(name == "AnswerHandler")
            {
                var ap = (AnswerPeek)qp;
                if(ap == AnswerPeek.ChoicesAnsw)
                {
                    answG?.FillRectangle(
                        new SolidBrush(Color.Red),
                        answRect);
                }
                if (ap == AnswerPeek.TextAnsw)
                {
                    answG?.FillRectangle(
                        new SolidBrush(Color.Green),
                        answRect);
                }
                if (ap == AnswerPeek.VoiceAnsw)
                {
                    answG?.FillRectangle(
                        new SolidBrush(Color.Blue),
                        answRect);
                }

                answerPeek = ap;
            }
        }

        public void QuestionHandler(object? sender, EventArgs e)
        {
            var peek = sender as int?;
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
