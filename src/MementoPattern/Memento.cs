namespace MementoPattern;

public class Memento
{
    public DateTime Time { get; set; }

    public Snapshot Snapshot { get; set; }

    public Memento(Snapshot snapshot)
    {
        Snapshot = snapshot;
        Time = DateTime.Now;
    }
}