using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch st = new Stopwatch();
            st.Start();

            Console.WriteLine("Welcome to the menu, buddy.\nChoose '1' if you would like to run Program 1.\nChoose '2' if you would like to run Program 2.\nChoose '3' if you would like to run Program 3.");
            int input = int.Parse(Console.ReadLine());


            // Task 1
            if (input == 1)
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("\nHello " + name + ".");

                Console.Write("\nPlease enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Please enter your gender, 'm' or 'f': ");
                char gender = char.Parse(Console.ReadLine());
                Console.Write("Please enter your address: ");
                string address = Console.ReadLine();

                Console.WriteLine("\nThank you. Your details are as follows:\nAge: {0}\nGender: {1}\nAddress: {2}", age, gender, address);
            }
            else if (input == 2)
            {
                Console.WriteLine("Please choose a number.");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please choose a second number.");
                double num2 = double.Parse(Console.ReadLine());

                double total1 = num1 + num2;
                double total2 = num1 - num2;
                double total3 = num1 * num2;
                double total4 = num1 / num2;

                Console.Write("\n{0} + {1} = {2}\n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}", num1, num2, total1, total2, total3, total4);
            }
            else if (input == 3)
            {
                Console.Write("Please enter your first name: ");
                string firstn = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                string lastn = Console.ReadLine();

                string fullname = firstn + " " + lastn;
                Console.WriteLine("\nHello, " + fullname + "!");
            }
            else
            {
                Console.WriteLine("Sorry, we didn't understand your input. Please try again.");
            }


            st.Stop();
            Console.Write("\nCongradulations, you have wasted " + st.Elapsed + "seconds of your life.");
            Console.ReadLine();

        }
    }
}
