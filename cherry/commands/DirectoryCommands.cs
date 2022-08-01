namespace cherry.commands;

internal class DirectoryCommands
{
    public static void Ls()
    {
        Console.Write('\n');

        foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory()))
        {
            Console.Write("DIR: ");
            Console.WriteLine(dir.Split(Data.CdSlash)[^1]);
        }

        foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory()))
        {
            Console.Write("FILE: ");
            Console.WriteLine(file.Split(Data.CdSlash)[^1]);
        }
    }

    public static void Cd(string command)
    {
        try
        {
            Directory.SetCurrentDirectory(command.Split(" ", count: 2)[1]);
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error.");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }

    public static void Path()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(Directory.GetCurrentDirectory());
        Console.ForegroundColor = ConsoleColor.White;
    }
}
