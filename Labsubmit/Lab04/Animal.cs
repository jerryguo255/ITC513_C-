using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_
{
    class Animal
    {
        private string species;
        private int legs;
        private string classification;
        private bool isExtinct;
        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }

        public bool IsExtinct
        {
            get { return isExtinct; }
            set { isExtinct = value; }
        }

        public Animal(string s, int l, string c, bool i)
        {
            Species = s;
            Legs = l;
            Classification = c;
            isExtinct = i;

        }

        public override string ToString()
        {
            if (isExtinct)
            {
                return string.Format("{0} ({1} legged) {2} (extinct)" ,Species,Legs,Classification);
            }
            else
                return string.Format("{0} ({1} legged) {2}", Species, Legs, Classification);
        }
    }
}
