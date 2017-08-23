using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Sorts
{
    public class InsertionSort : SortBase, ISort
    {
        public void Sort( ref long[] inputArray )
        {
            for( int i = 0 ; i < inputArray.Length ; i++ )
            {
                var element = inputArray[i];
                var j = i;

                while( j > 0 && inputArray[j-1] > element )
                {
                    inputArray[j] = inputArray[j - 1];
                    j--;
                }
                inputArray[j] = element;
            }
        }
    }
}
