using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public class StudentBL
    {
        public string name;
        public int age;
        public float FSCMarks;
        public float EcatMarks;
        public double merit;

        public List<DegreeBL> degrees = new List<DegreeBL>();
        public List<SubjectBL> subjects = new List<SubjectBL>();

        public StudentBL(string name, int age, float fSCMarks, float ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.FSCMarks = fSCMarks;
            this.EcatMarks = ecatMarks;
        }

        public void calculateMerit()
        {
            double m = (this.FSCMarks * .7) + (this.EcatMarks * .3);
            this.merit = m;
        }

        public void addDegree(DegreeBL degree)
        {
            this.degrees.Add(degree);
        }

        public int getCreditHours()
        {
            int creditHours = 0;
            foreach (SubjectBL s in subjects)
            {
                s.creditHours += creditHours;
            }
            return creditHours;
        }
    }
}