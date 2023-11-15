namespace Ikkuh;

public interface ITaak 
{
    void Doe();
}
public delegate void Taak();

public class Willem
{
    public void Execute(Taak functie)
    {
        System.Console.WriteLine("Willem gaat dit doen:");
        functie();
    }
    public void Execute(ITaak obj)
    {
        System.Console.WriteLine("Willem gaat dit doen:");
        obj.Doe();
    }
}
