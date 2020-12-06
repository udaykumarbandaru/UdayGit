using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> EmployeeDetails = new Dictionary<int, string>();

            EmployeeDetails.Add(1001, "Uday");
            EmployeeDetails.Add(1002, "Venky");
            EmployeeDetails.Add(1003, "Srikanth");
            EmployeeDetails.Add(1004, "Mani");

            bool isVal = false;
            string userID = string.Empty;
            int ID = 0;

            do
            {
                Console.WriteLine("Please enter your ID");
                userID = Console.ReadLine();

                isVal = int.TryParse(userID, out ID);

                while(!EmployeeDetails.ContainsKey(ID))
                {
                    Console.WriteLine("You have enetered a wrong ID, ID doesn't exist in our system. Please enter your ID Again");
                    userID = Console.ReadLine();
                    isVal = int.TryParse(userID, out ID);
                }
                                
            } while (isVal == false);

            Console.WriteLine($"ID is {ID} and name is {EmployeeDetails[ID]}");
            Console.ReadLine();
        }
    }
}
