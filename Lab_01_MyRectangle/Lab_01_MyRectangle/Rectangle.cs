using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_MyRectangle
{
    class Rectangle
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }
        public double Heidth
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }
        public double CaclAreas()
        {
            return height * width;
        }
        public double CaclPerimeter()
        {
            return (height + width)*2;
        }
        public override string ToString()
        {
            return string.Format("{0,0} x {1,0} Rectangle", Width, Heidth);

        }
    }
}
