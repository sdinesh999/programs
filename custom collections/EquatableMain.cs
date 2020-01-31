
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquatableDemo
{
    class EquatableMain
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("sai", "Geert Verhoeven");
            ArrayList employees = new ArrayList();
            employees.Add(emp1);
            Employee emp2 = new Employee("sai", "Geert");

            // Comparing with an object from the same class.
            Console.WriteLine("emp1.Equals(emp2): {0}", emp1.Equals(emp2));
            // Comparing with an object from a different class.
            Object obj = emp2;
            Console.WriteLine("emp1.Equals(obj): {0}", emp1.Equals(obj));
            //  Using an ArrayList
            Console.WriteLine("employees.Contains(emp2): {0}",
            employees.Contains(emp2));
            Console.ReadLine();
        }
    }
}