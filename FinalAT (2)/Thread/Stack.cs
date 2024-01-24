using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAT
{
    class Stack<T>
    {
        private List<T> data = new List<T>();
        private object lockObject = new object();
        public T Top
        {
            get
            {
                lock (this)
                {
                    if (this.IsEmpty)
                    {
                        throw new Exception("Stack is Empty");
                    }
                    return data[data.Count - 1];
                }
            }
        }

        public bool IsEmpty
        {
            get
            {
                lock (lockObject)
                {
                    return data.Count == 0;
                }
            }
        }

        public void Push(T val)
        {
            lock (lockObject)
            {
                data.Add(val);
            }
        }
        public T Pop()
        {
            T tmp;
            lock (lockObject)
            {
                if (this.IsEmpty)
                {
                    throw new Exception("Stack is Empty");
                }
                tmp = data[data.Count - 1];
                data.RemoveAt(data.Count - 1);
            }
            return tmp;
        }
    }
}
