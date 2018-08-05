using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_02__TransactionLines{
    class Transaction
    {
        private string Name;
        private double Cost;
        private int Quantity;
        public Transaction(string n,double c,int q)
        {
            Name = n;
            Cost = c;
            Quantity = q;
        }
        public double CalcTotal()
        {
           double Total= Cost* Quantity;
            double d = Math.Round(Total,2);
            return d;
        }
        public override string ToString()
        {
            double total = CalcTotal();
            string a = string.Format("{0} x {1} @ ${2:0.00} Total: ${3:0.00}", Name, Quantity, Cost, total);
            return a;

            //return Name+" x "+ Quantity+" @ $"+Cost+" Total:$"+total;
            //Console.WriteLine("{0} x {1} @ ${2:0.00} Total:${3:0.00}", Name,Quantity,Cost, total);
        }
    }
}
