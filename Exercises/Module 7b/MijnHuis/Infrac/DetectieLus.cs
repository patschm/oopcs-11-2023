using Afspraken;

namespace Infrac;

public class DetectieLus
{
    private List<IDetectable> devices = new List<IDetectable>();

    public void Connect(IDetectable detectable)
    {
        devices.Add(detectable);
    }
    public void Detect()
    {
        Console.WriteLine("Hmmm, we zien iets...");
        foreach (IDetectable device in devices)
        {
            device.Detecting();
        }
    }
}