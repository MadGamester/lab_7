using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Square : IMeasurable, ICircumcircleIncircle,IComparable
    {
        public double x;
        public Square( double X)
        {
            this.x = X;
        }
        public double Perimeter
        {
            get
            {
                return this.x * 4;
            }
        }
        public double Area
        {
            get
            {
                return this.x * this.x;
            }
        }
        public double R
        {
            get
            {
                return (Math.Sqrt((this.x * this.x) + (this.x * this.x)))/2;
            }
        }
        public double r
        {
            get
            {
                return this.x/2;
            }
        }
        public int CompareTo(object obj)
        {
            Square b = (Square)obj;
            //перетворимо до типу Square 
            //визначаємо критерії порівняння поточного об'єкта з параметром в  залежності від периметру 
            if (this.Perimeter == b.Perimeter) return 0;
            else if (this.Perimeter > b.Perimeter) return 1;
            else return -1;
        }   


        }
}
