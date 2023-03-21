using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12._1
{
    class Zafira : Opel
    {
        public string model = "Zafira";
        public int year = 1998;
        public void Opel_Zafira()
        {
            Console.WriteLine("model - " + model + " " + year);
            Console.WriteLine("sportscar - " + sportcar);
            Console.WriteLine("from - " + origin);
            Console.WriteLine("max speed - " + speed);
            Console.WriteLine("default color - " + default_color);
        }
        public Zafira()
        {
            speed = 90;
            default_color = "red";
            sportcar = false;
        }
    }
}
