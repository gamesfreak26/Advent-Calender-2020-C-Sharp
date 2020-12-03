using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Problems {
    public class Day2B {

        private string path = "Input/Day2Input.txt";

        public int SolveProblem() {

            var inputString = File.ReadAllLines(path);

            var result = FindValidPasswords(inputString);

            return result;
        }

        public int FindValidPasswords(string[] passwords) {

            return passwords.Count(IsValidPassword);
        }

        private bool IsValidPassword(string password) {
            var splitSpace = password.Split(" ");

            var minMax = splitSpace[0].Split("-")
                .Select(int.Parse).ToArray();

            var minNum = minMax[0];
            var maxNum = minMax[1];

            var letterToContainSplit = splitSpace[1].Split(":");
            var letterString = letterToContainSplit[0];
            var letterChar = letterString.ToCharArray();
            var letter = letterChar[0];

            var passwordString = splitSpace[2];

            if ((passwordString[minNum - 1] == letter && passwordString[maxNum - 1] == letter)) {
                return false;
            }
            else if ((passwordString[minNum - 1] == letter || passwordString[maxNum - 1] == letter)) {
                return true;
            }

            return false;
        }
    }



}

