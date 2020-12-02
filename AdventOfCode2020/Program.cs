using System;
using System.Threading.Tasks.Dataflow;
using AdventOfCode2020.Problems;

namespace AdventOfCode2020 {
    class Program {
        static void Main(string[] args) {

            //var result = new Day1A().SolveProblem()
            //var result = new Day1B().SolveProblem()
            var result = new Day2A().SolveProblem();

            Console.WriteLine(result);
        }
    }
}
