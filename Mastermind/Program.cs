namespace Mastermind {
    internal class Program {
        public static void Main(string[] args) {
            var ci = new ColourInitialiser();
            var g = new Game(ci);
        }
    }
}