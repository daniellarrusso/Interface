using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDummies
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student[] students = Student.CreateStudentList();
            Array.Sort(students);
            DisplayStuff(students);

            Console.ReadLine();
        }

        static void DisplayStuff(IDisplayable[] displayables)
        {
            foreach (IDisplayable displayable in displayables)
            {
                Console.WriteLine(displayable.Display());
            }
        }
       
    }
}
