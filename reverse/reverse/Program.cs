using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            string  reverse = "";
            for (int i = name.Length-1; i > -1; i--)
            {
                reverse += name.ElementAt(i);
            }
            Console.WriteLine("Hi your name is: " + reverse);
            Console.ReadKey();
        }
    }
}
