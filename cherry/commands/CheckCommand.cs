namespace cherry.commands;

internal class CheckCommand
{
    internal static void Check(string command)
    {
        try
        {
            if (command.Split(" ")[0] == "cd")
            {
                DirectoryCommands.Cd(command);
            }
            else if (command.Split()[0] == "path" || command.Split()[0] == ":p")
            {
                DirectoryCommands.Path();
            }
            else if (command.Split()[0] == "ls")
            {
                DirectoryCommands.Ls();
            }
            else if (command.Split()[0] == "clear")
            {
                Console.Clear();
            }
        }
        catch (Exception e)
        {
            Utils.PrintException(e);
        }
    }
}
