using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    public class ATM
    {
        float balance;
        int count;
        string[] transactions = new string[20];
        public ATM()
        {
            balance = 200; 
            count = 0;
        }

        public void deposit(float amount)
        {
            balance += amount;
            transactions[count] = $"Deposit: {amount}";
            count++;
        }

        public void withdraw (float amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient Balance");
                transactions[count] = $"Withdrew: {amount} INSUFFICIENT BALANCE";
                count++;
            }
            else
            {
                balance -= amount;
                transactions[count] = $"Withdrew: {amount}";
                count++;
            }
        }    

        public void check_balance()
        {
            Console.WriteLine($"Current Balance: {balance}"); 
        }

        public void history()
        {
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(transactions[i]);
            }
        }


        
    }
}
