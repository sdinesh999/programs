using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CollectionClass
{
    class AllCollectionClass
    {
        ArrayList marks = new ArrayList();

        Hashtable openWith = new Hashtable();

        Queue myqueue = new Queue();

        Stack mystack = new Stack();

        public AllCollectionClass()
        {

            Console.WriteLine("Adding elements to Arraylist. . .");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Adding {0}/{1} to Arraylist", marks.Count, marks.Capacity);
                marks.Add(i);
            }
            Console.WriteLine();
            Console.WriteLine("Adding elements to Hashtable . . .");

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("Elements present in the Hashtable are ...");
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Adding Elements to myQueue . . .");
            for (int i = 1; i < 15; i++)
            {
                myqueue.Enqueue(i * 255);
            }
            Console.WriteLine("Retriving elements from the queue");
            while (myqueue.Count != 0)
            {
                var a = myqueue.Dequeue();
                Console.WriteLine("{0} => Enqueued element ", a);
            }
            Console.WriteLine();
            Console.WriteLine("Adding elements into Stack");
            for (int i = 1; i < 15; i++)
            {
                mystack.Push(i * 255);
            }
            Console.WriteLine("Poping elements from stack");
            while (mystack.Count != 0)
            {
                var a = mystack.Pop();
                Console.WriteLine("{0} => is the poped element", a);
            }
            Console.WriteLine();
        }
    }
}
