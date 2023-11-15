namespace TheFirm;

public class Fabian: Employee
{
    public void TypeScripting()
    {
        Console.WriteLine($"{nameof(Fabian)} typescript het product in elkaar");
    }

    public override void Works()
    {
        TypeScripting();
    }
}
