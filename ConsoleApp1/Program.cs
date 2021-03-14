using System;
using System.Linq;

namespace Lesson16_13._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 348597;

            foreach (var item in SortNumber(num))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            
            foreach (var item in SortNumberSums(arr))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var str = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };
            
            foreach (var item in SortString(str))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            var arr2 = new double[] { 1, 1, 1, 2, 1, 1 };
            Console.WriteLine(FindOdd(arr2));

            var arr3 = new double[] { 0, 0, 0.55, 0, 0 };
            Console.WriteLine(FindOdd(arr3));
        }

        static int[] SortNumber(int input)
        {
            var num = input
                .ToString()
                .Reverse()
                .ToArray();

            var intArr = num
                .Select(n => n - '0')
                .ToArray();

            return intArr;
        }

        static int[] SortNumberSums(int[] input)
        {
            var sum1 = input
                .Where(n => n > 0)
                .Count();

            var sum2 = input
                .Where(n => n < 0)
                .Sum();

            return new int[] { sum1, sum2 };
        }

        static string[] SortString(string[] input)
        {
            return input
                .OrderBy(n => n.Length)
                .ToArray();
        }

        static double FindOdd(double[] input)
        {
            var unique = input
                .GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(y => y.Key)
                .ToArray();

            return unique[0];
        }
    }
}
