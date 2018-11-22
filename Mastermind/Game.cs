using System.Collections.Generic;

namespace Mastermind {
    public class Game {

        public IColourInitialiser ColourInitialiser { get; set; }
        private static readonly string[] PossibleColours = {"Red", "Blue", "Green", "Orange", "Purple", "Yellow"};
        private static string[] GameColours = new string[4];
        
        public Game(IColourInitialiser colourInitialiser) {
            ColourInitialiser = colourInitialiser;
            InitiateGameColours();
        }

        private void InitiateGameColours() {
            GameColours = ColourInitialiser.InitiateGameColours(PossibleColours);
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