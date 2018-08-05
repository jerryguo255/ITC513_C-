using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Lab_04_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalss =  GetData();
             string input = Console.ReadLine();
             while (input != "#")
             {
                 foreach (Animal line in animalss)
                 {
                     if (input == line.Classification)
                     {
                         Console.WriteLine(line);
                     }
                 }
                 input = Console.ReadLine();
             }
            Console.ReadLine();
        }
        static List<Animal> GetData()
        {
            List <Animal> animals = new List<Animal>();
            string aFileText = File.ReadAllText(@"../../animals.txt");
            string[] lines  =  aFileText.Split('\n');   // 每一行 的内容  存进数组  lines // lines[0]
            foreach (string line in lines)      
            {
                string [] parts = line.Split(',');
                Animal a = new Animal(parts[0], int.Parse(parts[1]), parts[2], bool.Parse(parts[3]));
                //Console.WriteLine(a.Species);
                animals.Add(a);
            }
            return animals;
        }
    }
}
