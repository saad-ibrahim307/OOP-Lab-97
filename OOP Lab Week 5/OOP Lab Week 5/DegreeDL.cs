using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public static class DegreeDL
    {
        static public List<DegreeBL> degreeList = new List<DegreeBL>();

        static public void addtoList(DegreeBL degree)
        {
            degreeList.Add(degree);
        }

    }
}