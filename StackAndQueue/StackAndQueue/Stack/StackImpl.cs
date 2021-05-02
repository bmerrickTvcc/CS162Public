using StackAndQueue.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Stack
{
    public class StackImpl : IStack<DataObject>
    {
        private int Size { get; }

        public StackImpl(int size)
        {
            Size = size;
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

        public DataObject Pop()
        {
            return default(DataObject);
        }

        public void Push(DataObject data)
        {
            
        }
    }
}
