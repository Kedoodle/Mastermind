using System;
using System.Collections.Generic;

namespace Mastermind {
    public class Game {

        private static List<string> PossibleColours = new List<string>(){"Red", "Blue", "Green", "Orange", "Purple", "Yellow"};
        private List<string> GameColours;
        public Game() {
            var r = new Random();
            for (var i = 0; i < 4; i++) {
                var randomIndex = r.Next(PossibleColours.Count);
                var colour = PossibleColours[randomIndex];
            }
        }
    }
}