namespace TheFirm;

public class ACME
{
    private IContract[] werknemers = new IContract[10];

    public void Hire(IContract emp)
    {
        for(int i = 0; i < werknemers.Length; i++)
        {
            if (werknemers[i] == null)
            {
                werknemers[i] = emp;
                return;
            }

        }
    }
    public void Stoomfluit()
    {
        Console.Beep(1000, 1500);
        Console.WriteLine("ACME gaat produceren");
        foreach(IContract e in werknemers)
        {
            e?.Werken();
        }
    }
}
