using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // клас DemoPoint успадковує інтерфейс IDemo 
    class DemoPoint : IDemo
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public void Show() //реалізація методу, оголошеного в інтерфейсі 
        {
            Console.WriteLine("точка на площині: ({0}, {1})", x, y);
        }
        public double Dlina() //реалізація методу, оголошеного в інтерфейсі    
        {
            return Math.Sqrt(x * x + y * y);
        }
        public int X //реалізація властивості, оголошеної в інтерфейсі        
        {
            get
            {
                return x;
            }
        }
        public int Y //реалізація властивості, оголошеної в інтерфейсі        
        {
            get
            {
                return y;
            }
        }
        public int this[int i] //реалізація індексатора, оголошеного в інтерфейсі       
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("неприпустиме значення індексу");
            }
        }
    }
}
