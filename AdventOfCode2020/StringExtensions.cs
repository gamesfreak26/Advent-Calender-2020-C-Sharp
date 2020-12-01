using System;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode2020 {
    public static class StringExtensions {

        public static IEnumerable<int> SplitStringsIntoInts(this string input) {

            return input.Split(new[] {','}, 
                StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .Select(int.Parse);
        }
    }
}
