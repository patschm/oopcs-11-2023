using DoomsdayPreppers;
using Heras;
using Infrac;
using Philips;

namespace MijnHuis;

internal class Program
{
    static void Main(string[] args)
    {
        DetectieLus lus = new DetectieLus();
        Hek hek = new Hek();
        Valkuil valkuil = new Valkuil();
        Lamp lamp = new Lamp();



        lus.Detect();
        //hek.Open(); Niet geaccepteerd.
    }
}