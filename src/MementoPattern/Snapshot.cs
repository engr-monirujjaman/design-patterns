namespace MementoPattern;

public class Snapshot
{
    public string Text { get; set; }

    public Snapshot(string text)
    {
        Text = text;
    }
}