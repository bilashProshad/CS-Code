using System;

namespace TicTacToeExercise
{
    class Program
    {
        //play field
        static char[,] playField =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

        static void Main(string[] args)
        {
            int player = 2;
            string input;
            int inputNumber;
            bool play = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                }
                else if (player == 1)
                {
                    player = 2;
                }

                SetField();
            John:
                Console.Write("Player {0}: Choose your field! ", player);
                input = Console.ReadLine();
                if(int.TryParse(input, out inputNumber))
                {
                    if (CheckInput(inputNumber))
                    {
                        bool isChecked = ChangeField(player, inputNumber);
                        if (!isChecked)
                        {
                            goto John;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter only number between 1 and 9");
                        goto John;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter only number between 1 and 9");
                    goto John;
                }

                if (GameOver())
                {
                    Console.Clear();
                    SetField();
                    Console.WriteLine("Game Over");
                    Console.WriteLine("Winner is Player {0}", Winner());
                    Console.WriteLine("Press 1 to continue the game");
                    Console.WriteLine("Press 2 for exit");

                    int count = 49;
                    int i = int.Parse(Console.ReadLine());

                    if (i == 2)
                        break;
                    else
                    {
                        for(int j=0; j<3; j++)
                        {
                            for(int k=0; k<3; k++)
                            {
                                playField[j, k] = (char)count;
                                count++;
                            }
                        }
                    }
                }

                else if (Draw())
                {
                    Console.Clear();
                    SetField();
                    Console.WriteLine("Game Over");
                    Console.WriteLine("Match is draw");
                    Console.WriteLine("Press 1 to continue the game");
                    Console.WriteLine("Press 2 for exit");

                    int count = 49;
                    int i = int.Parse(Console.ReadLine());

                    if (i == 2)
                        break;
                    else
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                playField[j, k] = (char)count;
                                count++;
                            }
                        }
                    }
                }

                Console.Clear();
            } while (play);

            
            Console.ReadKey();
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0,0], playField[0,1], playField[0,2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("_____|_____|_____");
        }

        public static bool CheckInput(int input)
        {
            if (input >= 1 && input <= 9)
                return true;
            return false;
        }


        public static bool ChangeField(int player, int input)
        {
            char eitherXorY = ' ';
            int count = 0;

            if (player == 1)
                eitherXorY = 'X';
            else if (player == 2)
                eitherXorY = 'O';

            switch (input)
            {
                case 1:
                    if (playField[0, 0] != 'O' && playField[0, 0] != 'X')
                    {
                        playField[0, 0] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 2:
                    if (playField[0, 1] != 'O' && playField[0, 1] != 'X')
                    {
                        playField[0, 1] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 3:
                    if (playField[0, 2] != 'O' && playField[0, 2] != 'X')
                    {
                        playField[0, 2] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 4:
                    if (playField[1, 0] != 'O' && playField[1, 0] != 'X')
                    {
                        playField[1, 0] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 5:
                    if (playField[1, 1] != 'O' && playField[1, 1] != 'X')
                    {
                        playField[1, 1] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 6:
                    if (playField[1, 2] != 'O' && playField[1, 2] != 'X')
                    {
                        playField[1, 2] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 7:
                    if (playField[2, 0] != 'O' && playField[2, 0] != 'X')
                    {
                        playField[2, 0] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 8:
                    if (playField[2, 1] != 'O' && playField[2, 1] != 'X')
                    {
                        playField[2, 1] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
                case 9:
                    if (playField[2, 2] != 'O' && playField[2, 2] != 'X')
                    {
                        playField[2, 2] = eitherXorY;
                        count = 1;
                    }
                    else
                        Console.WriteLine("Sorry, you can't override other players input");
                    break;
            }
            if (count == 1)
                return true;
            return false;
        }

        public static bool GameOver()
        {
            if (playField[0, 0] == playField[1, 1] && playField[0, 0] == playField[2, 2])
                return true;
            else if (playField[1, 1] == playField[0, 2] && playField[1, 1] == playField[2, 0])
                return true;
            else if (playField[0, 0] == playField[1, 0] && playField[0, 0] == playField[2, 0])
                return true;
            else if (playField[0, 1] == playField[1, 1] && playField[0, 1] == playField[2, 1])
                return true;
            else if (playField[0, 2] == playField[1, 2] && playField[0, 2] == playField[2, 2])
                return true;
            else if (playField[0, 0] == playField[0, 1] && playField[0, 0] == playField[0, 2])
                return true;
            else if (playField[1, 0] == playField[1, 1] && playField[1, 0] == playField[1, 2])
                return true;
            else if (playField[2, 0] == playField[2, 1] && playField[2, 0] == playField[2, 2])
                return true;
            else
                return false;
           
        }

        public static int Winner()
        {
            if (playField[0, 0] == 'X' && playField[1, 1] == 'X' && playField[2, 2] == 'X')
                return 1;
            else if (playField[1, 1] == 'X' && playField[0, 2] == 'X' && playField[2, 0] == 'X')
                return 1;
            else if (playField[0, 0] == 'X' && playField[1, 0] == 'X' && playField[2, 0] == 'X')
                return 1;
            else if (playField[0, 1] == 'X' && playField[1, 1] == 'X' && playField[2, 1] == 'X')
                return 1;
            else if (playField[0, 2] == 'X' && playField[1, 2] == 'X' && playField[2, 2] == 'X')
                return 1;
            else if (playField[0, 0] == 'X' && playField[0, 1] == 'X' && playField[0, 2] == 'X')
                return 1;
            else if (playField[1, 0] == 'X' && playField[1, 1] == 'X' && playField[1, 2] == 'X')
                return 1;
            else if (playField[2, 0] == 'X' && playField[2, 1] == 'X' && playField[2, 2] == 'X')
                return 1;
            else
                return 2;
        }

        public static bool Draw()
        {
            if (playField[0, 0] != '1' && playField[0, 1] != '2' && playField[0, 2] != '3' && playField[1, 0] != '4'
                && playField[1, 1] != '5' && playField[1, 2] != '6' && playField[2, 0] != '7' && playField[2, 1] != '8'
                && playField[2, 2] != '9')
                return true;
            return false;
        }
    }
}
