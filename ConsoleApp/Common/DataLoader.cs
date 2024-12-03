namespace EverybodyCodes.Common;

public class DataLoader
{
    public static string ReadString(string filename)
    {
        return File.ReadAllText($"./Data/{filename}");
    }
}
