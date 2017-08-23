using System;
using System.Diagnostics;
using Sorting.Sorts;
using static System.Console;

namespace Sorting
{
    class Program
    {
        static void Main( string[] args )
        {
            WindowTop = 0;
            WindowHeight = 80;

            //long[] inputArray = new long[10] { 89, 76, 45, 92, 67, 12, 99, 5, 52, 43 };
            long[] inputArray = new long[20000];
            Random rnd = new Random();

            for( int i = 0 ; i < inputArray.Length ; i++ )
            {
                inputArray[i] = rnd.Next();
            }

            long[] orignalInputArray = (long[])inputArray.Clone();
            
            DoSort<BubbleSort>( ref inputArray );           

            inputArray = (long[])orignalInputArray.Clone();
                      

            DoSort<SelectionSort>( ref inputArray );

            inputArray = (long[])orignalInputArray.Clone();

            DoSort<InsertionSort>( ref inputArray );

            inputArray = (long[])orignalInputArray.Clone();

            DoSort<HeapSort>( ref inputArray );

            inputArray = (long[])orignalInputArray.Clone();

            DoSort<QuickSort>( ref inputArray );

           

            //WriteArray( inputArray, nameof( inputArray ) );
            ReadKey();
        }

        static private void DoSort<T>( ref long[] inputArray ) where T : ISort, new()
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            ISort sortClass = new T();
            sortClass.Sort(ref inputArray );
            stopwatch.Stop();

            WriteLine( $"\n{typeof(T).Name}: {stopwatch.Elapsed.TotalMilliseconds}" );
        }        

        static private void WriteArray(long[] inputArray, string arrayName)
        {            
            WriteLine( $"\n{arrayName}:" );
            for( int i = 0 ; i < inputArray.Length ; i++ )
            {
                WriteLine( $"\t{inputArray[i]}" );
            }
        }   
    }
}