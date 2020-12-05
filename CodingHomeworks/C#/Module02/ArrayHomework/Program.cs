using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstnames = new string[] { "uday", "Kumar", "bandaru" };

            bool isVal = false;

            do
            {
                Console.WriteLine("Please enter values between 0 to 2");
                string option = Console.ReadLine();

                isVal = int.TryParse(option, out int num);


                if (num >2 || num <0)
                {
                    isVal = false;
                }
                
                if (isVal==true)
                {
                    Console.WriteLine($"firstname is {firstnames[num]}");
                }


            } while (isVal == false) ;


                Console.ReadLine();
        }
    }
}
