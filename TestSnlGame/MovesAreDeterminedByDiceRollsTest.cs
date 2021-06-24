using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSnlGame
{
    [TestClass]
    public class MovesAreDeterminedByDiceRollsTest
    {
        [TestMethod]
        public void when_the_player_rolls_a_die_then_the_result_shoul_be_between_1_6_inclusive()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            int result = game.RollDie();
            bool roll = result <= 6 && result >= 1;
            Assert.IsTrue(roll);
        }

        [TestMethod]
        public void given_the_player_rolls_a_X_when_they_move_their_token_then_the_token_should_move_X_spaces()
        {
            SnlGameLibrary.SnlGame game = new SnlGameLibrary.SnlGame();
            game.PlacePlayerOnBoard();
            int position = game.PlayerPosition();
            int result = game.RollDie();

            Assert.AreEqual(position + result, game.PlayerPosition());
        }
    }
}
