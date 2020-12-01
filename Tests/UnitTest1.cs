using System.Linq;
using AdventOfCode2020;
using AdventOfCode2020.Problems;
using NUnit.Framework;

namespace Tests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        [TestCase("1721, 979, 366, 299, 675, 1456", 514579)]
        public void Test1(string input, int expectedOutput) {
            var inputNum = input.SplitStringsIntoInts().ToArray();
            var day1A = new Day1A();

        }
    }
}