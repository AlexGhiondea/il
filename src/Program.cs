using CommandLine;
using Il.CommandLine;

namespace Il
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Parser.TryParse(args, out CommandLineOptions options))
            {
                return;
            }
        }
    }
}
