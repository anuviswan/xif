﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib
{
    public interface IImageInfo
    {
        FileInfo FileDetails { get; set; }
        DateTime CapturedOn { get; set; }


    }
}
