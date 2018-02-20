using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static System.Linq.Enumerable;
using static System.Console;

namespace Exercises.Chapter1
{
    static class Listings
    {
        internal static void Listing1()
        {
            Func<int, int> triple = x => x * 3;
            var range = Enumerable.Range(1, 3);
            var triples = range.Select(triple);
            triples.ToList().ForEach(Console.WriteLine);

            Func<int, bool> isOdd = x => x % 2 == 1;
            int[] original = {7,6,1};

            var sorted = original.OrderBy(x => x);
            var filtered = original.Where(isOdd);

            original.ToList().ForEach(Console.WriteLine);
            sorted.ToList().ForEach(Console.WriteLine);
            filtered.ToList().ForEach(Console.WriteLine);
        }

        internal static void Listing2()
        {
            var originalList = new List<int> {5,7,1};
            originalList.Sort();
            originalList.ToList().ForEach(Console.WriteLine);
        }


        internal static void Listing3()
        {
            var nums = Range(-10000, 20001).Reverse().ToList();
            Action task1 = () => WriteLine(nums.Sum());
            Action task2 = () => {
                nums.Sort();
                WriteLine(nums.Sum());
            };
            Action task3 = () => WriteLine(nums.OrderBy(x => x).Sum());
            Parallel.Invoke(task1, task2);
            // Al utilizar el OrderBy, como no modifica la colección se comporta correctamente
            Parallel.Invoke(task1, task3);
        }
    }
}