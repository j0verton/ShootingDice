using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("What number did you roll?");
            int roll = Int32.Parse(Console.ReadLine());
            return roll;
        }
    }
}