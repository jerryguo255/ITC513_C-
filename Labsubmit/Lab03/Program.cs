using static System.Console;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_AnimalSpecies_I
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"/data/animals.txt");
            string s = "";
            int l = 0;
            string c = "";
            bool i = false;
            while (!r.EndOfStream)
            {
                string line = r.ReadLine();
                if (line == "")
                {
                    continue;
                }
                string[] parts = line.Split(','); //trex,2,dinosaur,true
                 s = parts[0];
                 l = int.Parse(parts[1]);
                 c = parts[2];
                 i = bool.Parse(parts[3]);
                Animal a = new Animal(s, l, c, i);
                if (a.IsExtinct)
                {
                    WriteLine(a);
                }
            }
            /*
            while (input !="#")
            {
                string [] parts =  input.Split(',');
                string s = parts[0];
                int l = int.Parse(parts[1]);
                string c = parts[2];
                bool i = bool.Parse(parts[3]);

                Animal a = new Animal(s,l,c,i);
            }//dodo (2 legged) bird (extinct)
            //trex,2,dinosaur,true */
            ReadLine();
    }
    }
}
