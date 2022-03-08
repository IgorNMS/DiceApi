using DiceApi.Models;

namespace DiceApi.Services;

internal class DiceService
{
    public static Dice GetNumber(DiceTypes diceTypes)
    {
        Dice dices;
        Random randomDiceNumber = new Random();
        switch (diceTypes)
        {
            case DiceTypes.D4:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D4 + 1)
                };
                return dices;
            case DiceTypes.D6:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D6 + 1)
                };
                return dices;
            case DiceTypes.D8:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D8 + 1)
                };
                return dices;
            case DiceTypes.D10:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D10 + 1)
                };
                return dices;
            case DiceTypes.D12:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D12 + 1)
                };
                return dices;
            case DiceTypes.D20:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D20 + 1)
                };
                return dices;
            default:
                dices = new Dice
                {
                    Result = randomDiceNumber.Next(1, (int)DiceTypes.D6 + 1)
                };
                return dices;
        }
    }
}