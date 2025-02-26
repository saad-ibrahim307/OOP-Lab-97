using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public static class SubjectDL
    {
        public static List<SubjectBL> subjectList = new List<SubjectBL>();

        public static void addtoList(SubjectBL subject)
        {
            subjectList.Add(subject);
        }
    }
}