using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollection
{
    public class ConcurrentClass
    {
        BlockingCollection<int> bc = new BlockingCollection<int>(1);

        ConcurrentDictionary<string, string> cd = new ConcurrentDictionary<string, string>();

        ConcurrentDictionary<string, string> cd1 = new ConcurrentDictionary<string, string>();
        int item;


        /// <summary>
        /// Represents a thread-safe first in-first out (FIFO) collection. 
        /// </summary>
        ConcurrentQueue<int> numberstore = new ConcurrentQueue<int>();

        /// <summary>
        /// ConcurrentBag : It allows generic data to be stored in unordered from
        /// </summary>

        ConcurrentBag<int> bag = new ConcurrentBag<int>();

        public ConcurrentClass()
        {
            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    bc.Add(i);
                    Console.WriteLine("added item - " + i);
                }
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    var item = bc.Take();
                    Console.WriteLine("took out item - " + item);
                }

            });

            Task.WaitAll(t1, t2);

            Console.WriteLine("Trying Concurrent Dictionary . . .");

            cd.TryAdd("1", "First");
            cd.TryAdd("2", "Second");
            cd.TryAdd("3", "Third");
            cd.TryAdd("4", "Fourth");

            foreach (var item in cd)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }

            Console.WriteLine("Concurrent dictionary");
            Task tdot = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 7; ++i)
                {
                    Console.WriteLine("Running tdot");
                    cd1.TryAdd(i.ToString(), i.ToString());
                    Thread.Sleep(100);
                }
            });

            Task t2dot = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(300);
                foreach (var item in cd1)
                {
                    Console.WriteLine("Running t2dot");
                    Console.WriteLine(item.Key + "-" + item.Value);
                    Thread.Sleep(150);
                }
            });

            try
            {
                Task.WaitAll(t1, t2);
            }
            catch (AggregateException ex) // No exception
            {
                Console.WriteLine(ex.Flatten().Message);
            }

            for (int i = 0; i < 6; i++)
            {
                numberstore.Enqueue(i);
            }


            bool isSuccessful = numberstore.TryPeek(out item);
            Console.WriteLine("Is this successful? Ans: {0}", isSuccessful);
            Console.WriteLine(item);

            // Adding elements into collectionbag
            for (int i = 0; i < 10; i++)
            {
                bag.Add(i * 255);
            }
            Console.WriteLine("Total number of elements in the collectionbag is {0}", bag.Count());

            bool result = bag.TryTake(out item);

            Console.WriteLine("TryTake takes the first value and returned {0}", result);


        }
    }
}
