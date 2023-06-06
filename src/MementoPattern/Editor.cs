namespace MementoPattern;

public class Editor
{
    private string Text { get; set; } = string.Empty;

    private readonly List<Memento> _backups;

    public Editor()
    {
        _backups = new List<Memento>();
    }

    public void SetText(string text)
    {
        Text = text;
    }

    public void Save()
    {
        _backups.Add(new Memento(new Snapshot(Text)));
    }

    public void Restore(Memento memento)
    {
        _backups.Clear();
        _backups.Add(memento);
    }

    public void Undo()
    {
        if (!_backups.Any())
        {
            return;
        }
        
        if (_backups.Count > 1)
        {
            var memento = _backups[^2];
            SetText(memento.Snapshot.Text);
            _backups.Remove(memento);
        }
        else
        {
            var memento = _backups.Last();
            SetText(memento.Snapshot.Text);
            _backups.Remove(memento);
        }
    }

    public override string ToString()
    {
        return $"Editor: {Text}";
    }
}