using System;
using System.Threading.Tasks.Dataflow;
using AdventOfCode2020.Problems;

namespace AdventOfCode2020 {
    class Program {
        static void Main(string[] args) {

            //var day1A = new Day1A();
            //var result = day1A.SolveProblem(true);
            //Console.WriteLine(result);

            var day1B = new Day1B();
            var result = day1B.SolveProblem(false);
            Console.WriteLine(result);
        }
    }
}
