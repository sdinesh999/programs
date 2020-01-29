using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Memory_Management

{
    /// <summary>
    /// Implementing destructor to release resources which internally calls finalize method
    /// </summary>

    class Destructor

    {

        public Destructor()

        {

            Console.WriteLine("Calling class2 constructor . . .");

        }

        ~Destructor()

        {

            Console.WriteLine("Calling class2 Destructor . . .");

        }

    }

}