namespace GLAdmin.Client.V6.Pages._Test;

public class TestData
{
    public string Time = DateTime.UtcNow.ToLocalTime().ToLongTimeString();
    public string Source{ get; set; }
    public int Value { get; set; }

    public TestData(string source, int v)
    {
        Source = source;
        Value = v;
    }
}