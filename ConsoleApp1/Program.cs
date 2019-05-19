using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // створення масиву інтерфейсних посилань 
            IDemo[] a = new IDemo[4];

            // заповнення масиву             
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);

            // перегляд масиву          
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Dlina={0:f2}", x.Dlina());
                Console.WriteLine("x=" + x.X);
                x[1] += x[0];
                Console.Write("нові координати - ");
                x.Show();
                Console.WriteLine();
            }

            Console.WriteLine("Реалізація для Y:");

            foreach (IDemo y in a)
            {
                y.Show();
                Console.WriteLine("Dlina={0:f2}", y.Dlina());
                Console.WriteLine("y=" + y.Y);
                y[1] += y[0];
                Console.Write("нові координати - ");
                y.Show();
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Class Square:");
            Square s1 = new Square(10);
            Square s2 = new Square(14);
            Square s3 = new Square(9);
            Square s4 = new Square(17);
            Square s5 = new Square(1);

            Square[] s = new Square[] { s1, s2, s3, s4, s5 };

            Array.Sort(s);
            Console.WriteLine();

            foreach (Square  S in s)
            {
                Console.WriteLine("Perymeter:" + S.Perimeter);
                Console.WriteLine("Area:" + S.Area);
                Console.WriteLine("Big radius:" + S.R);
                Console.WriteLine("Small radius:" + S.r);
                Console.WriteLine();
            }

            Console.WriteLine("Sort by area:");

            Console.WriteLine("Class ClassRoom:");
            ClassRoom c1 = new ClassRoom(1,2,5);
            ClassRoom c2 = new ClassRoom(3, 4, 6);
            ClassRoom c3 = new ClassRoom(1, 5, 8);

            ClassRoom[] c = new ClassRoom[] { c1, c2, c3 };

            Array.Sort(c);
            Console.WriteLine();

            foreach (ClassRoom C in c)
            { 
                Console.WriteLine("Area:" + C.Area);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Class MyRoom:");
            MyRoom m1 = new MyRoom(1.3, 2, 3);
            MyRoom m2 = new MyRoom(1, 2.5, 15);
            MyRoom m3 = new MyRoom(1.3, 2.7, 5);

            MyRoom[] m = new MyRoom[] { m1, m2, m3 };

            Array.Sort(m);
            Console.WriteLine();
            foreach (MyRoom M in m)
            {
                Console.WriteLine("Area:" + M.Area);
                Console.WriteLine();
            }

            Console.WriteLine("Sort by windows:");
      
            Console.WriteLine("Class MyRoom:");
            Array.Sort(m, new MyRoomComparer());
            Console.WriteLine();

            foreach (MyRoom M in m)
            {
                Console.WriteLine("Windows:" + M.windows_num);
                Console.WriteLine();
            }

            Console.WriteLine("Class ClassRoom:");
            Array.Sort(c, new ClassRoomComparer());
            Console.WriteLine();

            foreach (MyRoom C in c)
            {
                Console.WriteLine("Windows:" + C.windows_num);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
