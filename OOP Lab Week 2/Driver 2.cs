using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    internal class Driver_2
    {
        static void driver_2(string[] args)
        {
            Calculator c = new Calculator(15, 7);

            Console.WriteLine($"Addition: {c.addition()}");
            Console.WriteLine($"Subtraction: {c.subtraction()}");
            Console.WriteLine($"Multiplication: {c.multiply()}");
            Console.WriteLine($"Division: {c.divide()}");
        }
    }
}
