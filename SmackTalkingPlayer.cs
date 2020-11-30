using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public virtual string Taunt { get; } = "How'd ya like them apples!!";

        public override int Roll()
        {
            int roll = new Random().Next(DiceSize) + 1;
            Console.WriteLine($"{Name} rolls a {roll} and shouts '{Taunt}'");
            return roll;
        }


    }
}