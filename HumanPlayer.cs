using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            bool entering = true;
            int output = 0;
            while (entering)
            {
                try
                {
                    Console.WriteLine("Human! What is your roll? (1-6)");
                    Console.Write(" > ");
                    string input = Console.ReadLine();
                    output = int.Parse(input);
                    if (output > 0 && output <= 6)
                    {
                        entering = false;
                    }
                    else
                    {
                        throw new Exception("That number won't do!");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.Error.WriteLine($"Error! {ex.Message}");
                }
            }
            return output;
        }
    }
}