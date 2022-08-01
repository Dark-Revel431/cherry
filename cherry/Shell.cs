namespace cherry;

internal class Shell
{
    internal static int LIMIT_INPUT { get; } = 4;

    internal static void Start()
    {
        while (true)
        {
            Input.PrintInput();
            string command = Input.GetInput().Trim();

            if (Data.Mode != Modes.nosave) History.AddHistory(command);

            CheckCommand.Check(command);
            if (command != "clear")
            {
                Console.Write(Environment.NewLine);
            }
        }
    }
}
