using System;

namespace IfStatementChallange2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "John";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Bilash");
            CheckHighScore(310, "Joyee");
            CheckHighScore(350, "John");

            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "         
                    + highscore + " and held by " + highscorePlayer);

            }
        }
    }
}
