using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    /// <summary>
    /// manually releasing the resources by using dispose method
    /// </summary>
    class MyResourceClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Releasing all the resources......");
        }
        public void DoSomeTask()
        {
            Console.WriteLine("Starting some task......");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing some task.....");
            }
        }
    }
}
