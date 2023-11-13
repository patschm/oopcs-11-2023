using System.Collections;

namespace Collects;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
        array[0] = 1;

        int[,] matrix = new int[2,3] {{1,2,3}, {4,5,6}};
        System.Console.WriteLine(matrix[0, 1]);

        //int[,]

        int[][] jagged = new int[3][];
        jagged[0] = new int[10];
        jagged[1] = new int[5];

        //int[] nrs = [1, ..array];

        ArrayList listold = new ArrayList();
        listold.Add(1);
        listold.Add(2);
        listold.Add("3");

        List<int> list = new List<int>();
        list.AddRange(new int[] {1,2,3,4,5});
        //list[1]

        var nummers = new Dictionary<string, int>();
        nummers.Add("een", 1);

        System.Console.WriteLine(nummers["een"]);

        foreach(var nr in array)
        {
            System.Console.WriteLine(nr);
        }
    }
}
