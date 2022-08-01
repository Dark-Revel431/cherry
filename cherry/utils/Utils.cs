namespace cherry.utils;

internal class Utils
{
    public static void PrintException(Exception e)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Error:{Environment.NewLine}{e}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
