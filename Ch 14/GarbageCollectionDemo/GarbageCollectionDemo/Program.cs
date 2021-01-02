using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Console.WriteLine($"120 / 15 = {calculator.Divide(102, 15)}");
            //Console.WriteLine("Program finishing");

            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 0 = {calculator.Divide(102, 0)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
