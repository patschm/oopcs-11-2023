
namespace FunctionProcs;

class Program
{
    static void Main(string[] args)
    {
        //var nr = GetNumber();
        var nr = Add(1,2,3,4, 5);
        DisplayNumber(nr2:53);

        int number;
        DoeIets(out number);
        System.Console.WriteLine(number);
    }

    static void DoeIets(out int xxx)
    {
        xxx = 20;
    }

    // Procedure
    static void DisplayNumber(int nr = 42, int nr2=43, string prefix = "Het getal is ")
    {
        int c = nr;
        System.Console.WriteLine(prefix + nr);
    }

    static int GetNumber()
    {
        System.Console.WriteLine("Geeft een getal");
        var snr = Console.ReadLine();
        if (int.TryParse(snr, out int nr))
        {
            return nr;
        }
        return int.Parse(snr!);
    }

    static int Add(params int[] nrs)
    {
        return nrs.Sum();
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

}
