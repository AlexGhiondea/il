using CommandLine.Attributes;
using CommandLine.Attributes.Advanced;

namespace Il.CommandLine
{
    internal class CommandLineOptions
    {
        [ActionArgument]
        public IlAction Action { get; set; }

        [CommonArgument]
        [RequiredArgument(0, "input", "The input file")]
        public string Host { get; set; }
    }
}
