using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    internal class AMV
    {
        internal AMV(ref List<IDataMap> mapper)
        {
            mapper = new()
        {
                new DataMap(5, 'T'),
                new DataMap(5, 'S'),
                new DataMap(5, 'S'),
                new DataMap(24, 'S'),
                new DataMap(5, 'S'),
                new DataMap(16, 'S'),
                new DataMap(16, 'S'),
                new DataMap(1, 'y'),
                new DataMap(1, 'm'),
                new DataMap(1, 'd'),
                new DataMap(1, 'y'),
                new DataMap(1, 'm'),
                new DataMap(1, 'd'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D'),
                new DataMap(8, 'D')
        };
        }
    }
}
