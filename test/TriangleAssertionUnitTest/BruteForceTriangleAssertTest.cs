using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAssertion;

namespace TriangleAssertionUnitTest
{
    [TestClass]
    public class BruteForceTriangleAssertTest
    {
        [TestMethod]
        [DataRow(new[] { 10, 2, 5, 1, 8, 20 }, 5, 1)]
        [DataRow(new[] { 10, 50, 5, 1 }, 4, 1)]
        public void ProposedExercise_ProducesExpectedResult(int[] arrayOfNumbers, int quantity, int expectedResult)
        {
            // ARRANGE
            ITriangleAssert _triangleAssert = new BruteForceTriangleAssert();

            // ACT
            var result = _triangleAssert.HasTriangleInside(arrayOfNumbers, quantity);

            // ASSERT
            result.Should().Be(expectedResult);
        }
    }
}
