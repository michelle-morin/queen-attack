using System;

namespace Game.Moves
{
  public class Queen
  {
    private int _xPos;
    private int _yPos;

    public Queen(int xPos, int yPos)
    {
      _xPos = xPos;
      _yPos = yPos;
    }
    public void CheckAttack(int oppPosX, int oppPosY)
    {
      int xDiff = _xPos - oppPosX;
      int yDiff = _yPos - oppPosY;
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
}