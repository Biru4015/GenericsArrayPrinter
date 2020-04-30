using System;
using System.Collections.Generic;
using System.Text;
using ArrayPrinter;

namespace ArrayPrinter
{
    class GenericDemo
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
            PrintArray<int> array1 = new PrintArray<int>(a);
            PrintArray<double> array2 = new PrintArray<double>(b);
            PrintArray<char> array3 = new PrintArray<char>(c);
            array1.toPrint();
            array2.toPrint();
            array3.toPrint();
        }
    }
}
