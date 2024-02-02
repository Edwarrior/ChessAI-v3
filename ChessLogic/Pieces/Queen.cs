namespace ChessLogic
{
    internal class Queen : Piece
    {

        public override PieceType Type => PieceType.Queen;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
                Direction.North,
                Direction.South,
                Direction.East,
                Direction.West,
                Direction.NorthWest,
                Direction.NorthEast,
                Direction.SouthWest,
                Direction.SouthEast
        };

        public Queen(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Queen copy = new Queen(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }


    }
}
