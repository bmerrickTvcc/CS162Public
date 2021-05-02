using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUtility.Utilities.Object
{
    public class ArrayObjectImpl : IArrayObjectInterface<int>
    {
        public int Value { private get; set; }

        public int GetValue()
        {
            return Value;
        }

        /// <summary>
        /// Returns 0 if equal, a negative value if other is greater than Value or a
        /// positive value if Value is greater than other.
        /// </summary>
        /// <param name="other">value being compared to current value</param>
        /// <returns>0 = equal, > 0 if Value greater than other or less than 0 if other is greater than Value </returns>
        public int CompareTo(int other)
        {
            return Value - other;
        }

        public IArrayObjectInterface<int> Clone()
        {
            return new ArrayObjectImpl
            {
                Value = Value
            };
        }

        public int CompareTo(object obj)
        {
            if (obj is ArrayObjectImpl)
            {
                var impl = obj as ArrayObjectImpl;
                return CompareTo(impl.Value);
            }

            return 0;
        }

        public new string ToString()
        {
            return GetValue().ToString();
        }
    }
}
