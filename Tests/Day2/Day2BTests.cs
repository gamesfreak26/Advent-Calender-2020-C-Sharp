using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2020.Problems;
using NUnit.Framework;

namespace Tests.Day2 {
    public class Day2BTests {

        Day2B day2B;

        [SetUp]
        public void Setup() {
            day2B = new Day2B();
        }
        
        [Test]
        [TestCase(
            new[] {"1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"}, 
            1
        )]
        public void Test(string[] input, int expectedOutput) {
            var actualResult = day2B.FindValidPasswords(input);
            Assert.AreEqual(expectedOutput, actualResult);
        }

    }
}
