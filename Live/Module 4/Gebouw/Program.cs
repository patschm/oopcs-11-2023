namespace Gebouw;

class Program
{
    static void Main(string[] args)
    {

        Etage.lift.Call(3);

        Etage[] flat = new Etage[30];

        for(int idx = 0; idx < flat.Length; idx++)
        {
            flat[idx] = new Etage {Nummer = idx};
        }

        flat[21].CallLift();

        foreach(Etage et in flat)
        {
            et.ShowLiftStatus();
        }
    }
}
