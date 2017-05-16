using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Rational
    {
        private int m;  //числитель
        private int n;  //знаменатель

        public static readonly Rational Zero, One;

        public Rational(int a, int b)
        {
            if (b == 0) { m = 0; n = 1; }
            else
            {
                //приведение знака
                if (b < 0) { b = -b; a = -a; }
                //приведение к несократимой дроби
                int d = del(a, b);
                m = a / d;
                n = b / d;
            }
        }

        private Rational(int a, int b, string t)
        {
            m = a;
            n = b;
        }

        static Rational()   //Статический конструктор
        {
            Console.WriteLine("Статический конструктор Rational");
            Zero = new Rational(0, 1, "private");
            One = new Rational(1, 1, "private");
        }

        private int del(int m, int n)
        {
            int p = 0;
            m = Math.Abs(m);
            n = Math.Abs(n);

            if (n > m) { p = m; m = n; n = p; }

            do
            {
                p = m % n;
                m = n;
                n = p;
            } while (n > 0);

            return (m);
        }

        public Rational Plus(Rational a)
        {
            int u, v;
            u = m * a.n + n * a.m; v = n * a.n;
            return (new Rational(u, v));
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return (r1.Plus(r2));
        }

        public Rational Minus(Rational a)
        {
            int u, v;
            u = m * a.n - n * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return (r1.Minus(r2));
        }

        public Rational Mult(Rational a)
        {
            int u, v;
            u = m * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return (r1.Mult(r2));
        }

        public Rational Divide(Rational a)
        {
            int u, v;
            u = m * a.n;
            v = n * a.m;
            return (new Rational(u, v));
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return (r1.Divide(r2));
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            return ((r1.m == r2.m) && (r1.n == r2.n));
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return ((r1.m != r2.m) || (r1.n != r2.n));
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            return (r1.m * r2.n < r2.m * r1.n);
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            return (r1.m * r2.n > r2.m * r1.n);
        }
        public static bool operator <(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n < r2);
        }
        public static bool operator >(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n > r2);
        }

        public void PrintRational(string name)
        {
            Console.WriteLine(" {0} = {1}/{2}", name, m, n);
        }

        public static void TestRational()
        {
            Rational r1 = new Rational(2, 8), r2 = new Rational(2, 5);
            Rational r3 = new Rational(4, 10), r4 = new Rational(3, 7);
            Rational r5 = Rational.Zero, r6 = Rational.Zero;
            if ((r1 != Rational.Zero) && (r2 == r3)) r5 =
             (r3 + Rational.One) * r4;
            r6 = Rational.One + Rational.One;
            r1.PrintRational("\n r1: (2,8)");
            r2.PrintRational("r2: (2,5)");
            r3.PrintRational("r3: (4,10)");
            r4.PrintRational("r4: (3,7)");
            r5.PrintRational("r5: ((r3 +1)*r4)");
            r6.PrintRational("r6: (1+1)");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(0, 0), r2 = new Rational(1, 1),
                     r3 = new Rational(10, 8), r4 = new Rational(2, 6),
                     r5 = new Rational(4, -12), r6 = new Rational(-12, -14);

            r1.PrintRational("r1:(0,0)");
            r2.PrintRational("r2:(1,1)");
            r3.PrintRational("r3:(10,8)");
            r4.PrintRational("r4:(2,6)");
            r5.PrintRational("r5: (4,-12)");
            r6.PrintRational("r6: (-12,-14)");

            Rational r7, r10, r11, r12;

            r7 = r1.Plus(r2);

            r10 = r1 + r2;
            r11 = r3 + r4;
            r12 = r5 + r6 + r10 + r11;

            r7.PrintRational("\n r7: (r1+r2)");
            r12.PrintRational("r12: (r5+r6+r10+r11)");

            r3 = r4 - r2;
            r4 = r4 * r2;
            r5 = r4 / r2;
            r6 = r3 + r4 * r5;

            r3.PrintRational("\n r3: (r4-r2)");
            r4.PrintRational("r4: (r4*r2)");
            r5.PrintRational("r5: (r4/r2)");
            r6.PrintRational("r6: (r3+r4*r5)");

            Rational.TestRational();
        }
    }
}
