using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDummies
{
    public class Student : IDisplayable, IComparable<Student>
    {
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }
        public string Name { get; private set; }
        public double Grade { get; private set; }

        // Create an Array of students and grades

        static string[] names = { "Nathan", "Daniel", "Sophie", "Martha" };
        static double[] grades = { 5, 10, 2, 45 };

        // Return an array of students
        public static Student[] CreateStudentList()
        {
            Student[] students = new Student[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                students[i] = new Student(names[i], grades[i]);
            }

            return students;
        }

        public string Display()
        {
            string padName = Name+":".PadRight(8);
            return string.Format(padName + Grade);
        }

        public int CompareTo(Student rightStudent)
        {
            Student leftStudent = this;
            if (leftStudent.Grade > rightStudent.Grade)
            {
                return -1;
            }
            if (leftStudent.Grade < rightStudent.Grade)
            {
                return 1;
            }
            return 0;
        }



      
    }
}
