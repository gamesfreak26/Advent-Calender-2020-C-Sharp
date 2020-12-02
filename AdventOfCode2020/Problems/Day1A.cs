using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdventOfCode2020.Problems {
    public class Day1A {

        private string path = "Input/input.txt";

        public int SolveProblem(bool Part1) {

            var inputString = File.ReadAllLines(path);
            int result = 0;

            if (!Part1) {
                result = FindExpensesPart2(inputString);
            }
            else result = FindExpenses(inputString);

            return result;
        }

        public int FindExpenses(string[] inputString) {
            //var inputsInts = inputString.SplitStringsIntoInts().ToArray();

            var inputsInts = inputString.Select(x => int.Parse(x)).ToArray();

            var sumResult = 2020;

            foreach (var s in inputsInts) {
                //var otherNumber = 2020 - s;
                //if (inputsInts.Contains(otherNumber)) {
                //    return s * otherNumber;
                //}
                foreach (var t in inputsInts) {
                    if (s + t == 2020) {
                        return s * t;
                    }
                }
            }

            return -1;
        }

        public int FindExpensesPart2(string[] inputString) {
            List<int> numbers = new List<int>();

            var inputsInts = inputString.Select(x => int.Parse(x)).ToArray();

            var sumResult = 2020;

            foreach (var s in inputsInts) {
                foreach (var t in inputsInts) {
                    foreach (var u in inputsInts) {
                        if (s + t + u == 2020) {
                            return s * t * u;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
