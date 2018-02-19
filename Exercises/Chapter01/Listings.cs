using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}