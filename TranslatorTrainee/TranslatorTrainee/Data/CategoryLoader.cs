using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    internal class CategoryLoader
    {
        public List<Category>? _categories = new();
        private string fileName = "";


        public CategoryLoader(string filename)
        {
            fileName = filename;
        }

        public void WhenClosing()
        {
            Task.Run(async () => await WriteCategoriesAsync()).Wait();
        }

        public async Task LoadCategoriesAsync()
        {
            using(var reader = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All),
                    WriteIndented = true,
                };
                _categories = await JsonSerializer.DeserializeAsync<List<Category>>(reader, jsonSerializerOptions);
            }
        }

        public async Task WriteCategoriesAsync()
        {
            using(var reader = new FileStream(fileName, FileMode.Truncate, FileAccess.Write))
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All),
                    WriteIndented = true,
                };
                await JsonSerializer.SerializeAsync(reader, _categories, jsonSerializerOptions);
            }
        }
    }
}
