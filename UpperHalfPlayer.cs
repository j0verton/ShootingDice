using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public int highRoll()
        {
            return new Random().Next(3, 6) + 1;
        }
        public override void Play(Player other)
        {
            int myRoll = highRoll();
            int otherRoll = other.Roll();
            DeclareWinner(this, myRoll, other, otherRoll);
        }
    }
}