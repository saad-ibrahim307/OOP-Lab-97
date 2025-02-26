using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    internal class Driver
    {
        static void driver(string[] args)
        {
            transaction t1 = new transaction();
            t1.TransactionID = 1;
            t1.ProductName = "Cigarettes";
            t1.Amount = 20;
            t1.DateTime = "16:00 12/4/2021";

            transaction t2 = new transaction(t1);

            t2.TransactionID = 2;
            t2.Amount = 15;
            t2.DateTime = "03:00 25/12/2024";

            Console.WriteLine(t1.TransactionID);
            Console.WriteLine(t1.ProductName);
            Console.WriteLine(t1.Amount);
            Console.WriteLine(t1.DateTime);
            Console.WriteLine(" ");
            Console.WriteLine(t2.TransactionID);
            Console.WriteLine(t2.ProductName);
            Console.WriteLine(t2.Amount);
            Console.WriteLine(t2.DateTime);

        }
    }
}
