using System.Linq;
using Mastermind;
using Xunit;

namespace MastermindTests {
    
    class FakeColourInitialiser:IColourInitialiser {
        public string[] InitiateGameColours(string[] possibleColours) {
            return new[] {"Red", "Blue", "Green", "Yellow"};
        }
    }
    
    public class Mastermind {
        
        private Game game;
        
        public Mastermind() {
            var fci = new FakeColourInitialiser();
            game = new Game(fci);  
        }
        
        [Fact]
        public void TakesStringArrayAndReturns() {
            var input = new[] {"Red", "Blue", "Green", "Yellow"};
            var output = Game.mastermind(input);
            Assert.NotNull(output);
        }
        
        [Fact]
        public void TakesStringArrayAndReturnsBlackElements() {
            var input = new[] {"Red", "Blue", "Green", "Yellow"};
            var expectedSubstring = "Black";
            var output = Game.mastermind(input);
            Assert.Equal(expectedSubstring, output.ToArray()[0]);
            Assert.Equal(expectedSubstring, output.ToArray()[1]);
            Assert.Equal(expectedSubstring, output.ToArray()[2]);
        }
    }
}