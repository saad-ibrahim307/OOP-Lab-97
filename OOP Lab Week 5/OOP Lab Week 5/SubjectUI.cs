using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public class SubjectUI
    {
        public static void displayDetails(SubjectBL subject)
        {
            Console.WriteLine(subject.code);
            Console.WriteLine(subject.subjectType);
            Console.WriteLine(subject.creditHours);
            Console.WriteLine(subject.subjectFee);
        }
    }
}