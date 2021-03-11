using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Queue
{
    public interface IQueue<T>
    {
        void Enqueue(T data);

        T Dequeue(T data);

        T Rear();

        T Front();
    }
}
