using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; } = new List<string>(){
            "\"You smell like farts!\"",
            "\"I used to date guys like you in prison!\"",
            "\"Does your mom know you're gambling?\"",
            "\"Go screw!\"",
            "\"You're gonna lose!!!\""
        };

        public override void Play(Player other)
        {
            int randomNumber = new Random().Next(0, Taunts.Count);
            Console.WriteLine(Taunts[randomNumber]);
            base.Play(other);
        }
    }
}