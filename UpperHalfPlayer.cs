using System;

namespace ShootingDice
{

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int newFloor = DiceSize / 2;
            return new Random().Next(newFloor, DiceSize) + 1;
        }
    }
}