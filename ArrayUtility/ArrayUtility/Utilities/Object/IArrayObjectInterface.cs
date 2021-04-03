using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtility.Utilities.Object
{
    public interface IArrayObjectInterface<T> : IComparable
    {
        T GetValue();

        IArrayObjectInterface<T> Clone();
    }
}
