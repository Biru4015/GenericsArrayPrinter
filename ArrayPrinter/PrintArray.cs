using System;

namespace ArrayPrinter
{
    /// <summary>
    /// This class contains the code for printing generic type array
    /// </summary>
    public class PrintArray<X,Y,Z>
    {
        X[] myXArray;
        Y[] myYArray;
        Z[] myZArray;

        public PrintArray(X[] myXArray,Y[] myYArray,Z[] myZArray)
        {
            this.myXArray = myXArray;
            this.myYArray = myYArray;
            this.myZArray = myZArray;
        }

        public void toPrint()
        {
            toPrint(myXArray);
            toPrint(myYArray);
            toPrint(myZArray);
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
