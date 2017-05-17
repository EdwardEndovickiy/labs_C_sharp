using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        class Example
        {
            public int x;
            public int y;

            public Example(ref int x)
            {
                this.x = x;
                Console.WriteLine("Непонятно зачем, но выводим параметр метода Example: " + this.x + "\n");
            }

            public static void Init(ref Example Obj1)
            {
                int x = 1;
                Example Obj = new Example(ref x);
                Obj.x = 1;
                Obj.y = 1;
                Console.WriteLine("В методе Init: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
            }

            public static void Sqr(ref double a, ref double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b + "\n");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());

            Example.Sqr(ref a, ref b);

            Console.WriteLine("a = {0}\tb = {1}", a, b + "\n");

            //Console.WriteLine("C: ");
            //double c ;   
            //Example.Sqr(ref a, ref c);
            //Example.Sqr(ref a * 2, ref b * 2);

            int x = 1;
            Example Obj = new Example(ref x);
            Obj.x = 2;
            Obj.y = 3;
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
            Example.Init(ref Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
        }
    }
}
