﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif.Lib.Contracts
{
    public interface IQuery
    {
        IImageInfo GetInfo(string FilePath);
    }
}
