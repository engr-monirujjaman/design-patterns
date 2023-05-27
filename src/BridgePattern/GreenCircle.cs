namespace BridgePattern;

public class GreenCircle : IDrawApi
{
    public void DrawCircle(int radius, int x, int y)
    {
        Console.WriteLine("Draw green circle");
    }
}