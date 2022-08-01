namespace cherry;

internal class Data
{
    internal static Dictionary<string, string> CommandDictionary = new()
    {
        { "cmd.exe", "/c %args%"},
        { "bash", "-c \"%args%\"" }
    };

    internal static List<string> commands = new();

    internal static string ShellDirectory { get; set; } = "C:\\";
    internal static string Process { get; set; } = string.Empty;
    internal static char CdSlash { get; set; } = '/';
    internal static Modes Mode { get; set; } = Modes.here;
}
