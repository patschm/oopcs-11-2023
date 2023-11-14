namespace Objecten;

public abstract class Lamp
{
    private int _lumen = 100;   
    public ConsoleColor Kleur { get; set;} =  ConsoleColor.Black;
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
    // Polymorf ready.
    // Afgeleidde classen kunnen OPTIONEEL overriden
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        Console.ResetColor();  
    }

    // Afgeleidde class moet implementeren.
    //public abstract void Aan();

}
