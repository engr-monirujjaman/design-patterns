namespace BridgePattern;

public class RedCircle : IDrawApi
{
    public void DrawCircle(int radius, int x, int y)
    {
        Console.WriteLine("Draw Red circle");
    }
}