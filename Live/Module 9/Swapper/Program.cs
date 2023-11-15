
namespace Swapper;


class X
{
    public override string ToString()
    {
        return "X";
    }
}
class Y: X{

}
class Point<T>
{
    public T X { get; set; }
    public T Y { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Point<float> p1 = new Point<float>{X=3.5F, Y=4.2F};

        double a = 10F;
        double b = 20F;

        Console.WriteLine($"a={a}, b={b}");
        Swap<double>(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");

        X x1 = Create<Y>();
        System.Console.WriteLine(x1);
    }

    static T Create<T>() where T: new()
    {
        return new T();
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }
    // static void Swap(ref int a, ref int b)
    // {
    //     int tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref long a, ref long b)
    // {
    //     long tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref float a, ref float b)
    // {
    //     float tmp = a;
    //     a = b;
    //     b = tmp;
    // }
}
