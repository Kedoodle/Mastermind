using System;
using System.Collections.Generic;

namespace Mastermind {
    public class Game {

        private static readonly string[] PossibleColours = {"Red", "Blue", "Green", "Orange", "Purple", "Yellow"};
        private static readonly string[] GameColours = new string[4];
        public Game() {
            var r = new Random();
            for (var i = 0; i < 4; i++) {
                var randomIndex = r.Next(PossibleColours.Length);
                GameColours[i] = PossibleColours[randomIndex];
            }
        }

        public static IEnumerable<string> mastermind(string[] input) {
            var output = new List<string>();
            for (var i = 0; i < 4; i++) {
                if (input[i] == GameColours[i]) {
                    output.Add("Black");
                }
            }
            return output.ToArray();
        }
    }
}