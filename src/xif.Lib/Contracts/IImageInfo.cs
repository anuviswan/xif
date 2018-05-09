using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib.Contracts
{
    public interface IImageInfo
    {
        FileInfo FileDetails { get; set; }
        DateTime TakenOn { get; set; }

    }
}
