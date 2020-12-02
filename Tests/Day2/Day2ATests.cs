using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2020.Problems;
using NUnit.Framework;

namespace Tests.Day2 {
    public class Day2ATests {

        Day2A day2A;

        [SetUp]
        public void Setup() {
            day2A = new Day2A();
        }
        
        [Test]
        [TestCase(
            new[] {"1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"}, 
            2
        )]

        [TestCase(
            new[] { "1-13 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc" },
            2
        )]
        public void Test(string[] input, int expectedOutput) {
            var actualResult = day2A.FindValidPasswords(input);
            Assert.AreEqual(expectedOutput, actualResult);
        }

    }
}
