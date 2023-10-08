using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Implementing_Stack_and_Queue
{
    internal class CustumList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustumList()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ThrowExceptionIfIndexOutOfRange(index);
                return items[index];
            }
            set
            {
                ThrowExceptionIfIndexOutOfRange(index);
                items[index] = value;
            }
        }
        public void Add(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            this.items[Count] = item;
            Count++;
        }
        public void AddRange(int[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        public int RemoveAtIndex(int index)
        {
            ThrowExceptionIfIndexOutOfRange(index);
            int removedItem = items[index];
            ShiftLeft(index);
            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return default;
        }
        public int InsertAt(int index, int item)
        {
            ThrowExceptionIfIndexOutOfRange(index);
            if (items.Length == Count)
            {
                Resize();
            }
            ShiftRight(index);
            items[index] = item;
            Count++;
            return default;
        }
        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            ThrowExceptionIfIndexOutOfRange(firstIndex);
            ThrowExceptionIfIndexOutOfRange(secondIndex);

            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
        public int Find(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return item;
                }
            }
            return default;
        }

        public void Reverse()
        {
            int[] reversed = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                reversed[i] = items[Count - 1 - i];
            }
            items = reversed;
        }


        private void ThrowExceptionIfIndexOutOfRange(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Invalid Index Value");
            }
        }
        private void Resize() 
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++) 
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = default;
        }
        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }

        //If you have good ideas to implement new functionalities, like Find(), Reverse() or overriding ToString methods, feel free to do it.


    }
}
