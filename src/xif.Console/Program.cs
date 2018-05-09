using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace xif
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<FilterOptions>(args)
                        .WithParsed<FilterOptions>(opts => RunOptionsAndReturnExitCode(opts))
                        .WithNotParsed<FilterOptions>((errs) => HandleParseError(errs));
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            return;
        }

        private static void RunOptionsAndReturnExitCode(FilterOptions opts)
        {
            return;
        }


    }
}
