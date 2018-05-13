using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib
{
    public interface IParser 
    {
        IEnumerable<IImageInfo> Parse(string rootDirPath);
    }
}
