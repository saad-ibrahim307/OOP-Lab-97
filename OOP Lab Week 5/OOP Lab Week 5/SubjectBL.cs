using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public class SubjectBL
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee;

        public SubjectBL(string code, int creditHours, string subjectType, int subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
    }
}