using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAssertion;

namespace TriangleAssertionUnitTest
{
    [TestClass]
    public class BruteForceTriangleAssertUnitTest
    {
        [DataTestMethod]
        [DynamicData(nameof(TriangleAssertTestData.GetPitagorasRightTriangleData), typeof(TriangleAssertTestData), DynamicDataSourceType.Method)]
        public void PitagorasRightTriangle_ShouldBeAcceptable(int[] arrayOfNumbers)
        {
            // ARRANGE
            ITriangleAssert triangleAssert = new BruteForceTriangleAssert();

            // ACT
            var result = triangleAssert.HasTriangleInside(arrayOfNumbers, 3);

            // ASSERT
            result.Should().Be(1);
        }

        [DataTestMethod]
        [DynamicData(nameof(TriangleAssertTestData.GetProposedExerciseData), typeof(TriangleAssertTestData), DynamicDataSourceType.Method)]
        public void ProposedExercise_ProducesExpectedResult(int[] arrayOfNumbers, int quantity, int expectedResult)
        {
            // ARRANGE
            ITriangleAssert triangleAssert = new BruteForceTriangleAssert();

            // ACT
            var result = triangleAssert.HasTriangleInside(arrayOfNumbers, quantity);

            // ASSERT
            result.Should().Be(expectedResult);
        }
    }
}
