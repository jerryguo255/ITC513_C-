using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_AnimalSpecies_I
{
    class Animal
    {
        private string species;
        private int legs;
        private string classification;
        private bool isExtinct;
        public string Species
        {
            set { species = value; }
            get { return species; }
        }
        public int Legs
        {
            set { legs = value; }
            get { return legs; }
        }
        public string Classification
        {
            set { classification = value; }
            get { return classification; }
        }
        public bool IsExtinct
        {
            set { isExtinct = value; }
            get { return isExtinct; }
        }
        public Animal(string Species, int Legs, string Classification, bool IsExtinct)
        {
            species = Species;
            legs = Legs;
            classification = Classification;
            isExtinct = IsExtinct;
         }
        
        public override string ToString()
        {
            if (isExtinct)
            {
                return species + " (" + legs + " legged) " + classification +" (extinct)";
            }//dodo (2 legged) bird (extinct)
            else
            {
                return species+ " (" + legs + " legged) " + classification;
            }
        }
        
        
    }
}
