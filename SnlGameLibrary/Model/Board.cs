namespace SnlGame.Model
{
    class Board
    {
        public Token Token { get; private set; }

        public Board()
        {
            Token = null;
        }

        public void AddToken(Token token)
        {
            Token = token;
        }
    }
}
