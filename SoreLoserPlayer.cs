using System;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????

    public class SoreLoserPlayer : Player
    {
        static void SoreLoser(int num, int num2)
        {
            // If num is an odd number, throw an ArgumentException.
            if (num < num2)
                throw new ArgumentException(String.Format("{0} is better than {1}", num, num2),"not cool");;
        }

        public override void Play(Player other)
        {
            

            

            try
            {
                // Call roll for "this" object and for the "other" object
                int myRoll = Roll();
                int otherRoll = other.Roll();

                //We'll test here if an exception needs to be thrown
                SoreLoser(myRoll, otherRoll);

                Console.WriteLine($"{Name} rolls a {myRoll}");
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
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
            }
        }   
    }
}