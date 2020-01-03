using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeachMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Person teacher, student;
            teacher = new Person("Dan", 42);
            student = new Person("Bobby", 21);

            string message = teacher.SayHello(student);
            Console.WriteLine(message);

            message = student.SayHello(teacher.Name);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            // the this keyword helps the computer to distinguish the local variable Name from the property called Name
            this.Name = Name;
            this.Age = Age;
        }

        public string SayHello(Person that)
        {
            return SayHello(that.Name);
        }

        public string SayHello(string Name)
        {
            return "Hello " + Name + ". I am " + this.Name;
        }
    }
}
