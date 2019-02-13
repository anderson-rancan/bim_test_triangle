using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAssertion
{
    public interface ITriangleAssert
    {
        int HasTriangleInside(int[] arrayOfNumbers, int quantity);
    }
}
