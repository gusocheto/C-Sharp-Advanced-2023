using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    internal class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElement = 0;

        private int[] items;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

       
        public void Enqueue(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }
	
        public int Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            
            int removedItem = items[FirstElement];
            ShiftLeft();

            //if needed shrink // TO:DO

            Count--;
            return removedItem;
        }
	
       public void Clear()
       {
            if (items.Length == 0) 
            {
                throw new InvalidOperationException();
            }
            items = new int[InitialCapacity];
            Count = 0;
       }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }

            return items[FirstElement];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(this.items[i]);
            }
        }

        private void ShiftLeft()
        {
            for (int i = FirstElement; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = default;
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
    }
}
