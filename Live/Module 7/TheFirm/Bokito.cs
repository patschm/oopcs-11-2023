namespace TheFirm;

public class Bokito : IContract, IContract2
{
    public void Werken()
    {
        Works();
    }
    void IContract2.Werken()
    {
        Console.WriteLine("Gedraagt zich");
    }

    public void Works()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }
}
