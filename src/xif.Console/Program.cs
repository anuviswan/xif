using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xif.Lib;

namespace xif
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Count() != 2)
                Console.WriteLine("Arguement missing");

            var sourceDir = args[0];
            var destinationDir = args[1];
            
            if(ValidateParameters(sourceDir, destinationDir))
            {
                var parser = new Parser();

                foreach (var item in parser.Parse(sourceDir))
                {
                    Console.WriteLine($"File : {item.FileDetails.FullName}, Date : {item.CapturedOn.ToShortDateString()}");
                }
            }
            
        }

        private static bool ValidateParameters(string sourceDir,string destinationDir)
        {
            if(!Directory.Exists(sourceDir))
            {
                Console.WriteLine("Source Directory does not exists !!");
                return false;
            }

            if (!Directory.Exists(destinationDir) || Directory.EnumerateFileSystemEntries(destinationDir).Any())
            {
                Console.WriteLine("Destination Directory does not exists or not empty!!");
                return false;
            }

            return true;
        }


     
    }
}
