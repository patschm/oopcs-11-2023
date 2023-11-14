namespace Objecten;

public class TL : Lamp
{
    public int StartTime { get; set; } = 4;
    public  override void Aan()
    {
        for(int i = 0; i < StartTime; i++)
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine("Start");
            Task.Delay(100).Wait();
            Console.ResetColor();
            Console.Clear();    
            Task.Delay(100).Wait();
        }

        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        Console.ResetColor();  
        base.Aan();
        //base._lumen
    }
}
