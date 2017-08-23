using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Sorting.Sorts
{
    public class SelectionSort : SortBase, ISort
    {
        public void Sort( ref long[] inputArray )
        {           
            int minIndex;
            //int numberOfPass = 0;
            for( int i = 0 ; i < inputArray.Length - 1 ; i++ )
            {
                minIndex = i;

                for( int j = i + 1 ; j < inputArray.Length ; j++ )
                {
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }
                    //numberOfPass++;
                }

                if( minIndex != i )
                {
                    Swap( ref inputArray[minIndex], ref inputArray[i] );
                }

            }
            //WriteLine( $"\nNumber of Passes Selection: {numberOfPass}" );
        }
    }
}
