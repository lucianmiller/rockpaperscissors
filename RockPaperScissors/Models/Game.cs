using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public Dictionary<string, string> RPS = new Dictionary<string, string>() { {"rock", "scissors"}, {"paper", "rock"}, {"scissors", "paper"} };

    public Game(string playerOne, string playerTwo)
    {
      Player1 = playerOne;
      Player2 = playerTwo;
    }

    public string DetermineWinner(string p1, string p2)
    {
      if (p1 == p2)
      {
        return "It's a tie!";
      }
      if (RPS[p1] == p2)
      {
        return Player1 + " wins!";
      }
      else
      {
        return Player2 + " wins!";
      }
    }
  }
}
