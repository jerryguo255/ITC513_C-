using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02__TransactionLines
{
    class Program
    {
        static void Main(string[] args)
        {
             string n = "";
             double c = 0;
             int q = 0;
            string input = Console.ReadLine();
            while (input != "#")
            {
                string[] parts = input.Split(',');
                n = parts[0];
                c = double.Parse(parts[1]);
                q = int.Parse(parts[2]);
                Transaction t = new Transaction(n, c, q);
                Console.WriteLine(t);

                input = Console.ReadLine();
            }
        }
    }
}
