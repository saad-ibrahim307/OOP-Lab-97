using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_Week_5
{
    public class DegreeBL
    {
        public string title;
        public int duration;
        public int seats;
        public List<SubjectBL> subjects = new List<SubjectBL>();
            
        public DegreeBL (string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        public void addSubject (SubjectBL subject)
        {
            this.subjects.Add(subject);
        }

        public bool isSubjectExist(SubjectBL subject)
        {
            foreach (SubjectBL var in this.subjects)
            {
                if (subject == var) return true;

            }

            return false;
        }

        public int calculateCreditHours()
        {
            int creditHours = 0;
            foreach(SubjectBL var in this.subjects)
            {
                creditHours += var.creditHours;

            }

            return creditHours;
        }

    }
}