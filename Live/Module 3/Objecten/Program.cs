namespace Objecten;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int[] aas = new int[5];

        string name = "Kees";
        string[] names = new string[5];

        Lamp[] lampen = new Lamp[5];
        
        // Big Bang
        Lamp l1 = new Lamp(300, ConsoleColor.Green);
        //l1.kleur = ConsoleColor.Yellow;
        //l1.lumen = 200;

        l1.Aan();

        Lamp l2 = new Lamp();
        l2.Aan();


        Lamp l3 = new()
        {
            Kleur = ConsoleColor.Red,
            Lumen = 400
        };
        //l3.lumen = -200;
        l3.SetLumen(-300);
        l3.Lumen = 200;
        l3.Aan();


        Lamp l4 = new();


        // Big Crunch
        
    }
}
