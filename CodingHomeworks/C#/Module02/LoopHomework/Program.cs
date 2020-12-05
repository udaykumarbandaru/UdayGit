using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueResult = "";

            do // One or more times
            {
                Console.Write("What is your first name: ");
                string firstName = Console.ReadLine();

                if (firstName.ToLower()=="tim")
                {
                    Console.WriteLine("Hello Professor");
                }
                else
                {
                    Console.WriteLine(@"Hello {0}",firstName);
                }

                Console.WriteLine("Please enter 'exit' if you want to come out of application");

                continueResult = Console.ReadLine();

            } while (continueResult.ToLower() != "exit");

            Console.ReadLine();
        }
    }
}
