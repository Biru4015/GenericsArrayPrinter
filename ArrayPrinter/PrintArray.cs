using System;

namespace ArrayPrinter
{
    /// <summary>
    /// This class contains the code for printing generic type array
    /// </summary>
    public class PrintArray<E>
    {
        E[] myArray;

        public PrintArray(E[] myArray)
        {
            this.myArray = myArray;
        }

        public void toPrint()
        {
            toPrint(myArray);
        }

        /// <summary>
        /// This method is created for printing geneeric type array
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="a"></param>
        public  void toPrint<E>(E[] a)
        {
            foreach(E item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
