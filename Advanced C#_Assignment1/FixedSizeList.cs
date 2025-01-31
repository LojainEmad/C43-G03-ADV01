using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Advanced_C__Assignment1
{
    internal class FixedSizeList<T>
    {
        private List<T> list;
        private int capacity;
        public FixedSizeList(int cap)
        {
            if (cap <= 0)
            {
                throw new ArgumentException("Capacity must be greater than 0");
            }

            capacity = cap;
            list = new List<T>(cap);
        }
        public int Count
        {
            get { return list.Count; }
        }
        public int Capacity
        {
            get { return capacity; }
        }
        public void Add(T item)
        {
            if (list.Count >= capacity)
            {
                throw new InvalidOperationException("the list is full cannot add more items");
            }

            list.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException("this is Invalid index");
            }

            return list[index];
        }
        public void Display()
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
      
    }
}
