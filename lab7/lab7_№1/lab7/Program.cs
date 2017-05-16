using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Person
    {
        private string fam = "";
        private string status;
        private float salary;
        private int age;
        
        //Read,Write-once
        public string Fam
        {
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }

        //Чтение и запись
        public int Age
        {
            set { age = value; }
            get { return (age); }
        }

        //Только чтение
        public string Status
        {
            get { return (status); }
        }

        //Только запись
        public float Salary
        {
            set { salary = value; }
        }

        public override string ToString()
        {
            return "\nФамилия - " + fam + "\nСтатус - " + status + "\nЗарплата - " + salary + "\nВозраст - " + age + "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person rab1 = new Person();

            rab1.Fam = "Ендовицкий";
            //rab1.Status = "менеджер"; //только чтение, запись невозможна
            rab1.Salary = 21500;
            rab1.Age = 22;

            //Console.WriteLine(rab1.Salary); //только запись

            Console.WriteLine(rab1);
        }
    }
}
