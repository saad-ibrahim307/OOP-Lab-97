using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    public class transaction
    {
        public int TransactionID;
        public string ProductName;
        public float Amount;
        public string DateTime;

        public transaction()
        {

        }

        public transaction(transaction t)
        {
            TransactionID = t.TransactionID;
            ProductName = t.ProductName;
            Amount = t.Amount;
            DateTime = t.DateTime;
        }
    }
}
