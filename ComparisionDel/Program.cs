using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionDel
{/// <summary>
/// comparing the student details by using delegates
/// </summary>
    public class StudentDetails
    {
        string studentName;
        int marks;

        public StudentDetails(string name, int score)
        {
            this.studentName = name;
            this.marks = score;
        }

        public string Name
        { get { return this.studentName; } }



        public int Marks
        { get { return this.marks; } }
        // comparing the student details based on the name
        public static int CompareByName(StudentDetails s1, StudentDetails s2)
        {
            return String.Compare(s1.Name, s2.Name);
        }
        // comparing the student details based on the marks
        public static int CompareByMarks(StudentDetails s1, StudentDetails s2)
        {
            return s1.Marks.CompareTo(s2.Marks);
        }
    }

    public class Program
    {
        public static void Main()
        {
            StudentDetails st1 = new StudentDetails("sai", 500);
            StudentDetails st2 = new StudentDetails("Dinesh", 600);
            StudentDetails st3 = new StudentDetails("kumar", 400);

            StudentDetails[] sts = { st1, st2, st3 };


            Array.Sort(sts, StudentDetails.CompareByName);

            Display(sts);


            // Sort array by population.
            Array.Sort(sts, StudentDetails.CompareByMarks);
            Display(sts);
        }
        // This method will display the details based on the names and marks
        private static void Display(StudentDetails[] sts)
        {
            foreach (var student in sts)
                Console.WriteLine("{0} {1}", student.Name,
                                  student.Marks);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
