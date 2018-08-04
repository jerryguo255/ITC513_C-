using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_MyRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Rectangle> rlist = new List<Rectangle>();
            while (input != "#")
            {
                string[] parts = input.Split(',');
                double width = double.Parse(parts[0]);
                double height = double.Parse(parts[1]);
                Rectangle a = new Rectangle(width, height);
                rlist.Add(a);
                
                input = Console.ReadLine();
            }
            foreach (Rectangle sa in rlist)
            {
                Console.WriteLine(sa);
                Console.WriteLine("Perimeter: "+sa.CaclPerimeter());
                Console.WriteLine("Area: "+sa.CaclAreas());
                Console.WriteLine("#");
            }
            

            Console.ReadLine();
        }
    }
}
