using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // клас DemoShape успадковує клас DemoPoint і інтерфейс IDemo    
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного методу з базового класу
        public new void Show()
        {
            Console.WriteLine("точка в пространстве: ({0}, {1}, {2})", x, y, z);
        }         // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного методу з базового класу  
        public new double Dlina()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        // реалізація індексатора, оголошеного в інтерфейсі, з приховуванням  
        // однойменного індексатора з базового класу 
        public new int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else if (i == 2) return z;
                else throw new Exception("неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception("неприпустиме значення індексу");
            }
        }
    }
}
