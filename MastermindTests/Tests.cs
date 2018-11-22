using System.Linq;
using Mastermind;
using Xunit;

namespace MastermindTests {
    
    internal class FakeColourInitialiser:IColourInitialiser {
        public string[] InitiateGameColours(string[] fakeColours) {
            return fakeColours;
        }
    }
    
    public class Mastermind {
        
        private readonly IColourInitialiser _fci;
        
        public Mastermind() {
            _fci = new FakeColourInitialiser();
        }
        
        [Fact]
        public void TakesStringArrayAndReturns() {
            var fakeColours = new[] {"Red", "Blue", "Green", "Yellow"};
            var guess = new[] {"Red", "Blue", "Green", "Yellow"};
            var game = new Game(fakeColours, _fci);
            var output = game.Mastermind(guess);
            Assert.NotNull(output);
        }
        
        [Fact]
        public void TakesStringArrayAndReturnsBlackElements() {
            var fakeColours = new[] {"Red", "Blue", "Green", "Yellow"};
            var guess = new[] {"Red", "Blue", "Green", "Yellow"};
            var expectedArray = new[] {"Black", "Black", "Black", "Black"};
            var game = new Game(fakeColours, _fci);
            var output = game.Mastermind(guess);
            Assert.Equal(expectedArray, output);
        }
    }
}