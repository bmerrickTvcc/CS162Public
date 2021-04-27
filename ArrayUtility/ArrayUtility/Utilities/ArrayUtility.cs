using System;
using System.Collections.Generic;
using System.Text;
using ArrayUtility.Utilities.Object;

namespace ArrayUtility.Utilities
{
    public static class ArrayUtility<T> where T : IComparable
    {
        /// <summary>
        /// 1. Returns the maximum value occurring in the array A between position i and j.
        /// </summary>
        public static T FindMax(T[] a, int i, int j)
        {
            return default(T);
        }

        /// <summary>
        /// 2. Returns the position of the maximum value in the array A between position i and j.
        /// </summary>
        public static int FindMaxPos(T[] a, int i, int j)
        {
            return -1;
        }

        /// <summary>
        /// 3. Returns the minimum value in the array A between position i and j.
        /// </summary>
        public static T FindMin(T[] a, int i, int j)
        {
            return default(T);
        }

        /// <summary>
        /// 4. Return the position of the minimum value in the array A between position i and j.
        /// </summary>
        public static int FindMinPos(T[] a, int i, int j)
        {
            return -1;
        }

        /// <summary>
        /// 5. Swaps the elements in position i and j in the array A.
        /// </summary>
        public static void Swap(T[] a, int i, int j)
        {
            
        }

        /// <summary>
        /// 6. Shifts to the right all the elements of the array A starting from position i and until position j
        /// (i.e., moves the element in position k to position k +1 for all i ≤ k &lt; j, and leaves position i unchanged).
        /// </summary>
        public static void ShiftRight(T[] a, int i, int j)
        {

        }

        /// <summary>
        /// 7. Shifts to the left all the elements of the array A, from position j down to position i
        /// (i.e., moves the element in position k to position k −1 for all i &lt; k ≤ j, and leaves the position j unchanged).
        /// </summary>
        public static void ShiftLeft(T[] a, int i, int j)
        {

        }

        /// <summary>
        /// 8. Returns the position of the number q in the array A (returns −1 if q is not present inA).
        /// </summary>
        public static int FindInArray(T[] a, T q)
        {
            return -1;
        }
    }
}
