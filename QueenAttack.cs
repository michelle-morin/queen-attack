using System;
using System.Collections.Generic;

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
public class Queen
{
  public int XPos;
  public int YPos;

  public Queen(int xPos, int yPos)
  {
    XPos = xPos;
    YPos = yPos;
  }
  public void CheckAttack(int oppPosX, int oppPosY)
  {
    int xDiff = XPos - oppPosX;
    int yDiff = YPos - oppPosY;
    if (xDiff == 0 || yDiff ==0 || Math.Abs(xDiff) == Math.Abs(yDiff))
    {
      Console.WriteLine("The Queen can attack her opponent.");
    }
    else
    {
      Console.WriteLine("The opponent is safe from Her Majesty.");
    }
  }
}