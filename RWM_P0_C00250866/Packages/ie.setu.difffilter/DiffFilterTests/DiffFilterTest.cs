using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DiffFilterTest
    {
        [Test]
        public void DiffFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = DiffFilter.diffs(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
