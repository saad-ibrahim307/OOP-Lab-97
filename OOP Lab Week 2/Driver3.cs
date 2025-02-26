using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    internal class Driver3
    {
        static void Main(string[] args)
        {
            ATM a = new ATM();

            a.deposit(75);
            a.withdraw(140);
            a.check_balance();
            a.withdraw(300);
            a.deposit(400);
            a.withdraw(350);
            a.history();
            a.check_balance();

        }
    }
}
