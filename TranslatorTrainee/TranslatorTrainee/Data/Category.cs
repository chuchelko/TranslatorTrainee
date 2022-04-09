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
        private int count;
        private string name;
        private double difficulty;
        public int Count
        {   
            get
            {
                return count;
            }
            set
            {
                if(value < 0 ) value = 0;
                count = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value)) 
                    throw new ArgumentNullException("value");
                name = value;
            }
        }

        public double Difficulty { 
            get { return difficulty; }
            set
            {
                difficulty = value;
            }
        }

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
