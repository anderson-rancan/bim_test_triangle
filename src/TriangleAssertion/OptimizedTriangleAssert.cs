using System;
using System.Collections.Generic;

namespace TriangleAssertion
{
    public class OptimizedTriangleAssert : TriangleAssertBase
    {
        public override int HasTriangleInside(int[] arrayOfNumbers, int quantity)
        {
            var group = 3;
            if (quantity < group) return 0;

            Array.Sort(arrayOfNumbers);
            var combination = new int[group];
            var stack = new Stack<int>(group);
            stack.Push(0);

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var currentValue = stack.Pop();

                while (currentValue < quantity)
                {
                    combination[index] = currentValue;

                    currentValue += 1;
                    stack.Push(currentValue);

                    index += 1;
                    if (index != group) continue;

                    if (IsValidTriangle(arrayOfNumbers[combination[0]], arrayOfNumbers[combination[1]], arrayOfNumbers[combination[2]]))
                    {
                        return 1;
                    }
                    else if (combination[2] < quantity - 1 && arrayOfNumbers[combination[2]] >= arrayOfNumbers[combination[0]] + arrayOfNumbers[combination[1]])
                    {
                        stack.Pop();
                        stack.Push(quantity);
                    }

                    break;
                }
            }

            return 0;
        }
    }
}
