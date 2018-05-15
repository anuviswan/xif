using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib
{
    public class Parser : IParser
    {
        public IEnumerable<IImageInfo> Parse(string rootDirPath)
        {
            var files = Directory.GetFiles(rootDirPath,"*.jpg",SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var reader = new ExifLib.ExifReader(file);
                reader.GetTagValue(ExifLib.ExifTags.DateTimeOriginal, out string result);
                yield return new ImageInfo()
                {
                    CapturedOn = ToDateTime(result),
                    FileDetails = new FileInfo(file)
                };
            }
                        
        }

        private DateTime ToDateTime(string dateString)
        {
            var dateComponent = dateString.Split(' ').First();
            return DateTime.ParseExact(dateComponent, "yyyy:MM:dd", CultureInfo.InvariantCulture);
        }
    }
}
