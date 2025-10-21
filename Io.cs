namespace Luhan.IO;

public static class Io
{
    public static void Printf(object? value)
    {
        Console.WriteLine(value);
    }

    public static void Printf(params object?[] values)
    {
        Console.WriteLine(string.Join(" ", values));
    }

    public static void Log(object? value)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {value}");
        Console.ForegroundColor = originalColor;
    }
}
