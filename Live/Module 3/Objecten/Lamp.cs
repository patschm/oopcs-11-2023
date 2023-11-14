namespace Objecten;

public class Lamp
{
    // Fields. Hierin sla je de eigenschappen op.
    private int _lumen = 100;
    //private ConsoleColor kleur = ConsoleColor.DarkCyan;

    public ConsoleColor Kleur { get; set;} =  ConsoleColor.Black;
    // Property
    public int Lumen
    {
        get
        {
            return _lumen;
        }
        set
        {
            if (value >= 0 && value < 2000)
            {
                _lumen = value;
            }
        }
    }

    // Dit doen Javanen en C plus plusserts 
    public void SetLumen(int lumen)
    {
        if (lumen >= 0 && lumen < 2000)
        {
            _lumen = lumen;
        }
    }

    public int GetLumen()
    {
        return _lumen;
    }
    // Methods. Hierin definieer je gedrag.
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        Console.ResetColor();
    }

    // Constructor
    public Lamp()
    {

    }
    public Lamp(int lum, ConsoleColor color)
    {
        Lumen = lum;
        Kleur = color;
    }

}
