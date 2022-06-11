using System;
using System.Threading;

namespace Unity_Gamedev_learning_minigame
{
    class Program
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static char playerChar1 = 'x';
        static char playerChar2 = 'o';
        static int pos;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic tac Toe the mini game");
            do
            {
                // tictac toe board
                Board(); //function calling
                Console.WriteLine("toi luot player {0}", getChar()); // function calling
                pos = Convert.ToInt32(Console.ReadLine());
       
                CheckPosition();
                CheckWin(); //function calling

                int flag = CheckWin();
                if (flag == 1)
                {
                    Board();
                    Console.WriteLine("Player {0} won" , PlayerWin());
                    Console.ReadLine();
                    ResetGame();
                }
              
            } while (true);
           
        }

        //Functions for calling

        //check position
        private static void CheckPosition()
        {
            char c = board[pos];
            if(c == playerChar1 || c == playerChar2)
            {
                Console.WriteLine("Vi tri da dung");
                Thread.Sleep(1000);
                return;
            }
            board[pos] = getChar();
            player++;
        }

        //Checkwin 
       
         
        private static int CheckWin()
        {

            
            int i;
            for (i = 1; i < 9; i++)
            {
                if(board[i] == '-')
                {
                    break;
                }               
            }
            if (board[1] == board[2] && board[2] == board[3] && board[3] != '-')
            {
                return 1;
            }
            if (board[4] == board[5] && board[5] == board[6] && board[6] != '-')
            {
                return 1;
            }
            if (board[7] == board[8] && board[8] == board[9] && board[9] != '-')
            {
                return 1;
            }
            if (board[1] == board[4] && board[4] == board[9] && board[9] != '-')
            {
                return 1;
            }
            if (board[3] == board[5] && board[5] == board[7] && board[7] != '-')
            {
                return 1;
            }
            if (board[1] == board[4] && board[4] == board[7] && board[7] != '-')
            {
                return 1;
            }
            if (board[2] == board[5] && board[5] == board[8] && board[8] != '-')
            {
                return 1;
            }
            if (board[3] == board[6] && board[6] == board[9] && board[9] != '-')
            {
                return 1;
            }
            if (i > 9)
            {
                return -1; //named by us 
            }
            return 0;
            
        

        }
        private static void ResetGame()
        {
            for (int i = 1; i <= 9; i++)
            {
                board[i] = '-';   
            }
            player = 1;

        }
        private static char PlayerWin()
        {
            player = player % 2 == 0 ? 1 : 2;
            return getChar();
        }

        //logic
        private static char getChar()
        {
            return player % 2 == 0 ? playerChar1 : playerChar2;
        }

        // Replace function
        private static char getplayerChar(char c)
        {
            if (c == '-')
            {
                return ' '; // return
            }
            return c;
        }

        //Board
        private static void Board()
        {
            Console.Clear();
            Console.WriteLine("Player 1 = {0} and Player 2  = {1}", playerChar1, playerChar2);

            Console.WriteLine("\n");
            Console.WriteLine("BOARD\n");


            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[1]), getplayerChar(board[2]), getplayerChar(board[3]));
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[4]), getplayerChar(board[5]), getplayerChar(board[6]));
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", getplayerChar(board[7]), getplayerChar(board[8]), getplayerChar(board[9]));
        }


       
        private static int CheckWin2()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (board[1] == board[2] && board[2] == board[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (board[4] == board[5] && board[5] == board[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (board[3] == board[6] && board[6] == board[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (board[1] == board[5] && board[5] == board[9])
            {
                return 1;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4' && board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }

        }
    }
}
