using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleAssertion;

namespace TriangleAssertionUnitTest
{
    [TestClass]
    public class OptimizedTriangleAssertUnitTest : TriangleAssertUnitTestBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            TriangleAssert = new OptimizedTriangleAssert();
        }
    }
}
