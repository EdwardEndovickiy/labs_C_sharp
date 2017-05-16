using System;

namespace lab1
{
	class MainClass
	{
		/*static void Main()
		{
			int i = 10; //объявление и инициализация целочисленной переменной i
			Console.WriteLine(i);       //просмотр значения переменной
			i = 100;        //изменение значение переменной
			Console.WriteLine(i);
		}*/

		/*static void Main()
		{
			int i = 10;
			Console.WriteLine(i);
		}*/

		class Program
		{
			/*enum gradus : int
			{
				min = 0,
				krit = 72,
				max = 100,
			}
			static void Main()
			{
				Console.WriteLine("минимальная температура=" + (int)gradus.min);
				Console.WriteLine("критическая температура=" + (int)gradus.krit);
				Console.WriteLine("максимальная температура=" + (int)gradus.max);
			}*/

			/*static void Main()
			{
				Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");
			}*/

			/*static void Main()
			{
				double x = Math.PI;
				Console.WriteLine("pi={0,20}", x);
				Console.WriteLine("pi={0,10}", x);
			}*/

			/*static void Main()
			{
				double x = Math.E;
				Console.WriteLine("E={0:##.#####}", x);
				Console.WriteLine("E={0:.####}", x);
				Console.WriteLine("Задание 6 знаков после запятой\nE={0:.######}", x);
			} */

			/*static void Main()
			{
				Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
				Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
				Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
				Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
				Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
				Console.WriteLine("X Format:{0,14:X} ", 1234);
				Console.WriteLine("P Format:{0,14:P} ", 0.9); 
			}*/

			/*static void Main()
			{
				string s = Console.ReadLine();
				Console.WriteLine(s);
			}*/


			/*static void Main()
			{
				string s = Console.ReadLine();
				double x = double.Parse(s); //преобразование строки в число
				Console.WriteLine("х={0:.###}", x);
			}*
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			/*static void Main()
			{
				Console.WriteLine("Задание 1\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				int x1 = int.Parse(s1);
				int x2 = int.Parse(s2);
				int x = x1 + x2;
				Console.WriteLine(x1 + "+" + x2 + "=" + x);
			}*/

			/*
			static void Main()
			{
				Console.WriteLine("Задание 2\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				Console.WriteLine("c = ");
				string s3 = Console.ReadLine();
				int x1 = int.Parse(s1);
				int x2 = int.Parse(s2);
				int x3 = int.Parse(s3);
				int x = x1 + x2 + x3;
				Console.WriteLine(x1 + "+" + x2 + "+" + x3 + "=" + x3 + "+" + x2 + "+" + x1);
			}*/

			/*
			static void Main()
			{
				Console.WriteLine("Задание 3\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				Console.WriteLine("c = ");
				string s3 = Console.ReadLine();
				int x1 = int.Parse(s1);
				int x2 = int.Parse(s2);
				int x3 = int.Parse(s3);
				int x = x1 + x2 + x3;
				Console.WriteLine(x1 + "+" + x2 + "+" + x3 + "=" + x);
			}*/

			/*
			static void Main()
			{
				Console.WriteLine("Задание 4\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				Console.WriteLine("c = ");
				double x1 = double.Parse(s1);
				double x2 = double.Parse(s2);
				double x = x1 * x2;
				Console.WriteLine("{0:.#} * {1:.#} = {2:.#}",x1,x2,x);
			}
			*/

			/*
			static void Main()
			{
				Console.WriteLine("Задание 5\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				double x1 = double.Parse(s1);
				double x2 = double.Parse(s2);
				double x = x1 / x2;
				Console.WriteLine("{0:N3} / {1:N3} = {2:N3}", x1, x2, x);
			}
			*/


			static void Main()
			{
				Console.WriteLine("Задание 6\na = ");
				string s1 = Console.ReadLine();
				Console.WriteLine("b = ");
				string s2 = Console.ReadLine();
				Console.WriteLine("c = ");
				string s3 = Console.ReadLine();
				double x1 = double.Parse(s1);
				double x2 = double.Parse(s2);
				double x3 = double.Parse(s3);
				Console.WriteLine("<{0:N2} + {1:N2}> + {2:N2} = {0:N2} + <{1:N2} + {2:N2}> ", x1, x2, x3);
			}

		}

	}
}
