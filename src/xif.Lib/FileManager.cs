using System;
using System.IO;

namespace xif.Lib
{
    public class FileManager
    {
        public void FileCopy(string sourceFile,DateTime capturedOn, string destinationRootDir)
        {
            var dirPath = Path.Combine(destinationRootDir, capturedOn.Year.ToString(), capturedOn.MonthName(),ParentFolderName(capturedOn));
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            var newFilePath = Path.Combine(dirPath, Path.GetFileName(sourceFile));
            if (File.Exists(newFilePath))
                newFilePath = UniqueFileName(newFilePath);
            File.Copy(sourceFile, newFilePath);
        }

        

        private string UniqueFileName(string path, int count = 0)
        {
            if (count == 0)
            {
                if (!File.Exists(path))
                {
                    return path;
                }
            }
            else
            {
                var candidatePath = string.Format(
                    @"{0}\{1}_{2}{3}",
                    Path.GetDirectoryName(path),
                    Path.GetFileNameWithoutExtension(path),
                    count,
                    Path.GetExtension(path));

                if (!File.Exists(candidatePath))
                {
                    return candidatePath;
                }
            }

            count++;
            return UniqueFileName(path, count);
        }

        private string ParentFolderName(DateTime capturedOn) => $"{capturedOn.Day:#00}{capturedOn.Month:#00}{capturedOn.Year:#0000}";
    }
}
