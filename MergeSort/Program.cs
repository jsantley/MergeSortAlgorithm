using MergeSorted;
using System;

namespace MergeSorted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] myArray = { 23, 45, 65, 87, 22, 1, 85, 236 };
            MergeSortThis mergeSortThis = new MergeSortThis();
            mergeSortThis.MergeSortMethod(myArray);
        }

    }  
}
