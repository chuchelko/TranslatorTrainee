using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    [Serializable]
    internal class Category
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public double Difficulty { get; set; }

        [JsonConstructor]
        public Category() { }

        public Category(string name, double diff)
        {
            Name = name;
            Difficulty = diff;
            Count += 1;
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.Append(Name + " " + Count + "шт. " + Difficulty);
            return res.ToString();
        }

    }
}
