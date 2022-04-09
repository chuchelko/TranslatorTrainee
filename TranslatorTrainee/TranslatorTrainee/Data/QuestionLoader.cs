using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace TranslatorTrainee.Data
{
    internal class QuestionLoader
    {
        private List<Question> _questions;

        public QuestionLoader(Category category)
        {
            Load(category);
        }

        private void Load(Category category)
        {
            string file = Directory
                .GetFiles(Directory.GetCurrentDirectory() + "\\json", category.FileName, SearchOption.AllDirectories)[0];
            using var reader = new FileStream(file, FileMode.Open, FileAccess.Read);
            _questions = JsonSerializer.Deserialize<List<Question>>(reader)!;
        }
        public Question GetRandomQuestion()
        {
            return _questions[new Random().Next(0, _questions.Count)];
        }
    }
}
