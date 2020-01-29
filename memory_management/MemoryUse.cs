using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    /// <summary>
    /// deallocating resources by 'using' keyword
    /// </summary>
    class MemoryUse
    {
        static void Main(string[] args)
        {
            Console.Title = "Use of using Keyword";
            // To release the resources manually
            #region 
            MyResourceClass ms1 = new MyResourceClass();
            try
            {
                ms1.DoSomeTask();
            }
            finally
            {
                ms1.Dispose();
            }
            #endregion
            // To release the resources automatically by 'using' keyword 
            #region   
            using (MyResourceClass ms = new MyResourceClass())
            {
                ms.DoSomeTask();
            }
            #endregion
            Console.ReadKey();
        }
    }
}
