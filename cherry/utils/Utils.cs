namespace cherry.utils;

internal class Utils
{
    internal static void PrintInfo()
    {
        Console.Write('\n');
        Console.Write("                                  ██  ");
        Console.WriteLine($"      Mode: {Data.Mode}");
        Console.Write("                      ██    ██████    ");
        Console.WriteLine($"      NoSave: {Data.NoSave}");
        Console.Write("                      ██  ██▒▒▒▒██    ");
        Console.WriteLine($"      Current Path: {Directory.GetCurrentDirectory()}");
        Console.Write("                    ██████▒▒▒▒▒▒██    ");
        Console.WriteLine($"      Shell Path: {Data.ShellDirectory}");
        Console.Write("                    ██  ██▒▒▒▒██      ");
        Console.WriteLine($"      Process: {Data.Process}");
        Console.Write("                  ██    ██████        ");
        Console.WriteLine($"      Path Separator: {Data.CdSlash}");
        Console.WriteLine("                ██    ██              ");
        Console.WriteLine("                ██    ██              ");
        Console.WriteLine("              ██        ██            ");
        Console.WriteLine("            ██            ████████    ");
        Console.Write("        ████████        ██▒▒▒▒▒▒▒▒██  ");
        Console.WriteLine($"      GitHub: https://github.com/Dark-Revel431/cherry");
        Console.Write("      ██▒▒▒▒▒▒▒▒██    ██▒▒▒▒▒▒▒▒▒▒▒▒██");
        Console.WriteLine($"      Version: {Data.Version}");
        Console.WriteLine("    ██▒▒▒▒▒▒  ▒▒▒▒██  ██▒▒▒▒▒▒▒▒▒▒▒▒██");
        Console.WriteLine("    ██▒▒▒▒▒▒▒▒  ▒▒██  ██▒▒  ▒▒▒▒▒▒▒▒██");
        Console.Write("    ██▒▒▒▒▒▒▒▒  ▒▒██  ██▒▒▒▒    ▒▒▒▒██");
        Console.Write("          ");
        Console.ForegroundColor = (ConsoleColor)0;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)1;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)2;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)3;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)4;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)5;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)6;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)7;
        Console.WriteLine("██");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("    ██▒▒▒▒▒▒▒▒▒▒▒▒██    ██▒▒▒▒▒▒▒▒██  ");
        Console.Write("          ");
        Console.ForegroundColor = (ConsoleColor)8;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)9;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)10;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)11;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)12;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)13;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)14;
        Console.Write("██");
        Console.ForegroundColor = (ConsoleColor)15;
        Console.Write("██");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write('\n');
        Console.WriteLine("      ██▒▒▒▒▒▒▒▒██        ████████    ");
        Console.WriteLine("        ████████                      ");

        Console.WriteLine('\n');
    }

    internal static void PrintException(Exception e)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Error:{Environment.NewLine}{e}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
