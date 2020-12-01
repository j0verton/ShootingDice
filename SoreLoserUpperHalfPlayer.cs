using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
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