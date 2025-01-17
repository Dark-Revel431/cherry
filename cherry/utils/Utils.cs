﻿namespace cherry.utils;

internal class Utils
{
    internal static void PrintHelp()
    {
        Console.WriteLine("cherry.");
        Console.Write('\n');
        Console.WriteLine("Short Cuts:");
        Console.WriteLine("     - (Alt + I) --> Show info");
        Console.WriteLine("     - (Alt + P) --> Show current path");
        Console.WriteLine("     - (Alt + C) --> Clear the shell");
        Console.WriteLine("     - (Alt + M) --> Show current mode");
        Console.WriteLine("     - (Alt + N) --> Show no-save value");
        Console.WriteLine("     - (Alt + R) --> Show current process");
        Console.WriteLine("     - (Alt + L) --> Show current-dir files");
        Console.WriteLine("     - (Alt + E) --> Exit");
        Console.Write('\n');
        Console.WriteLine("Key-Words:");
        Console.WriteLine("     - :i --> Show info");
        Console.WriteLine("     - :p --> Show current path");
        Console.WriteLine("     - :c --> Clear the shell");
        Console.WriteLine("     - :m --> Show/Set current mode");
        Console.WriteLine("     - :n --> Show/Set no-save value");
        Console.WriteLine("     - :pr --> Show/Set current process");
        Console.WriteLine("     - :s --> Start a process");
        Console.WriteLine("     - :l --> Show current-dir files");
        Console.WriteLine("     - :e --> Exit");
        Console.WriteLine("\n" +
            "GitHub: https://github.com/Dark-Revel431/cherry\n");

        Console.WriteLine("Custom commands:");
        Console.WriteLine("     - info/:i --> Show info");
        Console.WriteLine("     - ls/:l --> Show current-dir files");
        Console.WriteLine("     - path/:p --> Show current path");
        Console.WriteLine("     - clear/:c --> Clear the shell");
        Console.WriteLine("     - mode/:m [mode] --> Show/Set current mode");
        Console.WriteLine("     - nosave/:n [bool] --> Show/Set no-save value");
        Console.WriteLine("     - process/:pr [process] --> Show/Set current process");
        Console.WriteLine("     - start/:s [command] --> Exec a command");
        Console.WriteLine("     - exit/:e --> Exit");
        Console.WriteLine("     - update --> Check for updates");
        Console.WriteLine("     - [process] [command] --> Exec a command with a specified terminal");
        Console.WriteLine("          - ex. bash ls");

        Console.WriteLine("\nAll non-defined command will be executed with the selected Process");
    }

    internal static void PrintStart()
    {
        Console.WriteLine("Welcome on cherry.");
        Console.WriteLine("Short Cuts:");
        Console.WriteLine("     - (Alt + I) --> Show info");
        Console.WriteLine("     - (Alt + P) --> Show current path");
        Console.WriteLine("     - (Alt + C) --> Clear the shell");
        Console.WriteLine("     - (Alt + M) --> Show current mode");
        Console.WriteLine("     - (Alt + N) --> Show no-save value");
        Console.WriteLine("     - (Alt + R) --> Show current process");
        Console.WriteLine("     - (Alt + L) --> Show current-dir files");
        Console.WriteLine("     - (Alt + E) --> Exit");
        Console.Write('\n');
        Console.WriteLine("Key-Words:");
        Console.WriteLine("     - :i --> Show info");
        Console.WriteLine("     - :p --> Show current path");
        Console.WriteLine("     - :c --> Clear the shell");
        Console.WriteLine("     - :m --> Show/Set current mode");
        Console.WriteLine("     - :n --> Show/Set no-save value");
        Console.WriteLine("     - :pr --> Show/Set current process");
        Console.WriteLine("     - :s --> Start a process");
        Console.WriteLine("     - :l --> Show current-dir files");
        Console.WriteLine("     - :e --> Exit");
        Console.WriteLine("\n" +
            "GitHub: https://github.com/Dark-Revel431/cherry\n");
    }

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
