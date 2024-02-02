using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLogic;

namespace ChessAI
{
    public class RandomAI : ChessAI
    {

        public override Move GenerateMove(GameState gameState)
        {
            List<Move> moves = GetAllPossibleMoves(gameState);
            Random rnd = new Random();
            return moves[rnd.Next(0, moves.Count)];
        }






    }


}
