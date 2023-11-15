namespace RadioStation;

public class OntvangstMethodes
{
    public static void ViaEther(string message)
    {
        Console.WriteLine($"Via Ether ontvangen: {message}");
    }
    public static void ViaKabel(string message)
    {
        Console.WriteLine($"Via Kabel ontvangen: {message}");
    }
    public static void ViaWifi(string message)
    {
        Console.WriteLine($"Via Wifi ontvangen: {message}");
    }
    public static void ViaPostduif(string message)
    {
        Console.WriteLine($"Via Postduif ontvangen: {message}");
    }
}
