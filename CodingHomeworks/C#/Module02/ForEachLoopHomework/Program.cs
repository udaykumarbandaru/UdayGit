using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoopHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> firstnames = new List<string>();
            string exitText = string.Empty;

            do
            {
                Console.WriteLine("please enter firstname");
                firstnames.Add(Console.ReadLine());
                Console.WriteLine("please enter 'YES/NO' if you want to enter another name");
                exitText = Console.ReadLine();

            } while (exitText.ToLower()=="yes");

            foreach (string item in firstnames)
            {
                Console.WriteLine($"Hello {item}");
            }

            Console.ReadLine();
        }
    }
}
