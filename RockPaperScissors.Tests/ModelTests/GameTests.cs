using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_InputPlayerOneName_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string result = newGame.Player1;
      Assert.AreEqual(playerOneName, result);
    }

    [TestMethod]
    public void GameConstructor_InputPlayerTwoName_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string result = newGame.Player2;
      Assert.AreEqual(playerTwoName, result);
    }

    [TestMethod]
    public void DetermineWinner_CheckIfTie_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string winner = newGame.DetermineWinner("rock", "rock");
      Assert.AreEqual("It's a tie!", winner);
    }

    [TestMethod]
    public void DetermineWinner_CheckIfPlayer1Winner_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string winner = newGame.DetermineWinner("rock", "scissors");
      Assert.AreEqual("Ryan wins!", winner);
    }

    [TestMethod]
    public void DetermineWinner_CheckIfPlayer2Winner_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string winner = newGame.DetermineWinner("rock", "paper");
      Assert.AreEqual("Shane wins!", winner);
    }
  }
}


