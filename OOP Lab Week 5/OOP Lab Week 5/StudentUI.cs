using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public class StudentUI
    {
        public static void printStudentDetails()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");

            foreach (StudentBL s in StudentDL.studentList)
            {
                Console.WriteLine($"{s.name}\t{s.FSCMarks}\t{s.EcatMarks}\t{s.age}");
            }
        }
    }
}