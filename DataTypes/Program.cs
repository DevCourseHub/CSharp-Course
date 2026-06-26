using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main()
        {
            int A=4; //4 bytes
            float B=5; // 4 bytes
            bool C=false;//2 bytes
            char D = 'A';//1 bytes
            string E = "Hello World";//2 bytes

            Console.WriteLine("The value of A is " + A);
            Console.WriteLine("The value of B is " + B);
            Console.WriteLine("The value of C is " + C);
            Console.WriteLine("The value of D is " + D);
            Console.WriteLine("The value of E is " + E);
            Console.ReadLine();

        }
    }
}
