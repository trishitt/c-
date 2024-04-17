using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("What's the speed limit");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the car speed");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b<a)
            {
                Console.WriteLine("OK!");
            }
            else
            {
                if ((b-a) >12)
                {
                    int d = (b - a);
                    Console.WriteLine(d);
                    Console.WriteLine("suspended");
                }
                
            }
        }
    }
}
