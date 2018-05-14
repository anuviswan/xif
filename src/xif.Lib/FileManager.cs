using System;
using System.IO;

namespace xif.Lib
{
    public class FileManager
    {
        public void FileCopy(string sourceFile,DateTime capturedOn, string destinationRootDir)
        {
            var dirPath = Path.Combine(destinationRootDir, capturedOn.Year.ToString(), capturedOn.MonthName(),capturedOn.ToShortDateString().Replace(@"/", ""));
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            File.Copy(sourceFile, Path.Combine(dirPath, Path.GetFileName(sourceFile)));
        }
    }
}
