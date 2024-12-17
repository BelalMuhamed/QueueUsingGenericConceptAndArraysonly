using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal partial class queue<T> where T : IComparable<T>
    {
        #region Capacity
        public int Capacity()
        {

            if (Counter == 0)
            {
                return 0;
            }
            else
            {
                return items.Length;
            }

        }

        #endregion

        #region Count
        public int Count()
        {
            if (Counter == 0)
            {
                return 0;
            }
            else
            {
                return Counter;
            }

        }
        #endregion

        #region TrimExcess
        public void TrimEcxess()
        {


                if (Counter > 0)
            {
                CpyItems = new T[Counter];
                Array.Copy(items, CpyItems, CpyItems.Length);
                items = CpyItems;


            }
            else
            {

                throw new NullReferenceException("Can't access null reference");

            }
        }
        #endregion

        #region Clear
        public void Clear()
        {
            if (Counter > 0)
            {
                Array.Clear(items, 0, items.Length);
                Counter = 0;
                



            }
            else
            {

                throw new NullReferenceException("Can't access null reference");

            }
        }
        #endregion
    }
}
