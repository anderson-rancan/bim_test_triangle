﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAssertion;

namespace TriangleAssertionUnitTest
{
    [TestClass]
    public class BruteForceTriangleAssertUnitTest : TriangleAssertUnitTestBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            TriangleAssert = new BruteForceTriangleAssert();
        }
    }
}
