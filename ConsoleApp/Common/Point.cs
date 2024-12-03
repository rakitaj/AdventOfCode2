namespace EverybodyCodes.Common;

public record class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public Point Transform(int xDelta, int yDelta)
    {
        var x = this.X + xDelta;
        var y = this.Y + yDelta;
        return new Point(x, y);
    }

    public override string ToString() => $"({this.X}, {this.Y})";
}
