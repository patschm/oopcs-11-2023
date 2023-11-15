namespace RadioStation;

internal class Program
{
    static void Main(string[] args)
    {
        Station r538 = new Station();
        r538.subscribers += OntvangstMethodes.ViaEther;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaWifi;
        r538.subscribers += OntvangstMethodes.ViaKabel;
        r538.subscribers += OntvangstMethodes.ViaEther;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaWifi;
        r538.subscribers += OntvangstMethodes.ViaKabel;
        r538.subscribers += OntvangstMethodes.ViaEther;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaWifi;
        r538.subscribers += OntvangstMethodes.ViaKabel;
        r538.subscribers += OntvangstMethodes.ViaEther;
        r538.subscribers += OntvangstMethodes.ViaPostduif;
        r538.subscribers += OntvangstMethodes.ViaWifi;
        r538.subscribers += OntvangstMethodes.ViaKabel;

       // r538.subscribers("Hahahaha");

        r538.BroadCast();
    }
}