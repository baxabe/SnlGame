using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSnlGameII
{
    [TestClass]
    public class TokenCanMoveAcrossTheBoardTest
    {
        [TestMethod]
        public void when_the_token_is_placed_on_the_board_then_the_token_is_on_square_1()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();

            Assert.AreEqual(1, game.PlayerPosition());
        }

        [TestMethod]
        public void when_the_token_is_moved_3_spaces_then_the_token_is_on_square_4()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();
            game.MovePlayer(3);

            Assert.AreEqual(4, game.PlayerPosition());
        }

        [TestMethod]
        public void when_the_token_is_moved_3_spaces_and_then_the_token_moved_4spaces_then_token_is_on_square_8()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();
            game.MovePlayer(3);
            game.MovePlayer(4);

            Assert.AreEqual(8, game.PlayerPosition());
        }
    }
}
