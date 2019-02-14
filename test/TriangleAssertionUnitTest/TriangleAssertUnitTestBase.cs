using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TriangleAssertion;

namespace TriangleAssertionUnitTest
{
    public abstract class TriangleAssertUnitTestBase
    {
        protected ITriangleAssert TriangleAssert { get; set; }

        [DataTestMethod]
        [DynamicData(nameof(TriangleAssertUnitTestBase.GetPitagorasRightTriangleData), DynamicDataSourceType.Method)]
        public void PitagorasRightTriangle_ShouldBeAcceptable(int[] arrayOfNumbers)
        {
            // ARRANGE

            // ACT
            var result = TriangleAssert.HasTriangleInside(arrayOfNumbers, 3);

            // ASSERT
            result.Should().Be(1);
        }

        [DataTestMethod]
        [DynamicData(nameof(TriangleAssertUnitTestBase.GetProposedExerciseData), DynamicDataSourceType.Method)]
        public void ProposedExercise_ProducesExpectedResult(int[] arrayOfNumbers, int quantity, int expectedResult)
        {
            // ARRANGE

            // ACT
            var result = TriangleAssert.HasTriangleInside(arrayOfNumbers, quantity);

            // ASSERT
            result.Should().Be(expectedResult);
        }

        [DataTestMethod]
        [DynamicData(nameof(TriangleAssertUnitTestBase.GetBigArrayData), DynamicDataSourceType.Method)]
        public void BigArray_ShouldNotThrow(int[] arrayOfNumbers, int quantity, int expectedResult)
        {
            // ARRANGE
            var result = -1;

            // ACT

            // ASSERT
            TriangleAssert.Invoking(_ => result = _.HasTriangleInside(arrayOfNumbers, quantity)).Should().NotThrow();
            result.Should().Be(expectedResult);
        }

        private static IEnumerable<object[]> GetPitagorasRightTriangleData()
        {
            // array with 3 elements
            yield return new object[] { new[] { 3, 4, 5 } };
            yield return new object[] { new[] { 9, 12, 15 } };
            yield return new object[] { new[] { 411, 548, 685 } };
        }

        private static IEnumerable<object[]> GetProposedExerciseData()
        {
            // arrayOfObjects { arrayOfElements, elementsQuantity, expectedResult }
            yield return new object[] { new[] { 10, 2, 5, 1, 8, 20 }, 5, 1 };
            yield return new object[] { new[] { 10, 50, 5, 1 }, 4, 0 };
        }

        private static IEnumerable<object[]> GetBigArrayData()
        {
            // arrayOfObjects { arrayOfElements, elementsQuantity, expectedResult }
            yield return new object[] { new[] { 130, 60, 70, 80, 90, 100, 110, 120, 250, 50, 280, 260, 270, 140, 20, 30, 160, 170, 180, 190, 200, 210, 220, 230, 240, 40, 290, 150, 10, 300 }, 30, 1 }; // 1925 triangles
            yield return new object[] { new[] { 139, 69, 79, 89, 99, 199, 119, 129, 259, 59, 289, 269, 279, 149, 29, 39, 169, 179, 189, 299, 219, 229, 239, 249, 49, 159, 19, 399 }, 28, 1 }; // 1571 triangles
        }
    }
}
