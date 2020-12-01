using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdventOfCode2020.Problems {
    public class Day1A {

        private string path = "Input/input.txt";

        public int SolveProblem() {

            var inputString = File.ReadAllText(path);
            

            var result = FindExpenses(inputString);

            return -1;
        }

        public int FindExpenses(string inputString) {
            var inputsInts = inputString.SplitStringsIntoInts().ToArray();



            return -1;
        }
    }
}
