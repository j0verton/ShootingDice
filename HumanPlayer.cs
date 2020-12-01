using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {

            while (true)
            {
                Console.WriteLine("What number did you roll?");

                string userRoll = Console.ReadLine();
                try
                {
                    int roll = int.Parse(userRoll);
                    return roll;
                }
                catch (Exception)
                {
                    continue;
                }


            }
        }
    }
}