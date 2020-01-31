using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class AllGenericClass
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();

        List<int> l = new List<int>();

        Queue<string> numbers = new Queue<string>();

        SortedList<string, string> slist = new SortedList<string, string>();

        Stack<string> calledStack = new Stack<string>();


        public AllGenericClass()
        {
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("Retrieving data from Dictionary");
            foreach (KeyValuePair<string, string> kvp in openWith)
            {

                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            Console.WriteLine("Adding elements into list . . .");
            for (int i = 1; i < 5; i++)
            {
                l.Add(i);
            }

            Console.WriteLine("Retrieving data . . .");
            foreach (var i in l)
            {
                Console.Write(i + " ");
            }

            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            Console.WriteLine("Retrieving data from Queue . . .");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            slist.Add("txt", "notepad.exe");
            slist.Add("bmp", "paint.exe");
            slist.Add("dib", "paint.exe");
            slist.Add("rtf", "wordpad.exe");

            Console.WriteLine("Retrieving data from Sorted list");
            foreach (var s in slist)
            {
                Console.WriteLine("key = {0} and value = {1}", s.Key, s.Value);
            }

            calledStack.Push("Rohit");
            calledStack.Push("KL Rahul");
            calledStack.Push("Kohli");
            calledStack.Push("Bumrah");

            Console.WriteLine("Poping elements form stack");
            while (calledStack.Count != 0)
            {
                string a = calledStack.Pop();
                Console.WriteLine("Poped string is => {0}", a);
            }

        }
    }

}
