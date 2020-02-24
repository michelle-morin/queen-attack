using System;

class QueenAttack
{
  static void Main()
  {
    Console.WriteLine("Where is your queen?  Give us her horizontal position");
    string queenStringX = Console.ReadLine();
    Console.WriteLine("What is your queen's vertical position?");
    string queenStringY = Console.ReadLine();
    int queenPosX = int.Parse(queenStringX);
    int queenPosY = int.Parse(queenStringY);
    Console.WriteLine("Where is your opponent?  Give us their horizontal position");
    string oppStringX = Console.ReadLine();
    Console.WriteLine("What is your opponent's vertical position?");
    string oppStringY = Console.ReadLine();
    int oppPosX = int.Parse(oppStringX);
    int oppPosY = int.Parse(oppStringY);
    int xDiff = queenPosX - oppPosX;
    int yDiff = queenPosY - oppPosY;
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