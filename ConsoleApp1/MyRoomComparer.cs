using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyRoomComparer: IComparer<MyRoom>
    {
        public int Compare(MyRoom m1, MyRoom m2)
        {

            if (m1.windows_num > m2.windows_num) return 1;
            else if (m1.windows_num < m2.windows_num) return -1;
            else return 0;
        }
    }
}
