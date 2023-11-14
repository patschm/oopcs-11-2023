namespace Objecten;

class Program
{
    static void Main(string[] args)
    {
        // Generaliseren
        Lamp l1 = new TL {Kleur = ConsoleColor.DarkYellow, StartTime = 5};

        l1.Aan();
        //((TL)l1).Aan();

        // Lamp l3 = new Lamp
        // {
        //     Kleur = ConsoleColor.Red,
        //     Lumen = 400
        // };

        // l3.Aan();
        
    }
}
