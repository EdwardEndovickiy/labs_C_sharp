using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Student
    {
        public string Name { get; set; }
    }

    public class MyClass
    {
        public Student EmpObj;

        public void SetObject(Student obj)
        {
            EmpObj = obj;
        }
    }

    class Program
    {
        static void print_arr(int[] arr)
        {
            foreach (int elem in arr)
                Console.Write(elem + " ");
            Console.WriteLine("\n");
        }

        static void print_arr1(params int[] arr)
        {
            foreach (int elem in arr)
                Console.Write(elem + " ");
            Console.WriteLine("\n");
        }

        static void plus(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] -= 5;
            Console.WriteLine("\n");
        }

        static void replace(ref string s, ref string s1)
        {
            string temp = s;
            s = s1;
            s1 = temp;
            Console.WriteLine("Replace strings: {0} {1}", s, s1);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            print_arr(a);

            print_arr1(6, 7, 8, 9, 10, 11, 12);
            print_arr1(a);
            
            plus(a);
            print_arr1(a);

            string s="qwerty", s1="ytrewq";

            Console.WriteLine("Default strings: {0} {1}", s, s1);
            replace(ref s, ref s1);

            Student someTestObj = new Student();
            someTestObj.Name = "ABC";

            MyClass cls = new MyClass();
            cls.SetObject(someTestObj);

            Console.WriteLine("\n\nName - " + cls.EmpObj.Name);
            Console.WriteLine("Changing Student Name To XYZ...");
            someTestObj.Name = "XYZ";

            Console.Write("\nAccessing Assigned Emp Name: ");
            Console.WriteLine(cls.EmpObj.Name);
        }
    }
}
