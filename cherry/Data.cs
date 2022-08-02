namespace cherry;

internal class Data
{
    internal static Dictionary<string, string> ProcessDictionary = new()
    {
        { "cmd", "/c %args%"},
        { "bash", "-c \"%args%\"" },
        { "powershell", "/c %args%" }
    };

    internal static List<string> commands = new();

    internal static List<Process> process = new();

    internal static double Version { get; } = 1.0;
    internal static string ShellDirectory { get; set; } = "C:\\";
    internal static string Process { get; set; } = string.Empty;
    internal static char CdSlash { get; set; } = '/';
    internal static Modes Mode { get; set; } = Modes.here;
    internal static bool NoSave { get; set; } = false;
}
