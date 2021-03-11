using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Stack
{
    public interface IStack<T>
    {
        void Push(T data);

        T Pop();

        T Peek();

        bool IsEmpty();
    }
}
