using System;
using ArrayUtility.Utilities;
using ArrayUtility.Utilities.Object;

namespace ArrayUtility
{
    public class Program
    {
        private const int MinIndex = 0;

        private const int MaxIndex = 9;

        private static void Main(string[] args)
        {
            var array = ArrayUtilityHelper.RandomFixedArray();

            // 1. public static T FindMax(T[] A, int i, int j)
            var max = ArrayUtility<ArrayObjectImpl>.FindMax(array, MinIndex, MaxIndex);

            if (max == null || (max.GetValue() != ArrayUtilityHelper.Max))
            {
                var value = max?.GetValue() ?? -1;
                Console.WriteLine($"max value {value} does not equal {ArrayUtilityHelper.Max}");
            }

            // 2. public static int FindMaxPos(T[] A, int i, int j)
            var maxPos = ArrayUtility<ArrayObjectImpl>.FindMaxPos(array, MinIndex, MaxIndex);
            if (maxPos != ArrayUtilityHelper.MaxPos)
            {
                Console.WriteLine($"max position {maxPos} does not equal {ArrayUtilityHelper.MaxPos}");
            }

            // 3. public static T FindMin(T[] A, int i, int j)
            var min = ArrayUtility<ArrayObjectImpl>.FindMin(array, MinIndex, MaxIndex);

            if (min == null || (min.GetValue() != ArrayUtilityHelper.Max))
            {
                var value = min?.GetValue() ?? -1;
                Console.WriteLine($"min value {value} does not equal {ArrayUtilityHelper.Min}");
            }

            // 4. public static int FindMinPos(T[] A, int i, int j)
            var minPos = ArrayUtility<ArrayObjectImpl>.FindMinPos(array, MinIndex, MaxIndex);
            if (minPos != ArrayUtilityHelper.MinPos)
            {
                Console.WriteLine($"min position {minPos} does not equal {ArrayUtilityHelper.MinPos}");
            }

            // 5. public static void Swap(T[] A, int i, int j)
            ArrayUtility<ArrayObjectImpl>.Swap(array, ArrayUtilityHelper.MinPos, ArrayUtilityHelper.MaxPos);
            var swapMin = array[ArrayUtilityHelper.MinPos].GetValue();
            var swapMax = array[ArrayUtilityHelper.MaxPos].GetValue();
            if (swapMin != ArrayUtilityHelper.Max || swapMin != ArrayUtilityHelper.Min)
            {
                Console.WriteLine($"swapMin {swapMin} does not equal {ArrayUtilityHelper.Max} or swapMax {swapMax} does not equal {ArrayUtilityHelper.Min}");
            }

            // 6. public static void ShiftRight(T[] A,int i,int j)
            var eight = array[8].GetValue();
            ArrayUtility<ArrayObjectImpl>.ShiftRight(array, 7, 9);
            if (eight != array[0].GetValue())
            {
                Console.WriteLine($"new position 0[{array[0].GetValue()}] does not equal old position value 8[{eight}]");
            }

            // 7. public static void ShiftRight(T[] A,int i,int j)
            ArrayUtility<ArrayObjectImpl>.ShiftLeft(array, 2, 0);
            if (eight != array[8].GetValue())
            {
                Console.WriteLine($"new position 8[{array[8].GetValue()}] does not equal old position value 8[{eight}]");
            }

            // 12. public static int FindInArray(T[] A, int q)
            var find = ArrayUtility<ArrayObjectImpl>.FindInArray(array, array[5]);
            if (find != 5)
            {
                Console.WriteLine($"find index 5 does not match returned index of {find}");
            }
        }
    }
}
