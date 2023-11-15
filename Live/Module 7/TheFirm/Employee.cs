
namespace TheFirm;

public abstract class Employee : Person, IContract
{
    public void Werken()
    {
        Works();
    }

    public abstract void Works();
}
