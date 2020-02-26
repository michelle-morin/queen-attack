using System;
using System.Collections.Generic;
using Game.Moves;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Where is your queen?  Give us her horizontal position");
      string queenStringX = Console.ReadLine();
      Console.WriteLine("What is your queen's vertical position?");
      string queenStringY = Console.ReadLine();
      int queenPosX = int.Parse(queenStringX);
      int queenPosY = int.Parse(queenStringY);
      Queen inputQueen = new Queen(queenPosX, queenPosY);
      Console.WriteLine("Where is your opponent?  Give us their horizontal position");
      string oppStringX = Console.ReadLine();
      Console.WriteLine("What is your opponent's vertical position?");
      string oppStringY = Console.ReadLine();
      int oppPosX = int.Parse(oppStringX);
      int oppPosY = int.Parse(oppStringY);
      inputQueen.CheckAttack(oppPosX, oppPosY);
    }
  }
}