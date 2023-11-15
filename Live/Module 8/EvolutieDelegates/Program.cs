
namespace EvolutieDelegates;


delegate int MathDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int res = m1(1,2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        res = m2(2,3);

        int c = 10;
        MathDel m3 = delegate(int a, int b) {
            return a + b + c;
        };
        res = m3(3,4);

        // 2008. FW 3.0/3.5
        MathDel m4 = (a, b) => a + b;
    
        res = m4(4, 5);

        List<string> strings = new List<string>();
        strings.Where(args=>{ return args.Length < 6;});

        // Procedures
        Action<string> a1 = Console.WriteLine;
        a1("Hallo");

        // Functions
        Func<int, int, int> m6 = Add;
        res = m6(9, 10);



        res = Subtract(4,5);
        Console.WriteLine(res);


        int Subtract(int a, int b)
        {
            return a - b;
        }

    }

    private static bool FilterIets(string arg)
    {
        return arg.Length < 5;
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}

