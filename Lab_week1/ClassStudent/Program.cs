using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Student

    {
        public string name;
        public string surname;
        public double gpa;

        public Student()
        {
            name = "John";
            surname = "Doe";
            gpa = 3.5;

        }
        public Student(string name, string surname, int gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;

        }
        public override string ToString()
        {
            return name + " " + surname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("John", "Doe", 4);
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }  
}


