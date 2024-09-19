using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstProject
{
    class Program
    {
        // This is a method called "Main"
        // Our program starts from here
        static void Main(string[] args)
        {
            

            string[] names= new string[3];
            names[0] = "Example1";
            names[1] = "Example2";
            names[2] = "Example3";

            string[] names02 =
            {
                "Example1",
                "Example2",
                "Example3"
            };

            Console.WriteLine(names[2]);
            Console.WriteLine(names02[1]);
        }
    }
}