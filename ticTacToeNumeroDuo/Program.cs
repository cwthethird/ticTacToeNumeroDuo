using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeNumeroDuo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] gameBoard = new string[3, 3];
            string currentPlayer = "X";
            int rowMove = 0;
            int columnMove = 0;
            bool gameOver = false;
            bool winOrDraw = false;
            char playAgain = ' ';
            Random random = new Random();
            IntitialiseGameBoard(gameBoard);
            DisplayBoard(gameBoard);

            while (!gameOver)
            {
                takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                DisplayBoard(gameBoard);
                winOrDraw = checkForWin(gameBoard);

                if (winOrDraw)
                {
                    Console.WriteLine("Do you want to play Y for yes and any other to exit.");
                    playAgain = Convert.ToChar(Console.ReadLine());

                    if (playAgain != 'Y')
                    {
                        gameOver = true;
                    }
                    else
                    {
                        IntitialiseGameBoard(gameBoard);
                        DisplayBoard(gameBoard);
                    }
                }
            }

        }

        private static void DisplayBoard(string[,] gameBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("===========================================================================================================================");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                   " + gameBoard[i, 0] + "                    |                    " + gameBoard[i, 1] + "                    |                   " + gameBoard[i, 2] + "                  |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");
                Console.WriteLine("|                                        |                                         |                                      |");

            }
            Console.WriteLine("===========================================================================================================================");

        }

        private static void IntitialiseGameBoard(string[,] gameBoard)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = " ";
                }

            }

        }

        private static bool checkForWin(string[,] gameBoard)
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] != " " && gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] != " " && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] != " " && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
                {
                    Console.WriteLine("WE HAVE A WINNER");
                    result = true;
                }
            }
            if (gameBoard[0, 0] != " " && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                Console.WriteLine("WE HAVE A WINNER");
                result = true;
            }
            if (gameBoard[0, 2] != " " && gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                Console.WriteLine("WE HAVE A WINNER");
                result = true;
            }

            return result;

        }
        private static void takeTurn(string[,] gameBoard, ref string currentPlayer, ref int rowMove, ref int columnMove, ref Random random)
        {
            Console.Write("Enter row number 1 to 3:");
            rowMove = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column number 1 to 3:");
            columnMove = Convert.ToInt32(Console.ReadLine());
            if (currentPlayer=="X")
            {
                if (gameBoard[rowMove - 1, columnMove - 1] == " ")
                {
                    gameBoard[rowMove - 1, columnMove - 1] = currentPlayer;
                    if (currentPlayer == "X")
                    {
                        currentPlayer = "O";
                    }
                    else
                    {
                        currentPlayer = "X";
                    }
                }
                else
                {
                    Console.WriteLine("POSITION ALREADY TAKEN. TRY AGAIN");
                    takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                }
            }
            else
            {
                rowMove = random.Next(3);
                columnMove = random.Next(3);
                if (gameBoard[rowMove, columnMove] == " ")
                {
                    gameBoard[rowMove, columnMove] = currentPlayer;
                    if (currentPlayer == "X")
                    {
                        currentPlayer = "O";
                    }
                    else
                    {
                        currentPlayer = "X";
                    }
                }
                else
                {
                    Console.WriteLine("POSITION ALREADY TAKEN. TRY AGAIN");
                    takeTurn(gameBoard, ref currentPlayer, ref rowMove, ref columnMove, ref random);
                }

            }
         
        }

    }
}





