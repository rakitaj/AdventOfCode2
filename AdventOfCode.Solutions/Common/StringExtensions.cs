using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode.Solutions.Common;

public static class StringExtensions
{
    public static List<string> SplitLines(this string s, bool removeNullOrEmpty = false)
    {
        var lines = new List<string>();
        using (StringReader sr = new StringReader(s))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (removeNullOrEmpty && String.IsNullOrEmpty(line))
                {
                    continue;
                }
                lines.Add(line);
            }
        }
        return lines;
    }
}
