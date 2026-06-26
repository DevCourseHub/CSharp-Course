using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Name");
            string A=Console.ReadLine(); //We use this command like this to take input from user.
            Console.WriteLine("Good Morning " + A);
            Console.ReadLine(); //here we use it to pause the output
        }
    }
}
