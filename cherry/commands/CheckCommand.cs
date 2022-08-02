namespace cherry.commands;

internal class CheckCommand
{
    internal static async void Check(string command)
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
            else if (command.Split()[0] == "clear" || command.Split()[0] == ":c")
            {
                Console.Clear();
            }
            else if (command.Split()[0] == "exit")
            {
                GeneralCommands.Exit();
            }
            else if (command.Split()[0] == "info" || command.Split()[0] == ":i")
            {
                Utils.PrintInfo();
            }
            else if (command.Split()[0] == "nosave" || command.Split()[0] == ":n")
            {
                try
                {
                    switch (command.Split()[1])
                    {
                        case "true":
                            Data.NoSave = true;
                            break;
                        case "false":
                            Data.NoSave = false;
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Data.NoSave);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (command.Split()[0] == "mode" || command.Split()[0] == ":m")
            {
                try
                {
                    switch (command.Split()[1])
                    {
                        case "here":
                            Data.Mode = Modes.here;
                            break;
                        case "hide":
                            Data.Mode = Modes.hide;
                            break;
                        case "onlystatus":
                            Data.Mode = Modes.onlystatus;
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Data.Mode);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (command.Split()[0] == "process" || command.Split()[0] == ":pr")
            {
                try
                {
                    switch (command.Split()[1])
                    {
                        case "cmd":
                            Data.Process = "cmd";
                            break;
                        case "bash":
                            Data.Process = "bash";
                            break;
                        case "powershell":
                            Data.Process = "powershell";
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Data.Process);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (command.Split()[0] == "start" || command.Split()[0] == ":s")
            {
                if (Data.Mode == Modes.here)
                {
                    var process = Process.Start(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command.Split(" ", count: 2)[1]));
                    process.WaitForExit();
                }
                else if (Data.Mode == Modes.hide)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) await ProcessManager.AsyncWaitAndWriteFile(process);
                    }
                }
                else if (Data.Mode == Modes.onlystatus)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) ProcessManager.WaitAndWriteFile(process);
                    }
                }
            }
            else if (command.Split()[0] == "cmd")
            {
                if (Data.Mode == Modes.here)
                {
                    var process = Process.Start("cmd", Data.ProcessDictionary["cmd"].Replace("%args%", command.Split(" ", count: 2)[1]));
                    process.WaitForExit();
                }
                else if (Data.Mode == Modes.hide)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("cmd", Data.ProcessDictionary["cmd"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) await ProcessManager.AsyncWaitAndWriteFile(process);
                    }
                }
                else if (Data.Mode == Modes.onlystatus)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("cmd", Data.ProcessDictionary["cmd"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) ProcessManager.WaitAndWriteFile(process);
                    }
                }
            }
            else if (command.Split()[0] == "bash")
            {
                if (Data.Mode == Modes.here)
                {
                    var process = Process.Start("bash", Data.ProcessDictionary["bash"].Replace("%args%", command.Split(" ", count: 2)[1]));
                    process.WaitForExit();
                }
                else if (Data.Mode == Modes.hide)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("bash", Data.ProcessDictionary["bash"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) await ProcessManager.AsyncWaitAndWriteFile(process);
                    }
                }
                else if (Data.Mode == Modes.onlystatus)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("bash", Data.ProcessDictionary["bash"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) ProcessManager.WaitAndWriteFile(process);
                    }
                }
            }
            else if (command.Split()[0] == "powershell")
            {
                if (Data.Mode == Modes.here)
                {
                    var process = Process.Start("powershell", Data.ProcessDictionary["powershell"].Replace("%args%", command.Split(" ", count: 2)[1]));
                    process.WaitForExit();
                }
                else if (Data.Mode == Modes.hide)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("powershell", Data.ProcessDictionary["powershell"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) await ProcessManager.AsyncWaitAndWriteFile(process);
                    }
                }
                else if (Data.Mode == Modes.onlystatus)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new("powershell", Data.ProcessDictionary["powershell"].Replace("%args%", command.Split(" ", count: 2)[1]))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) ProcessManager.WaitAndWriteFile(process);
                    }
                }
            }
            else
            {
                if (Data.Mode == Modes.here)
                {
                    var process = Process.Start(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command));
                    process.WaitForExit();
                }
                else if (Data.Mode == Modes.hide)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) await ProcessManager.AsyncWaitAndWriteFile(process);
                    }
                }
                else if (Data.Mode == Modes.onlystatus)
                {
                    if (Directory.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}outputs"))
                    {
                        ProcessStartInfo psi = new(Data.Process, Data.ProcessDictionary[Data.Process].Replace("%args%", command))
                        {
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        var process = Process.Start(psi);
                        if (process != null) ProcessManager.WaitAndWriteFile(process);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Utils.PrintException(e);
        }
    }
}
