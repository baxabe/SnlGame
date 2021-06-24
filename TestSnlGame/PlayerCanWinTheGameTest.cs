using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSnlGame
{
    [TestClass]
    public class PlayerCanWinTheGameTest
    {
        [TestMethod]
        public void when_the_token_is_on_square_97_and_token_moves_3_squares_then_the_token_is_on_square_100_and_player_wins()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();
            game.MovePlayer(96);
            game.MovePlayer(3);
            
            Assert.AreEqual(100, game.PlayerPosition());
            Assert.IsTrue(game.PlayerWon());
        }

        [TestMethod]
        public void when_the_token_is_on_square_97_and_token_moves_4_squares_then_the_token_is_on_square_97_and_player_dont_won()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();
            game.MovePlayer(96);
            game.MovePlayer(4);

            Assert.AreEqual(97, game.PlayerPosition());
            Assert.IsFalse(game.PlayerWon());
        }
    }
}
