using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorTrainee.Data
{
    [Serializable]
    internal class Category
    {
        public static int Count { get; set; }
        public string Name { get; set; }

        public double Difficulty { get; set; }

        public Category(string name, double diff)
        {
            Name = name;
            Difficulty = diff;
            Count += 1;
        }

    }
}
