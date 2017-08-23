using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Sorts
{
    public class QuickSort : SortBase, ISort
    {
        public void Sort( ref long[] inputArray )
        {
            Sort( ref inputArray, 0, inputArray.Length - 1 );
        }

        private void Sort( ref long[] inputArray, int left, int right)
        {           
            // For Recusrion  
            if( left < right )
            {
                int pivot = Partition(ref inputArray, left, right );

                if( pivot > 1 )
                    Sort(ref inputArray, left, pivot - 1 );

                if( pivot + 1 < right )
                    Sort(ref inputArray, pivot + 1, right );
            }
            
        }

       
        private int Partition(ref long[] inputArray, int left, int right )
        {
            long pivot = inputArray[left];
            while( true )
            {
                while( inputArray[left] < pivot )
                    left++;

                while( inputArray[right] > pivot )
                    right--;

                if( left < right )
                {
                    long temp = inputArray[right];
                    inputArray[right] = inputArray[left];
                    inputArray[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
