using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        public List<string> ListOfTaunts= new List<string>
        {
            "Looks like your bringing your 'F' game today",
            "I sure would be embarrased if my dice looked like yours.",
            "If I had child as ugly as you I'd shave thier butt and make them walk backwards",
            "You eat dogcrap for breakfast, geek",
            "You bob for apples in your toilet, And You Like It",
            "Your an L-7 weenie"
        };

        public override void Play(Player other)
        {
            int numberForPickingAtRandom = new Random().Next(0,ListOfTaunts.Count);

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{Name} taunts {other.Name}, '{ListOfTaunts[numberForPickingAtRandom]}'");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}