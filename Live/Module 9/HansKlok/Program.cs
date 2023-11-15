
namespace HansKlok;

class Program
{
    static void Main(string[] args)
    {
       Point p1 = new Point {X=10, Y = 20};
       System.Console.WriteLine(p1);
       DoeIets(p1);
       System.Console.WriteLine(p1);
    }

    private static void DoeIets(Point px)
    {
        px.X += 100;
        px.Y += 200;
    }
}
