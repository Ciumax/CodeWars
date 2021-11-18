using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,] { { 2, 2, 2 }, { 0, 2, 2 }, { 0, 0, 0 } };
            IsSolved(board);
        }

        static public int IsSolved(int[,] board)
        { 
            for(int i = 1; i < 3; i++)
            {
            if(board[0,0] == i && board[0,1] == i && board[0,2] == i) return i; 
            if(board[1,0] == i && board[1,1] == i && board[1,2] == i) return i;
            if(board[2,0] == i && board[2,1] == i && board[2,2] == i) return i;
            if(board[0,0] == i && board[1,0] == i && board[2,0] == i) return i;
            if(board[0,1] == i && board[1,1] == i && board[2,1] == i) return i;
            if(board[0,2] == i && board[1,2] == i && board[2,2] == i) return i;

            if(board[2,0] == i && board[1,1] == i && board[0,2] == i) return i;
            if(board[0,0] == i && board[1,1] == i && board[2,2] == i) return i;
            }
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j] == 0) return -1;
                }
            }
            return 0;
        }
    }
}
