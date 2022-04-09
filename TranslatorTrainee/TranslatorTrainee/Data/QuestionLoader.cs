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
        public List<Question> Questions;

        public QuestionLoader(Category category)
        {
            Load(category);
        }

        private void Load(Category category)
        {
            string file = Directory
                .GetFiles(Directory.GetCurrentDirectory() + "\\json", category.FileName, SearchOption.AllDirectories)[0];
            using var reader = new FileStream(file, FileMode.Open, FileAccess.Read);
            Questions = JsonSerializer.Deserialize<List<Question>>(reader)!;
        }
        public Question GetRandomQuestion()
        {
            return Questions[new Random().Next(0, Questions.Count)];
        }
    }
}
