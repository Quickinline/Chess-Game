using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    public static class Board
    {
        private const int _WIDTH = 8;
        private const int _HEIGHT = 8;


        private static square[,] _grid = new square[8, 8];

        public static square[,] Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        public static void Init_Board()
        {
            for (int i = 0; i < _WIDTH; i++)
            {
                for (int j = 0; j < _HEIGHT; j++)
                {
                    _grid[i, j] = square.empty;
                    if (j == 1) { _grid[i, j] = square.Pawn_White; }
                    if (j == _HEIGHT - 2) { _grid[i, j] = square.Pawn_Black; }
                    if (i == 0 || i == _HEIGHT - 1)
                    {
                        if (j == 0) _grid[i, j] = square.Tower_White;
                        else if (j == _HEIGHT - 1) _grid[i, j] = square.Tower_Black;
                    }
                    if (i == 1 || i == _WIDTH - 2)
                    {
                        if (j == 0) _grid[i, j] = square.Horse_White;
                        if (j == _HEIGHT - 1) _grid[i, j] = square.Horse_Black;
                    }
                    if (i == 2 || i == _WIDTH - 3)
                    {
                        if (j == 0) _grid[i, j] = square.Bishop_White;
                        if (j == _HEIGHT - 1) _grid[i, j] = square.Bishop_Black;
                    }
                    if (i == 3)
                    {
                        if (j == 0) _grid[i, j] = square.Queen_White;
                        if (j == _HEIGHT - 1) _grid[i, j] = square.Queen_Black;
                    }
                    if (i == 4)
                    {
                        if (j == 0) _grid[i, j] = square.King_White;
                        if (j == _HEIGHT - 1) _grid[i, j] = square.King_Black;
                    }

                }
            }
        }

        static void Get_Available(int x, int y)
        {

        }


        public static bool Is_Black(square item)
        {
            if (item >= square.Pawn_Black && item <= square.Tower_Black) { return true; }
            else return false;
        }
        public static bool Is_White(square item)
        {
            if (item < square.Tower_White) return true;
            else return false;
        }

    }


    public enum square
    {
        //White pieces
        Pawn_White,
        King_White,
        Queen_White,
        Bishop_White,
        Horse_White,
        Tower_White,

        //Black Pieces
        Pawn_Black,
        King_Black,
        Queen_Black,
        Bishop_Black,
        Horse_Black,
        Tower_Black,

        //blank
        empty,
    }
}
