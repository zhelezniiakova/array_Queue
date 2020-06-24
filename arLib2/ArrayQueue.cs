using System;
using System.Collections;
using System.Collections.Generic;

namespace arLib2
{

    public class ArrayQueue<T> : IQueue<T>
    {
        private  T[] array;
        private  int count;
        public ArrayQueue(int n)
        {
            count = n;
            position = 0;
            array = new T[count];
        }
        bool empty = false;
        public int Count { get { return count; } set { count = value; } }
        public bool isEmpty { get { return empty; } set { empty = value; } }
        

        int position = 0;



        public void Clear()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i < count; i++)
                {
                    array[i] = default(T);
                }
                position = 0;
            }
        }


        public void Enqueue(T value)//позишн?
        {
            
            if (position == count) Addmemory();
            array[position] = value;
            position++;
        }

        public void Addmemory()
        {
            Array.Resize<T>(ref array, count+1);
            count += 1;
        }

        public T Dequeue()
        {
            IsEmpty();
            if (!empty)
            {
                T[] newArray = new T[array.Length - 1];

                for (int i = 1; i < array.Length; i++)
                {
                    newArray[i - 1] = array[i];
                }
                count--;
                position--;
                array = newArray;
                if (IsEmpty()) { return default(T); }
                return array[0];
            }
            throw new Exception("Массив пуст");
        }

        

        public bool IsEmpty()
        {
            if (array.Length > 0) empty = false;
            else empty = true;
            return empty;
        }

        public T Peek()
        {
            if (!IsEmpty()) return array[0];
            else throw new Exception("Массив пуст");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new NewEnumerator<T>(array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    class NewEnumerator<T> : IEnumerator<T>
    {
        int position = -1;
        public T[] array ;
        public NewEnumerator(T[] array)
        {
            this.array = array;
        }
         object IEnumerator.Current
        {
            get
            {
                if (position == -1 || position >= array.Length)
                    throw new InvalidOperationException();
                return array[position];
            }
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= array.Length)
                    throw new InvalidOperationException();
                return array[position];
            }
        } 

        void IDisposable.Dispose() { }
        
        bool IEnumerator.MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
            
        }

        void IEnumerator.Reset()
        {
            position = -1;
            
        }
    }
}

