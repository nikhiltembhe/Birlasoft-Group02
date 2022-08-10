using System;

namespace cs_con_Console
{
    internal class Program
    {
        /// <summary>
        ///     Gets the name of the user from the Standard Input Device (Console)
        /// </summary>
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

        /// <summary>
        ///     Sum the values of two numbers
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <returns>Sum of the First Number and the Second Number</returns>
        private static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        ///     The Main Method of the Program.
        /// </summary>
        /// <param name="args">Command Line Arguments</param>
        static void Main(string[] args)
        {
            // in-line comment

            /*
             * block comments
             */


            Program.GetName();              // get the name from the user.



            Console.WriteLine();

            Program p = new Program();
            p.GetAge();

            Console.WriteLine();


            int a = 10;
            string b = "hello world";

            Console.WriteLine("a = " + a.ToString() + ", b = " + b);
            Console.WriteLine("a = {0}, b = {1}", a, b);            // string.Format() implicitly called
            Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));

            Console.WriteLine();

            // String Interpolation
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a = {a + 50}, b = {b.ToUpper()}");
            Console.WriteLine("a = {0}, b = {1}", a + 50, b.ToUpper()); // string.Format() implicitly
        }
    }
}
