using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170803_FindTheParityOutlier
{
    [TestClass]
    public class FindTheParityOutlierTests
    {
        //https://www.codewars.com/kata/5526fc09a1bbd946250002dc
        [TestMethod]
        public void input_1_3_2_should_return_2()
        {
            AssertParityOutlierShouldbe(2, new[] {1, 3, 2});
        }

        [TestMethod]
        public void input_2_3_4_should_return_3()
        {
            AssertParityOutlierShouldbe(3, new[] { 2, 3, 4 });
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
            var evenList = integers.Where(a => a % 2 == 0).ToList();
            if (evenList.Count == 1)
            {
                return evenList[0];
            }

            return integers.FirstOrDefault(num => num % 2 != 0);
        }
    }
}
