using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; set; }
        public List<T> Item { get; set; }
        public FixedSizeList(int _Capacity)
        {
            Capacity = _Capacity;
            Item = new List<T>(Capacity);
        }
        public void Add(T item)
        {
            if (Capacity <= Item.Count)
            {
                Console.WriteLine("can't Add Element 'Full Capacity'");
            }
            Item.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= Item.Count)
            {
                Console.WriteLine("invalid indices");
                return default;
            }
            return Item[index];
        }
    }
}
