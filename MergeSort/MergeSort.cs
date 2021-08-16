using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorted
{
    public class MergeSortThis
    {
        public int[] MergeSortMethod(int[] array) //creates a public static method that returns type array of ints.  It takes in an array of ints called array
        {
            int[] left;
            int[] right;
            int[] result  = new int[array.Length];
            /// Creates the arrays that each will be sorted into
            /// also creates the result array that each will be sorted into which will be set to the length of the array that was taken in. 
            
            if (array.Length <= 1)
            {
                return array;
            }

            int midpoint = array.Length / 2;

            left = new int[midpoint]; 

            if (array.Length % 2 == 0)
            {
                right = new int[midpoint];

            } else
            {
                right = new int[midpoint+1];
            }

            for (int i = 0; i < midpoint; i++)
            {
                left[i] = array[i];
            }

            int x = 0;

            for (int i = midpoint; i < array.Length; i++)
            {
                right[x] = array[i]; 
                x++;
            }

            left = MergeSortMethod(left);
            right = MergeSortMethod(right);
            result = Merge(left, right);
            return result;

        }
        
        public int[] Merge(int[] left, int[] right)
        {
            int resultLenght = right.Length + left.Length;
            int[] result = new int[resultLenght];

            int indexLeft = 0, indexRight = 0, indexResult = 0;
            ///while either array still has more than 1 element. 
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (left[indexLeft] <= right[indexRight])
                {
                    result[indexLeft] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if(right[indexRight] >= left[indexLeft])
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
                if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
                
            }
            return result; 
        }
       
    }
}
