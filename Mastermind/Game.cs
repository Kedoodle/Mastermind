using System.Collections.Generic;

namespace Mastermind {
    public class Game {
        
        private readonly IColourInitialiser _colourInitialiser;
        private static string[] _possibleColours;
        private static string[] _gameColours;
        
        public Game(string[] possibleColours, IColourInitialiser colourInitialiser) {
            _possibleColours = possibleColours;
            _colourInitialiser = colourInitialiser;
            InitiateGameColours();
        }

        private void InitiateGameColours() {
            _gameColours = _colourInitialiser.InitiateGameColours(_possibleColours);
        }

        public IEnumerable<string> Mastermind(string[] guess) {
            var output = new List<string>();
            for (var i = 0; i < 4; i++) {
                if (guess[i] == _gameColours[i]) {
                    output.Add("Black");
                }
            }
            return output.ToArray();
        }
    }
}