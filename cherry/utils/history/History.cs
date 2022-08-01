namespace cherry.utils.history;

internal class History
{
    internal static void SetHistory()
    {
        Data.commands.Clear();

        StreamReader sr = new($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}history.txt");

        string? line = sr.ReadLine();

        while (line != null)
        {
            Data.commands.Add(line);
            line = sr.ReadLine();
        }

        sr.Close();
    }

    internal static void AddHistory(string command)
    {
        if (File.Exists($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}history.txt"))
        {
            string text = File.ReadAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}history.txt");

            text = $"{command}\n{text}";
            File.WriteAllText($"{Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out{Data.CdSlash}history.txt", text);

            SetHistory();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Error:\nno history.txt detected in {Data.ShellDirectory}{Data.CdSlash}.cherry{Data.CdSlash}.out");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(1);
        }
    }
}
