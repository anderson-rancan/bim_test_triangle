using System.Collections.Generic;

namespace TriangleAssertionUnitTest
{
    public static class TriangleAssertTestData
    {
        public static IEnumerable<object[]> GetPitagorasRightTriangleData()
        {
            // array with 3 elements
            yield return new object[] { new[] { 3, 4, 5 } };
            yield return new object[] { new[] { 9, 12, 15 } };
            yield return new object[] { new[] { 411, 548, 685 } };
        }

        public static IEnumerable<object[]> GetProposedExerciseData()
        {
            // arrayOfObjects { arrayOfElements, elementsQuantity, expectedResult }
            yield return new object[] { new[] { 10, 2, 5, 1, 8, 20 }, 5, 1 };
            yield return new object[] { new[] { 10, 50, 5, 1 }, 4, 0 };
        }
    }
}
