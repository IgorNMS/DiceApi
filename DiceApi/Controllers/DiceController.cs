using DiceApi.Models;
using DiceApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DiceController
{
    [HttpGet("{diceType}", Name = "GetDice")]
    public IActionResult GetDiceNumber(DiceTypes diceType)
    {
        Dice diceResult = DiceService.GetNumber(diceType);
        return new OkObjectResult(diceResult);
    }
}