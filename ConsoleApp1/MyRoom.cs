using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyRoom : Room, IComparable
    {
        public double weight;
        public double height;
        public int windows_num;
        public MyRoom(double w, double h, int w_n)
        {
            this.weight = w;
            this.height = h;
            this.windows_num = w_n;
        }
        public double  Area
        {
            get
            {
                return this.weight *this.height;
            }
        }
        public int CompareTo(object obj)
        {
            MyRoom b = (MyRoom)obj;
            //перетворимо до типу Square 
            //визначаємо критерії порівняння поточного об'єкта з параметром в  залежності від периметру 
            if (this.Area == b.Area) return 0;
            else if (this.Area > b.Area) return 1;
            else return -1;
        }
       

    }
}
