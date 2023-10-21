using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack_Donner
{
    public class MeineStack<T> : ICloneable
    {
        private List<T> list;

        public MeineStack()
        {
            list = new List<T>();
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Der Stack ist leer.");
            }

            return list[list.Count - 1];
        }

        public void CopyTo(T[] array, int index)
        {
            list.CopyTo(array, index);
        }

        public object Clone()
        {
            MeineStack<T> clonedStack = new MeineStack<T>();
            clonedStack.list = new List<T>(list);
            return clonedStack;
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Der Stack ist leer.");
            }

            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsEmpty
        {
            get { return list.Count == 0; }
        }
    }
}
