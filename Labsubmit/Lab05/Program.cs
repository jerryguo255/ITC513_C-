using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_05_Dewey_Classification_System
{
    class Program
    {
         static void Main(string[] args)
        {
            List<Dewey> dl = getData();   // a list called dl which has a set of objects in it , every object has different value.
            string input = Console.ReadLine();
            while (input != "#")
            {
                string[] range = input.Split(',');
                int min = int.Parse(range[0]); // 
                int max = int.Parse(range[1]);

                foreach (Dewey o in dl)   // traverse each object from list :dl    ,use o represent every object.
                {
                    if (o.Code >= min && o.Code <= max)
                    {
                        Console.WriteLine(o);
                    }
                }
                input = Console.ReadLine();
            }
        }

        public static List<Dewey> getData()
        {
            List<Dewey> dList  = new List<Dewey>();
            string[] lines = File.ReadAllLines(@"../../dewey.txt"); // get lines of data from dewey.txt  
            foreach (string line in lines)       // traverse  each line from lines
            {
                string[] words  = line.Split(':');  // split a line into words  (int , string)
                Dewey d = new Dewey(int.Parse(words[0]), words[1]); ;   // put the words(int, string) into a object : d 
                dList.Add(d);    // put the object : d into a list : dList
            }

            return dList;
        }
    }
}
