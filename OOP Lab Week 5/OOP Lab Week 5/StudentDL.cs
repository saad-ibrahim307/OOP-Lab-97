using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_Lab_Week_5
{
    public static class StudentDL
    {
        public static List<StudentBL> studentList = new List<StudentBL>();


        public static void addtoList(StudentBL student)
        {
            studentList.Add(student);
        }
    }
}