namespace EverybodyCodes.Common;

using System.Collections.Generic;
using System.Linq;

public class Grid<T> where T: IEquatable<T>
{
    public IReadOnlyList<IReadOnlyList<T>> Raw { get; set; }
    public int RowLength { get; }

    public Grid(IReadOnlyList<T> array1d, int rowLength)
    {
        this.RowLength = rowLength;
        this.Raw = array1d.Chunk(this.RowLength).ToArray();
    }

    public Grid(IReadOnlyList<IReadOnlyList<T>> array2d)
    {
        this.RowLength = array2d.Select(line => line.Count).Distinct().Single();
        this.Raw = array2d;
    }

    public static Grid<char> FromStringLists(IReadOnlyList<string> stringGrid)
    {
        var charGrid = stringGrid.Select(s => s.ToCharArray()).ToArray();
        return new Grid<char>(charGrid);
    }

    public bool InBounds(Point p)
    {
        return this.InBounds(p.X, p.Y);
    }

    public bool InBounds(int x, int y)
    {
        return x >= 0 && x < this.Raw[y].Count && y >= 0 && y < this.Raw.Count;
    }

    public T Get(int x, int y)
    {
        return this.Raw[y][x];
    }

    public T Get(Point p)
    {
        return this.Get(p.X, p.Y);
    }

    public List<Point> Adjacent(Point p)
    {
        var adjacentPoints = new List<Point>();
        List<int> deltas = [-1, 0, 1];
        foreach(var xDelta in deltas)
        {
            foreach(var yDelta in deltas)
            {
                if (xDelta == 0 && yDelta == 0)
                {
                    continue;
                }
                var transformedPoint = p.Transform(xDelta, yDelta);
                if (this.InBounds(transformedPoint))
                {
                    adjacentPoints.Add(transformedPoint);
                }
            }
        }
        return adjacentPoints;
    }

    public Point? Find(T element)
    {
        for(var row = 0; row < this.Raw.Count; row++)
        {
            for(var column = 0; column < this.Raw[row].Count; column++)
            {
                if (this.Raw[row][column].Equals(element))
                {
                    return new Point(column, row);
                }
            }
        }
        return null;
    }
}