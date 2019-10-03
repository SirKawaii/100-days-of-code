using System;
using System.Collections.Generic;


namespace TicTacToe
{
    class Program
    {

        const int PLAYER_ONE = 1;
        const int PLAYER_TWO = 2;

        static char[,] playfield =
        {
            {'1' ,'2' ,'3'},
            {'4' ,'5' ,'6'},
            {'7' ,'8' ,'9'}
        };
        static char[,] defaultPlayField =
        {
            {'1' ,'2' ,'3'},
            {'4' ,'5' ,'6'},
            {'7' ,'8' ,'9'}
        };

        static void Main(string[] args)
        {
            int activeUser = 2;
            int currentplay = 0;
            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to the tic tac toe");
            Console.WriteLine("**************************");
            //switch the users and play
            do
            {
                DrawField();
                // user one start the game.
                activeUser = activeUser == PLAYER_TWO ? PLAYER_ONE: PLAYER_TWO;
                Console.WriteLine("\nUser 1 : [x]\nUser 2 : [o]");
                EnterInput(activeUser);
                DrawField();
            } while (!WinnerWinnerChickenDinner(activeUser) && currentplay <= 9);
            Console.WriteLine("Game has end.");
        }
        static void EnterInput(int user)
        {
            Console.WriteLine("Hey user {0} , pick a place", user);
            int userInput;
            bool completeInput = false;

            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("No number selected");
                else if (userInput <= 0 || userInput > 9)
                    Console.WriteLine("Out of bounds");
                else
                {
                    completeInput = SetInput(userInput, user);
                }
            } while (!completeInput);
        }

        static bool SetInput(int input,int user)
        {

            char avatar = user is 1 ? 'x' : 'o';
            Console.WriteLine("User {0} use the following avatar : {1}", user, avatar);
            // can be better with for cicle. maybe.
            switch (input)
            {
                case 1:
                    playfield[0,0] = avatar;
                    break;
                case 2:
                    playfield[0,1] = avatar;
                    break;
                case 3:
                    playfield[0, 2] = avatar;
                    break;
                case 4:
                    playfield[1, 0] = avatar;
                    break;
                case 5:
                    playfield[1, 1] = avatar;
                    break;
                case 6:
                    playfield[1, 2] = avatar;
                    break;
                case 7:
                    playfield[2, 0] = avatar;
                    break;
                case 8:
                    playfield[2, 1] = avatar;
                    break;
                case 9:
                    playfield[2, 2] = avatar;
                    break;
                default:
                    return false;
            }
            return true;
        }


        static bool WinnerWinnerChickenDinner(int player)
        {
            List<List<int[,]>> posibilities = new List<List<int[,]>> {
                new List<int[,]>{
                    new int[,] { { 0 }, { 0 }  },
                    new int[,] { { 0 }, { 1 }  },
                    new int[,] { { 0 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 1 }, { 0 }  },
                    new int[,] { { 1 }, { 1 }  },
                    new int[,] { { 1 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 2 }, { 0 }  },
                    new int[,] { { 2 }, { 1 }  },
                    new int[,] { { 2 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 0 }, { 0 }  },
                    new int[,] { { 1 }, { 0 }  },
                    new int[,] { { 2 }, { 0 }  }
                },
                 new List<int[,]>{
                    new int[,] { { 0 }, { 1 }  },
                    new int[,] { { 1 }, { 1 }  },
                    new int[,] { { 2 }, { 1 }  }
                },
                new List<int[,]>{
                    new int[,] { { 0 }, { 2 }  },
                    new int[,] { { 1 }, { 2 }  },
                    new int[,] { { 2 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 1 }, { 0 }  },
                    new int[,] { { 1 }, { 1 }  },
                    new int[,] { { 1 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 2 }, { 0 }  },
                    new int[,] { { 2 }, { 1 }  },
                    new int[,] { { 2 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 0 }, { 0 }  },
                    new int[,] { { 1 }, { 1 }  },
                    new int[,] { { 2 }, { 2 }  }
                },
                new List<int[,]>{
                    new int[,] { { 2 }, { 0 }  },
                    new int[,] { { 1 }, { 1 }  },
                    new int[,] { { 0 }, { 2 }  }
                },
            };

            foreach ( var list in posibilities){

                cell a = new cell
                {
                    x = list[0][0,0],
                    y = list[0][1,0]
                };
                cell b = new cell
                {
                    x = list[1][0, 0],
                    y = list[1][1, 0]
                };
                cell c = new cell
                {
                    x = list[2][0, 0],
                    y = list[2][1, 0]
                };
                if(IsWinner(a, b, c))
                {
                    Console.WriteLine("Player {0} has won.", player);
                    return true;
                }                  
            }
            return false;
        }

        static bool IsWinner(cell a, cell b ,cell c)
        {
            char[,] p = playfield;

            char first = p[a.x, a.y];
            char second = p[b.x, b.y];
            char third = p[c.x, c.y];
            return  first == second && second == third;
        }

        static void DrawField()
        {
            Console.Clear();
            Console.WriteLine("####### batlefield #######\n");
            for (int i = 0; i <= playfield.GetUpperBound(0); i++)
            {
                Console.Write("\t");
                for ( int j = 0; j <= playfield.GetUpperBound(1); j++)
                {
                    Console.Write("[{0}]",playfield[i,j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n##########################");
        }
    }

    class cell
    {
        public int x{ get; set; }
        public int y{ get; set; }
    }
}
