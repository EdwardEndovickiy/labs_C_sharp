using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static double Avarge(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }
        static void Main(string[] args)
        {
            int[] m = { 1, 2, 3, 4 };


            Console.WriteLine("Среднее - " + Avarge(m));

            short z = 1, e = 12;
            byte v = 107;

            Console.WriteLine("Среднее элементов - " + Avarge(z, e, v));

        }
    }
}
