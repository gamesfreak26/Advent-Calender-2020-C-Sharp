using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Problems {
    public class Day1B {
        private string path = "Input/input.txt";
        public int SolveProblem(bool Part1) {

            var inputString = File.ReadAllLines(path);


            var result = FindExpenses(inputString);

            return result;
        }

        private int FindExpenses(string[] inputString) {
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
