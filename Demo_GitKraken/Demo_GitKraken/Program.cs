using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GitKraken
{
    class Program
    {
        static void Main(string[] args)
        {
            string justinsResponse;
            Console.WriteLine("Justin's first edit and check in, please type something in:");
            justinsResponse = Console.ReadLine();
            Console.WriteLine("You entered: {0}", justinsResponse);



            // Bob's edit for a pull request
            Console.BackgroundColor = ConsoleColor.Green;

            // testing an edit for a pull ddd
            // Making Christmas Colors
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
            return;
            
        }
    }
}
