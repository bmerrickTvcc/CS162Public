using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var lines    = File.ReadAllLines("Tests/bubbleSort.txt");
            var numbers  = new int[lines.Length];
            var largest  = -1;
            var smallest = int.MaxValue;
            for (var i = 0; i < lines.Length; i++)
            {
                numbers[i] = Convert.ToInt32(lines[i]);
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }

                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            var bubble = new Sort.BubbleSort();
            bubble.Sort(numbers);

            Console.WriteLine($"largest value in the list is {largest} and value at numbers[numbers.Length - 1] is {numbers[numbers.Length-1]}");
            Console.WriteLine($"smallest value in the list is {smallest} and value at numbers[0] is {numbers[0]}");
        }
    }
}
