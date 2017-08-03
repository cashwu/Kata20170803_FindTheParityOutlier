using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170803_FindTheParityOutlier
{
    [TestClass]
    public class FindTheParityOutlierTests
    {
        //https://www.codewars.com/kata/5526fc09a1bbd946250002dc
        [TestMethod]
        public void input_1_3_2()
        {
            AssertParityOutlierShouldbe(2, new[] {1, 3, 2});
        }

        private static void AssertParityOutlierShouldbe(int expected, int[] integers)
        {
            var kata = new Kata();
            var actual = kata.Find(integers);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int Find(int[] integers)
        {
            return 2;
        }
    }
}
