using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClassRoom:MyRoom, Room
    {
        public ClassRoom(double w, double h, int w_n) : base(w, h, w_n) { }
       
    }
}
