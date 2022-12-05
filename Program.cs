using System;
using System.Collections.Generic;
using SimpleGame.Model;

namespace SimpleGame
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's play a game! \nWhat is your name?");
      string userName = Console.ReadLine();
      Game game = new Game(userName);
      Console.WriteLine($"{game.GetName()}, here are the rules of the game: ");
      Console.WriteLine($"1. You add points to your point total one by one. \nHere are your total points: {game.GetPointTotal()}");
      Console.WriteLine($"2. You continue playing until your state of mind is thrilled. \n Here is your state of mind in the game: {game.GetStateOfMind()}");

      Console.WriteLine($"Here we go! \nPoint Total: {game.GetPointTotal()} \nState Of Mind: {game.GetStateOfMind()}");

      while (game.GetStateOfMind() != "thrilled")
      {
        game.DetermineNextSteps();
        Console.WriteLine($"Point Total: {game.GetPointTotal()}");
        Console.WriteLine($"State Of Mind: {game.GetStateOfMind()}");
        
        if (game.GetStateOfMind() == "thrilled")
        {
          Console.WriteLine("You win!");
        }
        else
        {
          Console.WriteLine("Keep playing...");
        }

      }
    }
  }
}