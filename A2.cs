public class DateSettings
{
    public string GetTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}
public class LeapClass2
{
    public bool Compare(int x ,int y)
    {
        return x>y;
    }
    public bool Compare(int x ,int y)
    {
        return x==y;
    }
     public bool Compare(int x ,int y)
    {
        return x<=y;
    }
}