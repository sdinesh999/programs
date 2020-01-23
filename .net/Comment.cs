using System;

namespace MyFirstProject1
{
    class Comment
    {
        /// <summary>
        /// mutliplying the given two numbers and displaying the output.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <remarks>
        /// multiplication of two numbers
        /// </remarks>
        /// <returns></returns>
        public static int MulNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// substracting the given two numbers and displaying output
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <remarks>
        /// performing math calculations
        /// </remarks>

        public static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// adding the given two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <remarks>
        /// performing math calculations
        /// </remarks>
        /// <list>
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine(MulNumbers(2, 3));
            Console.WriteLine(Substract(6, 8));
            Console.WriteLine(Addition(4, 7));
        }
    }

}