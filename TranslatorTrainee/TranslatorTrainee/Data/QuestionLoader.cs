using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    internal class QuestionLoader
    {
        private string _foldername = "";

        public QuestionLoader(string foldername, Category category)
        {
            _foldername = foldername;
            Load(category);
        }

        private void Load(Category category)
        {
            var directorylst = new List<string>();
            Directory
                .GetDirectories(category.Name, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(d => directorylst.Add(d)); 



        }

        internal static Question GetRandomQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
