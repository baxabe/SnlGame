using SnlGame.Model;

namespace SnlGameLibrary
{
    public class SnlGame
    {
        private Board board;
        private Token token;
        private Player player;
        private Die die;

        public SnlGame()
        {
            token = new Token();
            board = new Board();
            board.AddToken(token);
            player = new Player(token);
            die = new Die();
        }

        public void PlacePlayerOnBoard()
        {
            board.Token.Position = 1;
        }

        public int PlayerPosition()
        {
            return player.Token.Position;
        }

        public void MovePlayer(int delta)
        {
            player.Token.Position += delta;
        }

        public int RollDie()
        {
            int dieResult = die.Throw();
            player.Token.Position += dieResult;
            return dieResult;
        }

        public bool PlayerWon()
        {
            return player.Token.isAWinnerPosition;
        }
    }
}
