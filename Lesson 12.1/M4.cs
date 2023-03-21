using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12._1
{
    class M4 : BMW
    {
        public string model = "M4";
        public int year = 2004;
        

        public void BMW_M4()
        {
            Console.WriteLine("model - " + model + " " + year);
            Console.WriteLine("sportscar - " + sportcar);
            Console.WriteLine("from - " + origin);
            Console.WriteLine("max speed - " + speed);
            Console.WriteLine("default color - " + default_color);
        }
        public M4()
        {
            speed = 120;
            default_color = "black";
            sportcar = true;
        }
    }
}
