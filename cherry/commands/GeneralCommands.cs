namespace cherry.commands;

internal class GeneralCommands
{
    internal static void Exit()
    {
        foreach (Process process in Data.process)
        {
            if (!process.HasExited)
            {
                try
                {
                    ProcessManager.WriteFileKill(process);
                    Console.WriteLine($"killed {process.Id}");
                }
                catch { }
            }
        }

        Console.Clear();
        Console.ResetColor();
        Environment.Exit(0);
    }
}
