using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib
{
    class ImageInfo : IImageInfo
    {
        public FileInfo FileDetails { get; set; }
        public DateTime CapturedOn { get; set; }
    }
}
