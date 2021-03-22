using StackAndQueue.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Queue
{
    public class QueueImpl : IQueue<DataObject>
    {
        public int Size { get; }

        public QueueImpl(int size)
        {
            Size = size;
        }

        public DataObject Dequeue()
        {
            return default(DataObject);
        }

        public bool IsEmpty()
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }

        public DataObject Peek()
        {
            return default(DataObject);
        }

        public void Enqueue(DataObject data)
        {

        }
    }
}
