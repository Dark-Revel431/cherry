namespace cherry;

internal class Boot
{
    internal static void Start()
    {
        Data.ShellDirectory = Directory.GetCurrentDirectory();

        Console.Title = "cherry";

        if (Environment.OSVersion.ToString().Contains("Windows")) Data.Process = "cmd";
        else Data.Process = "bash";

        if (Data.Process == "cmd") Data.CdSlash = '\\';
        else Data.CdSlash = '/';

        if (File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}cherry.settings.json"))
        {
            string @string = File.ReadAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}cherry.settings.json");
            json.boot.JsonData? JsonD = json.boot.Json.ParseBoot(@string);

            if (JsonD != null)
            {
                if (JsonD.StartDirectory != null && Directory.Exists(JsonD.StartDirectory)) Directory.SetCurrentDirectory(JsonD.StartDirectory);

                if (JsonD.Mode != null)
                {
                    switch (JsonD.Mode)
                    {
                        case "here":
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
            }
        }

        if (File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}history.txt"))
        {
            History.SetHistory();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Error:\nno history.txt detected in {Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(1);
        }

        Shell.Start();
    }
}
