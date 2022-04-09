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
            var lst = new List<string>();
            Directory
                .GetFiles(_foldername, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => lst.Add(f));

        }
    }
}
