using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        class Example
        {
            public int x;
            public int y;

            public Example(int x)
            {
                this.x = x;
                Console.WriteLine("Непонятно зачем, но выводим параметр метода Example: "+this.x+"\n");
            }

            public static void Init(Example Obj1)
            {
                int x = 1;
                Example Obj = new Example(x);
                Obj.x = 1;
                Obj.y = 1;
                Console.WriteLine("В методе Init: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
            }

            public static void Sqr(double a, double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b + "\n");
            }
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("a = {0}\tb = {1}", a, b + "\n");
            
            Example.Sqr(a, b);
            Example.Sqr(a * 2, b * 2);
           
            int x = 1;
            Example Obj = new Example(x);
            Obj.x = 2;
            Obj.y = 4;
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
            Example.Init(Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y + "\n");
        }
    }
}
