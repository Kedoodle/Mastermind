using System;

namespace Mastermind {
    
    public class ColourInitialiser:IColourInitialiser {
        
        public string[] InitiateGameColours(string[] possibleColours) {
            var GameColours = new string[4];
            var r = new Random();
            for (var i = 0; i < 4; i++) {
                var randomIndex = r.Next(possibleColours.Length);
                GameColours[i] = possibleColours[randomIndex];
            }
            return GameColours;
        }
    }
}