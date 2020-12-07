using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Program
    {
        private static Dictionary<string, int> guestDetails = new Dictionary<string, int>();

        private static int guestCount = 0;

        static void Main(string[] args)
        {
            loadGuests();

            DisplayGuestNames();

            DisplayTotalGuests();

            Console.ReadLine();

        }

        private static void loadGuests()
        {
          string exitText = string.Empty;
            do
            {
                guestDetails.Add(GetUserName(), GetGuestCount());
                exitText = someMoreGuests();
            } while (exitText == "yes");
        }

        private static void DisplayGuestNames()
        {
            foreach (var item in guestDetails)
            {
                Console.WriteLine($"Guest {item.Key} is attended along with other {item.Value - 1} guests");
                guestCount += item.Value;
            }
        }

        private static void DisplayTotalGuests()
        {
            Console.WriteLine($"Total number of guests attended to the party are {guestCount}");
        }

        private static string GetUserName()
        {
            Console.WriteLine("Please enter your name");
            return Console.ReadLine();
        }

        private static int GetGuestCount()
        {
            Console.WriteLine("Please enter guest count");
            int.TryParse(Console.ReadLine(),out int count);
            return count;
        }

        private static string someMoreGuests()
        {
            Console.WriteLine("Please enter 'YES' if another guest comes and enter 'NO' if people stopped coming to party");
            return Console.ReadLine().ToLower();
        }
    }
}
