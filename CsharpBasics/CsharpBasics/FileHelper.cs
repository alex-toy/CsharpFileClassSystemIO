namespace CsharpBasics
{
    public static class FileHelper
    {
        public static void Append(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public static void AppendAllLines(string path, string[] lines)
        {
            File.AppendAllLines(path, lines);
        }

        public static async Task AppendAllTextAsync(string path, string content)
        {
            await File.AppendAllTextAsync(path, content);
        }
    }
}
