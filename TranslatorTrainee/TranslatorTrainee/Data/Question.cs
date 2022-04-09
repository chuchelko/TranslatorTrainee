using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    [Serializable]
    internal class Question
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public List<string> WrongAnswers { get; set; }
        public string RightAnswer { get; set; }

        public Question() { }

        public override string ToString()
        {
            return $"{Text} {WrongAnswers.Count+1}";
        }
    }
}
