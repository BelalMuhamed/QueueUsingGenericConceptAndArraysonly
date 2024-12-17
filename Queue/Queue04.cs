using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal partial class queue<T> where T : IComparable<T>
    {
        #region ToArray
        public T[] ToArray()
        {
            TrimEcxess();
            if (Counter > 0)
            {
                CpyItems = new T[Counter];
                Array.Copy(items, CpyItems, items.Length);
                items = CpyItems;


            }
            else
            {

                throw new NullReferenceException("Can't access null reference");

            }
            return items;
        }
        #endregion


        #region Contains
        public bool Contains( T item)
        {
            if (Counter > 0)
                return items.Contains(item);
            else
                throw new NullReferenceException("cannot access null reference object");
        }
        #endregion
    }
}
