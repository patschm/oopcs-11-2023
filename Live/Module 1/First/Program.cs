namespace First;

class Program
{
    static void Main(string[] args)
    {
        int? age = null;
        Console.WriteLine(age ?? 10);
        int leeftijd = 420000;
        bool oka = false;
        bool okb = false;
        string? name = null;
        //char first = 'P';

        int result = 6/4;
        System.Console.WriteLine(6/4);

        byte bleeftijd = (byte)leeftijd;
        System.Console.WriteLine(bleeftijd);

        //leeftijd = leeftijd + 1;
        System.Console.WriteLine(name?.Length);
        System.Console.WriteLine(oka && DoeIets());
        int a = 1;
        int b = 2;
        System.Console.WriteLine(a & b);
    }

    static bool DoeIets()
    {
        System.Console.WriteLine("Doet iets");
        return true;
    }
}
