namespace Geo;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point a, Point b)
    {
        return new Point {X = a.X + b.X, Y = a.Y + b.Y};
    }

    public static explicit operator double(Point p)
    {
        return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2)); 
    }

    public void Show()
    {
        System.Console.WriteLine($"({X}, {Y})");
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
