using System;

namespace MyFirstProject1
{
    class Comment
    {
        /// <summary>
        /// multiplying two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int MulNumbers(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MulNumbers(2, 3));
        }
    }
}
