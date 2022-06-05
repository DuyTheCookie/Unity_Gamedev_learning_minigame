using System;

namespace Unity_Gamedev_learning_minigame
{
    class Program
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static char playerChar1 = 'x';
        static char playerChar2 = 'o';
        static int pos;
        static void Main (string[] args)
        {
            Console.WriteLine("Welcome to Tic tac Toe the mini game");
            Console.WriteLine("Player 1 = {0} and Player 2  = {1}", playerChar1, playerChar2);

            Console.WriteLine("\n");
            Console.WriteLine("BOARD\n");

            // tictac toe board
            Board(); //function calling
        }
        
        private static char getplayerChar(char c)
        {
            if(c == '-')
            {
                return ' ';
            }
            return c;
        }

        //Board
        private static void Board()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[1]), getplayerChar(board[2]), getplayerChar(board[3]));
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[4]), getplayerChar(board[5]), getplayerChar(board[6]));
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[7]), getplayerChar(board[8]), getplayerChar(board[9]));
        }
    }
}