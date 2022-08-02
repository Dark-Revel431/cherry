namespace cherry;

internal class Shell
{
    internal static int LIMIT_INPUT { get; } = 4;

    internal static void Start()
    {
        Utils.PrintStart();
        Update.Check();

        Console.Write(Environment.NewLine);

        while (true)
        {
            Input.PrintInput();
            string command = Input.GetInput().Trim();

            if (!Data.NoSave) History.AddHistory(command);

            CheckCommand.Check(command);
            if (command != "clear" || command != ":c")
            {
                Console.Write(Environment.NewLine);
            }
        }
    }
}
