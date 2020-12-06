using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = GetUserName();
            WelcomeUser(name);
            Console.ReadLine();
        }

        private static string GetUserName()
        {
            Console.WriteLine("Please Enter Your Name");
            return Console.ReadLine();
        }

        private static void WelcomeUser(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
