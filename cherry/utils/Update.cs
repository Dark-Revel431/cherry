namespace cherry.utils;

internal class Update
{
    internal static void Check()
    {
        try
        {
            HttpClient client = new HttpClient();
            var process = client.GetStringAsync("https://raw.githubusercontent.com/Dark-Revel431/cherry/master/README.md");
            process.Wait();

            string @string = process.Result;

            string[] lines = @string.Split('\n');
            foreach (string line in lines)
            {
                if (line.Contains("Version: "))
                {
                    if (line.Replace("Version: ", "").Contains(Data.Version.ToString()))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("No updates found!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("New updates found!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error while checking for updates...");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
