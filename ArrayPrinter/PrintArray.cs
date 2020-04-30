using System;

namespace ArrayPrinter
{
    /// <summary>
    /// This class contains printing array
    /// </summary>
    class PrintArray
    {
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            double[] b = { 12.3, 20.5, 30.8, 50.3 };
            char[] c = { 'a', 'b', 'c', 'd', 'e' };
            toPrint(a);
            toPrint(b);
            toPrint(c);
        }

        /// <summary>
        /// This method is created for printing integer type array
        /// </summary>
        /// <param name="a"></param>
        private static  void toPrint(int[] a)
        {
            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This method is created for printing double type array
        /// </summary>
        /// <param name="b"></param>
        private static void toPrint(double[] b)
        {
            foreach (double item in b)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This method is created for printing character type array
        /// </summary>
        /// <param name="c"></param>
        private static void toPrint(char[] c)
        {
            foreach (char item in c)
            {
                Console.WriteLine(item);
            }
        }

    }
}
