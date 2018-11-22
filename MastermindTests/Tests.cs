using Mastermind;
using Xunit;

namespace MastermindTests {
    public class Mastermind {
        
        private Game game;
        
        public Mastermind() {
            game = new Game();  
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
            Assert.Contains(expectedSubstring, output);
        }
    }
}