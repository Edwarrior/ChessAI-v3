using ChessLogic;
using System.Xml.Schema;

namespace ChessAI
{
    public abstract class ChessAI
    {
        const int pawnValue = 1;
        const int knightValue = 3;
        const int bishopValue = 3;
        const int rookValue = 5;
        const int queenValue = 9;
        const int kingValue = 1000;




        public List<Move> GetAllPossibleMoves(GameState gameState)
        {
            IEnumerable<Move> newMoves;
            List<Move> moves = new List<Move> { };
            Position pos;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pos = new Position(i, j);

                    newMoves = gameState.LegalMovesForPiece(pos);

                    foreach (Move newMove in newMoves)
                    {
                        moves.Add(newMove);
                    }
                }
            }
            return (moves);
        }


        public abstract Move GenerateMove(GameState gameState);


        public int Evaluate(GameState gameState)
        {
            int pieceValueDiff = 0;

            int currentPlayerEval = 0;
            int opponentPlayerEval = 0;

            Piece[,] pieces = gameState.Board.GetPieces();


            foreach (Piece piece in pieces)
            {
                if (piece.Colour == gameState.CurrentPlayer)
                {
                    switch (piece.Type)
                    {
                        case PieceType.Pawn:
                            currentPlayerEval += pawnValue;
                            break;
                        case PieceType.Knight:
                            currentPlayerEval += knightValue;
                            break;
                        case PieceType.Bishop:
                            currentPlayerEval += bishopValue;
                            break;
                        case PieceType.Rook:
                            currentPlayerEval += rookValue;
                            break;
                        case PieceType.Queen:
                            currentPlayerEval += queenValue;
                            break;
                        case PieceType.King:
                            currentPlayerEval += kingValue;

                            break;
                    }
                }
                else
                {
                    switch (piece.Type)
                    {
                        case PieceType.Pawn:
                            opponentPlayerEval += pawnValue;
                            break;
                        case PieceType.Knight:
                            opponentPlayerEval += knightValue;
                            break;
                        case PieceType.Bishop:
                            opponentPlayerEval += bishopValue;
                            break;
                        case PieceType.Rook:
                            opponentPlayerEval += rookValue;
                            break;
                        case PieceType.Queen:
                            opponentPlayerEval += queenValue;
                            break;
                        case PieceType.King:
                            opponentPlayerEval += kingValue;
                            break;
                    }
                }


            }
            pieceValueDiff = currentPlayerEval - opponentPlayerEval;

            return pieceValueDiff;
        }



    }
}
