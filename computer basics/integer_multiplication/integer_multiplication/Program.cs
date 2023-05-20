using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("please enter a number:");
            string number = Console.ReadLine();
            num = int.Parse(number);
            num *= 3;
            Console.WriteLine(num);
            Console.WriteLine("enter any key to continue...");
            Console.ReadKey();
        }
    }
}
