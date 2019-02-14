using System;
using System.Diagnostics;
using System.Linq;

namespace TriangleAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length <= 4)
            {
                Console.WriteLine("Please use: TriangleAssertion [Number of Elements] [Element1] [Element2] [Element3] [Element4] [...]");
                return;
            }

            var numberOfElements = Convert.ToInt32(args[0]);
            var arrayOfNumbers = args.Skip(1).Take(numberOfElements).Select(_ => Convert.ToInt32(_)).ToArray();

            if (arrayOfNumbers.Length != numberOfElements)
            {
                Console.WriteLine("Please provide enough elements as specified");
                return;
            }

            Console.WriteLine($"Detected { numberOfElements } elements: { string.Join(",", arrayOfNumbers) }");
            Console.WriteLine();

            Console.WriteLine($"Starting { nameof(BruteForceTriangleAssert) }");
            SearchForTriangles(arrayOfNumbers, numberOfElements, new BruteForceTriangleAssert());

            Console.WriteLine($"Starting { nameof(OptimizedTriangleAssert) }");
            SearchForTriangles(arrayOfNumbers, numberOfElements, new OptimizedTriangleAssert());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void SearchForTriangles(int[] arrayOfNumbers, int quantity, ITriangleAssert triangleAssert)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = triangleAssert.HasTriangleInside(arrayOfNumbers, quantity);
            stopwatch.Stop();

            Console.WriteLine($"Result: { result }");
            Console.WriteLine($"Elapsed milliseconds: { stopwatch.ElapsedMilliseconds } ({stopwatch.ElapsedTicks} ticks)");
            Console.WriteLine();
        }
    }
}
