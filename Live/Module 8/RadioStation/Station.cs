namespace RadioStation;


public delegate void Medium(string msg);

public class Station
{
    private event  Medium subscribers;

    //public event Medium Subscribers
    //{
    //    add
    //    {
    //        subscribers += value;
    //    }
    //    remove
    //    {
    //        subscribers -= value;
    //    }
    //}

    public void BroadCast()
    {
        subscribers?.Invoke("Hallo luisteraars");
    }
}
