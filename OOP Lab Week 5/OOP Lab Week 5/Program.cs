using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_5
{
    internal class Program
    {
        static void addUser()
        {
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter FSC Marks: ");
            float fmarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ecat Marks: ");
            float emarks = float.Parse(Console.ReadLine());

            StudentBL student = new StudentBL(name, age, fmarks, emarks);

            StudentDL.addtoList(student);

            Console.WriteLine("Available Degree Programs: ");
            DegreeUI.printDegreeList();

            Console.WriteLine("Enter how many preferences to Enter: ");
            int prefs = int.Parse(Console.ReadLine());

            for (int i = 0; i < prefs; i++)
            {
                string title = Console.ReadLine();

                foreach (var v in DegreeDL.degreeList)
                {
                    if (v.title == title)
                    {
                        student.addDegree(v);
                    }
                }
            }
        }

        static void addDegree()
        {
            Console.WriteLine("Enter degree title: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter degree duration: ");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seats for degree: ");
            int seats = int.Parse(Console.ReadLine());

            DegreeBL degree = new DegreeBL(name, duration,seats);

            DegreeDL.addtoList(degree);

            Console.WriteLine("Enter how many subjects to Enter: ");
            int prefs = int.Parse(Console.ReadLine());

            for (int i = 0; i < prefs; i++)
            {
                Console.WriteLine("Enter Subject Code: ");
                string code = Console.ReadLine();

                Console.WriteLine("Enter Subject Tyoe: ");
                string type = Console.ReadLine();

                Console.WriteLine("Enter Credit Hours: ");
                int cH = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Fees: ");
                int fees = int.Parse(Console.ReadLine());

                SubjectBL subject = new SubjectBL(code, cH, type, fees);

                

                if ( (degree.isSubjectExist(subject) || degree.calculateCreditHours() > 20 ) )
                {
                    continue;
                }

                else 
                { 
                    degree.addSubject(subject);

                    SubjectDL.addtoList(subject); 
                 }

                
            }
        }

        static void Main(string[] args)
        {
            int option;

            while (true)
            {
                Console.Clear();
                ConsoleUtility.printMenu();
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    addUser();
                }

                else if (option == 2)
                {
                    addDegree();
                }

                else if option == 3
                else if (option == 4)
                {
                    Console.Clear();
                    StudentUI.printStudentDetails();
                    Console.ReadKey();
                }

            }
        }
    }
}
