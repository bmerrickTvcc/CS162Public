using System;
using ArrayUtility.Utilities.Object;

namespace ArrayUtility.Utilities
{
    public static class ArrayUtilityHelper
    {
        private static readonly Random Random = new Random();

        public static readonly int Min = 3;

        public static readonly int MinPos = 5;

        public static readonly int Max = 1000;

        public static readonly int MaxPos = 2;

        public static ArrayObjectImpl RandomObject()
        {
            return new ArrayObjectImpl
            {
                Value = Random.Next()
            };
        }

        public static ArrayObjectImpl[] RandomArray(int size)
        {
            var array = new ArrayObjectImpl[size];
            for (var i = 0; i < size; i++)
            {
                array[i] = RandomObject();
            }

            return array;
        }

        public static ArrayObjectImpl[] RandomFixedArray()
        {
            return new ArrayObjectImpl[]
            {
                new ArrayObjectImpl { Value = 10 },
                new ArrayObjectImpl { Value = 8 },
                new ArrayObjectImpl { Value = Max },
                new ArrayObjectImpl { Value = 100 },
                new ArrayObjectImpl { Value = 99 },
                new ArrayObjectImpl { Value = Min },
                new ArrayObjectImpl { Value = 57 },
                new ArrayObjectImpl { Value = 33 },
                new ArrayObjectImpl { Value = 968 },
                new ArrayObjectImpl { Value = 447 }
            };
        }

        public static ArrayObjectImpl[,] RandomMaxtrix(int rows, int cols)
        {
            var array = new ArrayObjectImpl[rows,cols];
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
