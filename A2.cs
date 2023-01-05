public class DateSettings
{
    public string GetTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}
public class LeapClass
{
    public bool Compare(int x ,int y)
    {
        return x>y;
    }
}