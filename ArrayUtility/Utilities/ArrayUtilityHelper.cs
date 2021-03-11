using System;
using System.Collections.Generic;
using System.Text;
using ArrayUtility.Utilities.Object;

namespace ArrayUtility.Utilities
{
    public static class ArrayUtilityHelper
    {
        private static readonly Random Random = new Random();

        public static IArrayObjectInterface<int> RandomObject()
        {
            return new ArrayObjectImpl
            {
                Value = Random.Next()
            };
        }

        public static IArrayObjectInterface<int>[] RandomArray(int size)
        {
            var array = new IArrayObjectInterface<int>[size];
            for (var i = 0; i < size; i++)
            {
                array[i] = RandomObject();
            }

            return array;
        }

        public static IArrayObjectInterface<int>[,] RandomMaxtrix(int rows, int cols)
        {
            var array = new IArrayObjectInterface<int>[rows,cols];
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    array[i,j] = RandomObject();
                }
            }

            return array;
        }
    }
}
