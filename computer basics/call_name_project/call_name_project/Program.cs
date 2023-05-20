using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_name_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("enter any key to continue...");
            Console.ReadKey();

        }
    }
}
