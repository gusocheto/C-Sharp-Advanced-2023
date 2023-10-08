using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public void Push(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            this.items[Count] = item;
            Count++;
        }
        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }
            int removed = items[Count - 1];
            items[Count - 1] = default;
            Count--;

            //Shrink : TO:DO

            return removed;
        }
        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            } 

            return items[Count - 1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = Count-1; i >= 0; i--)
            {
                action(this.items[i]);
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
    }
}
