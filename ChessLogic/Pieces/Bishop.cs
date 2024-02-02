﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Colour { get; }


        private static readonly Direction[] dirs = new Direction[]
        {
                Direction.NorthWest,
                Direction.NorthEast,
                Direction.SouthWest,
                Direction.SouthEast
        };


        public Bishop(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }


    }

}




