namespace TheFirm;

class Program
{
    static void Main(string[] args)
    {
        object a1 = 3;

        ACME firm = new ACME();
        Fabian fabian = new Fabian();
        Ruud ruud = new Ruud();
        Willem willem = new Willem();
        Bokito bok = new Bokito();

        firm.Hire(bok);
        firm.Hire(willem);
        firm.Hire(fabian);
        firm.Hire(ruud);
        firm.Stoomfluit();

    }
}
