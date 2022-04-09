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
        private string _title;
        private List<string> answers = new();

        public string Title
        {
            get { return _title; }
            set
            {
                if(string.IsNullOrEmpty(value)) 
                    throw new ArgumentNullException(nameof(value));
                _title = value;
            }
        }

        public List<string> Answers
        {
            get { return answers; }
            set
            {
                answers.AddRange(value);
            }
        }

        public Question() { }

        public Question(string title, List<string> answrs)
        {
            Title = title;
            Answers = answrs;
        }

        public override string ToString()
        {
            return $"{Title} {Answers.Count}";
        }
    }
}
