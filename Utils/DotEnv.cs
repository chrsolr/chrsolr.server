public class DotEnv
{
    public static void Load(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return;
        }

        foreach (var line in File.ReadAllLines(filepath))
        {
            var splitted = line.Split("=", 2);
            if (splitted.Length != 2)
            {
                continue;
            }

            Environment.SetEnvironmentVariable(splitted[0], splitted[1]);
        }
    }
}
