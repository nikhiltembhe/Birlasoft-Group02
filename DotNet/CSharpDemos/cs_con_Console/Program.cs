using System;

namespace cs_con_Console
{
    internal class Program
    {
        static private void GetName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "!  Nice to meet you!");
            Console.WriteLine("Hi {0}! Nice to meet you!", name);
        }

        private void GetAge()
        {
            Console.Write("Enter age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine("You are " + age.ToString() + " years old!");
            Console.WriteLine("You are {0} years old!", age);
            Console.WriteLine("input: {0}, age {1}", input, age);
        }

        static void Main(string[] args)
        {

            Program.GetName();

            Console.WriteLine();

            Program p = new Program();
            p.GetAge();

        }
    }
}
