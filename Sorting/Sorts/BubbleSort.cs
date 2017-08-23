using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Sorting.Sorts
{
    public class BubbleSort : SortBase, ISort
    {
        public void Sort( ref long[] inputArray )
        {
            //int numberOfPass =0;
            bool isStillSorting = true;
            for( int iterator = 0 ; iterator < inputArray.Length && isStillSorting ; iterator++ )
            {
                isStillSorting = false;
                //WriteLine( $"Iterator: {iterator} -----------------------------" );
                for( int index = 0 ; index < inputArray.Length - 1 ; index++ )
                {
                    //WriteLine( $"Index: {index}" );
                    //WriteLine($"\n{ inputArray[index]} - {inputArray[index + 1]}");
                    if( inputArray[index] > inputArray[index + 1] )
                    {
                        Swap(ref inputArray[index], ref inputArray[index + 1] );
                        isStillSorting = true;
                    }
                    //numberOfPass++;
                    //WriteArray( inputArray, nameof( inputArray ) );
                    //WriteLine($"isStillSorting: {isStillSorting}");

                }
            }
            //WriteLine($"\nNumber of Passes Bubbles: {numberOfPass}");
        }

        private void WriteArray( long[] inputArray, string arrayName )
        {
            WriteLine( $"\n{arrayName}:" );
            for( int i = 0 ; i < inputArray.Length ; i++ )
            {
                Write( $"{inputArray[i]} " );
            }
            WriteLine("\n");
        }
    }
}
