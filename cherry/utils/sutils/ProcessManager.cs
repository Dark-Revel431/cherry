namespace cherry.utils.sutils;

internal class ProcessManager
{
    public static void WriteFileKill(Process process)
    {
        int id;
        while (true)
        {
            Random r = new();
            id = r.Next();
            if (!File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt"))
            {
                break;
            }
        }

        int ProcessId = process.Id;
        string ProcessName = process.ProcessName;
        
        process.Kill(true);
        File.WriteAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt",
                $"Process name: {ProcessName}\n" +
                $"Process id: {ProcessId}\n" +
                $"Exit code: {process.ExitCode}\n\n" +
                $"Output:\n\n" +
                $"{process.StandardOutput.ReadToEnd()}\n\n" +
                $"Error:\n\n" +
                $"{process.StandardError.ReadToEnd()}\n\n\n" +
                $"(Killed!)");
    }

    public static async Task AsyncWaitAndWriteFile(Process process)
    {
        await Task.Run(() =>
        {
            int id;
            while (true)
            {
                Random r = new();
                id = r.Next();
                if (!File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt"))
                {
                    break;
                }
            }

            int ProcessId = process.Id;
            string ProcessName = process.ProcessName;

            Data.process.Add(process);
            process.WaitForExit();
            File.WriteAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt",
                    $"Process name: {ProcessName}\n" +
                    $"Process id: {ProcessId}\n" +
                    $"Exit code: {process.ExitCode}\n\n" +
                    $"Output:\n\n" +
                    $"{process.StandardOutput.ReadToEnd()}\n\n" +
                    $"Error:\n\n" +
                    $"{process.StandardError.ReadToEnd()}");
        });
    }

    public static void WaitAndWriteFile(Process process)
    {
        Console.WriteLine("\n┌── Process:");
        Console.Write("├─ ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("STARTED");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("├─ ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("IN PROGRESS");
        Console.ForegroundColor = ConsoleColor.White;

        int id;
        while (true)
        {
            Random r = new();
            id = r.Next();
            if (!File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt"))
            {
                break;
            }
        }

        int ProcessId = process.Id;
        string ProcessName = process.ProcessName;

        process.WaitForExit();
        File.WriteAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs{Data.CdSlash}Process-{id}.txt",
                $"Process name: {ProcessName}\n" +
                $"Process id: {ProcessId}\n" +
                $"Exit code: {process.ExitCode}\n\n" +
                $"Output:\n\n" +
                $"{process.StandardOutput.ReadToEnd()}\n\n" +
                $"Error:\n\n" +
                $"{process.StandardError.ReadToEnd()}");

        Console.Write("└─ ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("EXITED");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
