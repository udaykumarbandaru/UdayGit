using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter names with coma seperated value");
            string[] names = (Console.ReadLine()).Split(',');

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Hello {names[i]}");
            }

            Console.ReadLine();
        }
    }
}
