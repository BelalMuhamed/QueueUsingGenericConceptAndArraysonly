using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal partial class queue<T> where T : IComparable<T>
    {
        #region Members   
        T[] items = new T[size];
        T[] CpyItems;
        const int size = 4;
        int Counter = 0;
        #endregion

        
    }
}
