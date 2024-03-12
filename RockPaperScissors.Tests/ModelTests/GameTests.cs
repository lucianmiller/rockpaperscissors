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
    public void GetUserNames_InputPlayerOneName_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string result = newGame.Player1;
      Assert.AreEqual(playerOneName, result);
    }

        [TestMethod]
    public void GetUserNames_InputPlayerTwoName_String()
    {
      string playerOneName = "Ryan";
      string playerTwoName = "Shane";
      Game newGame = new Game(playerOneName, playerTwoName);
      string result = newGame.Player2;
      Assert.AreEqual(playerTwoName, result);
    }
  }
}


