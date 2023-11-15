namespace Ikkuh;

class Program
{
    static void Main(string[] args)
    {
        Patrick pat = new Patrick();
        Willem willem = new Willem();

        willem.Execute(pat.Opdracht);
        //pat.Opdracht();

        Taak t1 =pat.Opdracht;

        willem.Execute(Ontplof);
    }

    static void Ontplof()
    {
        System.Console.WriteLine("Kabooom");
    }
}
