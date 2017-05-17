using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        public static string Fun(double x, out int a, out bool b, out double s, out double p)
        {

            if (x < 0)
            {
                a = -1;
            }
            else {
                a = 1;
            }

            if (x % 1 != 0)
            {
                b = false;
            }
            else {
                b = true;    
            }

            s = Math.Abs(x);
            
            p = x * x;


            return a+"\n"+b+"\n"+s+"\n"+p;
            

        }
        static void Main(string[] args)
        {
            double u, v;
            int i; bool q;

            double x = 42;
            double y = -12.67;

            Console.WriteLine(" X до функции: "+ x);
            
            Console.WriteLine(Fun(x, out i, out q, out u, out v));
            Console.WriteLine("\n X после функции: " + x);

            Console.WriteLine("\n Y до функции: " + y);

            Console.WriteLine(Fun(y, out i, out q, out u, out v));
            Console.WriteLine("\n Y после функции: " + y);

            Console.WriteLine("\n U: " + u);
            Console.WriteLine(Fun(u, out i, out q, out u, out v));

            Console.WriteLine("\n V: " + v);
            Console.WriteLine(Fun(v, out i, out q, out u, out v));

        }
    }
}
