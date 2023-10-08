using Clp.Input;

namespace Clp.Library
{
    internal class Configuration
    {
        public List<string> InputPluginsDirectories { get; init; } = new List<string>();

        public List<string> OutputPluginsDirectories { get; init; } = new List<string>();

        public List<OutputPlugin> OutputPlugins { get; init; } = new List<OutputPlugin>();
        public Dictionary<string, ILexer>? LexerPlugins { get; init; } = new Dictionary<string, ILexer>();

        public void CreatePluginsDirectories()
        {
            foreach (var inputPluginsDirectory in InputPluginsDirectories)
            {
                if (!string.IsNullOrEmpty(inputPluginsDirectory) && !Directory.Exists(inputPluginsDirectory))
                {
                    Directory.CreateDirectory(inputPluginsDirectory);
                }
            }

            foreach (var outputPluginsDirectory in OutputPluginsDirectories)
            {
                if (!string.IsNullOrEmpty(outputPluginsDirectory) && !Directory.Exists(outputPluginsDirectory))
                {
                    Directory.CreateDirectory(outputPluginsDirectory);
                }
            }
        }
    }
}
