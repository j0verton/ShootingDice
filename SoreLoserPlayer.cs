using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void DeclareWinner(Player player1, int roll1, Player player2, int roll2)
        {
            Console.WriteLine($"{player1.Name} rolls a {roll1}");
            Console.WriteLine($"{player2.Name} rolls a {roll2}");
            if (roll1 > roll2)
            {
                Console.WriteLine($"{player1.Name} Wins!");
            }
            else if (roll1 < roll2)
            {
                throw new System.ArgumentException($"{player1.Name} says, 'This game sucks, I quit!'");

            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}