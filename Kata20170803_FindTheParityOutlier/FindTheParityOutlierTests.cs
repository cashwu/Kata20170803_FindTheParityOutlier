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

        [TestMethod]
        public void input_2_6_8_n10_3_should_return_3()
        {
            AssertParityOutlierShouldbe(3, new [] { 2, 6, 8, -10, 3 });
        }

        [TestMethod]
        public void input_intMax_0_1_should_return_0()
        {
            AssertParityOutlierShouldbe(0, new [] { int.MaxValue, 0, 1 });
        }

        [TestMethod]
        public void input_206847684_1056521_7_17_1901_21104421_7_1_35521_1_7781_should_return_206847684()
        {
            AssertParityOutlierShouldbe(206847684, new []{ 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 });
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
