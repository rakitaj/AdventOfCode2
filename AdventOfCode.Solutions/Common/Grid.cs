namespace AdventOfCode.Solutions.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Grid<T>
{
    public T[] Raw { get; set; }
    public int RowLength { get; }

    public Grid(T[] array1d, int rowLength)
    {
        this.RowLength = rowLength;
        this.Raw = array1d;
    }

    public Grid(T[][] array2d)
    {
        var lineLengths = array2d.Select(line => line.Length).Distinct();
        if (lineLengths.Count() > 1)
        {
            throw new ArgumentException("All the line in the grid must be the same length.");
        }
        this.RowLength = lineLengths.Single();
        this.Raw = array2d.SelectMany(x => x).ToArray();
    }

    public static Grid<char> FromStringLists(IReadOnlyList<IReadOnlyList<string>> stringArrays)
    {

    }
}