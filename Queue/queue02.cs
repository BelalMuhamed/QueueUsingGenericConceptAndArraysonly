using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal partial class queue<T>
    {
        #region Enqueue
        public void Enqueue(T item)
        {


            if (Counter == items.Length - 1)
            {
                CpyItems = new T[size * 2];
                Array.Copy(items, CpyItems, items.Length);
                items = CpyItems;
                try
                {
                    items[Counter++] = item;
                }
                catch (Exception ex)
                {
                    throw new InvalidDataException("invalid type of data");
                }

            }
            else
            {
                try
                {
                    items[Counter++] = item;
                }
                catch (Exception ex)
                {
                    throw new InvalidDataException("invalid type of data");
                }
            }
        }

        #endregion

        #region Dequeue
        public T Dequeue()
        {
            if (Counter > 0)
            {
                T ResultItem = items[0];
                for (int i = 0; i <Counter; i++)
                {
                    items[i] = items[i + 1];
                }
                Counter--;
                if (Counter <= items.Length / 4 && items.Length > size)
                {
                    T[] newItems = new T[items.Length / 2];
                    Array.Copy(items, newItems, Counter);
                    items = newItems;
                }
                return ResultItem;

            }
            else
            {
                throw new NullReferenceException("The Queue is Empty");
            }

        }
        #endregion

        #region Peek
        public T Peek()
        {
            if(Counter > 0)
            {
                return items[0];
            }
            else
            {
                throw new NullReferenceException("The Queue is Empty");
            }
        }
        #endregion

        #region IsEmpty
        public bool ISEmpty()
        {
             return (Counter==0);
        }
        #endregion
    }
}
