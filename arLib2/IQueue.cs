using System;
using System.Collections.Generic;
using System.Text;

namespace arLib2
{
    interface IQueue<T>:IEnumerable<T>
    {
        int Count { get; set; } //количество элементов в очереди
        bool isEmpty { get; set; } // заполненность очереди
        void Enqueue(T value);  // добавить элемент в очередь 
        void Clear(); // очистить очередь
        T Dequeue(); //убрать из очереди
        T Peek(); //смотрит какой в очереди 
    }
}
