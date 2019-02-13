namespace TriangleAssertion
{
    public abstract class TriangleAssertBase : ITriangleAssert
    {
        public abstract int HasTriangleInside(int[] arrayOfNumbers, int quantity);

        protected bool IsValidTriangle(int sideA, int sideB, int sideC)
        {
            return sideA + sideB > sideC
                && sideB + sideC > sideA
                && sideC + sideA > sideB;
        }
    }
}
