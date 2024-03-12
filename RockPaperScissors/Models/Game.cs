using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public Game(string playerOne, string playerTwo)
    {
      Player1 = playerOne;
      Player2 = playerTwo;
    }
  }
}
