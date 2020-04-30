using System;

namespace ArrayPrinter
{
    /// <summary>
    /// This class contains the code for printing generic type array
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
        /// This method is created for printing geneeric type array
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="a"></param>
        private static  void toPrint<E>(E[] a)
        {
            foreach(E item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
