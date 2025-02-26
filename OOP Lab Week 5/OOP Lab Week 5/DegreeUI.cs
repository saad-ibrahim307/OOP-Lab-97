using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public static class DegreeUI
    {
        public static void printDegreeList()
        {
            foreach (var v in DegreeDL.degreeList)
            {
                Console.WriteLine(v.title);
            }
        }
    }
}