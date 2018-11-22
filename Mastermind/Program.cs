namespace Mastermind {
    internal class Program {
        public static void Main(string[] args) {
            var possibleColours = new[] {"Red", "Blue", "Green", "Orange", "Purple", "Yellow"};
            var ci = new ColourInitialiser();
            var g = new Game(possibleColours, ci);
        }
    }
}