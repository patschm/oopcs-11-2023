namespace Flows;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        for(x = 0;x <= 10;x++)
        {
            if (x == 5) continue;
            System.Console.WriteLine(x);
        }
        
        int a = 2;

        switch(a)
        {
            case 0:
            case 1:
                System.Console.WriteLine("een");
                break;
            case 2:
                System.Console.WriteLine("twee");
                break;
            default:
                System.Console.WriteLine("Def");
                break;
        }


        if (true == true)
        {

        }
        else
        {

        }
    }
}
