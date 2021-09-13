using System;
using System.Collections.Generic;
using System.Text;


namespace Lab13
{
    public abstract class Player
    {
        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public abstract RPS GenerateRPS();
    }

    public enum RPS
    {
        rock,
        paper,
        scissors
    }

    public class RockPlayer : Player
    {
        public override RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }

    public class RandomPlayer : Player
    {
        public override RPS GenerateRPS()
        {
            Random _R = new Random();

            var v = Enum.GetValues(typeof(RPS));
            return (RPS)v.GetValue(_R.Next(v.Length));
        }
    }

    public class HumanPlayer : Player
    { 
        public override RPS GenerateRPS()
        {
            Console.WriteLine("Rock, paper, or scissors? (R/P/S)");
            string userInput = Console.ReadLine().ToLower();
            
            if (userInput == "r")
            {
                return RPS.rock;
            }
            else if(userInput == "p")
            {
                return RPS.paper;
            }
            else
            {
                return RPS.scissors;
            }
        }
    }
}
