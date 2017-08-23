using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class SortBase
    {        
        protected void Swap( ref long valOne, ref long valTwo )
        {
            long temp = valOne;
            valOne = valTwo;
            valTwo = temp;
        }
    }
}
