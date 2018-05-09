using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xif
{
    public interface IOptions
    {

        [Option('f',"Exclude Filters")]
        IEnumerable<string> Filters { get; set; }
    }

    public class FilterOptions : IOptions
    {
        public IEnumerable<string> Filters { get; set; }
    }

   
}
