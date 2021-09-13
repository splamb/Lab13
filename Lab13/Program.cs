using System;

namespace Lab13
{
    class RPSApp
    {
        static void Main(string[] args)
        {
            RockPlayer lions = new RockPlayer();
            RandomPlayer tigers = new RandomPlayer();
            HumanPlayer player = new HumanPlayer();
            int playerWinCount = 0;
            int botWinCount = 0;
            Console.WriteLine("Please enter your name");
            player.name = Console.ReadLine();

            bool looper = true;

            while (looper == true)
            {
                string team = string.Empty;
                bool teamCheck = false;
                while (teamCheck != true)
                {
                    Console.WriteLine("Would you like to play against the Lions or the Tigers? (L/T)");
                    team = Console.ReadLine().ToLower();

                    if (team == "l")
                    {
                        teamCheck = true;
                    }
                    else if (team == "t")
                    {
                        teamCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input was invalid, please try again.");
                    }
                }

                RPS lionsRPS = lions.GenerateRPS();
                RPS tigersRPS = tigers.GenerateRPS();
                RPS userRPS = player.GenerateRPS();
                RPS botRPS = RPS.rock;
                string botTeamName = string.Empty;

                if (team == "l")
                {
                    botRPS = lionsRPS;
                    botTeamName = "The Lions";
                }

                if (team == "t")
                {
                    botRPS = tigersRPS;
                    botTeamName = "The Tigers";
                }

                Console.WriteLine($"{player.name}: {userRPS}\n{botTeamName} : {botRPS}");

                if (userRPS == RPS.rock && botRPS == RPS.rock)
                {
                    Console.WriteLine("Draw!");
                }
                else if (userRPS == RPS.rock && botRPS == RPS.paper)
                {
                    Console.WriteLine($"{botTeamName} wins!");
                    botWinCount++;
                }
                else if (userRPS == RPS.rock && botRPS == RPS.scissors)
                {
                    Console.WriteLine($"{player.name} wins!");
                    playerWinCount++;
                }
                else if (userRPS == RPS.paper && botRPS == RPS.rock)
                {
                    Console.WriteLine($"{player.name} wins!");
                    playerWinCount++;
                }
                else if (userRPS == RPS.paper && botRPS == RPS.paper)
                {
                    Console.WriteLine("Draw!");
                }
                else if (userRPS == RPS.paper && botRPS == RPS.scissors)
                {
                    Console.WriteLine($"{botTeamName} wins!");
                    botWinCount++;
                }
                else if (userRPS == RPS.scissors && botRPS == RPS.rock)
                {
                    Console.WriteLine($"{botTeamName} wins!");
                    botWinCount++;
                }
                else if (userRPS == RPS.scissors && botRPS == RPS.paper)
                {
                    Console.WriteLine($"{player.name} wins!");
                    playerWinCount++;
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine($"{player.name}: {playerWinCount}\nBot: {botWinCount}");

                bool continueCheck = false;

                while (continueCheck != true)
                {
                    Console.WriteLine("Would you like to play again? (y/n)");
                    string userContinue = Console.ReadLine().ToLower();

                    if (userContinue == "y")
                    {
                        looper = true;
                        continueCheck = true;
                    }
                    else if (userContinue == "n")
                    {
                        looper = false;
                        continueCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input was invalid. Please try again.");
                        continue;
                    }
                }                
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
