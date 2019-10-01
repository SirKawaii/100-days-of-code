using System;

namespace TicTacToe
{
    class Program
    {

        const int PLAYER_ONE = 1;
        const int PLAYER_TWO = 2;

        static int[,] playfield =
        {
            {0 ,0 ,0},
            {0 ,0 ,0},
            {0 ,0 ,0}
        };
        static void Main(string[] args)
        {
            int activeUser = 2;
            int currentInput = 0;



            Console.WriteLine("Welcome to the tic tac toe");


            DrawField();
            //switch the users and play
            do
            {
                // user one start the game.
                activeUser = activeUser == PLAYER_TWO ? PLAYER_ONE: PLAYER_TWO;
                EnterInput(activeUser);
                

            } while (!WinnerWinnerChickenDinner());


        }

        static void EnterInput(int user)
        {
            Console.WriteLine("Hey user {0} , pick a place", user);
            int userInput = Int32.Parse(Console.ReadLine());

        }


        static bool WinnerWinnerChickenDinner()
        {

            return true;
        }

        static void DrawField()
        {
            Console.Clear();
            Console.WriteLine("[0][1][2]");
            Console.WriteLine("[3][4][5]");
            Console.WriteLine("[6][7][8]");
        }
    }
}
