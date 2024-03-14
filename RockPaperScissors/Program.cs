using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Welcome to rock, paper scissors!");
      Console.WriteLine("Player 1, please enter your name: ");
      string playerOne = Console.ReadLine();
      Console.WriteLine("Player 2, please enter your name: ");
      string playerTwo = Console.ReadLine();

      Game newGame = new Game(playerOne, playerTwo);
      Console.WriteLine(playerOne + " rock, paper or scissors?");
      string playerOneInput = Console.ReadLine();
      Console.WriteLine(playerTwo + " rock, paper or scissors?");
      string playerTwoInput = Console.ReadLine();
      Console.WriteLine(newGame.DetermineWinner(playerOneInput, playerTwoInput));
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
  }
}