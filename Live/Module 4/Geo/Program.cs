namespace Geo;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point {X = 10, Y = 20};
        Point p2 = new Point {X = 100, Y = 200};

        //Point p3 = Point.Add(p1, p2);
        Point p3 = p1 + p2;

        double dq = (double)p1;
        System.Console.WriteLine(dq);

        System.Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        // p1.Show();
        // p2.Show();
        // p3.Show();
    }
}
