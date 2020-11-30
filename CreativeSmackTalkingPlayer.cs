using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {

        List<string> Taunts = new List<string>
        {
        "Take that!", "How'd ya like them apples!!", "How'd ya like me now?!", "BOOYAH!!!!", "Givin ya the BUSINESS!"
        };

        public override string Taunt
        {
            get
            {
                int index = new Random().Next(Taunts.Count);
                return Taunts[index];
            }



        }
    }
}