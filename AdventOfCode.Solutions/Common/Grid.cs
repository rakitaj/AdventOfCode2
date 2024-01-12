namespace AdventOfCode.Solutions.Common;

using System.Collections.Generic;
using System.Linq;

public class Grid<T>
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

    public T Get(int x, int y)
    {
        return this.Raw[y][x];
    }

    public T Get(Point p)
    {
        return this.Raw[p.Y][p.X];
    }
}