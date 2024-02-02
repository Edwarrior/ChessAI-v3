using ChessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessAI
{
    public class MinMaxAI : ChessAI
    {
        public override Move GenerateMove(GameState gameState)
        {
            Console.WriteLine(Evaluate(gameState));
            
            
            
            return null;


        }
    }
}
