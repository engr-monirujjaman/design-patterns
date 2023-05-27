namespace BridgePattern;

public abstract class Shape
{
    protected Shape(IDrawApi drawApi)
    {
        DrawApi = drawApi;
    }

    protected IDrawApi DrawApi { get; set; }

    public abstract void Draw();
}