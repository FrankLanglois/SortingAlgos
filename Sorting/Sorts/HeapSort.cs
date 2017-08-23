using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Sorting.Sorts
{
    public class HeapSort : SortBase, ISort
    {
        public void Sort( ref long[] inputArray )
        {
            var heapSize = inputArray.Length;
            for( int i = heapSize / 2 ; i >= 0 ; i-- )
            {
                MaxHeapify(ref inputArray, heapSize, i );
            }
            for( int i = heapSize -1 ; i >= 0 ; i-- )
            {
                Swap( ref inputArray[0], ref inputArray[i] );
                MaxHeapify(ref inputArray, i, 0);
            }
        }

        private void MaxHeapify(ref long[] inputArray, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if( left < heapSize && inputArray[left] > inputArray[index] )
                largest = left;
            else
                largest = index;

            if( right < heapSize && inputArray[right] > inputArray[largest] )
                largest = right;

            if( largest != index )
            {
                long temp = inputArray[index];
                inputArray[index] = inputArray[largest];
                inputArray[largest] = temp;

                MaxHeapify(ref inputArray, heapSize, largest );
            }
        }
    }
}
