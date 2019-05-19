using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClassRoomComparer: IComparer<ClassRoom>
    {
        public int Compare(ClassRoom c1, ClassRoom c2)
        {
            if (c1.windows_num > c2.windows_num) return 1;
            else if (c1.windows_num < c2.windows_num) return -1;
            else return 0;
        }
    }
}
