using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Dewey_Classification_System
{
    class Dewey
    {
        private int code;
        private string descriptor;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Descriptor
        {
            get { return descriptor; }
            set { descriptor = value; }
        }

        public Dewey(int code, string descriptor)
        {
            Code = code;
            Descriptor = descriptor;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Code, Descriptor);
        }
    }
}
