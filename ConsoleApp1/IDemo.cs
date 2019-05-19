using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IDemo
    {
        void Show(); //оголошення методу
        double Dlina(); //оголошення методу
        int X { get; } //оголошення властивості, доступного тільки для читання 
        int Y { get; }//оголошення властивості, доступного тільки для читання 
        int this[int i] { get; set; } //оголошення індексатора, доступного для читання-запису
    }
}
