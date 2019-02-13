using System.Collections.Generic;

namespace TriangleAssertionUnitTest
{
    /// <summary>
    /// Provides common data for tests
    /// </summary>
    /// <remarks>
    /// Usage: arrayOfObjects { arrayOfElements, elementsQuantity, expectedResult }
    /// </remarks>
    public static class TriangleAssertTestData
    {
        public static IEnumerable<object[]> GetProposedExerciseData()
        {
            yield return new object[] { new[] { 10, 2, 5, 1, 8, 20 }, 5, 1 };
            yield return new object[] { new[] { 10, 50, 5, 1 }, 4, 0 };
        }
    }
}
