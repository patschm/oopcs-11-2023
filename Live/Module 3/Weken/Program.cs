namespace Weken;


enum WeekDay
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64
}

class Program
{
    static void Main(string[] args)
    {
        Weken.WeekDay weekdag = WeekDay.Tuesday;

        System.Console.WriteLine((int)weekdag);
        int dag = 7;
        System.Console.WriteLine((WeekDay)dag);
    }
}



