using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIterateProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your first name: ");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string input2 = Console.ReadLine();
                people.Add(new Person(input1, input2));
            }

            foreach(Person x in people)
            {
                Console.WriteLine($"Hello, {x.Fname} {x.Lname}");
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        string fName;
        string lName;
        public string Fname
        {
            get => fName; set => fName = value;
        }
        public string Lname
        {
            get => lName; set => lName = value;
        }
        public Person(string _Fname, string _Lname)
        {
            Fname = _Fname;
            Lname = _Lname;
        }
    }
}
