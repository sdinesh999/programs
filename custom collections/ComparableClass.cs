using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace CollectionImpl
{/// <summary>
/// sorting the data using comparable and comparer classses
/// </summary>
    class Student : IComparable<Student>
    {
        public int Roll
        {
            get;
            set;
        }
        public int Marks
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        // compareto method 
        public int CompareTo(Student obj)
        {
            if (this.Roll > obj.Roll)
                return 1;
            else if (this.Roll < obj.Roll)
            {
                return -1;
            }
            else
                return 0;
        }
    }


// compraring the marks using comparer interface
    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
}
