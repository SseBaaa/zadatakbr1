using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            float ostatak = a/b;

            Console.WriteLine("a podijeljeno s b je " +  Math.Abs(a/b) + " a ostatak je " + ".5"+ Math.Truncate(ostatak));


            Console.ReadKey();
        }
    }
}
