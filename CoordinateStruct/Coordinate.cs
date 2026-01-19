namespace CoordinateStruct;

public struct Coordinate
{
    public int X {get; init;}
    public int Y {get; init;}
    
    public Coordinate(int x, int y)
    {
      X = x;
      Y = y;
    }

    public bool IsCoordinateAdjacent(Coordinate coordinate)
    {
        if (coordinate.X - 1 == X || coordinate.Y - 1 == Y)
        {
            Console.WriteLine("Adjacent");
            return true;
        }
        Console.WriteLine("Not adjacent");
        return false;
        
    }
}