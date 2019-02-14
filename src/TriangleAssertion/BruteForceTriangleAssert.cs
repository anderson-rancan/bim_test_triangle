using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAssertion
{
    // probably O(n^3), will use just to test
    public class BruteForceTriangleAssert : TriangleAssertBase
    {
        public override int HasTriangleInside(int[] arrayOfNumbers, int quantity)
        {
            if (quantity < 3) return 0;

            var combinations = LinearCombination(quantity);

            var triangles = combinations
                .Where(combination => IsValidTriangle(arrayOfNumbers[combination[0]], arrayOfNumbers[combination[1]], arrayOfNumbers[combination[2]]));

            return triangles.Count() > 0
                ? 1
                : 0;
        }

        private IEnumerable<int[]> LinearCombination(int quantity)
        {
            var group = 3;
            var yieldResult = new int[group];
            var stack = new Stack<int>(group);
            stack.Push(0);

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var currentValue = stack.Pop();

                while (currentValue < quantity)
                {
                    yieldResult[index] = currentValue;
                    
                    currentValue += 1;
                    stack.Push(currentValue);

                    index += 1;
                    if (index != group) continue;

                    yield return new List<int>(yieldResult).ToArray();
                    break;
                }
            }
        }
    }
}
