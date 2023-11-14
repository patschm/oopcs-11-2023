namespace Gebouw;

public class Etage
{
    public int Nummer { get; set; }
    public static Lift lift = new Lift();

    public void CallLift()
    {
        Etage.lift.Call(this.Nummer);
    }
    public void ShowLiftStatus()
    {   
        Console.WriteLine($"Lift staat op de {lift.CurrentFloor}e verdieping");
    }

}



public class Lift
{
    public int CurrentFloor { get; set; } = 0;

    public void Call(int floor)
    {
        Console.WriteLine($"Zzzzzzzt (naar de {floor}e)");
        CurrentFloor = floor;
    }
}